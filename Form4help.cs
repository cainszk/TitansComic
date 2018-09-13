using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitansComic
{
    public partial class Form4help : Form
    {
        public Form4help()
        {
            InitializeComponent();
        }

        private void Form4help_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Icon = f1.Icon;
        }

        private void btn4pdf_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "/Wiki/" + "Readme.pdf");
            }
            catch
            {
                MessageBox.Show("该错误存在以下可能性：\r\n1. 程序资源不完整，请下载更新最新版。\r\n2. 当前系统缺少对应的打开方式。", "错误！");
            }
        }

        private void btn4chm_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Application.StartupPath + "/Wiki/" + "Readme.chm");
            }
            catch
            {
                MessageBox.Show("该错误存在以下可能性：\r\n1. 程序资源不完整，请下载更新最新版。\r\n2. 当前系统缺少对应的打开方式。", "错误！");
            }
        }
    }
}
