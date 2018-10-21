namespace UDPClient
{
    partial class Udp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Udp));
            this.lblocalIp = new System.Windows.Forms.Label();
            this.msgview = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.localIP = new System.Windows.Forms.ComboBox();
            this.localPort = new System.Windows.Forms.TextBox();
            this.recieve_port = new System.Windows.Forms.Label();
            this.des_port_label = new System.Windows.Forms.Label();
            this.des_port = new System.Windows.Forms.TextBox();
            this.des_ip_label = new System.Windows.Forms.Label();
            this.des_ip = new System.Windows.Forms.TextBox();
            this.file_open_btn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.pageSize = new System.Windows.Forms.TextBox();
            this.waitTime = new System.Windows.Forms.Label();
            this.byteLen = new System.Windows.Forms.Label();
            this.reflashEth = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.stopBtn = new System.Windows.Forms.Button();
            this.sendMutualBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.ReSendDelay = new System.Windows.Forms.NumericUpDown();
            this.MaxReSendTime = new System.Windows.Forms.NumericUpDown();
            this.ccc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.ResetBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReSendDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxReSendTime)).BeginInit();
            this.SuspendLayout();
            // 
            // lblocalIp
            // 
            this.lblocalIp.AutoSize = true;
            this.lblocalIp.BackColor = System.Drawing.Color.Transparent;
            this.lblocalIp.Font = new System.Drawing.Font("BankGothic Md BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblocalIp.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblocalIp.Location = new System.Drawing.Point(18, 12);
            this.lblocalIp.Name = "lblocalIp";
            this.lblocalIp.Size = new System.Drawing.Size(107, 19);
            this.lblocalIp.TabIndex = 1;
            this.lblocalIp.Text = "Local_IP:";
            // 
            // msgview
            // 
            this.msgview.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.msgview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msgview.Font = new System.Drawing.Font("华文中宋", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.msgview.ForeColor = System.Drawing.Color.White;
            this.msgview.FormattingEnabled = true;
            this.msgview.ItemHeight = 16;
            this.msgview.Location = new System.Drawing.Point(691, 8);
            this.msgview.Name = "msgview";
            this.msgview.Size = new System.Drawing.Size(474, 450);
            this.msgview.TabIndex = 11;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCyan;
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 12F);
            this.btnClear.Location = new System.Drawing.Point(1038, 474);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 48);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clean❌";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // localIP
            // 
            this.localIP.Font = new System.Drawing.Font("楷体", 10.8F);
            this.localIP.FormattingEnabled = true;
            this.localIP.Location = new System.Drawing.Point(122, 10);
            this.localIP.Name = "localIP";
            this.localIP.Size = new System.Drawing.Size(129, 24);
            this.localIP.TabIndex = 15;
            // 
            // localPort
            // 
            this.localPort.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.localPort.Location = new System.Drawing.Point(144, 50);
            this.localPort.Name = "localPort";
            this.localPort.Size = new System.Drawing.Size(106, 26);
            this.localPort.TabIndex = 16;
            this.localPort.Text = "6001";
            this.localPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // recieve_port
            // 
            this.recieve_port.AutoSize = true;
            this.recieve_port.BackColor = System.Drawing.Color.Transparent;
            this.recieve_port.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.recieve_port.ForeColor = System.Drawing.Color.LimeGreen;
            this.recieve_port.Location = new System.Drawing.Point(18, 57);
            this.recieve_port.Name = "recieve_port";
            this.recieve_port.Size = new System.Drawing.Size(133, 19);
            this.recieve_port.TabIndex = 18;
            this.recieve_port.Text = "Listin_Port";
            // 
            // des_port_label
            // 
            this.des_port_label.AutoSize = true;
            this.des_port_label.BackColor = System.Drawing.Color.Transparent;
            this.des_port_label.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.des_port_label.ForeColor = System.Drawing.Color.Orange;
            this.des_port_label.Location = new System.Drawing.Point(423, 52);
            this.des_port_label.Name = "des_port_label";
            this.des_port_label.Size = new System.Drawing.Size(149, 19);
            this.des_port_label.TabIndex = 23;
            this.des_port_label.Text = "Remote_Port";
            // 
            // des_port
            // 
            this.des_port.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.des_port.Location = new System.Drawing.Point(563, 50);
            this.des_port.Name = "des_port";
            this.des_port.Size = new System.Drawing.Size(108, 26);
            this.des_port.TabIndex = 22;
            this.des_port.Text = "6001";
            this.des_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // des_ip_label
            // 
            this.des_ip_label.AutoSize = true;
            this.des_ip_label.BackColor = System.Drawing.Color.Transparent;
            this.des_ip_label.Font = new System.Drawing.Font("BankGothic Md BT", 12F);
            this.des_ip_label.ForeColor = System.Drawing.Color.Orange;
            this.des_ip_label.Location = new System.Drawing.Point(423, 15);
            this.des_ip_label.Name = "des_ip_label";
            this.des_ip_label.Size = new System.Drawing.Size(119, 19);
            this.des_ip_label.TabIndex = 19;
            this.des_ip_label.Text = "Remote_IP";
            // 
            // des_ip
            // 
            this.des_ip.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.des_ip.Location = new System.Drawing.Point(538, 15);
            this.des_ip.Name = "des_ip";
            this.des_ip.Size = new System.Drawing.Size(133, 26);
            this.des_ip.TabIndex = 24;
            this.des_ip.Text = "192.168.0.100";
            this.des_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // file_open_btn
            // 
            this.file_open_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.file_open_btn.Font = new System.Drawing.Font("Cambria", 12F);
            this.file_open_btn.Location = new System.Drawing.Point(12, 120);
            this.file_open_btn.Name = "file_open_btn";
            this.file_open_btn.Size = new System.Drawing.Size(97, 35);
            this.file_open_btn.TabIndex = 25;
            this.file_open_btn.Text = "LoadFil👌";
            this.file_open_btn.UseVisualStyleBackColor = true;
            this.file_open_btn.Click += new System.EventHandler(this.file_open_btn_Click);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sendBtn.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.Location = new System.Drawing.Point(235, 275);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(100, 39);
            this.sendBtn.TabIndex = 26;
            this.sendBtn.Text = "间隔发送";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.send_byte_Click);
            // 
            // pageSize
            // 
            this.pageSize.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageSize.Location = new System.Drawing.Point(138, 203);
            this.pageSize.Name = "pageSize";
            this.pageSize.Size = new System.Drawing.Size(100, 27);
            this.pageSize.TabIndex = 27;
            this.pageSize.Text = "288\r\n";
            this.pageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageSize.TextChanged += new System.EventHandler(this.pageSize_TextChanged);
            // 
            // waitTime
            // 
            this.waitTime.AutoSize = true;
            this.waitTime.BackColor = System.Drawing.Color.Transparent;
            this.waitTime.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitTime.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.waitTime.Location = new System.Drawing.Point(28, 275);
            this.waitTime.Name = "waitTime";
            this.waitTime.Size = new System.Drawing.Size(104, 20);
            this.waitTime.TabIndex = 29;
            this.waitTime.Text = "Interval(ms):";
            // 
            // byteLen
            // 
            this.byteLen.AutoSize = true;
            this.byteLen.BackColor = System.Drawing.Color.Transparent;
            this.byteLen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.byteLen.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.byteLen.Location = new System.Drawing.Point(30, 203);
            this.byteLen.Name = "byteLen";
            this.byteLen.Size = new System.Drawing.Size(108, 22);
            this.byteLen.TabIndex = 30;
            this.byteLen.Text = "PackLength:";
            // 
            // reflashEth
            // 
            this.reflashEth.BackColor = System.Drawing.Color.PowderBlue;
            this.reflashEth.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reflashEth.Location = new System.Drawing.Point(278, 8);
            this.reflashEth.Name = "reflashEth";
            this.reflashEth.Size = new System.Drawing.Size(112, 29);
            this.reflashEth.TabIndex = 31;
            this.reflashEth.Text = "Refresh🔄";
            this.reflashEth.UseVisualStyleBackColor = true;
            this.reflashEth.Click += new System.EventHandler(this.reflashEth_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(138, 276);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 27);
            this.numericUpDown1.TabIndex = 32;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.Pink;
            this.stopBtn.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(440, 276);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(94, 38);
            this.stopBtn.TabIndex = 33;
            this.stopBtn.Text = "停止";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // sendMutualBtn
            // 
            this.sendMutualBtn.BackColor = System.Drawing.Color.Lavender;
            this.sendMutualBtn.Font = new System.Drawing.Font("楷体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendMutualBtn.Location = new System.Drawing.Point(235, 352);
            this.sendMutualBtn.Name = "sendMutualBtn";
            this.sendMutualBtn.Size = new System.Drawing.Size(100, 60);
            this.sendMutualBtn.TabIndex = 35;
            this.sendMutualBtn.Text = "交互发送";
            this.sendMutualBtn.UseVisualStyleBackColor = false;
            this.sendMutualBtn.Click += new System.EventHandler(this.sendMutualBeginBtn);
            // 
            // pauseBtn
            // 
            this.pauseBtn.BackColor = System.Drawing.Color.Moccasin;
            this.pauseBtn.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauseBtn.Location = new System.Drawing.Point(340, 276);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(94, 38);
            this.pauseBtn.TabIndex = 36;
            this.pauseBtn.Text = "暂停";
            this.pauseBtn.UseVisualStyleBackColor = false;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // ReSendDelay
            // 
            this.ReSendDelay.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReSendDelay.Location = new System.Drawing.Point(138, 385);
            this.ReSendDelay.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ReSendDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ReSendDelay.Name = "ReSendDelay";
            this.ReSendDelay.Size = new System.Drawing.Size(83, 27);
            this.ReSendDelay.TabIndex = 37;
            this.ReSendDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ReSendDelay.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ReSendDelay.ValueChanged += new System.EventHandler(this.ReSendDelay_ValueChanged);
            // 
            // MaxReSendTime
            // 
            this.MaxReSendTime.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxReSendTime.Location = new System.Drawing.Point(138, 352);
            this.MaxReSendTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxReSendTime.Name = "MaxReSendTime";
            this.MaxReSendTime.Size = new System.Drawing.Size(83, 27);
            this.MaxReSendTime.TabIndex = 38;
            this.MaxReSendTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxReSendTime.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.MaxReSendTime.ValueChanged += new System.EventHandler(this.MaxReSendTime_ValueChanged);
            // 
            // ccc
            // 
            this.ccc.AutoSize = true;
            this.ccc.BackColor = System.Drawing.Color.Transparent;
            this.ccc.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccc.ForeColor = System.Drawing.Color.Violet;
            this.ccc.Location = new System.Drawing.Point(3, 352);
            this.ccc.Name = "ccc";
            this.ccc.Size = new System.Drawing.Size(129, 20);
            this.ccc.TabIndex = 39;
            this.ccc.Text = "MaxReSendTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Violet;
            this.label2.Location = new System.Drawing.Point(28, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "ReSendDelay";
            // 
            // fileName
            // 
            this.fileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileName.Enabled = false;
            this.fileName.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileName.ForeColor = System.Drawing.Color.DarkGreen;
            this.fileName.Location = new System.Drawing.Point(122, 124);
            this.fileName.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(549, 32);
            this.fileName.TabIndex = 41;
            this.fileName.Text = "未加载文件";
            this.fileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetBtn.Enabled = false;
            this.ResetBtn.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(278, 50);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(112, 33);
            this.ResetBtn.TabIndex = 42;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // Udp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1176, 533);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ccc);
            this.Controls.Add(this.MaxReSendTime);
            this.Controls.Add(this.ReSendDelay);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.sendMutualBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.reflashEth);
            this.Controls.Add(this.byteLen);
            this.Controls.Add(this.waitTime);
            this.Controls.Add(this.pageSize);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.file_open_btn);
            this.Controls.Add(this.des_ip);
            this.Controls.Add(this.des_port_label);
            this.Controls.Add(this.des_port);
            this.Controls.Add(this.des_ip_label);
            this.Controls.Add(this.recieve_port);
            this.Controls.Add(this.localPort);
            this.Controls.Add(this.localIP);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.msgview);
            this.Controls.Add(this.lblocalIp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Udp";
            this.Text = "UDP文件发包";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Udp_FormClosing);
            this.Load += new System.EventHandler(this.frmUdp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReSendDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxReSendTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblocalIp;
        private System.Windows.Forms.ListBox msgview;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox localIP;
        private System.Windows.Forms.TextBox localPort;
        private System.Windows.Forms.Label recieve_port;
        private System.Windows.Forms.Label des_port_label;
        private System.Windows.Forms.TextBox des_port;
        private System.Windows.Forms.Label des_ip_label;
        private System.Windows.Forms.TextBox des_ip;
        private System.Windows.Forms.Button file_open_btn;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox pageSize;
        private System.Windows.Forms.Label waitTime;
        private System.Windows.Forms.Label byteLen;
        private System.Windows.Forms.Button reflashEth;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button sendMutualBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.NumericUpDown ReSendDelay;
        private System.Windows.Forms.NumericUpDown MaxReSendTime;
        private System.Windows.Forms.Label ccc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button ResetBtn;
    }
}

