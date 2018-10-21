using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace UDPClient
{
    public partial class Udp : Form
    {
        private UdpClient sendIgnoreBackClient;//切包发送，忽略回复
        private UdpClient sendMutualClient;//交互发送，接到包发送下一个，补发机制
        private UdpClient receiveUpdClient; //接收
        Thread sendAlone;//直发发送的线程
        Thread sendBack;//交互发送的线程
        Thread receiveThread;//监听线程




        private byte[] buffer=null;//文件byte数组
        private int rc_index;//保存接收的包序号
        private int now_send_index;//当前发包的序号
        private int resume_index;//保存暂停的序号
        private int page_size;//每个数据包的大小
        private int wait_time;// 包的间隔时间
        private int resend_time;//重复发包数量
        private int resend_delay;//补发包延时ms数


        //状态常量
        private bool isplaying;//标记正在播放
        private bool isListening = false;//是否启动了监听
        private bool isReceive=false;//是否接收到回复
        private bool pauseStatus=false;//是否暂停
        private PlayType playType; //播放类型（直接发送文件，和交互发包）
        private enum PlayType {
            playType1 = 1,//按时间间隔播
            playType2 = 2,//根据回复播
        };

        public Udp()
        {
            InitializeComponent();
            InitStatus();//初始化各种状态
            GetLocalEth();//获取本地ip
        }

        /// <summary>
        /// 初始化状态
        /// </summary>
        private void InitStatus()
        {
            rc_index = -1;//播放位置
            page_size = int.Parse(pageSize.Text);
            wait_time = int.Parse(numericUpDown1.Value.ToString());
            resend_time = int.Parse(MaxReSendTime.Value.ToString());
            resend_delay = int.Parse(ReSendDelay.Value.ToString());

        }

        /// <summary>
        /// 扫描网络接口
        /// </summary>
        private void GetLocalEth()
        {
            IPAddress[] ips = Dns.GetHostAddresses("");//获取本地I
            foreach (IPAddress ip in ips)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    localIP.Items.Add(ip);
                }
            }
            localIP.SelectedIndex = 0;
        }

        /// <summary>
        /// 本地开启监听接收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReceive_Click(object sender, EventArgs e)
        {
            isListening=CreateListening();
        }
        /// <summary>
        /// 启动监听
        /// </summary>
        /// <returns></returns>
        private bool CreateListening()
        {
            try
            {
                // 创建接收套接字
                IPAddress recieve_ip = IPAddress.Parse(localIP.SelectedItem.ToString());//创建接收IPAddress
                IPEndPoint recieve_ip_port = new IPEndPoint(recieve_ip, int.Parse(localPort.Text));//创建接收IP和端口号
                int port = int.Parse(localPort.Text);
                if (receiveUpdClient == null)
                {
                    receiveUpdClient = new UdpClient(recieve_ip_port);//定义接收套接字绑定IP和端口号
                }
                receiveThread = new Thread(ReceiveMessage);//创建监听线程
                receiveThread.Start();//启动监听线程
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        /// <summary>
        /// 接收消息方法(监听逻辑)
        /// </summary>
        private void ReceiveMessage()
        {
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);//监听访问IPEndPoint
            while (true)
            {
                try
                {
                    byte[] receiveBytes = receiveUpdClient.Receive(ref remoteIpEndPoint);//接收数据
                    //回复处理
                    int receiveIndex = BytesToInt(receiveBytes, 0);
                    if (!isReceive)//两个线程是一起运作的，收到序号不等的时候才标识
                    {   
                        rc_index = receiveIndex;
                        //最大重发次数重置
                        resend_time = int.Parse(MaxReSendTime.Value.ToString());
                        //标记收到数据(控制接收线程和发送线程顺序)
                        isReceive = true;
                    }
                    ShowMessageforView(msgview, string.Format("收到ap回复包序号：{0}\r\n", receiveIndex));//显示
    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("监听出错" + ex);
                }
            }
        }
        /// <summary>
        /// 检测是否重发委托
        /// </summary>
        /// <param name="index"></param>
        delegate void DelegateSendPage(int index);
       

        
        // 利用委托回调机制实现界面上消息内容显示
        delegate void ShowMessageforViewCallBack(ListBox listbox, string text);
        private void ShowMessageforView(ListBox listbox, string text)
        {
            if (listbox.InvokeRequired)
            {
                ShowMessageforViewCallBack showMessageforViewCallback = ShowMessageforView;
                listbox.Invoke(showMessageforViewCallback, new object[] { listbox, text });
            }
            else
            {
                msgview.Items.Add(text);
                msgview.SelectedIndex = msgview.Items.Count - 1;
                msgview.ClearSelected();
            }
        }
        /// <summary>
        /// 发送函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
           // SendPackByIndex(1);
        }
       
        private void send_byte_Click(object sender, EventArgs e)
        {   
            if (buffer==null)//空数据发送保护
            {
                MessageBox.Show("未加载文件");
                return;
            }
            if (isplaying)
            {
                //防止重复播放
                return;
            }
            else
            {
                isplaying = true;//标记正在播放
                pauseStatus = false;
                playType = PlayType.playType1;
            try
            {

                //IPAddress localIp = IPAddress.Parse(localIP.Text);
                //IPEndPoint localIpEndPoint = new IPEndPoint(localIp, int.Parse(localPort.Text));
                ////sendUdpClient = new UdpClient(localIpEndPoint);

                //sendUdpClient = new UdpClient(int.Parse(localPort.Text));

                if (sendAlone == null)
                {
                    sendAlone = new Thread(SendByteArray);//创建发送线程
                }else if (sendAlone.IsAlive)
                    {

                    }

                            sendAlone.Start();//开启发送线程

            }
            

               
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
        // 发送消息方法
        private void SendOnePackByIndex(object obj)
        {
           
          
        }

        /// <summary>
        /// 发送切包的音频文件
        /// </summary>
        private void SendByteArray()
        {

            isplaying = true;
            IPAddress localIp = IPAddress.Parse(localIP.Text);
            IPEndPoint localIpEndPoint = new IPEndPoint(localIp, int.Parse(localPort.Text));
            if (sendIgnoreBackClient == null)
            {
                sendIgnoreBackClient = new UdpClient(localIpEndPoint);
            }

            byte[] sendbytes = buffer;//文件发包数组

            IPAddress remoteIp = IPAddress.Parse(des_ip.Text);//绑定IP
            IPEndPoint remoteIpEndPoint = new IPEndPoint(remoteIp, int.Parse(des_port.Text));//绑定IPEndPoi

           if(sendIgnoreBackClient!=null)
            {
                for (int i = resume_index; i <= (buffer.Length / page_size); i++)
                {
                    if(i == ((buffer.Length / page_size) - 4))
                    {
                        i = 2;
                    }
                    isplaying = true;//标记正在播放
                    pauseStatus = false;
                    Thread.Sleep(wait_time);
                    byte[] page = GetpageByIndex(i, page_size);
                    try
                    {   if (!isplaying||pauseStatus) break;
                        
                        sendIgnoreBackClient.Send(page, page_size + 4, remoteIpEndPoint);//UDP发送
                        resume_index = i;//保存当前播放序号到全局
                        ShowMessageforView(msgview, string.Format("发包序号：{0}\r\n", i));//显示
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("关闭出错了但是我不想处理" + ex.ToString());
                    }

                }
            }
            isplaying = false;//标记播放借宿
            //sendBtn.Enabled = true;
            sendIgnoreBackClient.Close();//关闭发送线程

        }
        /// <summary>
        /// 生成单个数据包
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public byte[] GetpageByIndex(int index, int size)
        {
           
            //序号是4字节
            byte[] page = new byte[size + 4];
            byte[] byte_index = IntToBytes(index);
            Buffer.BlockCopy(byte_index, 0, page, 0, 4);
            //复制字节数
            int copy_size = buffer.Length - size * index >= size ? size : buffer.Length - size * index;
            if (copy_size <= 0)//文件已经切完了
            {
                return null;
            }
            Buffer.BlockCopy(buffer, index * size, page, 4, copy_size);
            return page;
        }

        // 采用了回调机制
        // 使用委托实现跨线程界面的操作方式
        delegate void ResetMessageCallback(TextBox textbox);
        private void ResetMessageText(TextBox textbox)
        {
            // Control.InvokeRequired属性代表
            // 如果空间的处理与调用线程在不同线程上创建的，则为true,否则为false
            if (textbox.InvokeRequired)
            {
                ResetMessageCallback resetMessagecallback = ResetMessageText;
                textbox.Invoke(resetMessagecallback, new object[] { textbox });
            }
            else
            {
                textbox.Clear();
                textbox.Focus();
            }
        }

        // 停止接收
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                receiveUpdClient.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("关闭出错" + ex);
            }
        }

        // 清空接受消息框
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.msgview.Items.Clear();
        }

        private void frmUdp_Load(object sender, EventArgs e)
        {   

            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void lstbxMessageView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }



        /// <summary>
        /// 打开文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void file_open_btn_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    buffer = GetBinaryFile(ofd.FileName);
                    fileName.Text = ofd.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            // MessageBox.Show(fileName.Text);

        }

        /// <summary>
        /// 转换为字节数组
        /// </summary>
        /// <param name="filename">文件名</param>
        /// <returns>字节数组</returns>
        public byte[] GetBinaryFile(string filename)
        {
            if (File.Exists(filename))
            {
                FileStream Fsm = null;
                try
                {
                    Fsm = File.OpenRead(filename);
                    return this.ConvertStreamToByteBuffer(Fsm);
                }
                catch
                {
                    return new byte[0];
                }
                finally
                {
                    Fsm.Close();
                }
            }
            else
            {
                return new byte[0];
            }
        }

        /// <summary>
        /// 流转化为字节数组
        /// </summary>
        /// <param name="theStream">流</param>
        /// <returns>字节数组</returns>
        public byte[] ConvertStreamToByteBuffer(System.IO.Stream theStream)
        {
            int bi;
            MemoryStream tempStream = new System.IO.MemoryStream();
            try
            {
                while ((bi = theStream.ReadByte()) != -1)
                {
                    tempStream.WriteByte(((byte)bi));
                }
                return tempStream.ToArray();
            }
            catch
            {
                return new byte[0];
            }
            finally
            {
                tempStream.Close();
            }
        }

        public static byte[] IntToBytes(int value)
        {
            byte[] byte_src = new byte[4];
            byte_src[0] = (byte)((value & 0xFF000000) >> 24);
            byte_src[1] = (byte)((value & 0x00FF0000) >> 16);
            byte_src[2] = (byte)((value & 0x0000FF00) >> 8);
            byte_src[3] = (byte)((value & 0x000000FF));
            return byte_src;
        }
        public static int BytesToInt(byte[] src, int offset)
        {
            int value;
            value = (int)((src[offset + 3] & 0xFF) |
                         ((src[offset + 2] & 0xFF) << 8) |
                         ((src[offset + 1] & 0xFF) << 16) |
                         ((src[offset] & 0xFF) << 24));
            return value;
        }

        private void reflashEth_Click(object sender, EventArgs e)
        {
            localIP.Items.Clear();
            GetLocalEth();
        }
        /// <summary>
        /// 停止播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopBtn_Click(object sender, EventArgs e)
        {
            isplaying = false;
        }
        /// <summary>
        /// 关闭程序
        /// </summary>
        private void Udp_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Environment.Exit(0);
        }
        /// <summary>
        ///交互发送按钮点击发送事件,发送一个包
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendMutualBeginBtn(object sender, EventArgs e)
        {
            playType = PlayType.playType2;//标记发送方式为交互类型
            if (buffer == null)
            {
                MessageBox.Show("未加载文件");
                return;
            }
            CreateListening();//开启监听端口
            byte[] sendbytes = GetpageByIndex(rc_index+1, page_size);//数据编码
            IPAddress remoteIp = IPAddress.Parse(des_ip.Text);//绑定IP
            IPEndPoint remoteIpEndPoint = new IPEndPoint(remoteIp, int.Parse(des_port.Text));//绑定IPEndPoint
            if (sendMutualClient == null)
            {
                sendMutualClient = new UdpClient(int.Parse(localPort.Text));
            }
            sendMutualClient.Send(sendbytes, sendbytes.Length, remoteIpEndPoint);//UDP发送
            now_send_index = rc_index+1;

            if (sendBack == null)
            {
                sendBack = new Thread(SendPackByIndex);
                sendBack.Start();
            }
        }


        /// <summary>
        /// 回复函数
        /// </summary>
        /// <param name="index"></param>
        public void SendPackByIndex()
        {
            try
            {
                
                while (true)
                {
                    IPAddress remoteIp = IPAddress.Parse(des_ip.Text);//绑定IP
                    IPEndPoint remoteIpEndPoint = new IPEndPoint(remoteIp, int.Parse(des_port.Text));//绑定IPEndPoint
                    byte[] sendbytes;
                  
                    if (rc_index == now_send_index)//收到的序号与发送的序号相同说明接收到了,立即回复
                    {
                        if (isReceive)
                        {
                            isReceive = false;
                            sendbytes = GetpageByIndex(now_send_index + 1, page_size);//数据编码
                            sendMutualClient.Send(sendbytes, sendbytes.Length, remoteIpEndPoint);//UDP发送
                            ShowMessageforView(msgview, string.Format("回复发包，序号：{0}\r\n", now_send_index));//显示
                            now_send_index = now_send_index + 1;
                        }
                    }
                    else if( now_send_index - rc_index== 1&&(--resend_time>=0))//重发当前的包
                    {   
                        isReceive = false;
                        Thread.Sleep(resend_delay);
                        sendbytes = GetpageByIndex(now_send_index, page_size);//数据编码
                        sendMutualClient.Send(sendbytes, sendbytes.Length, remoteIpEndPoint);//UDP发送
                        ShowMessageforView(msgview, string.Format("补充发包，序号：{0}\r\n", now_send_index));//显示
                    }
                    else
                    {
                        sendbytes = GetpageByIndex(now_send_index, page_size);//数据编码
                        sendMutualClient.Send(sendbytes, sendbytes.Length, remoteIpEndPoint);//UDP发送
                        ShowMessageforView(msgview, string.Format("断线，不断重发，序号：{0}\r\n", now_send_index));//显示
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发送监听出错" + ex);
            }
          
        }
        /// <summary>
        ///发包时间间隔
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            wait_time = int.Parse(numericUpDown1.Value.ToString());
        }

        /// <summary>
        /// 包长改变函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pageSize_TextChanged(object sender, EventArgs e)
        {
            page_size = int.Parse(pageSize.Text);
        }

        private void pauseBtn_Click(object sender, EventArgs e)
        {
               pauseStatus = true;//是否暂停
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void MaxReSendTime_ValueChanged(object sender, EventArgs e)
        {
            resend_time = int.Parse(MaxReSendTime.Value.ToString());
           
        }

        private void ReSendDelay_ValueChanged(object sender, EventArgs e)
        {
            resend_delay = int.Parse(ReSendDelay.Value.ToString());
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            if(sendIgnoreBackClient!=null)sendIgnoreBackClient.Close();
            if (sendMutualClient != null)sendMutualClient.Close();
            if (receiveUpdClient != null) receiveUpdClient.Close();
            if (receiveThread != null) receiveThread.Abort();
            if (sendAlone != null) sendAlone.Abort();
            if (sendBack != null) sendBack.Abort();
        }
    }
}
