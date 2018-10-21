using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace PortDemo3
{
    public class Settings
    {
        private static string applicationPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        /// <summary>
        /// 程序启动目录
        /// </summary>
        public static string ApplicationPath
        {
            get { return applicationPath; }
            set { applicationPath = value; }
        }
        private static string connectionString;
        /// <summary>
        /// sqllite数据库文件连接
        /// </summary>
        public static string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        private static string yltApiDomain;
        /// <summary>
        /// 银旅通接口域名
        /// </summary>
        public static string YltApiDomain
        {
            get { return yltApiDomain; }
            set { yltApiDomain = value; }
        }
        private static string yltApiUserId;
        /// <summary>
        /// 银旅通接口用户名
        /// </summary>
        public static string YltApiUserId
        {
            get { return yltApiUserId; }
            set { yltApiUserId = value; }
        }
        private static string yltApiOperatorLoginId;
        /// <summary>
        /// 银旅通接口操作员
        /// </summary>
        public static string YltApiOperatorLoginId
        {
            get { return yltApiOperatorLoginId; }
            set { yltApiOperatorLoginId = value; }
        }

        private static string yltApiPassWord;
        /// <summary>
        /// 银旅通接口密码
        /// </summary>
        public static string YltApiPassWord
        {
            get { return yltApiPassWord; }
            set { yltApiPassWord = value; }
        }

        private static string yltApiVersion;
        /// <summary>
        /// 银旅通接口版本
        /// </summary>
        public static string YltApiVersion
        {
            get { return yltApiVersion; }
            set { yltApiVersion = value; }
        }


        private static string qRCodePort;
        /// <summary>
        /// 二维码串口
        /// </summary>
        public static string QRCodePort
        {
            get { return qRCodePort; }
            set { qRCodePort = value; }
        }

        private static string posControlPort;
        /// <summary>
        /// 闸机控制串口
        /// </summary>
        public static string PosControlPort
        {
            get { return posControlPort; }
            set { posControlPort = value; }
        }

        private static string serverAddress;
        /// <summary>
        /// 服务器地址(ip:端口)
        /// </summary>
        public static string ServerAddress
        {
            get { return serverAddress; }
            set { serverAddress = value; }
        }

        private static string equipmentID;
        /// <summary>
        /// 设备编号
        /// </summary>
        public static string EquipmentID
        {
            get { return equipmentID; }
            set { equipmentID = value; }
        }
        #region 客户端设置

        /// <summary>
        /// 获取 客户端设置
        /// </summary>
        //public static void GetParameters()
        //{
        //    string xmlFilename = Global.ApplicationPath + "\\settings.Xml";

        //    if (!File.Exists(xmlFilename))
        //        return;
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        ds.ReadXml(xmlFilename);

        //        CommInterface.IpAdd = ds.Tables[0].Rows[0]["IpAdd"].ToString();//
        //        CommInterface.Port = Convert.ToInt32(ds.Tables[0].Rows[0]["Port"].ToString());
        //        CommInterface.DevNo = Convert.ToInt32(ds.Tables[0].Rows[0]["DevNo"].ToString());
        //        CommInterface.DevType = Convert.ToInt32(ds.Tables[0].Rows[0]["DevType"].ToString());
        //        CommInterface.DevSN = ds.Tables[0].Rows[0]["DevSN"].ToString();
        //        CommInterface.DevVer = ds.Tables[0].Rows[0]["DevVer"].ToString();
        //        CommInterface.IsWriteLog = Convert.ToInt32(ds.Tables[0].Rows[0]["IsWriteLog"].ToString());

        //        CommInterface.PosId = ds.Tables[0].Rows[0]["PosId"].ToString();
        //        CommInterface.DefOpenDir = "A";
        //        if (ds.Tables[0].Columns.Contains("DefOpenDir"))
        //        {
        //            CommInterface.DefOpenDir = ds.Tables[0].Rows[0]["DefOpenDir"].ToString();
        //        }
        //        if (ds.Tables[0].Columns.Contains("CardReceive"))
        //        {
        //            CommInterface.CardReceive = Convert.ToInt32(ds.Tables[0].Rows[0]["CardReceive"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("CardSplit"))
        //        {
        //            CommInterface.CardSplit = Convert.ToInt32(ds.Tables[0].Rows[0]["CardSplit"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("PassA"))
        //        {
        //            CommInterface.PassA = Convert.ToInt32(ds.Tables[0].Rows[0]["PassA"]);
        //            CommInterface.PassB = Convert.ToInt32(ds.Tables[0].Rows[0]["PassB"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("UploadPass"))
        //        {
        //            CommInterface.UploadPass = Convert.ToInt32(ds.Tables[0].Rows[0]["UploadPass"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("Phone"))
        //        {
        //            CommInterface.Phone = ds.Tables[0].Rows[0]["Phone"].ToString();
        //        }
        //        if (ds.Tables[0].Columns.Contains("ICCom"))
        //        {
        //            icCom = Convert.ToInt16(ds.Tables[0].Rows[0]["ICCom"]);
        //        }

        //        if (ds.Tables[0].Columns.Contains("TradeTimeReadCard"))
        //        {
        //            TradeTimeReadCard = Convert.ToInt32(ds.Tables[0].Rows[0]["TradeTimeReadCard"]);
        //        }

        //        if (ds.Tables[0].Columns.Contains("IsLoadFinger"))
        //        {
        //            CommInterface.IsLoadFinger = ds.Tables[0].Rows[0]["IsLoadFinger"].ToString() == "1";
        //            JKFinger = ClsChFinger.GetInstance();
        //        }
        //        Console.Write("RS232COM:" + CommInterface.RS232Com);
        //        if (ds.Tables[0].Columns.Contains("RS232Com"))
        //        {
        //            CommInterface.RS232Com = ds.Tables[0].Rows[0]["RS232Com"].ToString();
        //            Console.Write("RS232COM1:" + CommInterface.RS232Com);
        //        }

        //        if (ds.Tables[0].Columns.Contains("localIP"))
        //        {
        //            CommInterface.localIP = ds.Tables[0].Rows[0]["localIP"].ToString();
        //        }

        //        if (ds.Tables[0].Columns.Contains("IsReadSystemConfigXml"))
        //        {
        //            IsReadSystemConfigXml = Convert.ToInt32(ds.Tables[0].Rows[0]["IsReadSystemConfigXml"]);
        //        }

        //        if (ds.Tables[0].Columns.Contains("NoValidateDir"))
        //        {
        //            NoValidateDir = ds.Tables[0].Rows[0]["NoValidateDir"].ToString();
        //        }

        //        if (ds.Tables[0].Columns.Contains("SoundSize"))
        //        {
        //            SoundSize = Convert.ToUInt32(ds.Tables[0].Rows[0]["SoundSize"]);
        //        }

        //        if (ds.Tables[0].Columns.Contains("IsIndentityCard"))
        //        {
        //            IsIndentityCard = Convert.ToInt32(ds.Tables[0].Rows[0]["IsIndentityCard"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("IndentityFilter"))
        //        {
        //            IndentityFilter = ds.Tables[0].Rows[0]["IndentityFilter"].ToString();
        //        }

        //        if (ds.Tables[0].Columns.Contains("IsKeyBoardErweima"))
        //        {
        //            IsKeyBoardErweima = Convert.ToInt32(ds.Tables[0].Rows[0]["IsKeyBoardErweima"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("IsDebug"))
        //        {
        //            IsDebug = Convert.ToInt32(ds.Tables[0].Rows[0]["IsDebug"]);
        //        }

        //        if (ds.Tables[0].Columns.Contains("EnableSoundDown"))
        //        {
        //            EnableSoundDown = Convert.ToInt32(ds.Tables[0].Rows[0]["EnableSoundDown"]);
        //        }

        //        if (IsDebug > 0)
        //        {
        //            panel1.Visible = true;
        //        }
        //        if (ds.Tables[0].Columns.Contains("IsXinHao"))
        //        {
        //            IsXinHao = Convert.ToInt32(ds.Tables[0].Rows[0]["IsXinHao"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("TimeOut"))
        //        {
        //            TimeOut = Convert.ToInt32(ds.Tables[0].Rows[0]["TimeOut"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("EnablePOS"))
        //        {
        //            EnablePOS = Convert.ToInt32(ds.Tables[0].Rows[0]["EnablePOS"]);
        //            if (ds.Tables[0].Columns.Contains("OpengGatePassPrice"))
        //            {
        //                OpengGatePassPrice = ds.Tables[0].Rows[0]["OpengGatePassPrice"].ToString();
        //                UpdateInfo myfunc1 = delegate()
        //                {
        //                    ticketLbl.Text = string.Format("门票:{0}\n价格:{1}", "成人票", OpengGatePassPrice);
        //                    Console.Write("初始化门票价格本地配置" + ticketLbl.Text);
        //                };
        //                this.Invoke(myfunc1);
        //            }
        //            if (ds.Tables[0].Columns.Contains("POSPort"))
        //            {
        //                POSPort = Convert.ToInt32(ds.Tables[0].Rows[0]["POSPort"]);
        //            }
        //        }
        //        if (ds.Tables[0].Columns.Contains("IsShowBindTicket"))
        //        {
        //            this.IsShowBindTicket = Convert.ToInt32(ds.Tables[0].Rows[0]["IsShowBindTicket"]);
        //        }
        //        if (ds.Tables[0].Columns.Contains("IsShowAllCount"))
        //        {
        //            this.IsShowAllCount = ds.Tables[0].Rows[0]["IsShowAllCount"].ToString() == "1";
        //            this.ClearAllCountCodePrefix = ds.Tables[0].Rows[0]["ClearAllCountCodePrefix"].ToString();
        //        }
        //        this.ticketLbl.Visible = false;
        //        if (this.EnablePOS != 0)
        //        {
        //            this.IsShowBindTicket = 1;
        //        }
        //        if (this.IsShowBindTicket != 0)
        //        {
        //            this.ticketLbl.Visible = true;
        //        }
        //        if (this.IsShowAllCount)
        //        {
        //            this.lblAllCount.Visible = true;
        //            this.lblAllCount.Text = "总人数：0";
        //        }
        //        waveOutSetVolume(IntPtr.Zero, SoundSize);//设置音量


        //        #region 显示效果

        //        CompanyInfoLabel.Text = "@powerby 银旅通\n" + CommInterface.Phone;

        //        #endregion


        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write("ex:" + ex.ToString());
        //    }

        //}


        /// <summary>
        /// 设置 客户端设置
        /// </summary>
        public static bool SetParameters()
        {
            DataSet dsTmp = new DataSet("客户端配置");
            DataTable dtTmp = new DataTable("参数表");
            dtTmp.Columns.Add("服务地址", typeof(System.String));
            dtTmp.Columns.Add("设备编号", typeof(System.String));
            dtTmp.Columns.Add("二维码串口", typeof(System.String));
            dtTmp.Columns.Add("闸机控制串口", typeof(System.String));
            dtTmp.Columns.Add("设备编号", typeof(System.String));

            DataRow drTmp = dtTmp.NewRow();
            drTmp["服务地址"] = Global.ServerAddress;
            drTmp["设备编号"] = Global.EquipmentID;
            drTmp["二维码串口"] = Global.QRCodePort;
            drTmp["闸机控制串口"] = Global.PosControlPort;
            dtTmp.Rows.Add(drTmp);
            dsTmp.Tables.Add(dtTmp);
            try
            {
                string xmlFilename = Global.ApplicationPath + "\\Client.Xml";
                dsTmp.WriteXml(xmlFilename, XmlWriteMode.WriteSchema);

                return true;
            }
            catch (Exception ex)
            {
                Global.MsgBox("保存客户端参数错误:\n" + ex.Message, 0);
                return false;
            }
        }

        #endregion

        /// <summary>
        /// 信息提示
        /// </summary>
        /// <param name="message">显示信息内容</param>
        public static System.Windows.Forms.DialogResult MsgTipsBox(string message)
        {
            return System.Windows.Forms.MessageBox.Show(message, "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk, System.Windows.Forms.MessageBoxDefaultButton.Button1);

        }

        /// <summary>
        /// 信息提示
        /// 0=提示信息框
        /// 1=选择信息框
        /// </summary>
        /// <param name="message">显示信息内容</param>
        /// <param name="frmType">对话框类型</param>
        public static System.Windows.Forms.DialogResult MsgBox(string message, int frmType)
        {
            if (frmType == 0)
                return System.Windows.Forms.MessageBox.Show(message, "提示", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Asterisk, System.Windows.Forms.MessageBoxDefaultButton.Button1);
            else
                return System.Windows.Forms.MessageBox.Show(message, "选择", System.Windows.Forms.MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question, System.Windows.Forms.MessageBoxDefaultButton.Button1);
        }

        /// <summary>
        /// 窗体居中
        /// </summary>
        public static System.Drawing.Point FormCenter(int width, int height)
        {
            System.Drawing.Point point = new System.Drawing.Point(0, 0);

            int scrWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            int scrHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;

            if (scrWidth > width)
                point.X = (scrWidth - width) / 2;
            if (scrHeight > height)
                point.Y = (scrHeight - height) / 2;

            return point;
        }

        /// <summary>
        /// 窗口充满整个屏幕
        /// </summary>
        public static void FormFullScreen(System.Windows.Forms.Form frm)
        {
            int scrWidth = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width;
            int scrHeight = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
            frm.Width = scrWidth;
            frm.Height = scrHeight;
            frm.Left = 0;
            frm.Top = 0;
        }
    }
}
