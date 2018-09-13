using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitansComic
{
    public partial class Form4download : Form
    {
        public Form4download()
        {
            InitializeComponent();
        }

        private void Form4download_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Icon = f1.Icon;
        }

        private void btn4exp_Click(object sender, EventArgs e)
        {
            string v_OpenFolderPath = Application.StartupPath + "\\Download";
            Process.Start("explorer.exe", v_OpenFolderPath);
            this.Close();
        }
    }
}
