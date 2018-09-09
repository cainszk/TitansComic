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

namespace TitansComic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string picurl;
        string epurl;
        string epname;
        int picnum;
        int pgnum;
        string lstx;
        string x;
        string y;
        void lastpage()
        {
            if (pgnum > 1)
            {
                picnum -= 1;
                see();
            }
        }
        void nextpage()
        {
            picnum += 1;
            see();
        }
        void see()
        {
            picurl = epurl + picnum.ToString();
            string url = string.Format(picurl + ".jpg");
            System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
            System.Net.WebResponse webres = webreq.GetResponse();
            using (System.IO.Stream stream = webres.GetResponseStream())
            {
                pictureBox1.Image = Image.FromStream(stream);
            }
            switch (epurl)
            {
                case "http://p17.xiaoshidi.net/2013/03/":
                    switch (epname)
                    {
                        case "ep001":
                            pgnum = picnum - 171233319;
                            lb4num.Text = "第1话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep002":
                            pgnum = picnum - 171234349;
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
                        picnum = Int32.Parse(y) + 171233319;
                        break;
                    case "ep002":
                        lstx = "第2话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        picnum = Int32.Parse(y) + 171234349;
                        break;
                }
                lb4history.Text = "上次看到：" + lstx + "，第" + y + "页";
                see();

            }
        }
        private void btn4001_Click(object sender, EventArgs e)
        {
            epname = "ep001";
            picnum = 171233320;
            pgnum = picnum - 171233319;
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
            picnum = 171234350;
            pgnum = picnum - 171234349;
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
