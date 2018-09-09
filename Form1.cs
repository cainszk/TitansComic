using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace TitansComic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string picurl;//图片地址字符串
        string epurl;//章节地址字符串
        string epname;//章节名字字符串
        int epnum;//章节号数值
        int pgnum;//页码数值
        string lstx;//分割后上一个章节名字字符串
        string x;//分割后获得的章节名字字符串
        string y;//分割后获得的页码字符串
        string str4picnum;//图片号字符串
        string str4pgnum;//页码字符串
        string str4epnum;//页码字符串
        void str4num()
        {
            str4epnum = epnum.ToString();
            str4pgnum = (pgnum - 1).ToString();
        }
        void lastpage()
        {
            if (pgnum > 1)
            {
                pgnum -= 1;
                see();
            }
        }
        void nextpage()
        {
            pgnum += 1;
            see();
        }
        void see()
        {
            str4num();
            picurl = epurl + str4epnum+ str4pgnum;
            string url = string.Format(picurl + ".jpg");
            try
            {
                WebRequest webreq = WebRequest.Create(url);
                WebResponse webres = webreq.GetResponse();
                using (Stream stream = webres.GetResponseStream())
                {
                    pictureBox1.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                
            }
            switch (epurl)
            {
                case "http://p17.xiaoshidi.net/2013/03/":
                    switch (epname)
                    {
                        case "ep001":
                            lb4num.Text = "第1话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep002":
                            lb4num.Text = "第2话，第" + pgnum.ToString() + "页";
                            break;
                    }
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"book.mark"))
            {
                FileStream fsrd = File.OpenRead(@"book.mark");
                StreamReader sr = new StreamReader(fsrd, System.Text.Encoding.Default);
                string strrd = sr.ReadToEnd();
                sr.Close();
                fsrd.Close();
                char[] separator = { ':' };
                string[] splitstrings = new string[100];
                splitstrings = strrd.Split(separator);
                for (int i = 0; i < splitstrings.Length; i++)
                {
                    x = splitstrings[0];
                    y = splitstrings[1];
                }
                epname = x;
                switch (x)
                {
                    case "ep001":
                        lstx = "第1话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum= 17123332;
                        break;
                    case "ep002":
                        lstx = "第2话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123435;
                        break;
                }
                lb4history.Text = "上次看到：" + lstx + "，第" + y + "页";
                pgnum = Int32.Parse(y);
                see();

            }
        }
        private void btn4001_Click(object sender, EventArgs e)
        {
            epname = "ep001";
            epnum = 17123332;
            pgnum = 1;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            see();
        }
        private void btn4lastpage_Click(object sender, EventArgs e)
        {
            lastpage();
        }
        private void btn4nextpage_Click(object sender, EventArgs e)
        {
            nextpage();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fscr = File.Create(@"book.mark");
            StreamWriter sw = new StreamWriter(fscr, System.Text.Encoding.Default);
            sw.Write(epname+":"+ pgnum);
            sw.Close();
            fscr.Close();
        }
        private void btn4002_Click(object sender, EventArgs e)
        {
            epname = "ep002";
            epnum = 17123435;
            pgnum = 1;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            see();
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                lastpage();
            }
            if (e.KeyCode == Keys.Down)
            {
                nextpage();
            }
            if (e.KeyCode == Keys.Left)
            {
                lastpage();
            }
            if (e.KeyCode == Keys.Right)
            {
                nextpage();
            }
            if (e.KeyCode == Keys.Space)
            {
                nextpage();
            }
        }
    }
}
