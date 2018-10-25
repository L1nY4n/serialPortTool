using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenserProj
{
    public partial class FormCalibrate : Form
    {
        private GasCalibration gc= null; //气体类型
        private SenserForm parentForm;

        public int timer_range = 0;
        public FormCalibrate(GasCalibration gc,  SenserForm sf)
        {
            InitializeComponent();
            this.gc = gc;
            this.parentForm = sf;
            for (int i = 0; i < 6; i++)
            {
                string name = "desc" + i;
                Label lb = this.Controls.Find(name, true).FirstOrDefault() as Label;
                if (i < gc.descs.Length)
                {
                    lb.Text = gc.descs[i];
                }
                else
                {
                    lb.Text = String.Empty;
                }
            }

            time_label.Text = (gc.time / 60).ToString() + ":" + (gc.time % 60).ToString().PadLeft(2,'0');
            switch(gc.type)
            {
                case "o2":
                calibrate_send_btn.Text = "氧气校准[21.9]";
                cmd_label.Text = gc.cmd.Replace(" ",string.Empty );
                    customValue_NumberUpDown.Visible = false;
                    custom_gen.Visible = false;
                    custom_calibrate_btn.Visible = false;
                    break;
                case "ch4":
                    calibrate_send_btn.Text = "ch4零点校准";
                    cmd_label.Text = gc.cmd.Replace(" ", string.Empty)+"0000";
                    customValue_NumberUpDown.Value = 50;
                    custom_calibrate_btn.Text = "50%LEL校准";
                    break;
                case "h2s":
                    calibrate_send_btn.Text = "h2s零点校准";
                    cmd_label.Text = gc.cmd.Replace(" ", string.Empty) + "0000";
                    customValue_NumberUpDown.Value = 50;
                    custom_calibrate_btn.Text = "50ppm校准";
                    break;
                case "co":
                    calibrate_send_btn.Text = "co零点校准";
                    cmd_label.Text = gc.cmd.Replace(" ", string.Empty) + "0000";
                    customValue_NumberUpDown.Value = 200;
                    custom_calibrate_btn.Text = "200ppm校准";
                    break;
            }
            customValue_NumberUpDown.Enabled = false;
            string v = Decimal.ToInt32(customValue_NumberUpDown.Value).ToString("X2").PadLeft(4, '0');
            custom_gen.Text = (gc.cmd + v).Replace(" ",string.Empty);
        }
        private void startTimeOut_Click(object sender, EventArgs e)
        {
            timer1.Start();
            startTimeOut.Text = "倒计时中...";
            startTimeOut.Enabled = false;
           
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer_range == 0)
            {
                startTimeOut.Text = "重新计时";
                startTimeOut.Enabled = true;
                time_label.Text = "计时结束";
                timer1.Stop();
                timer_range = gc.time;
            }
            else
            {
                timer_range--;
                time_label.Text = (timer_range / 60).ToString() + ":" + (timer_range % 60).ToString().PadLeft(2, '0');
            } 
        }
        public void SendCmd(string cmd)
        {
            if (MessageBox.Show("发送的指令为【"+cmd+"】\r\n确认无误后发送", "发送确认", MessageBoxButtons.OKCancel)== DialogResult.OK){

                string cmd_t = cmd.Replace(" ", string.Empty);
                string cmd_crc = cmd_t + Crc16_modbus.ToModbusCRC16(cmd_t, true);
                bool staus = parentForm.SendStrCmd(cmd_crc);
                if (staus)
                {
                    MessageBox.Show("指令【" + cmd_crc + "】发送成功！", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("指令【" + cmd_crc + "】发送失败！\r\n 请检查串口工作状态。", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }
        private void FormCalibrate_Load(object sender, EventArgs e)
        {
            //初始化定时器
            timer_range = gc.time;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
        }
        private void calibrate_send_btn_Click(object sender, EventArgs e)
        {
            SendCmd(cmd_label.Text);
        }
        private void custom_calibrate_btn_Click(object sender, EventArgs e)
        {
            SendCmd(custom_gen.Text);
        }
        private void customValue_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown nu = (NumericUpDown)sender;
            //nu.Enabled = false;
            int value = Decimal.ToInt32(nu.Value);
            string cmd = value.ToString("X2");
            custom_gen.Text = cmd;
        }
    }
}
