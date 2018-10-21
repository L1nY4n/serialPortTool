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
        public string gas_type = string.Empty; //气体类型
        public int t;
        public string cmd;
        private SenserForm parentForm;
       public FormCalibrate(GasCalibration gc,  SenserForm sf)
        {
            InitializeComponent();
            this.gas_type = gc.type;
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
            t = gc.time;
            cmd = gc.cmd;
            cmd_label.Text = gc.cmd.Replace(" ",string.Empty );
        }
        int timer_range = 0;
        private void startTimeOut_Click(object sender, EventArgs e)
        {
            
           
            timer1.Start();
            startTimeOut.Text = "倒计时中...";
            startTimeOut.Enabled = false;
            calibrate_send_btn.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
           
            if (timer_range == 0)
            {
                startTimeOut.Text = "重新计时";
                startTimeOut.Enabled = true;
                time_label.Text = "计时结束";
                timer1.Stop();
                timer_range = t;
                SendCmd(cmd);
                calibrate_send_btn.Enabled = true;

            }
            else
            {
                timer_range--;
                time_label.Text = (timer_range / 60).ToString() + ":" + (timer_range % 60).ToString().PadLeft(2, '0');
            }
            
          
        }
        public void SendCmd(string cmd)
        {
            string cmd_t = cmd.Replace(" ", string.Empty);
            string cmd_crc = cmd_t + Crc16_modbus.ToModbusCRC16(cmd_t, true);
            bool staus=  parentForm.SendStrCmd(cmd_crc);
            if (staus)
            {
                MessageBox.Show("指令【" + cmd_crc + "】发送成功！", "操作提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("指令【"+ cmd_crc +"】发送失败！\r\n 请检查串口工作状态。", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        

        }

        private void FormCalibrate_Load(object sender, EventArgs e)
        {
            //初始化定时器
            timer_range = t;
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
        }

        private void calibrate_send_btn_Click(object sender, EventArgs e)
        {
            SendCmd(cmd);
        }
    }
   

}
