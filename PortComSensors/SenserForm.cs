using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using NewPortTest;
using System.Drawing;

namespace SenserProj
{
    public partial class SenserForm : Form
    {
        SerialPort serialPort = new SerialPort();
        bool isOpen = false;
        string currentType = "";//标记当前轮询到哪个传感器
        Thread loopthread;//轮询线程
        Thread getThresholdThread;

        string ch4_range;
        string h2s_range;
        string co_range;
        string o2_range;
        string temp_range;

        //警报的状态
        bool Alarming = false;

        //阈值查询状态
        Hashtable table = new Hashtable {
            { "ch4", false},
            { "h2s", false},
            { "co",  false},
            { "o2",  false},
            { "temp",false}
        };


        //传感器读取指令
        Dictionary<string, string> cmdRead = new Dictionary<string, string>{
            { "ch4","ff0300010001c014"},
            { "h2s","ff0300040001d015"},
            { "co","ff03000700012015"},
            { "o2","ff03000a0001b1d6"},
            { "temp","ff03000d00010017"},
            { "humi","ff03000e0001f017"},
};
        /*读取阈值指令
         *  读取CH4上限 ff0300 2000 01 90 1E
         *  读取CH4下限 ff0300 2100 01 C1 DE
         *
         *  读取H2S上限 ff0300 2200 01 31 DE
         *  读取H2S下限 ff0300 2300 01 60 1E
         *
         *  读取CO上限 ff0300 2400 01 D1 DF
         *  读取CO下限 ff0300 2500 01 80 1F
         *
         *  读取O2上限 ff0300 2600 01 70 1F
         *  读取O2下限 ff0300 2700 01 21 DF
         *
         *  读取温度上限  ff0300 2800 01 11 DC
         *  读取温度下限  ff0300 2900 01 40 1C
        */
        Dictionary<string, string> cmdGetThreshold = new Dictionary<string, string>
        {
            { "ch4_up","ff0300200001901E"},
            { "ch4_dw","ff0300210001C1DE"},

            { "h2s_up","ff030022000131DE"},
            { "h2s_dw","ff0300230001601E"},

            { "co_up","ff0300240001D1DF"},
            { "co_dw","ff0300250001801F"},

            { "o2_up","ff0300260001701F"},
            { "o2_dw","ff030027000121DF"},

            { "temp_up","ff030028000111DC"},
            { "temp_dw","ff0300290001401C"},
        };


        /* ==============设置传感器阈值=================
         * 设置CH4上限	ff1000 2000 010200 50 E9 68
         * 设置CH4下限	ff1000 2100 010200 14 E8 8A
         * 
         * 设置H2S上限	ff1000 2200 010200 50 69 63
         * 设置H2S下限	ff1000 2300 010200 14 E9 68
         * 
         * 设置CO上限	ff1000 2400 010200 50 69 05
         * 设置CO下限	ff1000 2500 010200 14 E9 0E
         * 
         * 设置O2上限	ff1000 2600 010200 12 A9 3C
         * 设置O2下限	ff1000 2700 010200 17 68 EE
         * 
         * 设置温度上限	ff1000 2800 010200 00 69 C6
         * 设置温度下限	ff1000 2900 010200 26 69 CA
         *
         */
        Dictionary<string, string> cmdSetThreshold = new Dictionary<string, string>
        {
            {"ch4_up","ff10002000010200" },
            {"ch4_dw","ff10002100010200" },

            {"h2s_up","ff10002200010200" },
            {"h2s_dw","ff10002300010200" },

            {"co_up", "ff10002400010200" },
            {"co_dw", "ff10002500010200" },

            {"o2_up", "ff10002600010200" },
            {"o2_dw", "ff10002700010200" },

            {"temp_up","ff10002800010200" },
            {"temp_dw","ff10002900010200" },
        };

        //警报控制指令
        string alrm_on_cmd = "ff10001100010200012cb5";
        string alrm_off_cmd = "ff1000110001020000ed75";

