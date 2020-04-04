using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chronometer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void makeActive(string type)
        {
            var activeColor = System.Drawing.Color.Black;
            var passiveColor = System.Drawing.Color.White;
            if (type == "start")
            {
                this.btnStart.ForeColor = activeColor;
                this.button1.ForeColor = passiveColor;
                this.btnFinish.ForeColor = passiveColor;
            }
            else if (type == "pause")
            {
                this.btnStart.ForeColor = passiveColor;
                this.button1.ForeColor = activeColor;
                this.btnFinish.ForeColor = passiveColor;
            } else if (type == "finish")
            {
                this.btnStart.ForeColor = passiveColor;
                this.button1.ForeColor = activeColor;
                this.btnFinish.ForeColor = activeColor;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.makeActive("start");
            this.timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBarSecond.Increment(1);
            int second = this.progressBarSecond.Value;
            if (second == 60)
            {
                txtSecond.Text = 0.ToString();
                int minute = Int32.Parse(txtMinute.Text);
                minute += 1;
                txtMinute.Text = minute.ToString();
                this.progressBarSecond.Value = 0;
                this.progressBarMinute.Increment(1);
            }
            else
            {
               txtSecond.Text = second.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.makeActive("pause");
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.makeActive("finish");
            this.timer1.Stop();
            this.progressBarMinute.Value = 0;
            this.progressBarSecond.Value = 0;
            this.txtMinute.Text = 0.ToString();
            this.txtSecond.Text = 0.ToString();
        }
    }
}
