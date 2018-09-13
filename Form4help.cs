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
    }
}
