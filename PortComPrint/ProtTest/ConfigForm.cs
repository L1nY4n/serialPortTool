using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PortDemo3
{
    public partial class ConfigForm : Form
    {
        string xmlFilename = Global.ApplicationPath + "\\Client.Xml";
        DataSet dsTmp;
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            GetParameters();
        }
        /// <summary>
        ///获取参数列表
        /// </summary>
        private void GetParameters()
        {
            if (File.Exists(xmlFilename) == true)
            {
                try
                {
                    dsTmp = new DataSet();
                    dsTmp.ReadXml(xmlFilename, XmlReadMode.Auto);
                    DataTable dt = dsTmp.Tables["参数表"];

                    TreeNode t;
                    int i = 0;
                    foreach (DataColumn dc in dt.Columns)
                    {

                        t = new TreeNode();
                        t.Text = dc.ColumnName;
                        tvConfig.Nodes.Add(t);

                        i += 1;
                    }
                }
                catch { }
            }
        }

        private void tvConfig_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lblInfo.Text = e.Node.Text;
            txtValue.Text = dsTmp.Tables["参数表"].Rows[0][e.Node.Text].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SetParameters(lblInfo.Text);
        }
        private void SetParameters(string param)
        {
            try
            {
                dsTmp.Tables["参数表"].Rows[0][param] = txtValue.Text;
                dsTmp.WriteXml(xmlFilename, XmlWriteMode.WriteSchema);
                Global.MsgBox("保存参数成功！", 0);
            }
            catch (Exception ex)
            {
                Global.MsgBox("保存客户端参数错误:\n" + ex.Message, 0);
            }
        }

    }
}