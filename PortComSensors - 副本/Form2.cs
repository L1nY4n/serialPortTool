using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using NewPortTest;
using System.Drawing;

namespace PortDemo3
{
    public partial class Form2 : Form
    {
        SerialPort serialPort = new SerialPort();
        bool isOpen = false;
        string currentType = "";//标记当前轮询到哪个传感器
        Thread loopthread;
        int intervalTime = 500;

        string ch4_range;
        string h2s_range;
        string co_range;
        string o2_range;
        string temp_range;

        //警报的状态
        bool Alarming = false;

        //传感器状态
        bool ch4_staus = false;
        bool h2s_staus = false;
        bool co_staus = false;
        bool o2_staus = false;
        bool temp_staus = false;

       
        //Dictionary<string, bool> statusDic = new Dictionary<string, bool>{
        //    { "ch4", false},
        //    { "h2s", false},
        //    { "co",  false},
        //    { "o2",  false},
        //    { "temp",false}
        //};
        Hashtable table = new Hashtable {
            { "ch4", false},
            { "h2s", false},
            { "co",  false},
            { "o2",  false},
            { "temp",false}
        };
       

        //传感器指令
        Dictionary<string, string> cmdDic = new Dictionary<string, string>{
            { "ch4","ff0300010001c014"},
            { "h2s","ff0300040001d015"},
            { "co","ff03000700012015"},
            { "o2","ff03000a0001b1d6"},
            { "temp","ff03000d00010017"}
};
       //警报控制指令
        string alrm_on_cmd = "ff10001100010200012cb5";
        string alrm_off_cmd = "ff1000110001020000ed75";

        public Form2()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序初加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form2_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;//取消线程检查
            initPortSetting();//绑定初始值
            initSensorsSetting();
            bool exist =GetPort();//获取portCom
            if (exist)
            {
                //存在串口port   
                this.btnSend.Enabled = isOpen;
            }
        }

