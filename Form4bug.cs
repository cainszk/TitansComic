using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TitansComic
{
    public partial class Form4bug : Form
    {
        public Form4bug()
        {
            InitializeComponent();
        }
        private void btn4issue_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/cainszk/TitansComic/issues"); 
        }
        private void btn4mail_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:shenzhoukai@aliyun.com");
        }
    }
}