        public SenserForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 程序初加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Load(object sender, EventArgs e)
        {
            initSensorsSetting();
            Control.CheckForIllegalCrossThreadCalls = false;//取消线程检查
            initPortSetting();//绑定初始值

            bool exist = GetPort();//获取portCom
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
            txtPort.Items.Add("COM1");
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

            //设置配置
            ch4_range_textBox.Text = ch4_range;
            h2s_range_textBox.Text = h2s_range;
            co_range_textBox.Text = co_range;
            o2_range_textBox.Text = o2_range;
            temp_range_textBox.Text = temp_range;

            //加载告警阈值
            foreach (string type in table.Keys)
            {
                string[] alert_type = { "up_warn", "up_danger", "down_warn", "down_danger" };
                for (int i = 0; i < alert_type.Length; i++)
                {
                    string config_key = type + "_" + alert_type[i];
                    string config_value = Config.valueItem(config_key);
                    string texbox_key = config_key + "_tb";
                    TextBox tb = this.Controls.Find(texbox_key, true).FirstOrDefault() as TextBox;
                    //非空则赋值
                    if (config_value != null && tb != null)
                    {
                        tb.Text = config_value;
                    }



                }
            }


            label_ch4.Text = "甲烷(0-" + ch4_range + "%LEL)";
            label_h2s.Text = "硫化氢(0-" + h2s_range + "PPM)";
            label_co.Text = "一氧化碳(0-" + co_range + "PPM)";
            label_o2.Text = "氧气(0-" + o2_range + "%VOL)";
            label_temp.Text = "温度（0-" + temp_range + "℃）";
            label_humi.Text = "湿度（0-"+ 100+"RH% ）";




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

            if (btnOpen.Text == "打开")
            {
                if (serialPort.IsOpen)
                {
                    isOpen = true;
                    txtMsg.Text = "串口已打开";
                    btnOpen.Text = "关闭";
                }
                try
                {
                    if (!isOpen)
                    {
                        SetPortProperty();
                        serialPort.Open();
                        isOpen = true;
                        setEnabled(false);
                        txtMsg.Text = "打开串口成功";
                        btnOpen.Text = "关闭";

                        //串口打开成功后获取传感器阈值
                        if (serialPort.IsOpen)
                        {
                            getThreshold();
                        }
                    }
                }
                catch (Exception ex)
                {

                    txtMsg.Text = "打开串口失败" + ex.ToString();
                    isOpen = false;
                    btnOpen.Text = "打开";
                }
            }
            else
            {
                //关闭串口逻辑
                try
                {


                    if (getThresholdThread != null)
                    {
                        getThresholdThread.Abort();
                    }
                    if (loopthread != null)
                    {
                        loopthread.Abort();
                    }
                    serialPort.Close();
                    isOpen = false;
                    setEnabled(true);
                    btnOpen.Text = "打开";
                    txtMsg.Text = "串口关闭成功";

                }
                catch (Exception ex)
                {
                    txtMsg.Text = "串口关闭失败" + ex.Message;
                    btnOpen.Text = "关闭";
                }
            }
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


            //十六进制显示数据
            Byte[] receivedData = new Byte[serialPort.BytesToRead];
            serialPort.Read(receivedData, 0, receivedData.Length);
            String receDataText = null;
            for (int i = 0; i < receivedData.Length; i++)
            {
                receDataText += ("Ox" + receivedData[i].ToString("X2") + " ") + "\r\n";
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

        /// <summary>
        /// 处理接收到的字节（按类型）
        /// </summary>
        /// <param name="bytes"></param>
        public void UpdateLoop(Byte[] bytes)
        {
            string text = currentType.PadLeft(4) + "<--" + crc16.ByteArrayToHexString(bytes);
            textBox1.AppendText(text + "\r\n");

            string time = DateTime.Now.ToLocalTime().ToString();
            Output.WriteMessage(@".\Log.txt", "[" + time + "]" + text);
            try
            {
                if (bytes.Length != 7)
                {
                    return;
                }
                int v = (bytes[3] & 0xff) << 8 | bytes[4];

                double value = (double)v * 0.1;
                int i = (int)Math.Round(value, 0);//四舍五入
                string str = value.ToString();
                markCurrenty(currentType);
                switch (currentType)
                {

                    case "ch4":
                        if (v == 65535)
                        {
                            ch4.Text = "未在线";
                            table[currentType] = false;

                            break;
                        }
                        ch4.Text = v.ToString() + "%LEL";
                        ch4.BackColor = operate(v, v.ToString(), ch4_range, "ch4");

                        break;
                    case "h2s":
                        if (v == 65535)
                        {
                            h2s.Text = "未在线";
                            table[currentType] = false;

                            break;
                        }
                        h2s.Text = v.ToString() + "PPM";
                        h2s.BackColor = operate(v, v.ToString(), h2s_range, "h2s");

                        break;
                    case "co":
                        if (v == 65535)
                        {
                            co.Text = "未在线";
                            table[currentType] = false;

                            break;
                        }
                        co.Text = v.ToString() + "PPM";
                        co.BackColor = operate(v, v.ToString(), co_range, "co");

                        break;
                    case "o2":
                        if (v == 65535)
                        {
                            o2.Text = "未在线";
                            table[currentType] = false;

                            break;
                        }
                        o2.Text = str + "%VOL";
                        o2.BackColor = operate(v, value.ToString(), o2_range, "o2");
                        break;
                    case "temp":
                        if (v == 65535)
                        {
                            temp.Text = "未在线";
                            table[currentType] = false;

                            break;
                        }
                        temp.Text = (value).ToString() + "℃";
                        temp.BackColor = operate(v, (value).ToString(), temp_range, "temp");
                        break;
                    //获取默认阈值逻辑
                    case "ch4_up":
                        ch4_up.Value = v;
                        break;
                    case "ch4_dw":
                        ch4_dw.Value = v;
                        break;
                    case "h2s_up":
                        h2s_up.Value = v;
                        break;
                    case "h2s_dw":
                        h2s_dw.Value = v;
                        break;
                    case "co_up":
                        co_up.Value = v;
                        break;
                    case "co_dw":
                        co_dw.Value = v;
                        break;
                    case "o2_up":
                        o2_up.Value = v;
                        break;
                    case "o2_dw":
                        o2_dw.Value = v;
                        break;
                    case "temp_up":
                        temp_up.Value = v;
                        break;
                    case "temp_dw":
                        temp_dw.Value = v;
                        break;
                }




            }
            catch (Exception ex)
            {
                txtMsg.Text = "解析数据出错" + ex.ToString();
            }

            //遍历所有的传感器，计算告警状态
            bool alert = false;
            foreach (bool status in table.Values) //ht为一个Hashtable实例 
            {
                alert |= status;

            }
            if (alert)
            {
                //  toggleAlarm(true);
            }
            else
            {
                // toggleAlarm(false);
            }
        }
        public Color operate(int origen, string value, string range, string type)
        {
            int a = 125;//透明度
            Color normal_color = Color.FromArgb(a, 0, 255, 0);//告警色--绿
            Color warn_color = Color.FromArgb(a, 255, 165, 0);//告警色--橙
            Color danger_color = Color.FromArgb(a, 255, 0, 0);//告警色--红

            int up_alarm = Decimal.ToInt32((this.Controls.Find(type + "_up", true).FirstOrDefault() as NumericUpDown).Value);
            int dw_alarm = Decimal.ToInt32((this.Controls.Find(type + "_dw", true).FirstOrDefault() as NumericUpDown).Value);

            if (type == "o2")
            {
                if (origen > up_alarm || origen < dw_alarm)
                {
                    //标识当前类型有告警
                    table[type] = true;
                    return danger_color;
                }
                else
                {
                    table[type] = false;
                    return normal_color;

                }
            }
            else if (type == "ch4" || type == "h2s" || type == "co")
            {
                if (origen > dw_alarm)
                {
                    //标识当前类型有告警
                    table[type] = true;
                    return danger_color;
                }

                else
                {
                    table[type] = false;
                    return normal_color;

                }
            }
            else
            {
                return normal_color;
            }


            /*================================本地保存量程时===================
                        string up_warn = (this.Controls.Find(type + "_up_warn_tb", true).FirstOrDefault() as TextBox).Text;
                        string up_danger = (this.Controls.Find(type + "_up_danger_tb", true).FirstOrDefault() as TextBox).Text;
                        //hack 去掉橙色告警
                        if (type == "temp" || type == "o2")
                        {
                            up_warn = up_danger;
                        }
                        double num = double.Parse(value);
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
                            if (type == "temp"||type=="o2")//区间告警类型（有向下的告警）
                            {
                                string down_warn = (this.Controls.Find(type + "_down_warn_tb", true).FirstOrDefault() as TextBox).Text;
                                string down_danger = (this.Controls.Find(type + "_down_danger_tb", true).FirstOrDefault() as TextBox).Text;
                                //去掉橙色告警
                                down_warn = down_danger;

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
                        */

        }

        /// <summary>
        /// 当前更新加label背景色
        /// 
        /// </summary>
        /// <param name="current"></param>
        public void markCurrenty(string current)
        {
            foreach (string type in table.Keys)
            {
                string label_name = "label_" + type;
                Label lb = this.Controls.Find(label_name, true).FirstOrDefault() as Label;
                if (type == current)
                {
                    lb.BackColor = Color.LawnGreen;
                }
                else
                {
                    lb.BackColor = Color.Transparent;
                }

            }
        }


        #region 写入数据

        /// <summary>
        /// 写入数据
        /// </summary>
        /// <param name="msg">写入端口的字节数组</param>
        public Boolean WriteData(byte[] msg)
        {
            try
            {
                if (!(serialPort.IsOpen)) serialPort.Open();

                serialPort.Write(msg, 0, msg.Length);

            }
            catch (Exception ex)
            {
                txtMsg.Text = "send Exception:" + ex.Message;
                return false;
            }
            string text = "send-" + currentType + "->" + crc16.ByteArrayToHexString(msg);
            txtMsg.Text = text;
            string time = DateTime.Now.ToLocalTime().ToString();
            Output.WriteMessage(@".\Log.txt", "[" + time + "]" + text);
            return true;

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
            if (open == Alarming)
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
            SendStrCmd(cmdRead[lb.Name]);
        }

        public bool SendStrCmd(string cmd)
        {

            byte[] buffer = crc16.HexString2Bytes(cmd.Trim());

            bool status = WriteData(buffer);
            return status;
        }

        private void loopBtn_Click(object sender, EventArgs e)
        {
            if (loopBtn.Text == "停止")
            {
                //关闭轮询
                currentType = "关报警";
                toggleAlarm(false);

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
            catch (Exception exp)
            {
                txtMsg.Text = "loopError" + exp.ToString();
            }

        }
        /// <summary>
        /// 轮询函数
        /// </summary>
        public void LoopCheck()
        {
            for (int count = 0; count < cmdRead.Count; count++)
            {
                var element = cmdRead.ElementAt(count);
                var Key = element.Key;
                var Value = element.Value;
                currentType = Key;
                try
                {

                    SendStrCmd(Value);//发送请求

                    int loop_time = int.Parse(loopTime.Value.ToString());
                    Thread.Sleep(loop_time);
                }
                catch (Exception ex)
                {
                    txtMsg.Text = ex.ToString();
                }
                if (count == cmdRead.Count - 1)
                {
                    count = -1;
                }
            }
        }

        private void HandelModify(object sender, EventArgs e)
        {
            TextBox mtb = (TextBox)sender;
            string name = mtb.Name;
            string value_modify = mtb.Text;
            string key_map = name.Remove(name.Length - 3);
            Config.modifyItem(key_map, value_modify);
        }

        public void getThreshold()
        {

            if (!isOpen)
            {
                MessageBox.Show("未打开串口");
                return;
            }
            if (getThresholdThread != null && getThresholdThread.ThreadState == ThreadState.Running)
            {
                //防止重复调用
                return;
            }
            //关掉轮询
            if (loopthread != null)
            {
                loopthread.Abort();
            }

            loopBtn.Enabled = false;

            getThresholdThread = new Thread(getThresholdMethods);
            getThresholdThread.Start();
        }

        public void getThresholdMethods()
        {
            for (int count = 0; count < cmdGetThreshold.Count; count++)
            {
                var element = cmdGetThreshold.ElementAt(count);
                var Key = element.Key;
                var Value = element.Value;
                currentType = Key;
                try
                {
                    SendStrCmd(Value);//发送请求
                    int loop_time = int.Parse(getThresholdTime.Value.ToString());
                    Thread.Sleep(loop_time);
                }
                catch (Exception ex)
                {
                    txtMsg.Text = "获取默认阈值线程出错" + ex.ToString();
                    loopBtn.Enabled = true;//打开轮询按钮
                }
            }
            loopBtn.Enabled = true;//打开轮询按钮

            //查询阈值结束
            getThresholdThread.Abort();



            //上面调用Thread.Abort方法后线程thread不一定马上就被终止了，所以我们在这里写了个循环来做检查，看线程thread是否已经真正停止。其实也可以在这里使用Thread.Join方法来等待线程thread终止，Thread.Join方法做的事情和我们在这里写的循环效果是一样的，都是阻塞主线程直到thread线程终止为止
            while (getThresholdThread.ThreadState != ThreadState.Aborted)
            {
                //当调用Abort方法后，如果thread线程的状态不为Aborted，主线程就一直在这里做循环，直到thread线程的状态变为Aborted为止
                Thread.Sleep(100);
            }
        }

        private void setting_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nu = (NumericUpDown)sender;
            string name = nu.Name;
            int value = Decimal.ToInt32(nu.Value);
            string pre = cmdSetThreshold.Single(k => k.Key == name).Value;//获取到前缀
            string hex = value.ToString("x2");

            string msg = pre + hex + Crc16_modbus.ToModbusCRC16(pre + hex, true);//得到加了crc校验的消息
            //发送设置指令
            SendStrCmd(msg);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //获取默认的阈值

            getThreshold();
        }
        /// <summary>
        /// 禁用自动上报功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void disableAuto_btn_Click(object sender, EventArgs e)
        {
            string disableAutoSend = "ff10001200010200012C86";//禁止传感器的自动上传
            SendStrCmd(disableAutoSend);
        }
        /// <summary>
        /// 氧气校准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        private void id_set_btn_Click(object sender, EventArgs e)
        {
            string hex = Decimal.ToInt32(id.Value).ToString("x2");
            string pre = "ff10001000010200";
            string msg = pre + hex + Crc16_modbus.ToModbusCRC16(pre + hex, true);//得到加了crc校验的消息
            //发送设置指令
            SendStrCmd(msg);
        }

        #region  Sensor Calibrate


        /// <summary>
        /// 
        /// </summary>
        /// <param name="formText"></param> 窗体的标题
        /// <param name="gasType"></param>  气体类型
        /// <param name="descriptions"></param> 描述的数组 填充label
        /// <param name="time"></param> 定时秒数
        /// <param name="cmd"></param>  校验的命令

        public void OpenCalibrateForm(GasCalibration gc)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未打开或连接异常","提示");
                return;
            }
            FormCalibrate fc = new FormCalibrate(gc, this);
            fc.Text = gc.title;
            fc.ShowDialog();
        }

