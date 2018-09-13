using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TitansComic
{
    public partial class Form4update : Form
    {
        public Form4update()
        {
            InitializeComponent();
        }
        string webcode;
        string str4vernum;
        float vernum;
        string verstrrd;
        public static string getwebcode(string wurl, string encoder)
        {
            WebClient myWebClient = new WebClient();
            byte[] myDataBuffer = myWebClient.DownloadData(wurl);
            string SourceCode = Encoding.GetEncoding(encoder).GetString(myDataBuffer);
            return SourceCode;
        }
        void getcode()
        {
            webcode = getwebcode("https://github.com/cainszk/TitansComic/releases/latest", "UTF-8");
  
        }
        void substr()
        {
            string[] sArray = webcode.Split(new string[] { "<title>Release TitansComic ", " · cainszk/" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string sub0 in sArray)
            {
                str4vernum = sArray[1];
            }
        }
        void checkupdate()
        {
            getcode();
            substr();
            vernum = float.Parse(str4vernum);
            if (float.Parse(verstrrd) < vernum)
            {
                lb4ver.Text = "您当前的版本：v" + verstrrd + " 发现新版本：v" + str4vernum;
                lb4hint.Enabled = true;
                btn4rls.Enabled = true;
            }
            else
            {
                lb4ver.Text = "当前版本已经是最新版本";
            }
        }
        private void btn4rls_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cainszk/TitansComic/releases/latest");
        }
        
        private void Form4update_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Icon = f1.Icon;
            FileStream verfsrd = File.OpenRead(@"version.ini");
            StreamReader versr = new StreamReader(verfsrd, System.Text.Encoding.Default);
            verstrrd = versr.ReadToEnd();
            versr.Close();
            verfsrd.Close();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkupdate();
            timer1.Enabled = false;
        }
    }
}
