using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.IO;

namespace SenserProj
{
    public class Global
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

        //private static string remoteServerAddress = "219.139.81.5:8090";
        ///// <summary>
        ///// 远程服务器地址
        ///// </summary>
        //public static string RemoteServerAddress
        //{
        //    get { return remoteServerAddress; }
        //    set { remoteServerAddress = value; }
        //}

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
        public static void GetParameters()
        {
            string xmlFilename = Global.ApplicationPath + "\\Client.Xml";

            if (File.Exists(xmlFilename) == true)
            {
                try
                {
                    DataSet dsTmp = new DataSet();
                    dsTmp.ReadXml(xmlFilename, XmlReadMode.Auto);

                    if (dsTmp.Tables["参数表"].Rows.Count != 0)
                    {
                        DataTable dt = dsTmp.Tables[0];
                        DataRow dr = dt.Rows[0];
                        Global.ServerAddress = dr["服务地址"].ToString();
                        Global.QRCodePort = dr["二维码串口"].ToString();
                        Global.PosControlPort = dr["闸机控制串口"].ToString();
                        Global.EquipmentID = dr["设备编号"].ToString();
                    }
                }
                catch { }
            }
        }


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
