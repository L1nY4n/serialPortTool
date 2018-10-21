using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using ZXing;
using ZXing.QrCode.Internal;
using ZXing.Common;
using System.IO;
using ZXing.QrCode;
using NewPortTest;
using System.Drawing.Printing;


namespace PortDemo3
{
  

    public partial class Form2 : Form
    {
        SerialPort serialPort = new SerialPort();
        bool isOpen = false;
        bool isSetProperty = false;
        bool isHex = false;

        string currentType = "";//标记当前轮询到哪个传感器
        Thread ThAutoSendData;
        Thread loopthread;
        int intervalTime = 500;

        //传感器指令

        private static Dictionary<string, string> cmdDic = new Dictionary<string, string>{
            { "ch4","ff0300010001c014"},
            { "h2s","ff0300040001d015"},
            { "co2","ff03000700012015"},
            { "o2","ff03000a0001b1d6"},
            { "temp","ff03000d00010017"}
};
        string alrm_on_cmd = "ff10001100010200012cb5";
        string alrm_off_cmd = "ff1000110001020000ed75";

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            BindData();
            bool exist =GetPort();
            if (exist)
            {
                  
            }
            //ThreadStart threadStart = new ThreadStart(receviedData);
            //Thread thread = new Thread(threadStart);
            //thread.Start();


                txtMsg.Text = System.DateTime.Now.ToString("yyyyMMddhhmmss").Substring(0, 12);

          

        }

        private void BindData()
        {
            //绑定端口号 
            this.txtPort.Items.Add("COM1");
            txtPort.SelectedIndex = 0; 
            //波特率
            txtBaudRate.Items.Add("110");
            txtBaudRate.Items.Add("300");
            txtBaudRate.Items.Add("1200");
            txtBaudRate.Items.Add("2400");
            txtBaudRate.Items.Add("4800");
            txtBaudRate.Items.Add("9600");
            txtBaudRate.Items.Add("19200");
            txtBaudRate.Items.Add("38400");
            txtBaudRate.Items.Add("57600");
            txtBaudRate.Items.Add("115200");
            txtBaudRate.Items.Add("230400");
            txtBaudRate.Items.Add("460800");
            txtBaudRate.Items.Add("921600");
            txtBaudRate.SelectedIndex =9;

            //数据位
            txtDataBits.Items.Add("5");
            txtDataBits.Items.Add("6");
            txtDataBits.Items.Add("7");
            txtDataBits.Items.Add("8");
            txtDataBits.SelectedIndex = 3;


            //校验位 
            this.txtParity.Items.Add("0");//不发生奇偶校验检查。
            this.txtParity.Items.Add("1");//设置奇偶校验位，使位数等于奇数。
            this.txtParity.Items.Add("2");//设置奇偶校验位，使位数等于偶数。
            this.txtParity.Items.Add("3");//将奇偶校验位保留为 1。
            this.txtParity.Items.Add("4");// 将奇偶校验位保留为 0。
            this.txtParity.SelectedIndex = 0;

            //停止位 
            this.txtStopBit.Items.Add("0");//不使用停止位。不支持此值。将 System.IO.Ports.SerialPort.StopBits 属性设置为 System.IO.Ports.StopBits.None,
            // 将引发 System.ArgumentOutOfRangeException。
            this.txtStopBit.Items.Add("1");//使用一个停止位。
            this.txtStopBit.Items.Add("2");//使用两个停止位。
            this.txtStopBit.Items.Add("3");// 使用 1.5 个停止位。
            this.txtStopBit.SelectedIndex = 1;

            this.btnSend.Enabled = isOpen;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 检测串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            GetPort();
        }
        /// <summary>
        /// 检查串口是否配置
        /// </summary>
        /// <returns></returns>
        private bool CheckPortSetting()
        {
            if (txtPort.Text.Trim() == "") return false;
            if (txtParity.Text.Trim() == "") return false;
            if (txtBaudRate.Text.Trim() == "") return false;
            if (txtDataBits.Text.Trim() == "") return false;
            if (txtStopBit.Text.Trim() == "") return false;
            txtMsg.Text = "port Check success";
            return true;
        }

