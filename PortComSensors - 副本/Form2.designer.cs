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
            this.btnSend = new System.Windows.Forms.Button();
            this.txtSendData = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.ComboBox();
            this.txtDataBits = new System.Windows.Forms.ComboBox();
            this.txtBaudRate = new System.Windows.Forms.ComboBox();
            this.txtStopBit = new System.Windows.Forms.ComboBox();
            this.txtParity = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chkHex = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAppend = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.alrm_on = new System.Windows.Forms.Button();
            this.alrm_off = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loopBtn = new System.Windows.Forms.Button();
            this.loopTime = new System.Windows.Forms.NumericUpDown();
            this.ch4 = new System.Windows.Forms.Label();
            this.h2s = new System.Windows.Forms.Label();
            this.co = new System.Windows.Forms.Label();
            this.o2 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.label_ch4 = new System.Windows.Forms.Label();
            this.label_h2s = new System.Windows.Forms.Label();
            this.label_co = new System.Windows.Forms.Label();
            this.label_o2 = new System.Windows.Forms.Label();
            this.label_temp = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loopTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 26);
            this.label1.TabIndex = 75;
            this.label1.Text = "Port";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.LawnGreen;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 26);
            this.label2.TabIndex = 74;
            this.label2.Text = "BaudRate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.LawnGreen;
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 26);
            this.label3.TabIndex = 73;
            this.label3.Text = "Parity";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.LawnGreen;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 72;
            this.label4.Text = "StopBit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label5.ForeColor = System.Drawing.Color.Chartreuse;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 71;
            this.label5.Text = "DataBits";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSend.Location = new System.Drawing.Point(945, 471);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(63, 46);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(467, 472);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(472, 45);
            this.txtSendData.TabIndex = 17;
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("PanRoman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPort.Location = new System.Drawing.Point(115, 65);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(88, 26);
            this.txtPort.TabIndex = 21;
            // 
            // txtDataBits
            // 
            this.txtDataBits.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtDataBits.Location = new System.Drawing.Point(115, 129);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(88, 26);
            this.txtDataBits.TabIndex = 22;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtBaudRate.Location = new System.Drawing.Point(115, 97);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(88, 26);
            this.txtBaudRate.TabIndex = 23;
            // 
            // txtStopBit
            // 
            this.txtStopBit.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtStopBit.Location = new System.Drawing.Point(115, 161);
            this.txtStopBit.Name = "txtStopBit";
            this.txtStopBit.Size = new System.Drawing.Size(88, 26);
            this.txtStopBit.TabIndex = 24;
            // 
            // txtParity
            // 
            this.txtParity.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtParity.Location = new System.Drawing.Point(115, 193);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(88, 26);
            this.txtParity.TabIndex = 25;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheck.Location = new System.Drawing.Point(115, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(88, 40);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "Reflash";
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.LightBlue;
            this.btnOpen.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.Location = new System.Drawing.Point(1, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 39);
            this.btnOpen.TabIndex = 36;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(37, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 68;
            this.label7.Text = "HEX";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // chkHex
            // 
            this.chkHex.BackColor = System.Drawing.Color.Transparent;
            this.chkHex.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.chkHex.Location = new System.Drawing.Point(116, 227);
            this.chkHex.Name = "chkHex";
            this.chkHex.Size = new System.Drawing.Size(34, 25);
            this.chkHex.TabIndex = 38;
            this.chkHex.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(1014, 471);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 46);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "ClearData";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.label9.ForeColor = System.Drawing.Color.GreenYellow;
            this.label9.Location = new System.Drawing.Point(5, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 66;
            this.label9.Text = "IsAppend";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // chkAppend
            // 
            this.chkAppend.BackColor = System.Drawing.Color.Transparent;
            this.chkAppend.Location = new System.Drawing.Point(116, 251);
            this.chkAppend.Name = "chkAppend";
            this.chkAppend.Size = new System.Drawing.Size(35, 29);
            this.chkAppend.TabIndex = 53;
            this.chkAppend.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage_1);
            // 
            // alrm_on
            // 
            this.alrm_on.BackColor = System.Drawing.Color.Gold;
            this.alrm_on.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alrm_on.Location = new System.Drawing.Point(17, 322);
            this.alrm_on.Name = "alrm_on";
            this.alrm_on.Size = new System.Drawing.Size(111, 42);
            this.alrm_on.TabIndex = 89;
            this.alrm_on.Text = "报警开";
            this.alrm_on.UseVisualStyleBackColor = false;
            this.alrm_on.Click += new System.EventHandler(this.alrm_on_Click);
            // 
            // alrm_off
            // 
            this.alrm_off.BackColor = System.Drawing.Color.LawnGreen;
            this.alrm_off.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alrm_off.Location = new System.Drawing.Point(134, 322);
            this.alrm_off.Name = "alrm_off";
            this.alrm_off.Size = new System.Drawing.Size(110, 40);
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
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.Location = new System.Drawing.Point(589, 257);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(532, 209);
            this.textBox1.TabIndex = 92;
            // 
            // loopBtn
            // 
            this.loopBtn.BackColor = System.Drawing.Color.LightSkyBlue;
            this.loopBtn.Font = new System.Drawing.Font("BankGothic Md BT", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopBtn.Location = new System.Drawing.Point(17, 398);
            this.loopBtn.Name = "loopBtn";
            this.loopBtn.Size = new System.Drawing.Size(111, 39);
            this.loopBtn.TabIndex = 93;
            this.loopBtn.Text = "Loop";
            this.loopBtn.UseVisualStyleBackColor = false;
            this.loopBtn.Click += new System.EventHandler(this.loopBtn_Click);
            // 
            // loopTime
            // 
            this.loopTime.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.loopTime.Location = new System.Drawing.Point(134, 398);
            this.loopTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.loopTime.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.loopTime.Name = "loopTime";
            this.loopTime.Size = new System.Drawing.Size(110, 39);
            this.loopTime.TabIndex = 94;
            this.loopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loopTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // ch4
            // 
            this.ch4.BackColor = System.Drawing.Color.Transparent;
            this.ch4.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch4.ForeColor = System.Drawing.Color.White;
            this.ch4.Location = new System.Drawing.Point(242, 12);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(159, 148);
            this.ch4.TabIndex = 100;
            this.ch4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ch4.Click += new System.EventHandler(this.cmd_Click);
            // 
            // h2s
            // 
            this.h2s.BackColor = System.Drawing.Color.Transparent;
            this.h2s.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h2s.ForeColor = System.Drawing.Color.White;
            this.h2s.Location = new System.Drawing.Point(423, 12);
            this.h2s.Name = "h2s";
            this.h2s.Size = new System.Drawing.Size(163, 148);
            this.h2s.TabIndex = 101;
            this.h2s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.h2s.Click += new System.EventHandler(this.cmd_Click);
            // 
            // co
            // 
            this.co.BackColor = System.Drawing.Color.Transparent;
            this.co.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.co.ForeColor = System.Drawing.Color.White;
            this.co.Location = new System.Drawing.Point(603, 12);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(161, 149);
            this.co.TabIndex = 102;
            this.co.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.co.Click += new System.EventHandler(this.cmd_Click);
            // 
            // o2
            // 
            this.o2.BackColor = System.Drawing.Color.Transparent;
            this.o2.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o2.ForeColor = System.Drawing.Color.White;
            this.o2.Location = new System.Drawing.Point(780, 12);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(165, 149);
            this.o2.TabIndex = 103;
            this.o2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.o2.Click += new System.EventHandler(this.cmd_Click);
            // 
            // temp
            // 
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.Color.White;
            this.temp.Location = new System.Drawing.Point(962, 12);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(165, 149);
            this.temp.TabIndex = 104;
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temp.Click += new System.EventHandler(this.cmd_Click);
            // 
            // label_ch4
            // 
            this.label_ch4.BackColor = System.Drawing.Color.Transparent;
            this.label_ch4.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ch4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_ch4.Location = new System.Drawing.Point(243, 186);
            this.label_ch4.Name = "label_ch4";
            this.label_ch4.Size = new System.Drawing.Size(158, 65);
            this.label_ch4.TabIndex = 105;
            this.label_ch4.Text = "甲烷";
            this.label_ch4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_h2s
            // 
            this.label_h2s.BackColor = System.Drawing.Color.Transparent;
            this.label_h2s.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_h2s.ForeColor = System.Drawing.Color.Orange;
            this.label_h2s.Location = new System.Drawing.Point(424, 186);
            this.label_h2s.Name = "label_h2s";
            this.label_h2s.Size = new System.Drawing.Size(158, 68);
            this.label_h2s.TabIndex = 106;
            this.label_h2s.Text = "硫化氢";
            this.label_h2s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_co
            // 
            this.label_co.BackColor = System.Drawing.Color.Transparent;
            this.label_co.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_co.ForeColor = System.Drawing.Color.Orange;
            this.label_co.Location = new System.Drawing.Point(604, 184);
            this.label_co.Name = "label_co";
            this.label_co.Size = new System.Drawing.Size(158, 68);
            this.label_co.TabIndex = 107;
            this.label_co.Text = "一氧化碳";
            this.label_co.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_o2
            // 
            this.label_o2.BackColor = System.Drawing.Color.Transparent;
            this.label_o2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_o2.ForeColor = System.Drawing.Color.Orange;
            this.label_o2.Location = new System.Drawing.Point(781, 184);
            this.label_o2.Name = "label_o2";
            this.label_o2.Size = new System.Drawing.Size(158, 70);
            this.label_o2.TabIndex = 108;
            this.label_o2.Text = "氧气";
            this.label_o2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_temp
            // 
            this.label_temp.BackColor = System.Drawing.Color.Transparent;
            this.label_temp.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_temp.ForeColor = System.Drawing.Color.Orange;
            this.label_temp.Location = new System.Drawing.Point(963, 184);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(158, 67);
            this.label_temp.TabIndex = 109;
            this.label_temp.Text = "温度";
            this.label_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Transparent;
            this.txtMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMsg.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.ForeColor = System.Drawing.Color.Lime;
            this.txtMsg.Location = new System.Drawing.Point(134, 472);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(327, 45);
            this.txtMsg.TabIndex = 111;
            this.txtMsg.Text = "动作打印";
            this.txtMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 530);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label_temp);
            this.Controls.Add(this.label_o2);
            this.Controls.Add(this.label_co);
            this.Controls.Add(this.label_h2s);
            this.Controls.Add(this.label_ch4);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.o2);
            this.Controls.Add(this.co);
            this.Controls.Add(this.h2s);
            this.Controls.Add(this.ch4);
            this.Controls.Add(this.loopTime);
            this.Controls.Add(this.loopBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.alrm_off);
            this.Controls.Add(this.alrm_on);
            this.Controls.Add(this.chkAppend);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkHex);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtParity);
            this.Controls.Add(this.txtStopBit);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "SensorsViewer";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtSendData;
        private System.Windows.Forms.ComboBox txtPort;
        private System.Windows.Forms.ComboBox txtDataBits;
        private System.Windows.Forms.ComboBox txtBaudRate;
        private System.Windows.Forms.ComboBox txtStopBit;
        private System.Windows.Forms.ComboBox txtParity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkHex;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAppend;
        private System.Windows.Forms.Timer timer1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button alrm_on;
        private System.Windows.Forms.Button alrm_off;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loopBtn;
        private System.Windows.Forms.NumericUpDown loopTime;
        private System.Windows.Forms.Label ch4;
        private System.Windows.Forms.Label h2s;
        private System.Windows.Forms.Label co;
        private System.Windows.Forms.Label o2;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.Label label_ch4;
        private System.Windows.Forms.Label label_h2s;
        private System.Windows.Forms.Label label_co;
        private System.Windows.Forms.Label label_o2;
        private System.Windows.Forms.Label label_temp;
        private System.Windows.Forms.Label txtMsg;
    }
}