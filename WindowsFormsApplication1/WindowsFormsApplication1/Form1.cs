using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int tick1 = 20, tick2 = 7, tick3 = 11, n;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            n = 19;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            label1.Visible = true;
            tick1--;
            label4.Text = Convert.ToString(n);
            label4.Visible = true;
            n--;
            if (tick1 == 0)
            {
                pictureBox1.Visible = false;
                label1.Visible = false;
                pictureBox2.Visible = true;
                label2.Visible = true;
                timer1.Enabled = false;
                tick2 = 7;
                timer2.Enabled = true;
                n = 6;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tick2--;
            label4.Text = Convert.ToString(n);
            n--;
            if (tick2 == 0)
            {
                pictureBox2.Visible = false;
                label2.Visible = false;
                pictureBox3.Visible = true;
                label3.Visible = true;
                timer2.Enabled = false;
                tick3 = 11;
                timer3.Enabled = true;
                n = 10;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tick3--;
            label4.Text = Convert.ToString(n);
            n--;
            if (tick3 == 0)
            {
                pictureBox3.Visible = false;
                label3.Visible = false;
                pictureBox1.Visible = true;
                label1.Visible = true;
                timer3.Enabled = false;
                timer1.Enabled = true;
                n = 19;
                tick1 = 20;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
        }
    }
}

