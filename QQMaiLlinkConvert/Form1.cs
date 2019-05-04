using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQMaiLlinkConvert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (TopcheckBox.Checked == true)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }
        private void convert_Click(object sender, EventArgs e)
        {
            string Share1 = "http://mail.qq.com/cgi-bin/ftnExs_download?k=";
            string Share2 = "&t=exs_ftn_download&code=";
            string downloadlink = "默认";
            string sharelink;
            //获取剪切版数据

            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(DataFormats.Text))
                downloadlink = data.GetData(DataFormats.Text).ToString();
            //转换链接
            string[] sArray = downloadlink.Split(new string[] { "code=", "&k=" }, StringSplitOptions.RemoveEmptyEntries);
            sharelink = Share1 + sArray[2] + Share2 + sArray[1];
            Clipboard.SetDataObject(sharelink);
            MessageBox.Show("链接转换成功并已复制到剪贴板", "复制成功");
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q && e.Control)
            {
                convert.PerformClick(); //执行单击convert的动作      
            }
        }
    }
}

