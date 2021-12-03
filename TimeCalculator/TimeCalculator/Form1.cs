using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
            
            a1 = Convert.ToInt32(textBox4.Text);
            a2 = Convert.ToInt32(textBox8.Text);
            b1 = Convert.ToInt32(textBox3.Text);
            b2 = Convert.ToInt32(textBox7.Text);
            c1 = Convert.ToInt32(textBox2.Text);
            c2 = Convert.ToInt32(textBox6.Text);
            d1 = Convert.ToInt32(textBox1.Text);
            d2 = Convert.ToInt32(textBox5.Text);

            if (comboBox1.Text == "+")
            {
                a3 = a1 + a2;
                b3 = b1 + b2;
                c3 = c1 + c2;
                d3 = d1 + d2;

                if (a3 > 60)
                {
                    a3 = a3 % 60;
                    textBox12.Text = Convert.ToString(a3);
                }
                else
                {
                    textBox12.Text = Convert.ToString(a3);
                }
                if (b3 > 60)
                {
                    b3 = b3 + (a3 / 60);
                    b3 = b3 % 60;
                    textBox11.Text = Convert.ToString(b3);
                }
                else
                {
                    b3 = b3 + (a3 / 60);
                    textBox11.Text = Convert.ToString(b3);
                }
                if (c3 > 60)
                {
                    c3 = c3 + (b3 / 60);
                    c3 = c3 % 60;
                    textBox10.Text = Convert.ToString(c3);
                }
                else
                {
                    c3 = c3 + (b3 / 60);
                    textBox10.Text = Convert.ToString(c3);
                }

                d3 = d3 + (c3 / 24);
                textBox9.Text = Convert.ToString(d3);
               
            }
           /* else if (comboBox1.Text == "-")
            {

            }*/
            else
            {
                MessageBox.Show("Please Select a Operator","Message");
                comboBox1.Focus();
            }
        }
    }
}