        private void ch4_calibrate_Click(object sender, EventArgs e)
        {
            GasCalibration ch4 = new GasCalibration();
            ch4.title = "甲烷校准";
            ch4.type = "ch4";
            ch4.time = 180;
            ch4.cmd = "ff1000 3100 0102";
            string[] descs = {
                "1.首先保证传感器上电时间大于30分钟以。",
                "2.使用50%LEL的CH4标气，流速是500ml/min，通过管路将气体通到传感器表面。",
                "3.通气三分钟后，向模组发送零点校准指令【FF 10 00 30 00 01 02 00 00 】。",
                "4.观察模组输出数据是否为50%LEL 是则说明校准正常，否则说明校准失败。",
                "5.多次标定不成功或出现其它情况，请联系本公司。"
            };
            ch4.descs = descs;
            OpenCalibrateForm(ch4);

        }

        #endregion

        private void h2s_calibrate_Click(object sender, EventArgs e)
        {
            GasCalibration h2s = new GasCalibration();
            h2s.title = "硫化氢校准";
            h2s.type = "h2s";
            h2s.time = 180;
            h2s.cmd = "ff1000 3200 0102";
            string[] descs = {
                "1.首先保证传感器上电时间大于5min。",
                "2.使用50ppm的H2S，流量在100ml/min左右，通过管路将气体通到传感器表面。",
                "3.通气三分钟后，向模组发送校准指令  【FF 10 00 30 00 01 02 00 01 】。",
                "4.观察模组输出数据是否为50ppm 是则说明校准正常，否则说明校准失败。",
                "5.发送校准命令时,模组输出的模拟电压需在0.8V~1.8V之间，",
                "  若超出此范围,则不能校准成功，需要返厂校准。"
            };
            h2s.descs = descs;
            OpenCalibrateForm(h2s);
        }

