namespace SenserProj
{
    partial class FormCalibrate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalibrate));
            this.label1 = new System.Windows.Forms.Label();
            this.desc0 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.desc1 = new System.Windows.Forms.Label();
            this.desc2 = new System.Windows.Forms.Label();
            this.desc3 = new System.Windows.Forms.Label();
            this.desc4 = new System.Windows.Forms.Label();
            this.startTimeOut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desc5 = new System.Windows.Forms.Label();
            this.time_label = new System.Windows.Forms.Label();
            this.cmd_label = new System.Windows.Forms.Label();
            this.calibrate_send_btn = new System.Windows.Forms.Button();
            this.custom_calibrate_btn = new System.Windows.Forms.Button();
            this.customValue_NumberUpDown = new System.Windows.Forms.NumericUpDown();
            this.custom_gen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customValue_NumberUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "标定说明：";
            // 
            // desc0
            // 
            this.desc0.AutoSize = true;
            this.desc0.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.desc0.Location = new System.Drawing.Point(15, 40);
            this.desc0.Name = "desc0";
            this.desc0.Size = new System.Drawing.Size(53, 17);
            this.desc0.TabIndex = 1;
            this.desc0.Text = "desc0";
            // 
            // desc1
            // 
            this.desc1.AutoSize = true;
            this.desc1.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.desc1.Location = new System.Drawing.Point(15, 70);
            this.desc1.Name = "desc1";
            this.desc1.Size = new System.Drawing.Size(53, 17);
            this.desc1.TabIndex = 2;
            this.desc1.Text = "desc1";
            // 
            // desc2
            // 
            this.desc2.AutoSize = true;
            this.desc2.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.desc2.Location = new System.Drawing.Point(15, 100);
            this.desc2.Name = "desc2";
            this.desc2.Size = new System.Drawing.Size(53, 17);
            this.desc2.TabIndex = 3;
            this.desc2.Text = "desc2";
            // 
            // desc3
            // 
            this.desc3.AutoSize = true;
            this.desc3.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.desc3.Location = new System.Drawing.Point(15, 130);
            this.desc3.Name = "desc3";
            this.desc3.Size = new System.Drawing.Size(53, 17);
            this.desc3.TabIndex = 4;
            this.desc3.Text = "desc3";
            // 
            // desc4
            // 
            this.desc4.AutoSize = true;
            this.desc4.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.desc4.Location = new System.Drawing.Point(15, 160);
            this.desc4.Name = "desc4";
            this.desc4.Size = new System.Drawing.Size(53, 17);
            this.desc4.TabIndex = 5;
            this.desc4.Text = "desc4";
            // 
            // startTimeOut
            // 
            this.startTimeOut.BackColor = System.Drawing.Color.LightGray;
            this.startTimeOut.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startTimeOut.Location = new System.Drawing.Point(12, 486);
            this.startTimeOut.Name = "startTimeOut";
            this.startTimeOut.Size = new System.Drawing.Size(93, 28);
            this.startTimeOut.TabIndex = 104;
            this.startTimeOut.Text = "辅助计时";
            this.startTimeOut.UseVisualStyleBackColor = false;
            this.startTimeOut.Click += new System.EventHandler(this.startTimeOut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 415);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 65);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // desc5
            // 
            this.desc5.AutoSize = true;
            this.desc5.Font = new System.Drawing.Font("楷体", 10.47273F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.desc5.Location = new System.Drawing.Point(15, 190);
            this.desc5.Name = "desc5";
            this.desc5.Size = new System.Drawing.Size(53, 17);
            this.desc5.TabIndex = 106;
            this.desc5.Text = "desc5";
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Font = new System.Drawing.Font("楷体", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.time_label.Location = new System.Drawing.Point(83, 438);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(75, 24);
            this.time_label.TabIndex = 107;
            this.time_label.Text = "00:00";
            // 
            // cmd_label
            // 
            this.cmd_label.AutoSize = true;
            this.cmd_label.Font = new System.Drawing.Font("楷体", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_label.Location = new System.Drawing.Point(437, 441);
            this.cmd_label.Name = "cmd_label";
            this.cmd_label.Size = new System.Drawing.Size(43, 21);
            this.cmd_label.TabIndex = 108;
            this.cmd_label.Text = "cmd";
            // 
            // calibrate_send_btn
            // 
            this.calibrate_send_btn.BackColor = System.Drawing.Color.Transparent;
            this.calibrate_send_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calibrate_send_btn.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.calibrate_send_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.calibrate_send_btn.Location = new System.Drawing.Point(316, 440);
            this.calibrate_send_btn.Name = "calibrate_send_btn";
            this.calibrate_send_btn.Size = new System.Drawing.Size(115, 29);
            this.calibrate_send_btn.TabIndex = 123;
            this.calibrate_send_btn.Text = "零点校准";
            this.calibrate_send_btn.UseVisualStyleBackColor = false;
            this.calibrate_send_btn.Click += new System.EventHandler(this.calibrate_send_btn_Click);
            // 
            // custom_calibrate_btn
            // 
            this.custom_calibrate_btn.BackColor = System.Drawing.Color.Transparent;
            this.custom_calibrate_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custom_calibrate_btn.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Bold);
            this.custom_calibrate_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.custom_calibrate_btn.Location = new System.Drawing.Point(316, 482);
            this.custom_calibrate_btn.Name = "custom_calibrate_btn";
            this.custom_calibrate_btn.Size = new System.Drawing.Size(115, 32);
            this.custom_calibrate_btn.TabIndex = 125;
            this.custom_calibrate_btn.Text = "自定校准";
            this.custom_calibrate_btn.UseVisualStyleBackColor = false;
            this.custom_calibrate_btn.Click += new System.EventHandler(this.custom_calibrate_btn_Click);
            // 
            // customValue_NumberUpDown
            // 
            this.customValue_NumberUpDown.Font = new System.Drawing.Font("Cambria", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customValue_NumberUpDown.Location = new System.Drawing.Point(228, 482);
            this.customValue_NumberUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.customValue_NumberUpDown.Name = "customValue_NumberUpDown";
            this.customValue_NumberUpDown.Size = new System.Drawing.Size(82, 32);
            this.customValue_NumberUpDown.TabIndex = 126;
            this.customValue_NumberUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.customValue_NumberUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.customValue_NumberUpDown.ValueChanged += new System.EventHandler(this.customValue_ValueChanged);
            // 
            // custom_gen
            // 
            this.custom_gen.AutoSize = true;
            this.custom_gen.Font = new System.Drawing.Font("楷体", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.custom_gen.Location = new System.Drawing.Point(437, 488);
            this.custom_gen.Name = "custom_gen";
            this.custom_gen.Size = new System.Drawing.Size(43, 21);
            this.custom_gen.TabIndex = 127;
            this.custom_gen.Text = "cmd";
            // 
            // FormCalibrate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 524);
            this.Controls.Add(this.custom_gen);
            this.Controls.Add(this.customValue_NumberUpDown);
            this.Controls.Add(this.custom_calibrate_btn);
            this.Controls.Add(this.calibrate_send_btn);
            this.Controls.Add(this.cmd_label);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.desc5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.startTimeOut);
            this.Controls.Add(this.desc4);
            this.Controls.Add(this.desc3);
            this.Controls.Add(this.desc2);
            this.Controls.Add(this.desc1);
            this.Controls.Add(this.desc0);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("楷体", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormCalibrate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCalibrate";
            this.Load += new System.EventHandler(this.FormCalibrate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customValue_NumberUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label desc0;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label desc1;
        private System.Windows.Forms.Label desc2;
        private System.Windows.Forms.Label desc3;
        private System.Windows.Forms.Label desc4;
        private System.Windows.Forms.Button startTimeOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label desc5;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.Label cmd_label;
        private System.Windows.Forms.Button calibrate_send_btn;
        private System.Windows.Forms.Button custom_calibrate_btn;
        private System.Windows.Forms.NumericUpDown customValue_NumberUpDown;
        private System.Windows.Forms.Label custom_gen;
    }
}