namespace SenserProj
{
    partial class SenserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenserForm));
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
            this.btnClear = new System.Windows.Forms.Button();
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
            this.co_calibrate = new System.Windows.Forms.Button();
            this.h2s_calibrate = new System.Windows.Forms.Button();
            this.ch4_calibrate = new System.Windows.Forms.Button();
            this.temp_calibrate = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.id_set_btn = new System.Windows.Forms.Button();
            this.o2_calibrate = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.NumericUpDown();
            this.disableAuto_btn = new System.Windows.Forms.Button();
            this.temp_dw = new System.Windows.Forms.NumericUpDown();
            this.temp_up = new System.Windows.Forms.NumericUpDown();
            this.o2_dw = new System.Windows.Forms.NumericUpDown();
            this.o2_up = new System.Windows.Forms.NumericUpDown();
            this.co_dw = new System.Windows.Forms.NumericUpDown();
            this.co_up = new System.Windows.Forms.NumericUpDown();
            this.h2s_dw = new System.Windows.Forms.NumericUpDown();
            this.h2s_up = new System.Windows.Forms.NumericUpDown();
            this.ch4_dw = new System.Windows.Forms.NumericUpDown();
            this.ch4_up = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.getThresholdTime = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.temp_down_danger_tb = new System.Windows.Forms.TextBox();
            this.o2_down_danger_tb = new System.Windows.Forms.TextBox();
            this.temp_down_warn_tb = new System.Windows.Forms.TextBox();
            this.o2_down_warn_tb = new System.Windows.Forms.TextBox();
            this.temp_up_warn_tb = new System.Windows.Forms.TextBox();
            this.o2_up_warn_tb = new System.Windows.Forms.TextBox();
            this.co_up_warn_tb = new System.Windows.Forms.TextBox();
            this.h2s_up_warn_tb = new System.Windows.Forms.TextBox();
            this.temp_up_danger_tb = new System.Windows.Forms.TextBox();
            this.o2_up_danger_tb = new System.Windows.Forms.TextBox();
            this.co_up_danger_tb = new System.Windows.Forms.TextBox();
            this.h2s_up_danger_tb = new System.Windows.Forms.TextBox();
            this.ch4_up_warn_tb = new System.Windows.Forms.TextBox();
            this.ch4_up_danger_tb = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.temp_range_textBox = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.o2_range_textBox = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.co_range_textBox = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.h2s_range_textBox = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ch4_range_textBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label_humi = new System.Windows.Forms.Label();
            this.humi = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loopTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o2_dw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.o2_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.co_dw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.co_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2s_dw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2s_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch4_dw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch4_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getThresholdTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("华文楷体", 9.163635F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(21, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 75;
            this.label1.Text = "端口号";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("华文楷体", 9.163635F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(11, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("华文楷体", 9.163635F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(11, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "校验位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("华文楷体", 9.163635F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 72;
            this.label4.Text = "停止位";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("华文楷体", 9.163635F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(11, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 71;
            this.label5.Text = "数据位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSend.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSend.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSend.Location = new System.Drawing.Point(192, 474);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(58, 37);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtSendData
            // 
            this.txtSendData.Location = new System.Drawing.Point(8, 474);
            this.txtSendData.Multiline = true;
            this.txtSendData.Name = "txtSendData";
            this.txtSendData.Size = new System.Drawing.Size(178, 37);
            this.txtSendData.TabIndex = 17;
            // 
            // txtPort
            // 
            this.txtPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPort.Font = new System.Drawing.Font("PanRoman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.txtPort.Location = new System.Drawing.Point(105, 60);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(81, 24);
            this.txtPort.TabIndex = 21;
            // 
            // txtDataBits
            // 
            this.txtDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtDataBits.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtDataBits.Location = new System.Drawing.Point(105, 118);
            this.txtDataBits.Name = "txtDataBits";
            this.txtDataBits.Size = new System.Drawing.Size(81, 24);
            this.txtDataBits.TabIndex = 22;
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtBaudRate.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtBaudRate.Location = new System.Drawing.Point(105, 89);
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(81, 24);
            this.txtBaudRate.TabIndex = 23;
            // 
            // txtStopBit
            // 
            this.txtStopBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStopBit.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtStopBit.Location = new System.Drawing.Point(105, 148);
            this.txtStopBit.Name = "txtStopBit";
            this.txtStopBit.Size = new System.Drawing.Size(81, 24);
            this.txtStopBit.TabIndex = 24;
            // 
            // txtParity
            // 
            this.txtParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtParity.Font = new System.Drawing.Font("PanRoman", 10.8F);
            this.txtParity.Location = new System.Drawing.Point(105, 177);
            this.txtParity.Name = "txtParity";
            this.txtParity.Size = new System.Drawing.Size(81, 24);
            this.txtParity.TabIndex = 25;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCheck.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.btnCheck.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnCheck.Location = new System.Drawing.Point(105, 11);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(81, 37);
            this.btnCheck.TabIndex = 34;
            this.btnCheck.Text = "刷新端口";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOpen.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOpen.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnOpen.Location = new System.Drawing.Point(8, 11);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(82, 36);
            this.btnOpen.TabIndex = 36;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(256, 474);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 37);
            this.btnClear.TabIndex = 41;
            this.btnClear.Text = "清除";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
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
            this.alrm_on.BackColor = System.Drawing.Color.LightGray;
            this.alrm_on.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alrm_on.Location = new System.Drawing.Point(216, 11);
            this.alrm_on.Name = "alrm_on";
            this.alrm_on.Size = new System.Drawing.Size(102, 39);
            this.alrm_on.TabIndex = 89;
            this.alrm_on.Text = "报警开";
            this.alrm_on.UseVisualStyleBackColor = false;
            this.alrm_on.Click += new System.EventHandler(this.alrm_on_Click);
            // 
            // alrm_off
            // 
            this.alrm_off.BackColor = System.Drawing.Color.LightGray;
            this.alrm_off.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alrm_off.Location = new System.Drawing.Point(215, 60);
            this.alrm_off.Name = "alrm_off";
            this.alrm_off.Size = new System.Drawing.Size(103, 37);
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
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(8, 207);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 261);
            this.textBox1.TabIndex = 92;
            // 
            // loopBtn
            // 
            this.loopBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.loopBtn.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.loopBtn.Location = new System.Drawing.Point(214, 111);
            this.loopBtn.Name = "loopBtn";
            this.loopBtn.Size = new System.Drawing.Size(104, 36);
            this.loopBtn.TabIndex = 93;
            this.loopBtn.Text = "轮询";
            this.loopBtn.UseVisualStyleBackColor = false;
            this.loopBtn.Click += new System.EventHandler(this.loopBtn_Click);
            // 
            // loopTime
            // 
            this.loopTime.Font = new System.Drawing.Font("Cambria", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loopTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.loopTime.Location = new System.Drawing.Point(256, 157);
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
            this.loopTime.Size = new System.Drawing.Size(60, 24);
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
            this.ch4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ch4.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.ch4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ch4.Location = new System.Drawing.Point(340, 11);
            this.ch4.Name = "ch4";
            this.ch4.Size = new System.Drawing.Size(146, 136);
            this.ch4.TabIndex = 100;
            this.ch4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ch4.Click += new System.EventHandler(this.cmd_Click);
            // 
            // h2s
            // 
            this.h2s.BackColor = System.Drawing.Color.Transparent;
            this.h2s.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.h2s.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.h2s.ForeColor = System.Drawing.Color.DodgerBlue;
            this.h2s.Location = new System.Drawing.Point(506, 11);
            this.h2s.Name = "h2s";
            this.h2s.Size = new System.Drawing.Size(150, 136);
            this.h2s.TabIndex = 101;
            this.h2s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.h2s.Click += new System.EventHandler(this.cmd_Click);
            // 
            // co
            // 
            this.co.BackColor = System.Drawing.Color.Transparent;
            this.co.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.co.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.co.ForeColor = System.Drawing.Color.DodgerBlue;
            this.co.Location = new System.Drawing.Point(340, 189);
            this.co.Name = "co";
            this.co.Size = new System.Drawing.Size(146, 137);
            this.co.TabIndex = 102;
            this.co.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.co.Click += new System.EventHandler(this.cmd_Click);
            // 
            // o2
            // 
            this.o2.BackColor = System.Drawing.Color.Transparent;
            this.o2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.o2.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.o2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.o2.Location = new System.Drawing.Point(510, 189);
            this.o2.Name = "o2";
            this.o2.Size = new System.Drawing.Size(146, 137);
            this.o2.TabIndex = 103;
            this.o2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.o2.Click += new System.EventHandler(this.cmd_Click);
            // 
            // temp
            // 
            this.temp.BackColor = System.Drawing.Color.Transparent;
            this.temp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.temp.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.temp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.temp.Location = new System.Drawing.Point(340, 374);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(151, 137);
            this.temp.TabIndex = 104;
            this.temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.temp.Click += new System.EventHandler(this.cmd_Click);
            // 
            // label_ch4
            // 
            this.label_ch4.BackColor = System.Drawing.Color.Transparent;
            this.label_ch4.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_ch4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_ch4.Location = new System.Drawing.Point(341, 147);
            this.label_ch4.Name = "label_ch4";
            this.label_ch4.Size = new System.Drawing.Size(145, 39);
            this.label_ch4.TabIndex = 105;
            this.label_ch4.Text = "甲烷";
            this.label_ch4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_h2s
            // 
            this.label_h2s.BackColor = System.Drawing.Color.Transparent;
            this.label_h2s.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_h2s.ForeColor = System.Drawing.Color.Black;
            this.label_h2s.Location = new System.Drawing.Point(506, 149);
            this.label_h2s.Name = "label_h2s";
            this.label_h2s.Size = new System.Drawing.Size(149, 37);
            this.label_h2s.TabIndex = 106;
            this.label_h2s.Text = "硫化氢";
            this.label_h2s.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_co
            // 
            this.label_co.BackColor = System.Drawing.Color.Transparent;
            this.label_co.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_co.ForeColor = System.Drawing.Color.Black;
            this.label_co.Location = new System.Drawing.Point(324, 328);
            this.label_co.Name = "label_co";
            this.label_co.Size = new System.Drawing.Size(178, 36);
            this.label_co.TabIndex = 107;
            this.label_co.Text = "一氧化碳";
            this.label_co.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_o2
            // 
            this.label_o2.BackColor = System.Drawing.Color.Transparent;
            this.label_o2.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_o2.ForeColor = System.Drawing.Color.Black;
            this.label_o2.Location = new System.Drawing.Point(507, 328);
            this.label_o2.Name = "label_o2";
            this.label_o2.Size = new System.Drawing.Size(149, 37);
            this.label_o2.TabIndex = 108;
            this.label_o2.Text = "氧气";
            this.label_o2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_temp
            // 
            this.label_temp.BackColor = System.Drawing.Color.Transparent;
            this.label_temp.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_temp.ForeColor = System.Drawing.Color.Black;
            this.label_temp.Location = new System.Drawing.Point(340, 511);
            this.label_temp.Name = "label_temp";
            this.label_temp.Size = new System.Drawing.Size(151, 39);
            this.label_temp.TabIndex = 109;
            this.label_temp.Text = "温度";
            this.label_temp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMsg
            // 
            this.txtMsg.BackColor = System.Drawing.Color.Transparent;
            this.txtMsg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtMsg.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMsg.ForeColor = System.Drawing.Color.ForestGreen;
            this.txtMsg.Location = new System.Drawing.Point(45, 545);
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(611, 33);
            this.txtMsg.TabIndex = 111;
            this.txtMsg.Text = "操作日志打印";
            this.txtMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // co_calibrate
            // 
            this.co_calibrate.BackColor = System.Drawing.Color.Gainsboro;
            this.co_calibrate.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.co_calibrate.Location = new System.Drawing.Point(297, 230);
            this.co_calibrate.Name = "co_calibrate";
            this.co_calibrate.Size = new System.Drawing.Size(76, 29);
            this.co_calibrate.TabIndex = 125;
            this.co_calibrate.Text = "CO校准";
            this.co_calibrate.UseVisualStyleBackColor = false;
            this.co_calibrate.Click += new System.EventHandler(this.co_calibrate_Click);
            // 
            // h2s_calibrate
            // 
            this.h2s_calibrate.BackColor = System.Drawing.Color.Gainsboro;
            this.h2s_calibrate.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.h2s_calibrate.Location = new System.Drawing.Point(297, 190);
            this.h2s_calibrate.Name = "h2s_calibrate";
            this.h2s_calibrate.Size = new System.Drawing.Size(76, 29);
            this.h2s_calibrate.TabIndex = 124;
            this.h2s_calibrate.Text = "H2S校准";
            this.h2s_calibrate.UseVisualStyleBackColor = false;
            this.h2s_calibrate.Click += new System.EventHandler(this.h2s_calibrate_Click);
            // 
            // ch4_calibrate
            // 
            this.ch4_calibrate.BackColor = System.Drawing.Color.Gainsboro;
            this.ch4_calibrate.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.ch4_calibrate.Location = new System.Drawing.Point(297, 150);
            this.ch4_calibrate.Name = "ch4_calibrate";
            this.ch4_calibrate.Size = new System.Drawing.Size(76, 29);
            this.ch4_calibrate.TabIndex = 123;
            this.ch4_calibrate.Text = "Ch4校准";
            this.ch4_calibrate.UseVisualStyleBackColor = false;
            this.ch4_calibrate.Click += new System.EventHandler(this.ch4_calibrate_Click);
            // 
            // temp_calibrate
            // 
            this.temp_calibrate.BackColor = System.Drawing.Color.Gainsboro;
            this.temp_calibrate.Enabled = false;
            this.temp_calibrate.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.temp_calibrate.Location = new System.Drawing.Point(297, 310);
            this.temp_calibrate.Name = "temp_calibrate";
            this.temp_calibrate.Size = new System.Drawing.Size(76, 29);
            this.temp_calibrate.TabIndex = 122;
            this.temp_calibrate.Text = "℃校准";
            this.temp_calibrate.UseVisualStyleBackColor = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("宋体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label28.Location = new System.Drawing.Point(352, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(37, 14);
            this.label28.TabIndex = 116;
            this.label28.Text = "间隔";
            // 
            // id_set_btn
            // 
            this.id_set_btn.BackColor = System.Drawing.Color.Gainsboro;
            this.id_set_btn.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.id_set_btn.Location = new System.Drawing.Point(344, 19);
            this.id_set_btn.Name = "id_set_btn";
            this.id_set_btn.Size = new System.Drawing.Size(112, 32);
            this.id_set_btn.TabIndex = 121;
            this.id_set_btn.Text = "设置传感器id";
            this.id_set_btn.UseVisualStyleBackColor = false;
            this.id_set_btn.Click += new System.EventHandler(this.id_set_btn_Click);
            // 
            // o2_calibrate
            // 
            this.o2_calibrate.BackColor = System.Drawing.Color.Gainsboro;
            this.o2_calibrate.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.o2_calibrate.Location = new System.Drawing.Point(297, 270);
            this.o2_calibrate.Name = "o2_calibrate";
            this.o2_calibrate.Size = new System.Drawing.Size(76, 29);
            this.o2_calibrate.TabIndex = 120;
            this.o2_calibrate.Text = "O2校准";
            this.o2_calibrate.UseVisualStyleBackColor = false;
            this.o2_calibrate.Click += new System.EventHandler(this.o2_calibrate_Click);
            // 
            // id
            // 
            this.id.Font = new System.Drawing.Font("Cambria", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(256, 19);
            this.id.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(82, 32);
            this.id.TabIndex = 119;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // disableAuto_btn
            // 
            this.disableAuto_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.disableAuto_btn.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.disableAuto_btn.Location = new System.Drawing.Point(39, 19);
            this.disableAuto_btn.Name = "disableAuto_btn";
            this.disableAuto_btn.Size = new System.Drawing.Size(202, 32);
            this.disableAuto_btn.TabIndex = 116;
            this.disableAuto_btn.Text = "禁用传感器自动上报";
            this.disableAuto_btn.UseVisualStyleBackColor = false;
            this.disableAuto_btn.Click += new System.EventHandler(this.disableAuto_btn_Click);
            // 
            // temp_dw
            // 
            this.temp_dw.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.temp_dw.Location = new System.Drawing.Point(197, 310);
            this.temp_dw.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.temp_dw.Name = "temp_dw";
            this.temp_dw.Size = new System.Drawing.Size(76, 29);
            this.temp_dw.TabIndex = 114;
            this.temp_dw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp_dw.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.temp_dw.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // temp_up
            // 
            this.temp_up.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.temp_up.Location = new System.Drawing.Point(98, 310);
            this.temp_up.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.temp_up.Name = "temp_up";
            this.temp_up.Size = new System.Drawing.Size(76, 29);
            this.temp_up.TabIndex = 113;
            this.temp_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp_up.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.temp_up.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // o2_dw
            // 
            this.o2_dw.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.o2_dw.Location = new System.Drawing.Point(197, 270);
            this.o2_dw.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.o2_dw.Name = "o2_dw";
            this.o2_dw.Size = new System.Drawing.Size(76, 29);
            this.o2_dw.TabIndex = 112;
            this.o2_dw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.o2_dw.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.o2_dw.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // o2_up
            // 
            this.o2_up.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.o2_up.Location = new System.Drawing.Point(98, 270);
            this.o2_up.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.o2_up.Name = "o2_up";
            this.o2_up.Size = new System.Drawing.Size(76, 29);
            this.o2_up.TabIndex = 111;
            this.o2_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.o2_up.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.o2_up.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // co_dw
            // 
            this.co_dw.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.co_dw.Location = new System.Drawing.Point(197, 230);
            this.co_dw.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.co_dw.Name = "co_dw";
            this.co_dw.Size = new System.Drawing.Size(76, 29);
            this.co_dw.TabIndex = 110;
            this.co_dw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.co_dw.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.co_dw.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // co_up
            // 
            this.co_up.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.co_up.Location = new System.Drawing.Point(97, 230);
            this.co_up.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.co_up.Name = "co_up";
            this.co_up.Size = new System.Drawing.Size(76, 29);
            this.co_up.TabIndex = 109;
            this.co_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.co_up.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.co_up.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // h2s_dw
            // 
            this.h2s_dw.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.h2s_dw.Location = new System.Drawing.Point(197, 190);
            this.h2s_dw.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.h2s_dw.Name = "h2s_dw";
            this.h2s_dw.Size = new System.Drawing.Size(76, 29);
            this.h2s_dw.TabIndex = 108;
            this.h2s_dw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.h2s_dw.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.h2s_dw.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // h2s_up
            // 
            this.h2s_up.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.h2s_up.Location = new System.Drawing.Point(97, 190);
            this.h2s_up.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.h2s_up.Name = "h2s_up";
            this.h2s_up.Size = new System.Drawing.Size(76, 29);
            this.h2s_up.TabIndex = 107;
            this.h2s_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.h2s_up.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.h2s_up.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // ch4_dw
            // 
            this.ch4_dw.Font = new System.Drawing.Font("Cambria", 11.78182F);
            this.ch4_dw.Location = new System.Drawing.Point(197, 150);
            this.ch4_dw.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ch4_dw.Name = "ch4_dw";
            this.ch4_dw.Size = new System.Drawing.Size(76, 29);
            this.ch4_dw.TabIndex = 106;
            this.ch4_dw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch4_dw.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ch4_dw.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // ch4_up
            // 
            this.ch4_up.Font = new System.Drawing.Font("Cambria", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch4_up.Location = new System.Drawing.Point(97, 150);
            this.ch4_up.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.ch4_up.Name = "ch4_up";
            this.ch4_up.Size = new System.Drawing.Size(76, 29);
            this.ch4_up.TabIndex = 105;
            this.ch4_up.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch4_up.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.ch4_up.ValueChanged += new System.EventHandler(this.setting_ValueChanged);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("楷体", 11.78182F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(44, 83);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(135, 19);
            this.label26.TabIndex = 104;
            this.label26.Text = "告警阈值设置";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(281, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 28);
            this.button1.TabIndex = 103;
            this.button1.Text = "刷新";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.label19.Location = new System.Drawing.Point(36, 319);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 17);
            this.label19.TabIndex = 100;
            this.label19.Text = "温度";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.label20.Location = new System.Drawing.Point(36, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(46, 17);
            this.label20.TabIndex = 99;
            this.label20.Text = "氧气";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.label21.Location = new System.Drawing.Point(6, 237);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(84, 17);
            this.label21.TabIndex = 98;
            this.label21.Text = "一氧化碳";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(23, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 17);
            this.label22.TabIndex = 97;
            this.label22.Text = "硫化氢";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.Location = new System.Drawing.Point(28, 159);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(46, 17);
            this.label23.TabIndex = 96;
            this.label23.Text = "甲烷";
            // 
            // getThresholdTime
            // 
            this.getThresholdTime.Font = new System.Drawing.Font("Cambria", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getThresholdTime.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.getThresholdTime.Location = new System.Drawing.Point(395, 83);
            this.getThresholdTime.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.getThresholdTime.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.getThresholdTime.Name = "getThresholdTime";
            this.getThresholdTime.Size = new System.Drawing.Size(61, 26);
            this.getThresholdTime.TabIndex = 95;
            this.getThresholdTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.getThresholdTime.Value = new decimal(new int[] {
            900,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("宋体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label27.Location = new System.Drawing.Point(213, 162);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(37, 14);
            this.label27.TabIndex = 115;
            this.label27.Text = "间隔";
            // 
            // temp_down_danger_tb
            // 
            this.temp_down_danger_tb.Location = new System.Drawing.Point(982, 221);
            this.temp_down_danger_tb.Name = "temp_down_danger_tb";
            this.temp_down_danger_tb.Size = new System.Drawing.Size(36, 23);
            this.temp_down_danger_tb.TabIndex = 54;
            this.temp_down_danger_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp_down_danger_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // o2_down_danger_tb
            // 
            this.o2_down_danger_tb.Location = new System.Drawing.Point(982, 183);
            this.o2_down_danger_tb.Name = "o2_down_danger_tb";
            this.o2_down_danger_tb.Size = new System.Drawing.Size(36, 23);
            this.o2_down_danger_tb.TabIndex = 53;
            this.o2_down_danger_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.o2_down_danger_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // temp_down_warn_tb
            // 
            this.temp_down_warn_tb.Location = new System.Drawing.Point(940, 221);
            this.temp_down_warn_tb.Name = "temp_down_warn_tb";
            this.temp_down_warn_tb.Size = new System.Drawing.Size(36, 23);
            this.temp_down_warn_tb.TabIndex = 50;
            this.temp_down_warn_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp_down_warn_tb.Visible = false;
            this.temp_down_warn_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // o2_down_warn_tb
            // 
            this.o2_down_warn_tb.Location = new System.Drawing.Point(940, 183);
            this.o2_down_warn_tb.Name = "o2_down_warn_tb";
            this.o2_down_warn_tb.Size = new System.Drawing.Size(36, 23);
            this.o2_down_warn_tb.TabIndex = 49;
            this.o2_down_warn_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.o2_down_warn_tb.Visible = false;
            this.o2_down_warn_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // temp_up_warn_tb
            // 
            this.temp_up_warn_tb.Location = new System.Drawing.Point(898, 221);
            this.temp_up_warn_tb.Name = "temp_up_warn_tb";
            this.temp_up_warn_tb.Size = new System.Drawing.Size(36, 23);
            this.temp_up_warn_tb.TabIndex = 46;
            this.temp_up_warn_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp_up_warn_tb.Visible = false;
            this.temp_up_warn_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // o2_up_warn_tb
            // 
            this.o2_up_warn_tb.Location = new System.Drawing.Point(898, 183);
            this.o2_up_warn_tb.Name = "o2_up_warn_tb";
            this.o2_up_warn_tb.Size = new System.Drawing.Size(36, 23);
            this.o2_up_warn_tb.TabIndex = 45;
            this.o2_up_warn_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.o2_up_warn_tb.Visible = false;
            this.o2_up_warn_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // co_up_warn_tb
            // 
            this.co_up_warn_tb.Location = new System.Drawing.Point(898, 145);
            this.co_up_warn_tb.Name = "co_up_warn_tb";
            this.co_up_warn_tb.Size = new System.Drawing.Size(36, 23);
            this.co_up_warn_tb.TabIndex = 44;
            this.co_up_warn_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.co_up_warn_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // h2s_up_warn_tb
            // 
            this.h2s_up_warn_tb.Location = new System.Drawing.Point(898, 108);
            this.h2s_up_warn_tb.Name = "h2s_up_warn_tb";
            this.h2s_up_warn_tb.Size = new System.Drawing.Size(36, 23);
            this.h2s_up_warn_tb.TabIndex = 43;
            this.h2s_up_warn_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.h2s_up_warn_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // temp_up_danger_tb
            // 
            this.temp_up_danger_tb.Location = new System.Drawing.Point(857, 221);
            this.temp_up_danger_tb.Name = "temp_up_danger_tb";
            this.temp_up_danger_tb.Size = new System.Drawing.Size(36, 23);
            this.temp_up_danger_tb.TabIndex = 42;
            this.temp_up_danger_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.temp_up_danger_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // o2_up_danger_tb
            // 
            this.o2_up_danger_tb.Location = new System.Drawing.Point(857, 183);
            this.o2_up_danger_tb.Name = "o2_up_danger_tb";
            this.o2_up_danger_tb.Size = new System.Drawing.Size(36, 23);
            this.o2_up_danger_tb.TabIndex = 41;
            this.o2_up_danger_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.o2_up_danger_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // co_up_danger_tb
            // 
            this.co_up_danger_tb.Location = new System.Drawing.Point(857, 145);
            this.co_up_danger_tb.Name = "co_up_danger_tb";
            this.co_up_danger_tb.Size = new System.Drawing.Size(36, 23);
            this.co_up_danger_tb.TabIndex = 40;
            this.co_up_danger_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.co_up_danger_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // h2s_up_danger_tb
            // 
            this.h2s_up_danger_tb.Location = new System.Drawing.Point(857, 108);
            this.h2s_up_danger_tb.Name = "h2s_up_danger_tb";
            this.h2s_up_danger_tb.Size = new System.Drawing.Size(36, 23);
            this.h2s_up_danger_tb.TabIndex = 39;
            this.h2s_up_danger_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.h2s_up_danger_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // ch4_up_warn_tb
            // 
            this.ch4_up_warn_tb.Location = new System.Drawing.Point(898, 70);
            this.ch4_up_warn_tb.Name = "ch4_up_warn_tb";
            this.ch4_up_warn_tb.Size = new System.Drawing.Size(36, 23);
            this.ch4_up_warn_tb.TabIndex = 37;
            this.ch4_up_warn_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch4_up_warn_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // ch4_up_danger_tb
            // 
            this.ch4_up_danger_tb.Location = new System.Drawing.Point(857, 70);
            this.ch4_up_danger_tb.Name = "ch4_up_danger_tb";
            this.ch4_up_danger_tb.Size = new System.Drawing.Size(36, 23);
            this.ch4_up_danger_tb.TabIndex = 36;
            this.ch4_up_danger_tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch4_up_danger_tb.TextChanged += new System.EventHandler(this.HandelModify);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(997, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 17);
            this.label18.TabIndex = 35;
            this.label18.Text = "▼";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Orange;
            this.label17.Location = new System.Drawing.Point(908, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 17);
            this.label17.TabIndex = 34;
            this.label17.Text = "▲";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Orange;
            this.label16.Location = new System.Drawing.Point(952, 45);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 17);
            this.label16.TabIndex = 33;
            this.label16.Text = "▼";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(864, 45);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "▲";
            // 
            // temp_range_textBox
            // 
            this.temp_range_textBox.Location = new System.Drawing.Point(776, 221);
            this.temp_range_textBox.Name = "temp_range_textBox";
            this.temp_range_textBox.Size = new System.Drawing.Size(39, 23);
            this.temp_range_textBox.TabIndex = 15;
            this.temp_range_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(730, 224);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 14);
            this.label14.TabIndex = 14;
            this.label14.Text = "温度";
            // 
            // o2_range_textBox
            // 
            this.o2_range_textBox.Location = new System.Drawing.Point(776, 183);
            this.o2_range_textBox.Name = "o2_range_textBox";
            this.o2_range_textBox.Size = new System.Drawing.Size(39, 23);
            this.o2_range_textBox.TabIndex = 12;
            this.o2_range_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(730, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 14);
            this.label13.TabIndex = 11;
            this.label13.Text = "氧气";
            // 
            // co_range_textBox
            // 
            this.co_range_textBox.Location = new System.Drawing.Point(776, 145);
            this.co_range_textBox.Name = "co_range_textBox";
            this.co_range_textBox.Size = new System.Drawing.Size(39, 23);
            this.co_range_textBox.TabIndex = 9;
            this.co_range_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(702, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 14);
            this.label12.TabIndex = 8;
            this.label12.Text = "一氧化碳";
            // 
            // h2s_range_textBox
            // 
            this.h2s_range_textBox.Location = new System.Drawing.Point(776, 108);
            this.h2s_range_textBox.Name = "h2s_range_textBox";
            this.h2s_range_textBox.Size = new System.Drawing.Size(39, 23);
            this.h2s_range_textBox.TabIndex = 6;
            this.h2s_range_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(716, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 14);
            this.label11.TabIndex = 5;
            this.label11.Text = "硫化氢";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(908, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "告警阈值";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(774, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "量程";
            // 
            // ch4_range_textBox
            // 
            this.ch4_range_textBox.Location = new System.Drawing.Point(776, 70);
            this.ch4_range_textBox.Name = "ch4_range_textBox";
            this.ch4_range_textBox.Size = new System.Drawing.Size(39, 23);
            this.ch4_range_textBox.TabIndex = 1;
            this.ch4_range_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(730, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "甲烷";
            // 
            // label_humi
            // 
            this.label_humi.BackColor = System.Drawing.Color.Transparent;
            this.label_humi.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_humi.ForeColor = System.Drawing.Color.Black;
            this.label_humi.Location = new System.Drawing.Point(504, 511);
            this.label_humi.Name = "label_humi";
            this.label_humi.Size = new System.Drawing.Size(151, 39);
            this.label_humi.TabIndex = 114;
            this.label_humi.Text = "湿度";
            this.label_humi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // humi
            // 
            this.humi.BackColor = System.Drawing.Color.Transparent;
            this.humi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.humi.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold);
            this.humi.ForeColor = System.Drawing.Color.DodgerBlue;
            this.humi.Location = new System.Drawing.Point(504, 374);
            this.humi.Name = "humi";
            this.humi.Size = new System.Drawing.Size(151, 137);
            this.humi.TabIndex = 113;
            this.humi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.co_calibrate);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.h2s_calibrate);
            this.groupBox1.Controls.Add(this.getThresholdTime);
            this.groupBox1.Controls.Add(this.ch4_calibrate);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.temp_calibrate);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.id_set_btn);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.o2_calibrate);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.disableAuto_btn);
            this.groupBox1.Controls.Add(this.temp_dw);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.temp_up);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.o2_dw);
            this.groupBox1.Controls.Add(this.ch4_up);
            this.groupBox1.Controls.Add(this.o2_up);
            this.groupBox1.Controls.Add(this.ch4_dw);
            this.groupBox1.Controls.Add(this.co_dw);
            this.groupBox1.Controls.Add(this.h2s_up);
            this.groupBox1.Controls.Add(this.co_up);
            this.groupBox1.Controls.Add(this.h2s_dw);
            this.groupBox1.Location = new System.Drawing.Point(678, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 577);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(220, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.TabIndex = 129;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(118, 113);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 128;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 77);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 127;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 126;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 545);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 33);
            this.pictureBox1.TabIndex = 126;
            this.pictureBox1.TabStop = false;
            // 
            // SenserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(110F, 110F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 586);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_humi);
            this.Controls.Add(this.humi);
            this.Controls.Add(this.label27);
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
            this.Controls.Add(this.temp_down_danger_tb);
            this.Controls.Add(this.o2_down_danger_tb);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.temp_down_warn_tb);
            this.Controls.Add(this.o2_down_warn_tb);
            this.Controls.Add(this.temp_up_warn_tb);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.o2_up_warn_tb);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.co_up_warn_tb);
            this.Controls.Add(this.txtParity);
            this.Controls.Add(this.h2s_up_warn_tb);
            this.Controls.Add(this.txtStopBit);
            this.Controls.Add(this.temp_up_danger_tb);
            this.Controls.Add(this.txtBaudRate);
            this.Controls.Add(this.o2_up_danger_tb);
            this.Controls.Add(this.txtDataBits);
            this.Controls.Add(this.co_up_danger_tb);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.h2s_up_danger_tb);
            this.Controls.Add(this.txtSendData);
            this.Controls.Add(this.ch4_up_warn_tb);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.ch4_up_danger_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp_range_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.o2_range_textBox);
            this.Controls.Add(this.ch4_range_textBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.co_range_textBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.h2s_range_textBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SenserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "传感器测试";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loopTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_dw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temp_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o2_dw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.o2_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.co_dw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.co_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2s_dw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2s_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch4_dw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch4_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getThresholdTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClear;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ch4_up_danger_tb;
        private System.Windows.Forms.TextBox temp_down_danger_tb;
        private System.Windows.Forms.TextBox o2_down_danger_tb;
        private System.Windows.Forms.TextBox co_up_warn_tb;
        private System.Windows.Forms.TextBox h2s_up_warn_tb;
        private System.Windows.Forms.TextBox temp_up_danger_tb;
        private System.Windows.Forms.TextBox o2_up_danger_tb;
        private System.Windows.Forms.TextBox co_up_danger_tb;
        private System.Windows.Forms.TextBox h2s_up_danger_tb;
        private System.Windows.Forms.TextBox ch4_up_warn_tb;
        private System.Windows.Forms.TextBox temp_down_warn_tb;
        private System.Windows.Forms.TextBox o2_down_warn_tb;
        private System.Windows.Forms.TextBox temp_up_warn_tb;
        private System.Windows.Forms.TextBox o2_up_warn_tb;
        private System.Windows.Forms.Label label_humi;
        private System.Windows.Forms.Label humi;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown getThresholdTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox temp_range_textBox;
        private System.Windows.Forms.MaskedTextBox o2_range_textBox;
        private System.Windows.Forms.MaskedTextBox co_range_textBox;
        private System.Windows.Forms.MaskedTextBox h2s_range_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox ch4_range_textBox;
        private System.Windows.Forms.NumericUpDown temp_dw;
        private System.Windows.Forms.NumericUpDown temp_up;
        private System.Windows.Forms.NumericUpDown o2_dw;
        private System.Windows.Forms.NumericUpDown o2_up;
        private System.Windows.Forms.NumericUpDown co_dw;
        private System.Windows.Forms.NumericUpDown co_up;
        private System.Windows.Forms.NumericUpDown h2s_dw;
        private System.Windows.Forms.NumericUpDown h2s_up;
        private System.Windows.Forms.NumericUpDown ch4_dw;
        private System.Windows.Forms.NumericUpDown ch4_up;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Button disableAuto_btn;
        private System.Windows.Forms.NumericUpDown id;
        private System.Windows.Forms.Button o2_calibrate;
        private System.Windows.Forms.Button id_set_btn;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button co_calibrate;
        private System.Windows.Forms.Button h2s_calibrate;
        private System.Windows.Forms.Button ch4_calibrate;
        private System.Windows.Forms.Button temp_calibrate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}