        private void co_calibrate_Click(object sender, EventArgs e)
        {
            GasCalibration co = new GasCalibration();
            co.title = "一氧化碳校准";
            co.type = "co";
            co.time = 210;
            co.cmd = "ff1000 3300 0102";
            string[] descs = {
                "1.首先保证传感器上电时间大于5min。（长时间未使用的，需要老化24h）",
                "2.使用200ppm的CO，流量在100ml/min左右，通过管路将气体通到传感器表面。",
                "3.通气三分钟后，向模组发送校准指令  【FF 01 88 00 C8 00 00 00 AF】。",
                "4.观察模组输出数据是否为200ppm， 是则说明校准正常，否则说明校准失败。",
                "5.在200ppm环境下发送校准命令时，模组输出的模拟电压需在0.8V~1.3V之间，",
                "  若超出此范围，则不能校准成功，需要返厂校准。"
            };
            co.descs = descs;
            OpenCalibrateForm(co);
        }
        private void o2_calibrate_Click(object sender, EventArgs e)
        {
            GasCalibration o2 = new GasCalibration();
            o2.title = "氧气校准";
            o2.type = "o2";
            o2.time = 210;
            o2.cmd = "ff 10 00 30 00 01 02 00 03";//校准O2:
            string[] descs = {
                "1.模组上电老化24小时，如果已老化，可直接进行步骤2",
                "2.老化完成后，断电，重新上电，开始计时三分钟半",
                "3.通气三分半钟后，向模组发送校准指令【 ff 10 00 30 00 01 02 00 03】",
                "4.串口返回命令或当前浓度值，标定成功" ,
                "5.如标定不成功，等待5秒后重新发送标定命令。",
                "6.步骤5多次不成功，请尝试重新断电上电，重复标定步骤。",
                "6.多次标定不成功或出现其它情况，请联系本公司。"
            };
            o2.descs = descs;
            OpenCalibrateForm(o2);
        }
    }
}
