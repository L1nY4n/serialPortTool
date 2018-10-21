namespace PortDemo3
{
    partial class Form2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDisConn = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.txtDataBits = new System.Windows.Forms.ComboBox();
            this.txtBaudRate = new System.Windows.Forms.ComboBox();
            this.txtStopBit = new System.Windows.Forms.ComboBox();
            this.txtParity = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAppend = new System.Windows.Forms.CheckBox();
            this.chkAutoSend = new System.Windows.Forms.CheckBox();
            this.txtIntervalTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.getMac = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barcode_gen = new System.Windows.Forms.Button();
            this.qrcode_gen = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.reflashBtn = new System.Windows.Forms.Button();
            this.ch4 = new System.Windows.Forms.Button();
            this.h2s = new System.Windows.Forms.Button();
            this.co2 = new System.Windows.Forms.Button();
            this.o2 = new System.Windows.Forms.Button();
            this.temp = new System.Windows.Forms.Button();
            this.alrm_on = new System.Windows.Forms.Button();
            this.alrm_off = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loopBtn = new System.Windows.Forms.Button();
            this.loopTime = new System.Windows.Forms.NumericUpDown();
            this.ch4_show = new System.Windows.Forms.Label();
            this.h2s_show = new System.Windows.Forms.Label();
            this.co2_show = new System.Windows.Forms.Label();
            this.o2_show = new System.Windows.Forms.Label();
            this.temp_show = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 26);
            this.label1.TabIndex = 75;
            this.label1.Text = "Port:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "BaudRate:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 73;
            this.label3.Text = "Parity:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 72;
            this.label4.Text = "StopBit:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "DataBits:";
            // 
            // btnDisConn
            // 
            this.btnDisConn.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnDisConn.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDisConn.Location = new System.Drawing.Point(596, 7);
            this.btnDisConn.Name = "btnDisConn";
            this.btnDisConn.Size = new System.Drawing.Size(75, 39);
            this.btnDisConn.TabIndex = 14;
            this.btnDisConn.Text = "Close";
            this.btnDisConn.UseVisualStyleBackColor = false;
            this.btnDisConn.Click += new System.EventHandler(this.btnDisConn_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSend.Location = new System.Drawing.Point(608, 163);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(63, 46);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(20, 359);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(217, 65);
            this.lblResult.TabIndex = 70;
            this.lblResult.Text = "DisConn";
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(278, 163);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(323, 45);
            this.txtSendData.TabIndex = 17;
            // 
            // txtReceived
            // 
            this.txtReceived.Location = new System.Drawing.Point(278, 248);
            this.txtReceived.Multiline = true;
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtReceived.Size = new System.Drawing.Size(556, 176);
            this.txtReceived.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(275, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 69;
            this.label6.Text = "ResultData:";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(112, 15);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(124, 23);
            this.txtPort.TabIndex = 21;
            // 
            // txtDataBits
            // 
            this.txtDataBits.Location = new System.Drawing.Point(112, 144);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(124, 23);
            this.txtDataBits.TabIndex = 22;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Location = new System.Drawing.Point(112, 77);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(124, 23);
            this.txtBaudRate.TabIndex = 23;
            // 
            // txtStopBit
            // 
            this.txtStopBit.Location = new System.Drawing.Point(112, 207);
            this.txtStopBit.Name = "txtStopBit";
            this.txtStopBit.Size = new System.Drawing.Size(124, 23);
            this.txtStopBit.TabIndex = 24;
            // 
            // txtParity
            // 
            this.txtParity.Location = new System.Drawing.Point(112, 263);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(124, 23);
            this.txtParity.TabIndex = 25;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(731, 58);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(104, 39);
            this.btnConnect.TabIndex = 26;
            this.btnConnect.Text = "Conn";
            this.btnConnect.Visible = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheck.Location = new System.Drawing.Point(278, 7);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(122, 40);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "ScanPort";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(278, 431);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(556, 39);
            this.txtMsg.TabIndex = 35;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.LightBlue;
            this.btnOpen.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(493, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 39);
            this.btnOpen.TabIndex = 36;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(20, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "HEX";
            // 
            // chkHex
            // 
            this.chkHex.Location = new System.Drawing.Point(59, 315);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(46, 25);
            this.chkHex.TabIndex = 38;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(278, 55);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 47);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "ClearData";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(731, 5);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(104, 39);
            this.btnReceive.TabIndex = 51;
            this.btnReceive.Text = "Receive";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(118, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 66;
            this.label9.Text = "IsAppend";
            // 
            // chkAppend
            // 
            this.chkAppend.Location = new System.Drawing.Point(202, 315);
            this.chkAppend.Name = "chkAppend";
            this.chkAppend.Size = new System.Drawing.Size(35, 25);
            this.chkAppend.TabIndex = 53;
            // 
            // chkAutoSend
            // 
            this.chkAutoSend.Location = new System.Drawing.Point(681, 183);
            this.chkAutoSend.Name = "chkAutoSend";
            this.chkAutoSend.Size = new System.Drawing.Size(125, 25);
            this.chkAutoSend.TabIndex = 64;
            this.chkAutoSend.Text = "AutoSend";
            this.chkAutoSend.CheckStateChanged += new System.EventHandler(this.chkAutoSend_CheckStateChanged);
            // 
            // txtIntervalTime
            // 
            this.txtIntervalTime.Location = new System.Drawing.Point(784, 159);
            this.txtIntervalTime.Name = "txtIntervalTime";
            this.txtIntervalTime.Size = new System.Drawing.Size(50, 25);
            this.txtIntervalTime.TabIndex = 65;
            this.txtIntervalTime.Text = "500";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(677, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Interval(ms)";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // getMac
            // 
            this.getMac.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.getMac.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.getMac.Location = new System.Drawing.Point(868, 51);
            this.getMac.Name = "getMac";
            this.getMac.Size = new System.Drawing.Size(151, 40);
            this.getMac.TabIndex = 76;
            this.getMac.Text = "getMac";
            this.getMac.UseVisualStyleBackColor = false;
            this.getMac.Click += new System.EventHandler(this.getMac_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(868, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 372);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // barcode_gen
            // 
            this.barcode_gen.Font = new System.Drawing.Font("华文中宋", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.barcode_gen.Location = new System.Drawing.Point(868, 5);
            this.barcode_gen.Name = "barcode_gen";
            this.barcode_gen.Size = new System.Drawing.Size(117, 39);
            this.barcode_gen.TabIndex = 78;
            this.barcode_gen.Text = "BarCode";
            this.barcode_gen.UseVisualStyleBackColor = true;
            this.barcode_gen.Click += new System.EventHandler(this.barcode_gen_Click);
            // 
            // qrcode_gen
            // 
            this.qrcode_gen.Font = new System.Drawing.Font("华文中宋", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.qrcode_gen.Location = new System.Drawing.Point(992, 4);
            this.qrcode_gen.Name = "qrcode_gen";
            this.qrcode_gen.Size = new System.Drawing.Size(86, 40);
            this.qrcode_gen.TabIndex = 79;
            this.qrcode_gen.Text = "QrCode";
            this.qrcode_gen.UseVisualStyleBackColor = true;
            this.qrcode_gen.Click += new System.EventHandler(this.qrcode_gen_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.printBtn.Font = new System.Drawing.Font("华文中宋", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.printBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.printBtn.Location = new System.Drawing.Point(1164, 50);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 40);
            this.printBtn.TabIndex = 80;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(161, 445);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 82;
            this.label8.Text = "Output";
            // 
            // reflashBtn
            // 
            this.reflashBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.reflashBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.reflashBtn.Location = new System.Drawing.Point(1025, 51);
            this.reflashBtn.Name = "reflashBtn";
            this.reflashBtn.Size = new System.Drawing.Size(121, 40);
            this.reflashBtn.TabIndex = 83;
            this.reflashBtn.Text = "Reset";
            this.reflashBtn.UseVisualStyleBackColor = false;
            this.reflashBtn.Click += new System.EventHandler(this.reflashBtn_Click);
            // 
            // ch4
            // 
            this.ch4.Location = new System.Drawing.Point(23, 537);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(105, 41);
            this.ch4.TabIndex = 84;
            this.ch4.Text = "甲烷";
            this.ch4.UseVisualStyleBackColor = true;
            this.ch4.Click += new System.EventHandler(this.cmd_Click);
            // 
            // h2s
            // 
            this.h2s.Location = new System.Drawing.Point(134, 537);
            this.h2s.Name = "h2s";
            this.h2s.Size = new System.Drawing.Size(96, 42);
            this.h2s.TabIndex = 85;
            this.h2s.Text = "硫化氢";
            this.h2s.UseVisualStyleBackColor = true;
            this.h2s.Click += new System.EventHandler(this.cmd_Click);
            // 
            // co2
            // 
            this.co2.Location = new System.Drawing.Point(242, 537);
            this.co2.Name = "co2";
            this.co2.Size = new System.Drawing.Size(104, 42);
            this.co2.TabIndex = 86;
            this.co2.Text = "二氧化碳";
            this.co2.UseVisualStyleBackColor = true;
            this.co2.Click += new System.EventHandler(this.cmd_Click);
            // 
            // o2
            // 
            this.o2.Location = new System.Drawing.Point(352, 537);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(103, 42);
            this.o2.TabIndex = 87;
            this.o2.Text = "氧气";
            this.o2.UseVisualStyleBackColor = true;
            this.o2.Click += new System.EventHandler(this.cmd_Click);
            // 
            // temp
            // 
            this.temp.Location = new System.Drawing.Point(461, 536);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(105, 42);
            this.temp.TabIndex = 88;
            this.temp.Text = "温度";
            this.temp.UseVisualStyleBackColor = true;
            this.temp.Click += new System.EventHandler(this.cmd_Click);
            // 
            // alrm_on
            // 
            this.alrm_on.BackColor = System.Drawing.Color.Orange;
            this.alrm_on.Location = new System.Drawing.Point(572, 536);
            this.alrm_on.Name = "alrm_on";
            this.alrm_on.Size = new System.Drawing.Size(71, 42);
            this.alrm_on.TabIndex = 89;
            this.alrm_on.Text = "报警开";
            this.alrm_on.UseVisualStyleBackColor = false;
            this.alrm_on.Click += new System.EventHandler(this.alrm_on_Click);
            // 
            // alrm_off
            // 
            this.alrm_off.BackColor = System.Drawing.Color.LawnGreen;
            this.alrm_off.Location = new System.Drawing.Point(649, 537);
            this.alrm_off.Name = "alrm_off";
            this.alrm_off.Size = new System.Drawing.Size(71, 42);
            this.alrm_off.TabIndex = 90;
            this.alrm_off.Text = "报警关";
            this.alrm_off.UseVisualStyleBackColor = false;
            this.alrm_off.Click += new System.EventHandler(this.alrm_off_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(731, 537);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(508, 114);
            this.textBox1.TabIndex = 92;
            // 
            // loopBtn
            // 
            this.loopBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loopBtn.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopBtn.Location = new System.Drawing.Point(572, 603);
            this.loopBtn.Name = "loopBtn";
            this.loopBtn.Size = new System.Drawing.Size(71, 39);
            this.loopBtn.TabIndex = 93;
            this.loopBtn.Text = "Loop";
            this.loopBtn.UseVisualStyleBackColor = false;
            this.loopBtn.Click += new System.EventHandler(this.loopBtn_Click);
            // 
            // loopTime
            // 
            this.loopTime.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopTime.Location = new System.Drawing.Point(649, 603);
            this.loopTime.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.loopTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.loopTime.Name = "loopTime";
            this.loopTime.Size = new System.Drawing.Size(71, 39);
            this.loopTime.TabIndex = 94;
            this.loopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loopTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ch4_show
            // 
            this.ch4_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ch4_show.Font = new System.Drawing.Font("Cambria", 15F);
            this.ch4_show.Location = new System.Drawing.Point(23, 585);
            this.ch4_show.Name = "ch4_show";
            this.ch4_show.Size = new System.Drawing.Size(105, 57);
            this.ch4_show.TabIndex = 100;
            this.ch4_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // h2s_show
            // 
            this.h2s_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.h2s_show.Font = new System.Drawing.Font("Cambria", 15F);
            this.h2s_show.Location = new System.Drawing.Point(134, 585);
            this.h2s_show.Name = "h2s_show";
            this.h2s_show.Size = new System.Drawing.Size(96, 57);
            this.h2s_show.TabIndex = 101;
            this.h2s_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // co2_show
            // 
            this.co2_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.co2_show.Font = new System.Drawing.Font("Cambria", 15F);
            this.co2_show.Location = new System.Drawing.Point(242, 585);
            this.co2_show.Name = "co2_show";
            this.co2_show.Size = new System.Drawing.Size(104, 57);
            this.co2_show.TabIndex = 102;
            this.co2_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // o2_show
            // 
            this.o2_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.o2_show.Font = new System.Drawing.Font("Cambria", 15F);
            this.o2_show.Location = new System.Drawing.Point(352, 585);
            this.o2_show.Name = "o2_show";
            this.o2_show.Size = new System.Drawing.Size(103, 57);
            this.o2_show.TabIndex = 103;
            this.o2_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temp_show
            // 
            this.temp_show.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.temp_show.Font = new System.Drawing.Font("Cambria", 15F);
            this.temp_show.Location = new System.Drawing.Point(464, 585);
            this.temp_show.Name = "temp_show";
            this.temp_show.Size = new System.Drawing.Size(102, 57);
            this.temp_show.TabIndex = 104;
            this.temp_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1249, 663);
            this.Controls.Add(this.temp_show);
            this.Controls.Add(this.o2_show);
            this.Controls.Add(this.co2_show);
            this.Controls.Add(this.h2s_show);
            this.Controls.Add(this.ch4_show);
            this.Controls.Add(this.loopTime);
            this.Controls.Add(this.loopBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.alrm_off);
            this.Controls.Add(this.alrm_on);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.o2);
            this.Controls.Add(this.co2);
            this.Controls.Add(this.h2s);
            this.Controls.Add(this.ch4);
            this.Controls.Add(this.reflashBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.qrcode_gen);
            this.Controls.Add(this.barcode_gen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.getMac);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIntervalTime);
            this.Controls.Add(this.chkAutoSend);
            this.Controls.Add(this.chkAppend);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkHex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtParity);
            this.Controls.Add(this.txtStopBit);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReceived);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnDisConn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "SerialCOM";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loopTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDisConn;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.TextBox txtReceived;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtPort;
        private System.Windows.Forms.ComboBox txtDataBits;
        private System.Windows.Forms.ComboBox txtBaudRate;
        private System.Windows.Forms.ComboBox txtStopBit;
        private System.Windows.Forms.ComboBox txtParity;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAppend;
        private System.Windows.Forms.CheckBox chkAutoSend;
        private System.Windows.Forms.TextBox txtIntervalTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button getMac;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button barcode_gen;
        private System.Windows.Forms.Button qrcode_gen;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button reflashBtn;
        private System.Windows.Forms.Button ch4;
        private System.Windows.Forms.Button h2s;
        private System.Windows.Forms.Button co2;
        private System.Windows.Forms.Button o2;
        private System.Windows.Forms.Button temp;
        private System.Windows.Forms.Button alrm_on;
        private System.Windows.Forms.Button alrm_off;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loopBtn;
        private System.Windows.Forms.NumericUpDown loopTime;
        private System.Windows.Forms.Label ch4_show;
        private System.Windows.Forms.Label h2s_show;
        private System.Windows.Forms.Label co2_show;
        private System.Windows.Forms.Label o2_show;
        private System.Windows.Forms.Label temp_show;
    }
}