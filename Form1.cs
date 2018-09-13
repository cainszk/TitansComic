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
        string url;//总图片jpg地址字符串
        string picurl;//图片地址字符串
        string epurl;//章节地址字符串
        string epname;//章节名字字符串
        int epnum;//章节号数值
        int pgnum;//页码数值
        string lstx;//分割后上一个章节名字字符串
        string x;//分割后获得的章节名字字符串
        string y;//分割后获得的页码字符串
        string str4pgnum;//页码字符串
        string str4epnum;//章节号字符串
        void str4num()
        {
            
            str4epnum = epnum.ToString();
            if (str4epnum.Length < 8)
            {
                str4epnum = "0" + str4epnum;
            }
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
            url = string.Format(picurl + ".jpg");
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
                MessageBox.Show("该错误存在以下可能性：\r\n1. 图片无法获取，请检测您的网络连接。\r\n2. 漫画已经观看到最后一页，请选择下一话。", "错误");
            }

           switch (epname)
                    {
                        case "ep001":
                            lb4num.Text = "第1话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep002":
                            lb4num.Text = "第2话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep003":
                            lb4num.Text = "第3话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep004":
                            lb4num.Text = "第4话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep005":
                            lb4num.Text = "第5话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep006":
                            lb4num.Text = "第6话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep007":
                            lb4num.Text = "第7话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep008":
                            lb4num.Text = "第8话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep009":
                            lb4num.Text = "第9话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep010":
                            lb4num.Text = "第10话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep011":
                            lb4num.Text = "第11话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep012":
                            lb4num.Text = "第12话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep013":
                            lb4num.Text = "第13话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep014":
                            lb4num.Text = "第14话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep015":
                            lb4num.Text = "第15话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep016":
                            lb4num.Text = "第16话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep017":
                            lb4num.Text = "第17话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep018":
                            lb4num.Text = "第18话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep019":
                            lb4num.Text = "第19话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep020":
                            lb4num.Text = "第20话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep021":
                            lb4num.Text = "第21话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep022":
                            lb4num.Text = "第22话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep023":
                            lb4num.Text = "第23话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep024":
                            lb4num.Text = "第24话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep025":
                            lb4num.Text = "第25话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep026":
                            lb4num.Text = "第26话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep027":
                            lb4num.Text = "第27话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep028":
                            lb4num.Text = "第28话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep029":
                            lb4num.Text = "第29话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep030":
                            lb4num.Text = "第30话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep031":
                            lb4num.Text = "第31话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep032":
                            lb4num.Text = "第32话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep033":
                            lb4num.Text = "第33话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep034":
                            lb4num.Text = "第34话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep035":
                            lb4num.Text = "第35话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep036":
                            lb4num.Text = "第36话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep037":
                            lb4num.Text = "第37话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep038":
                            lb4num.Text = "第38话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep039":
                            lb4num.Text = "第39话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep040":
                            lb4num.Text = "第40话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep041":
                            lb4num.Text = "第41话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep042":
                            lb4num.Text = "第42话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep043":
                            lb4num.Text = "第43话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep044":
                            lb4num.Text = "第44话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep045":
                            lb4num.Text = "第45话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep046":
                            lb4num.Text = "第46话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep047":
                            lb4num.Text = "第47话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep048":
                            lb4num.Text = "第48话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep049":
                            lb4num.Text = "第49话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep050":
                            lb4num.Text = "第50话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep051":
                            lb4num.Text = "第51话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep052":
                            lb4num.Text = "第52话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep053":
                            lb4num.Text = "第53话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep054":
                            lb4num.Text = "第54话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep055":
                            lb4num.Text = "第55话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep056":
                            lb4num.Text = "第56话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep057":
                            lb4num.Text = "第57话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep058":
                            lb4num.Text = "第58话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep059":
                            lb4num.Text = "第59话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep060":
                            lb4num.Text = "第60话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep061":
                            lb4num.Text = "第61话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep062":
                            lb4num.Text = "第62话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep063":
                            lb4num.Text = "第63话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep064":
                            lb4num.Text = "第64话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep065":
                            lb4num.Text = "第65话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep066":
                            lb4num.Text = "第66话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep067":
                            lb4num.Text = "第67话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep068":
                            lb4num.Text = "第68话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep069":
                            lb4num.Text = "第69话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep070":
                            lb4num.Text = "第70话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep071":
                            lb4num.Text = "第71话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep072":
                            lb4num.Text = "第72话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep073":
                            lb4num.Text = "第73话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep074":
                            lb4num.Text = "第74话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep075":
                            lb4num.Text = "第75话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep076":
                            lb4num.Text = "第76话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep077":
                            lb4num.Text = "第77话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep078":
                            lb4num.Text = "第78话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep079":
                            lb4num.Text = "第79话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep080":
                            lb4num.Text = "第80话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep081":
                            lb4num.Text = "第81话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep082":
                            lb4num.Text = "第82话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep083":
                            lb4num.Text = "第83话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep084":
                            lb4num.Text = "第84话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep085":
                            lb4num.Text = "第85话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep086":
                            lb4num.Text = "第86话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep087":
                            lb4num.Text = "第87话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep088":
                            lb4num.Text = "第88话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep089":
                            lb4num.Text = "第89话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep090":
                            lb4num.Text = "第90话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep091":
                            lb4num.Text = "第91话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep092":
                            lb4num.Text = "第92话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep093":
                            lb4num.Text = "第93话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep094":
                            lb4num.Text = "第94话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep095":
                            lb4num.Text = "第95话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep096":
                            lb4num.Text = "第96话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep097":
                            lb4num.Text = "第97话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep098":
                            lb4num.Text = "第98话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep099":
                            lb4num.Text = "第99话，第" + pgnum.ToString() + "页";
                            break;
                        case "ep100":
                            lb4num.Text = "第100话，第" + pgnum.ToString() + "页";
                            break;
                        ////////////////////////////正传分割线//////////////////////////
                        case "tb01":
                            lb4num.Text = "特别篇·利威尔士兵长，第" + pgnum.ToString() + "页";
                            break;
                        case "tb02":
                            lb4num.Text = "特别篇·伊尔泽的笔记，第" + pgnum.ToString() + "页";
                            break;
                        case "sg":
                            lb4num.Text = "四格篇，第" + pgnum.ToString() + "页";
                            break;
                        case "qz0":
                            lb4num.Text = "BeforeTheFall·序章，第" + pgnum.ToString() + "页";
                            break;
                        case "wz0":
                            lb4num.Text = "无悔的抉择·序幕，第" + pgnum.ToString() + "页";
                            break;
                        case "wz01":
                            lb4num.Text = "无悔的抉择·第1话，第" + pgnum.ToString() + "页";
                            break;
                        case "wz02":
                            lb4num.Text = "无悔的抉择·第2话，第" + pgnum.ToString() + "页";
                            break;
                        case "wz03":
                            lb4num.Text = "无悔的抉择·第3话，第" + pgnum.ToString() + "页";
                            break;

            }

            txt4pg.Text = pgnum.ToString();
        }
        void seeinit()
        {
            pgnum = 1;
            see();
        }
        public void DownloadImage(string durl, string path)
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(durl);
            req.ServicePoint.Expect100Continue = false;
            req.Method = "GET";
            req.KeepAlive = true;
            req.ContentType = "image/*";
            HttpWebResponse rsp = (HttpWebResponse)req.GetResponse();
            System.IO.Stream stream = null;
            try
            {
                // 以字符流的方式读取HTTP响应
                stream = rsp.GetResponseStream();
                Image.FromStream(stream).Save(path);
            }
            finally
            {
                // 释放资源
                if (stream != null) stream.Close();
                if (rsp != null) rsp.Close();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream verfsrd = File.OpenRead(@"version.ini");
            StreamReader versr = new StreamReader(verfsrd, System.Text.Encoding.Default);
            string verstrrd = versr.ReadToEnd();
            versr.Close();
            verfsrd.Close();
            this.Text = this.Text + verstrrd;
            lb4tt.Text= lb4tt.Text + verstrrd;
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
                    case "ep003":
                        lstx = "第3话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123448;
                        break;
                    case "ep004":
                        lstx = "第4话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123500;
                        break;
                    case "ep005":
                        lstx = "第5话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123514;
                        break;
                    case "ep006":
                        lstx = "第6话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123527;
                        break;
                    case "ep007":
                        lstx = "第7话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123539;
                        break;
                    case "ep008":
                        lstx = "第8话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123552;
                        break;
                    case "ep009":
                        lstx = "第9话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123606;
                        break;
                    case "ep010":
                        lstx = "第10话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123619;
                        break;
                    case "ep011":
                        lstx = "第11话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123633;
                        break;
                    case "ep012":
                        lstx = "第12话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123647;
                        break;
                    case "ep013":
                        lstx = "第13话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123700;
                        break;
                    case "ep014":
                        lstx = "第14话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123712;
                        break;
                    case "ep015":
                        lstx = "第15话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123726;
                        break;
                    case "ep016":
                        lstx = "第16话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123739;
                        break;
                    case "ep017":
                        lstx = "第17话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123751;
                        break;
                    case "ep018":
                        lstx = "第18话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123804;
                        break;
                    case "ep019":
                        lstx = "第19话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123816;
                        break;
                    case "ep020":
                        lstx = "第20话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123830;
                        break;
                    case "ep021":
                        lstx = "第21话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123842;
                        break;
                    case "ep022":
                        lstx = "第22话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123856;
                        break;
                    case "ep023":
                        lstx = "第23话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123909;
                        break;
                    case "ep024":
                        lstx = "第24话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123921;
                        break;
                    case "ep025":
                        lstx = "第25话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123934;
                        break;
                    case "ep026":
                        lstx = "第26话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17123948;
                        break;
                    case "ep027":
                        lstx = "第27话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124000;
                        break;
                    case "ep028":
                        lstx = "第28话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124014;
                        break;
                    case "ep029":
                        lstx = "第29话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124027;
                        break;
                    case "ep030":
                        lstx = "第30话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124039;
                        break;
                    case "ep031":
                        lstx = "第31话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124053;
                        break;
                    case "ep032":
                        lstx = "第32话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124106;
                        break;
                    case "ep033":
                        lstx = "第33话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124119;
                        break;
                    case "ep034":
                        lstx = "第34话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124134;
                        break;
                    case "ep035":
                        lstx = "第35话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124147;
                        break;
                    case "ep036":
                        lstx = "第36话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124202;
                        break;
                    case "ep037":
                        lstx = "第37话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124215;
                        break;
                    case "ep038":
                        lstx = "第38话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124227;
                        break;
                    case "ep039":
                        lstx = "第39话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124239;
                        break;
                    case "ep040":
                        lstx = "第40话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124254;
                        break;
                    case "ep041":
                        lstx = "第41话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124307;
                        break;
                    case "ep042":
                        lstx = "第42话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124320;
                        break;
                    case "ep043":
                        lstx = "第43话";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124334;
                        break;
                    case "ep044":
                        lstx = "第44话";
                        epurl = "http://p17.xiaoshidi.net/2013/04/";
                        epnum = 10190330;
                        break;
                    case "ep045":
                        lstx = "第45话";
                        epurl = "http://p17.xiaoshidi.net/2013/05/";
                        epnum = 15114007;
                        break;
                    case "ep046":
                        lstx = "第46话";
                        epurl = "http://p17.xiaoshidi.net/2013/06/";
                        epnum = 07081652;
                        break;
                    case "ep047":
                        lstx = "第47话";
                        epurl = "http://p17.xiaoshidi.net/2013/07/";
                        epnum = 07125307;
                        break;
                    case "ep048":
                        lstx = "第48话";
                        epurl = "http://p17.xiaoshidi.net/2013/08/";
                        epnum = 08005021;
                        break;
                    case "ep049":
                        lstx = "第49话";
                        epurl = "http://p17.xiaoshidi.net/2013/09/";
                        epnum = 06083445;
                        break;
                    case "ep050":
                        lstx = "第50话";
                        epurl = "http://p17.xiaoshidi.net/2013/10/";
                        epnum = 05124248;
                        break;
                    case "ep051":
                        lstx = "第51话";
                        epurl = "http://p17.xiaoshidi.net/2013/11/";
                        epnum = 08000023;
                        break;
                    case "ep052":
                        lstx = "第52话";
                        epurl = "http://p17.xiaoshidi.net/2013/12/";
                        epnum = 06133739;
                        break;
                    case "ep053":
                        lstx = "第53话";
                        epurl = "http://p17.xiaoshidi.net/2014/01/";
                        epnum = 07111156;
                        break;
                    case "tb01":
                        lstx = "特别篇·利威尔士兵长";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124346;
                        break;
                    case "tb02":
                        lstx = "特别篇·伊尔泽的笔记";
                        epurl = "http://p17.xiaoshidi.net/2013/03/";
                        epnum = 17124359;
                        break;
                    case "sg":
                        lstx = "四格篇";
                        epurl = "http://p17.xiaoshidi.net/2013/06/";
                        epnum = 17211652;
                        break;
                    case "qz0":
                        lstx = "BeforeTheFall·序章";
                        epurl = "http://p17.xiaoshidi.net/2013/09/";
                        epnum = 02233922;
                        break;
                    case "wz0":
                        lstx = "无悔的抉择·序幕";
                        epurl = "http://p17.xiaoshidi.net/2013/09/";
                        epnum = 29140411;
                        break;
                    case "wz01":
                        lstx = "无悔的抉择·01";
                        epurl = "http://p17.xiaoshidi.net/2013/11/";
                        epnum = 30134321;
                        break;
                    case "wz02":
                        lstx = "无悔的抉择·02";
                        epurl = "http://p17.xiaoshidi.net/2013/12/";
                        epnum = 28120751;
                        break;
                    case "wz03":
                        lstx = "无悔的抉择·03";
                        epurl = "http://p17.xiaoshidi.net/2014/02/";
                        epnum = 01173759;
                        break;

                }
                lb4history.Text = "上次看到：" + lstx + "，第" + y + "页";
                pgnum = int.Parse(y);
                see();
            }
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
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W| e.KeyCode == Keys.A)
            {
                lastpage();
            }
            if (e.KeyCode == Keys.S | e.KeyCode == Keys.D)
            {
                nextpage();
            }

        }
        private void btn4gopg_Click(object sender, EventArgs e)
        {
            pgnum= int.Parse(txt4pg.Text);
            see();
        }
        private void txt4pg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))//如果不是输入数字就不让输入
            {
                 e.Handled = true;
            }
        }
        private void txt4pg_TextChanged(object sender, EventArgs e)
        {
            int iMax = 100;//首先设置上限值
             if (txt4pg.Text != null && txt4pg.Text != "")//判断TextBox的内容不为空，如果不判断会导致后面的非数字对比异常
             {
                 if (int.Parse(txt4pg.Text) > iMax)//num就是传进来的值,如果大于上限（输入的值），那就强制为上限-1，或者就是上限值？
                 {
                     txt4pg.Text = (iMax - 1).ToString();
                 }
             }
        }
        private void txt4pg_Click(object sender, EventArgs e)
        {
            txt4pg.Text = "";
        }
        private void btn4update_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cainszk/TitansComic/releases");
        }
        private void btn4tur_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cainszk.com/index.php/archives/5/");
        }
        private void btn4blog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.cainszk.com");
        }
        private void btn4001_Click(object sender, EventArgs e)
        {
            epname = "ep001";
            epnum = 17123332;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4002_Click(object sender, EventArgs e)
        {
            epname = "ep002";
            epnum = 17123435;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4003_Click(object sender, EventArgs e)
        {
            epname = "ep003";
            epnum = 17123448;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4004_Click(object sender, EventArgs e)
        {
            epname = "ep004";
            epnum = 17123500;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4005_Click(object sender, EventArgs e)
        {
            epname = "ep005";
            epnum = 17123514;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4006_Click(object sender, EventArgs e)
        {
            epname = "ep006";
            epnum = 17123527;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4007_Click(object sender, EventArgs e)
        {
            epname = "ep007";
            epnum = 17123539;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4008_Click(object sender, EventArgs e)
        {
            epname = "ep008";
            epnum = 17123552;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4009_Click(object sender, EventArgs e)
        {
            epname = "ep009";
            epnum = 17123606;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4010_Click(object sender, EventArgs e)
        {
            epname = "ep010";
            epnum = 17123619;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4011_Click(object sender, EventArgs e)
        {
            epname = "ep011";
            epnum = 17123633;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4012_Click(object sender, EventArgs e)
        {
            epname = "ep012";
            epnum = 17123647;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4013_Click(object sender, EventArgs e)
        {
            epname = "ep013";
            epnum = 17123700;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4014_Click(object sender, EventArgs e)
        {
            epname = "ep014";
            epnum = 17123712;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4015_Click(object sender, EventArgs e)
        {
            epname = "ep015";
            epnum = 17123726;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4016_Click(object sender, EventArgs e)
        {
            epname = "ep016";
            epnum = 17123739;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4017_Click(object sender, EventArgs e)
        {
            epname = "ep017";
            epnum = 17123751;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4018_Click(object sender, EventArgs e)
        {
            epname = "ep018";
            epnum = 17123804;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4019_Click(object sender, EventArgs e)
        {
            epname = "ep019";
            epnum = 17123816;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4020_Click(object sender, EventArgs e)
        {
            epname = "ep020";
            epnum = 17123830;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4021_Click(object sender, EventArgs e)
        {
            epname = "ep021";
            epnum = 17123842;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4022_Click(object sender, EventArgs e)
        {
            epname = "ep022";
            epnum = 17123856;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4023_Click(object sender, EventArgs e)
        {
            epname = "ep023";
            epnum = 17123909;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4024_Click(object sender, EventArgs e)
        {
            epname = "ep024";
            epnum = 17123921;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4025_Click(object sender, EventArgs e)
        {
            epname = "ep025";
            epnum = 17123934;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4026_Click(object sender, EventArgs e)
        {
            epname = "ep026";
            epnum = 17123948;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4027_Click(object sender, EventArgs e)
        {
            epname = "ep027";
            epnum = 17124000;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4028_Click(object sender, EventArgs e)
        {
            epname = "ep028";
            epnum = 17124014;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4029_Click(object sender, EventArgs e)
        {
            epname = "ep029";
            epnum = 17124027;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4030_Click(object sender, EventArgs e)
        {
            epname = "ep030";
            epnum = 17124039;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4031_Click(object sender, EventArgs e)
        {
            epname = "ep031";
            epnum = 17124053;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4032_Click(object sender, EventArgs e)
        {
            epname = "ep032";
            epnum = 17124106;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4033_Click(object sender, EventArgs e)
        {
            epname = "ep033";
            epnum = 17124119;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4034_Click(object sender, EventArgs e)
        {
            epname = "ep034";
            epnum = 17124134;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4035_Click(object sender, EventArgs e)
        {
            epname = "ep035";
            epnum = 17124147;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4036_Click(object sender, EventArgs e)
        {
            epname = "ep036";
            epnum = 17124202;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4037_Click(object sender, EventArgs e)
        {
            epname = "ep037";
            epnum = 17124215;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4038_Click(object sender, EventArgs e)
        {
            epname = "ep038";
            epnum = 17124227;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4039_Click(object sender, EventArgs e)
        {
            epname = "ep039";
            epnum = 17124239;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4040_Click(object sender, EventArgs e)
        {
            epname = "ep040";
            epnum = 17124254;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4041_Click(object sender, EventArgs e)
        {
            epname = "ep041";
            epnum = 17124307;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4042_Click(object sender, EventArgs e)
        {
            epname = "ep042";
            epnum = 17124320;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4043_Click(object sender, EventArgs e)
        {
            epname = "ep043";
            epnum = 17124334;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4044_Click(object sender, EventArgs e)
        {
            epname = "ep044";
            epnum = 10190330;
            epurl = "http://p17.xiaoshidi.net/2013/04/";
            seeinit();
        }
        private void btn4045_Click(object sender, EventArgs e)
        {
            epname = "ep045";
            epnum = 15114007;
            epurl = "http://p17.xiaoshidi.net/2013/05/";
            seeinit();
        }
        private void btn4046_Click(object sender, EventArgs e)
        {
            epname = "ep046";
            epnum = 07081652;
            epurl = "http://p17.xiaoshidi.net/2013/06/";
            seeinit();
        }
        private void btn4047_Click(object sender, EventArgs e)
        {
            epname = "ep047";
            epnum = 07125307;
            epurl = "http://p17.xiaoshidi.net/2013/07/";
            seeinit();
        }
        private void btn4048_Click(object sender, EventArgs e)
        {
            epname = "ep048";
            epnum = 08005021;
            epurl = "http://p17.xiaoshidi.net/2013/08/";
            seeinit();
        }
        private void btn4049_Click(object sender, EventArgs e)
        {
            epname = "ep049";
            epnum = 06083445;
            epurl = "http://p17.xiaoshidi.net/2013/09/";
            seeinit();
        }
        private void btn4050_Click(object sender, EventArgs e)
        {
            epname = "ep050";
            epnum = 05124248;
            epurl = "http://p17.xiaoshidi.net/2013/10/";
            seeinit();
        }
        private void btn4051_Click(object sender, EventArgs e)
        {
            epname = "ep051";
            epnum = 08000023;
            epurl = "http://p17.xiaoshidi.net/2013/11/";
            seeinit();
        }
        private void btn4052_Click(object sender, EventArgs e)
        {
            epname = "ep052";
            epnum = 06133739;
            epurl = "http://p17.xiaoshidi.net/2013/12/";
            seeinit();
        }
        private void btn4053_Click(object sender, EventArgs e)
        {
            epname = "ep053";
            epnum = 07111156;
            epurl = "http://p17.xiaoshidi.net/2014/01/";
            seeinit();
        }
        private void btn4tb1_Click(object sender, EventArgs e)
        {
            epname = "tb01";
            epnum = 17124346;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4tb2_Click(object sender, EventArgs e)
        {
            epname = "tb02";
            epnum = 17124359;
            epurl = "http://p17.xiaoshidi.net/2013/03/";
            seeinit();
        }
        private void btn4sg_Click(object sender, EventArgs e)
        {
            epname = "sg";
            epnum = 17211652;
            epurl = "http://p17.xiaoshidi.net/2013/06/";
            seeinit();
        }
        private void btn4qz0_Click(object sender, EventArgs e)
        {
            epname = "qz0";
            epnum = 02233922;
            epurl = "http://p17.xiaoshidi.net/2013/09/";
            seeinit();
        }
        private void btn4wz0_Click(object sender, EventArgs e)
        {
            epname = "wz0";
            epnum = 29140411;
            epurl = "http://p17.xiaoshidi.net/2013/09/";
            seeinit();
        }
        private void btn4wz1_Click(object sender, EventArgs e)
        {
            epname = "wz01";
            epnum = 30134321;
            epurl = "http://p17.xiaoshidi.net/2013/11/";
            seeinit();
        }
        private void btn4wz2_Click(object sender, EventArgs e)
        {
            epname = "wz02";
            epnum = 28120751;
            epurl = "http://p17.xiaoshidi.net/2013/12/";
            seeinit();
        }
        private void btn4wz3_Click(object sender, EventArgs e)
        {
            epname = "wz03";
            epnum = 01173759;
            epurl = "http://p17.xiaoshidi.net/2014/02/";
            seeinit();
        }
        private void txt4pg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt4pg.Text != "")
                {
                    pgnum = int.Parse(txt4pg.Text);
                    see();
                }
                else
                {
                    see();
                }
            }
        }
        private void btn4dl_Click(object sender, EventArgs e)
        {
            try
            {
                DownloadImage(url, Application.StartupPath+"/Download/"+lb4num.Text+".jpg");
                Form4download f4dl = new Form4download();
                f4dl.Show();
            }
            catch
            {
                MessageBox.Show("该错误存在以下可能性：\r\n1. 图片无法下载，请检测您的网络连接。\r\n2. 保存目录没有写入权限，请将本程序放在非系统盘再运行。", "错误");
            }
        }
    }
}
