using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JobForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label6.Text = Form1.t;
            label7.Text = Form1.b2;
            label8.Text = Form1.b1;
            label9.Text = Form1.r1;
            label10.Text = Form1.c1;
            label11.Text = Form1.c2;
            label12.Text = Form1.c3;
            label13.Text = Form1.c4;
        }
    }
}
