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
    public partial class Form4don : Form
    {
        public Form4don()
        {
            InitializeComponent();
        }

        private void Form4don_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Icon = f1.Icon;
        }
    }
}