        /// <summary>
        /// 初始化串口设置
        /// </summary>
        public void initPortSetting()
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
            txtBaudRate.SelectedIndex = 5;

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
        }

        /// <summary>
        /// 初始化传感器的信息
        /// </summary>
        public void initSensorsSetting()
        {
             ch4_range = Config.valueItem("ch4_range");
             h2s_range = Config.valueItem("h2s_range");
             co_range = Config.valueItem("co_range");
             o2_range = Config.valueItem("o2_range");
             temp_range = Config.valueItem("temp_range");

            label_ch4.Text="甲烷(0-"+ ch4_range+"%LEL)";
            label_h2s.Text = "硫化氢(0-" + h2s_range + "PPM)";
            label_co.Text = "一氧化碳(0-" + co_range + "PPM)";
            label_o2.Text = "氧气(0-" + o2_range + "%VOL)";

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
            txtMsg.Text = "串口设置成功—" + txtPort.Text.Trim();
        }
        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
          
            if (btnOpen.Text == "Open")
            {
               

                try
                {
                    if (!isOpen)
                    {
                        SetPortProperty();
                        serialPort.Open();

                        isOpen = true;
                        setEnabled(false);
                        txtMsg.Text = "打开串口成功";
                        btnOpen.Text = "Close";
                    }
                }
                catch (Exception ex)
                {

                    txtMsg.Text = "打开串口失败";
                    isOpen = false;
                    btnOpen.Text = "Open";

                }
            }
            else
            {
                //关闭串口逻辑
                try
                {
                    if (isOpen) serialPort.Close();
                    isOpen = false;
                    setEnabled(true);
                    btnOpen.Text = "Open";
                    txtMsg.Text = "串口关闭成功";

                }
                catch (Exception ex)
                {
                    txtMsg.Text = "串口关闭失败" + ex.Message;
                    btnOpen.Text = "Close";
                }
            }
        }
        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void btnDisConn_Click(object sender, EventArgs e)
        {
           
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
            System.Threading.Thread.Sleep(50);//延时接收数据
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
            if (!chkHex.Checked)//十六进制显示
            {   
                Byte[] receivedData = new Byte[serialPort.BytesToRead];
                serialPort.Read(receivedData, 0, receivedData.Length);
                String str = System.Text.Encoding.Default.GetString(receivedData, 0, receivedData.Length) + "\r\n";

             //处理接收到的bytes
                UpdateLoop(receivedData);
            }
            else
            {   
                //十六进制显示数据
                Byte[] receivedData = new Byte[serialPort.BytesToRead];
                serialPort.Read(receivedData, 0, receivedData.Length);
                String receDataText = null;
                for (int i = 0; i < receivedData.Length; i++)
                {
                    receDataText += ("Ox" + receivedData[i].ToString("X2") + " ") + "\r\n";
                }
               
            }

            try
            {
                serialPort.DiscardInBuffer();//释放接收缓冲区数据
            }
            catch (Exception ex)
            {
                txtMsg.Text = "释放接收缓冲区数据出错:" + ex.Message;
              
            }
        }
        /// <summary>
        ///清空数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            txtSendData.Text = "";
            txtMsg.Text = "";
        }

        public void UpdateLoop( Byte[] bytes)
        {
            string text = currentType.PadLeft(4) + "<--" + crc16.ByteArrayToHexString(bytes);
            textBox1.AppendText(text + "\r\n");

            string time = DateTime.Now.ToLocalTime().ToString();
            Output.WriteMessage(@".\Log.txt", "[" + time + "]" + text);
            try
            {
                if (bytes.Length !=7)
                {
                    return;
                }
                int v = (bytes[3] & 0xff) << 8 | bytes[4];
              
                double value = (double)v;
                string str = value.ToString();
                switch (currentType)
                {   

                    case "ch4":
                        if (v == 65535)
                        {
                            ch4.Text = "故障";
                            table[currentType] = false;
                            ch4_staus = false;
                            break;
                        }
                        ch4.Text = str+"%LEL";
                        ch4.BackColor = operate(value.ToString(), ch4_range, "ch4");

                        break;
                    case "h2s":
                        if (v == 65535)
                        {
                            h2s.Text = "故障";
                            table[currentType] = false;
                            h2s_staus = false;
                            break;
                        }
                        h2s.Text = str + "PPM";
                        h2s.BackColor = operate(value.ToString(),h2s_range, "h2s");
                       
                        break;
                    case "co":
                        if (v == 65535)
                        {
                            co.Text = "故障";
                            table[currentType] = false;
                            co_staus = false;
                            break;
                        }
                        co.Text = str + "PPM";
                        co.BackColor = operate(value.ToString(), co_range, "co");
                       
                        break;
                    case "o2":
                        if (v == 65535)
                        {
                            o2.Text = "故障";
                            table[currentType] = false;
                            o2_staus = false;
                            break;
                        }
                        o2.Text = str + "%VOL";
                       o2.BackColor = operate(value.ToString(), o2_range, "o2");
                        break;
                    case "temp":
                        if (v == 65535)
                        {
                            temp.Text = "故障";
                            table[currentType] = false;
                            temp_staus = false;
                            break;
                        }
                        temp.Text = (value * 0.1).ToString() + "℃";
                        temp.BackColor = operate((value * 0.1).ToString(), temp_range, "temp");
                        break;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //遍历所有的传感器，计算告警状态
            bool alert = false;
            foreach (bool status in table.Values) //ht为一个Hashtable实例 
            {
                alert |= status;
                
            }
            if (alert) {
                toggleAlarm(true);
            }
            else
            {
                toggleAlarm(false);
            }
        }
        public Color operate(string value, string range, string type)
        {
            int a = 125;//透明度
            Color normal_color = Color.FromArgb(a, 0, 255, 0);//告警色--绿
            Color warn_color = Color.FromArgb(a, 255, 165, 0);//告警色--橙
            Color danger_color = Color.FromArgb(a, 255, 0, 0);//告警色--红
            string up_warn = Config.valueItem(type + "_up_warn");
            string up_danger = Config.valueItem(type + "_up_danger");
            double num = double.Parse(value);
            double double_num = num * 0.1;


            if (num < double.Parse(up_danger) && num > double.Parse(up_warn))
            {

            
                table[type] = true;
                return warn_color;
            }
            else if (num >= double.Parse(up_danger)) //danger
            {
                
                table[type] = true;
                return danger_color;
            }
            else
            {
                if (type == "temp")//区间告警类型（有向下的告警）
                {
                    string down_warn = Config.valueItem(type + "_down_warn");
                    string down_danger = Config.valueItem(type + "_down_danger");
                    if (num < double.Parse(down_warn) && num > double.Parse(down_danger))
                    {
                        //warn

                       
                        table[type] = true;
                        return warn_color;


                    }
                    else if (num <= double.Parse(down_danger))
                    {
                        //danger

                      
                        table[type] = true;
                        return danger_color;


                    }
                    else
                    {
                        //normal

                        table[type] = false;
                        return normal_color;
                    }

                }
                //normal
             
                table[type] = false;
                return normal_color;
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
                string text = "send-->" + crc16.ByteArrayToHexString(msg);
                txtMsg.Text =text;
                string time = DateTime.Now.ToLocalTime().ToString();
                Output.WriteMessage(@".\Log.txt", "["+time+"]"+text);
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
        /// 二维码及打印部分处理
        /// </summary>
        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        //二维码生成和解析类
        private BarCodeClass bcc = new BarCodeClass();
        // 打印对象
        private DocementBase _document;

        private void alrm_off_Click(object sender, EventArgs e)
        {
            currentType = "关报警";
            toggleAlarm(false);

        }

        private void alrm_on_Click(object sender, EventArgs e)
        {
            
            toggleAlarm(true);
        }

        public void toggleAlarm(bool open)
        {
            if(open==Alarming)
            {
                //status no change
                return;
            }
            if (open)
            {
                currentType = "back";
                SendStrCmd(alrm_on_cmd);
                Alarming = true;
            }
            else
            {
                currentType = "back";
                Alarming = false;
                SendStrCmd(alrm_off_cmd);
            }
        }
        /// <summary>
        /// label点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmd_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
  
            currentType = lb.Name;
            try
            {
                if (loopthread != null)
                {
                    //关掉轮询线程
                    loopthread.Abort();
                    loopBtn.Text = "轮询";
                }
            }
            catch (Exception ex)
            {
                txtMsg.Text = "关掉轮询出错" + ex.ToString();
            }
            SendStrCmd(cmdDic[lb.Name]);
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
               MessageBox.Show("轮询error"+exp.ToString());
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
                    Thread.Sleep(loop_time);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
