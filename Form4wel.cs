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
    public partial class Form4wel : Form
    {
        int counter = 0;
        private double mOpacity = 0;
        public Form4wel()
        {
            InitializeComponent();
            this.Opacity = this.mOpacity;
        }

        private void Form4wel_Load(object sender, EventArgs e)
        {
            this.timerX.Start();
            this.timerX.Interval = 10000;
        }

        private void timerX_Tick(object sender, EventArgs e)
        {
                this.Close();
        }

        private void Form4wel_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.timerX.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter += 1;
            if (mOpacity < 1)
            {
                mOpacity += 0.05;
                this.Opacity = mOpacity;
            }
            else
            {
                if (counter > 250)
                {
                    if (mOpacity > 0)
                    {
                        this.Opacity -= 0.05;
                    }
                }
            }
        }
    }
}
