using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class Form1 : Form
    {
        int buttonClicks = 0;
        Stopwatch stopwatch = new Stopwatch();
        bool seconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonClicks == 0)
            {
                label1.Text = "First Click";
                stopwatch.Start();
                buttonClicks++;
            }
            else
            {
                if (seconds)
                {
                    long s = stopwatch.ElapsedMilliseconds / 1000;
                    label1.Text = s.ToString() + " seconds";
                }
                else
                {
                    long ms = stopwatch.ElapsedMilliseconds;
                    label1.Text = ms.ToString() + " milliseconds";
                }
                stopwatch.Stop();
                stopwatch.Reset();
                stopwatch.Start();
                buttonClicks++;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            seconds = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            seconds = false;
        }
    }
}