        private bool GetPort()
        {
            bool isExist = false;
            txtPort.Items.Clear();
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    serialPort = new SerialPort("COM" + (i + 1).ToString());
                    serialPort.Open();
                    serialPort.Close();
                    txtPort.Items.Add("COM" + (i + 1).ToString());
                    isExist = true;
                }
                catch (Exception)
                {

                    continue;
                }
            }
            if (isExist)
            {
                txtPort.SelectedIndex = 0;
            }
            else
            {
                txtMsg.Text = "未找到串口";
            }
            return isExist;
        }

        /// <summary>
        /// 设置串口
        /// </summary>
        private void SetPortProperty()
        {
            serialPort = new SerialPort();
            serialPort.PortName = txtPort.Text.Trim();
            serialPort.BaudRate = int.Parse(txtBaudRate.Text.Trim());
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.txtParity.Text, true);
            serialPort.DataBits = int.Parse(txtDataBits.Text);
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.txtStopBit.Text, true);
            serialPort.ReadTimeout = -1;//设置超时读取时间
            serialPort.RtsEnable = true;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);

            if (chkHex.Checked) isHex = true; else isHex = false;
        }
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {

            if (!CheckPortSetting())
            {
                lblResult.Text = "port no setting";
                return;
            }
            if (!isSetProperty)//串口未设置则则设置串口
            {
                SetPortProperty();
                isSetProperty = true;
            }
            try
            {
                if (!isOpen) serialPort.Open();
                isOpen = true;
                setEnabled(false);
                txtMsg.Text = "port open success";
            }
            catch (Exception ex)
            {
                isSetProperty = false;
                isOpen = false;
                txtMsg.Text = "port open fail: invalid or having,:Exception" + ex.Message;
            }

            this.lblResult.Text = isOpen ? "Conn" : "Disconn";
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnDisConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isOpen) serialPort.Close();
                isOpen = false;
                setEnabled(true);
                txtMsg.Text = "port colse success";

            }
            catch (Exception ex)
            {
                txtMsg.Text = "colsing fail: Exception:" + ex.Message;
            }
            this.lblResult.Text = isOpen ? "conn" : "Disconn";
        }
        /// <summary>
        /// 设置按钮是否可点击
        /// </summary>
        /// <param name="isEnabled"></param>
        private void setEnabled(bool isEnabled)
        {
            txtBaudRate.Enabled = isEnabled;
            txtDataBits.Enabled = isEnabled;
            txtParity.Enabled = isEnabled;
            txtPort.Enabled = isEnabled;
            txtStopBit.Enabled = isEnabled;
            btnCheck.Enabled = isEnabled;
            btnSend.Enabled = !isEnabled;
        }

        /// <summary>
        /// 委托 接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);//延时接收数据
            this.Invoke((EventHandler)(delegate
            {
                receviedData();
            }));
        }
        /// <summary>
        /// 接收数据操作
        /// </summary>
        private void receviedData()
        {
            if (!chkHex.Checked)
            {   
               
                
                Byte[] receivedData = new Byte[serialPort.BytesToRead];
                serialPort.Read(receivedData, 0, receivedData.Length);
                String str = System.Text.Encoding.Default.GetString(receivedData, 0, receivedData.Length) + "\r\n";
                txtReceived.AppendText (str);
                textBox1.AppendText(currentType.PadLeft(4)+"  ---  "+crc16.ByteArrayToHexString(receivedData) + "\r\n");
                UpdateLoop(receivedData);
                ///在这里处理接口逻辑(解析接收到的数据)
                Regex r = new Regex("([A-Fa-f0-9]{2}:){5}[A-Fa-f0-9]{2}");
                Regex wifikeyword = new Regex("STAMAC");
                Match isWifi = wifikeyword.Match(str);
                MatchCollection mc = r.Matches(str); // 在字符串中匹配

                if (isWifi.Success && mc.Count==1)
                {

                    String mac_pure = mc[0].Value.Replace(":","");
                    bcc.CreateQuickMark(pictureBox1, "0000"+mac_pure, mc[0].Value);
                }
               
            }
            else
            {   
                //十六进制接收数据
                Byte[] receivedData = new Byte[serialPort.BytesToRead];
                serialPort.Read(receivedData, 0, receivedData.Length);
                String receDataText = null;
                for (int i = 0; i < receivedData.Length; i++)
                {
                    receDataText += ("Ox" + receivedData[i].ToString("X2") + " ") + "\r\n";
                }
                txtReceived.Text += receDataText;
            }
            try
            {
                serialPort.DiscardInBuffer();//释放接收缓冲区数据
            }
            catch (Exception ex)
            {
                txtMsg.Text = "Process Exception:" + ex.Message;
              
            }
        }
        /// <summary>
        ///清空数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtReceived.Text = "";
            txtSendData.Text = "";
            txtMsg.Text = "";
        }

        public void UpdateLoop( Byte[] bytes)
        {
            try
            {
                double value = (double)((bytes[3] & 0xff) << 8 | bytes[4]);

                switch (currentType)
                {
                    case "ch4":
                        ch4_show.Text = value.ToString();
                        break;
                    case "h2s":
                        h2s_show.Text = value.ToString();
                        break;
                    case "co2":
                        co2_show.Text = value.ToString();
                        break;
                    case "o2":
                        o2_show.Text = value.ToString();
                        break;
                    case "temp":
                        temp_show.Text = (value * 0.1).ToString() + "℃";
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        #region 写入数据

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="msg">写入端口的字节数组</param>
        public void WriteData(byte[] msg)
        {
            try
            {
                if (!(serialPort.IsOpen)) serialPort.Open();

                serialPort.Write(msg, 0, msg.Length);
                txtMsg.Text = "send success";
            }
            catch (Exception ex)
            {
                txtMsg.Text = "send Exception:" + ex.Message;
            }

        }

        public class DataReceivedEventArgs : EventArgs
        {
            public string DataReceived;
            public DataReceivedEventArgs(string m_DataReceived)
            {
                this.DataReceived = m_DataReceived;
            }
        }
        #endregion

        /// <summary>
        /// 发送数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string sendMsg = this.txtSendData.Text;
            WriteData(System.Text.Encoding.Default.GetBytes(sendMsg));
        }
        /// <summary>
        /// 自定发送时数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void chkAutoSend_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkAutoSend.Checked)//自定发送
            {
                intervalTime = int.Parse(txtIntervalTime.Text);
                txtIntervalTime.Enabled = false;
                ThAutoSendData = new Thread(autoSendData);
                ThAutoSendData.Name = "ThAutoSendData";
                ThAutoSendData.Start();
            }
            else
            {
                txtIntervalTime.Enabled = true;
                ThAutoSendData.Abort();
            }

        }
        /// <summary>
        /// 自定发送数据
        /// </summary>
        private void autoSendData()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(intervalTime);//间隔时间 

                this.Invoke((EventHandler)(delegate
                {
                    string sendMsg = this.txtSendData.Text;
                    WriteData(System.Text.Encoding.Default.GetBytes(sendMsg));
                }));

            }
        }
        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="e"></param>
        protected override void OnClosing(CancelEventArgs e)
        {
            if (isOpen) serialPort.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 发送获取mac串口指令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void getMac_Click(object sender, EventArgs e)
        {
           // WriteData(System.Text.Encoding.Default.GetBytes("wifimac"));
            WriteData(System.Text.Encoding.Default.GetBytes("wifimac"));
        }




        /// <summary>
        /// 二维码及打印部分处理
        /// </summary>



        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        //二维码生成和解析类
        private BarCodeClass bcc = new BarCodeClass();
        // 打印对象
        private DocementBase _document;
       
        //生成条形码
        private void barcode_gen_Click(object sender, EventArgs e)
        {
            bcc.CreateBarCode(pictureBox1, txtMsg.Text);
        }
        //生成二维码
        private void qrcode_gen_Click(object sender, EventArgs e)
        {
            bcc.CreateQuickMark(pictureBox1, txtMsg.Text, txtMsg.Text);
        }

        //解码
        private void button4_Click(object sender, EventArgs e)

        {

            if (pictureBox1.Image == null)

            {

                MessageBox.Show("请录入图像后再进行解码!");

                return;

            }

            BarcodeReader reader = new BarcodeReader();

            Result result = reader.Decode((Bitmap)pictureBox1.Image);

            MessageBox.Show(result.Text);

        }

        //打印btn
        private void printBtn_Click(object sender, EventArgs e)

        {
            if (pictureBox1.Image == null)

            {

                MessageBox.Show("二维码未获取到");

                return;

            }

            else

            {

                _document = new imageDocument(pictureBox1.Image);
                // printDocument1 为 打印控件  
                //设置打印用的纸张 当设置为Custom的时候，可以自定义纸张的大小，还可以选择A4,A5等常用纸型  
                //this.printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custum", 500, 300);
                //this.printDocument1.PrintPage += new PrintPageEventHandler(this.MyPrintDocument_PrintPage);
                //将写好的格式给打印预览控件以便预览  
                //printPreviewDialog1.Document = printDocument1;
                //显示打印预览  
                // DialogResult result = printPreviewDialog1.ShowDialog();
                //if (result == DialogResult.OK)  
                //this.MyPrintDocument.Print();  

            }
            //打印边距设置
            Margins margin = new Margins(60, 60, 0, 0);
            _document.DefaultPageSettings.Margins = margin;
            //_document.DefaultPageSettings.PaperSize
            _document.showPrintPreviewDialog();

        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {

        }

        private void reflashBtn_Click(object sender, EventArgs e)
        {
            bcc.CreateQuickMark(pictureBox1, " ", "重置");
        }

       

    

        private void alrm_off_Click(object sender, EventArgs e)
        {
            currentType = "关报警";
            SendStrCmd(alrm_off_cmd);
        }

        private void alrm_on_Click(object sender, EventArgs e)
        {
            currentType = "开报警";
            SendStrCmd(alrm_on_cmd);
        }
        private void cmd_Click(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            currentType = btn.Name;
            SendStrCmd(cmdDic[btn.Name]);

        }

        public void SendStrCmd(string cmd)
        {
            byte[] buffer = crc16.HexString2Bytes(cmd);

            WriteData(buffer);
        }

        private void loopBtn_Click(object sender, EventArgs e)
        {
            if (loopBtn.Text == "停止")
            {
                loopthread.Abort();
                loopBtn.Text = "轮询";
                return;
            }
            try
            {
                loopthread = new Thread(LoopCheck);
                loopthread.Start();
                loopBtn.Text = "停止";

            }
            catch(Exception exp)
            {
               MessageBox.Show(exp.ToString());
            }
           
        }

        /// <summary>
        /// 轮询函数
        /// </summary>
        public void LoopCheck()
        {
           

            for (int count = 0; count < cmdDic.Count; count++)
            {
                var element = cmdDic.ElementAt(count);
                var Key = element.Key;
                var Value = element.Value;
                currentType = Key;
                try
                {
                    SendStrCmd(Value);//发送请求
                    int loop_time = int.Parse(loopTime.Value.ToString());
                    Thread.Sleep(loop_time * 1000);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                if(count == cmdDic.Count - 1)
                {
                    count = 0;
                }
            }
        }
    }






}
