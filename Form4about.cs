using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitansComic
{
    public partial class Form4about : Form
    {
        public Form4about()
        {
            InitializeComponent();
        }

        private void Form4about_Load(object sender, EventArgs e)
        {
            FileStream verfsrd = File.OpenRead(@"version.ini");
            StreamReader versr = new StreamReader(verfsrd, System.Text.Encoding.Default);
            string verstrrd = versr.ReadToEnd();
            versr.Close();
            verfsrd.Close();
            lb4tt.Text = lb4tt.Text + verstrrd;
        }
    }
}
