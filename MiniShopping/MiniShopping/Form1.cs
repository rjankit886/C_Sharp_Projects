using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MiniShopping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            label15.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double l1, l2, l3, l4, l5, a1, a2, a3, a4, a5;
            
            l1=Convert.ToDouble(label10.Text);
            l2=Convert.ToDouble(label11.Text);
            l3=Convert.ToDouble(label12.Text);
            l4=Convert.ToDouble(label13.Text);
            l5=Convert.ToDouble(label14.Text);

            a1=Convert.ToDouble(textBox1.Text);
            a2=Convert.ToDouble(textBox2.Text);
            a3=Convert.ToDouble(textBox3.Text);
            a4=Convert.ToDouble(textBox4.Text);
            a5=Convert.ToDouble(textBox5.Text);

            if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false && checkBox5.Checked == false)
            {
                MessageBox.Show("Please Check Atleast One Item", "Message");
                label15.Text = "";
            }
            else
            {
                if(checkBox1.Checked == true && textBox1.Text == "0")
                {
                    MessageBox.Show("Please Enter Quantity Of the Selected Item");
                    textBox1.Text = "";
                    textBox1.Focus();
                }
                else if (checkBox2.Checked == true && textBox2.Text == "0")
                {
                    MessageBox.Show("Please Enter Quantity Of the Selected Item");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                else if (checkBox3.Checked == true && textBox3.Text == "0")
                {
                    MessageBox.Show("Please Enter Quantity Of the Selected Item");
                    textBox3.Text = "";
                    textBox3.Focus();
                }
                else if (checkBox4.Checked == true && textBox4.Text == "0")
                {
                    MessageBox.Show("Please Enter Quantity Of the Selected Item");
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                else if (checkBox5.Checked == true && textBox5.Text == "0")
                {
                    MessageBox.Show("Please Enter Quantity Of the Selected Item");
                    textBox5.Text = "";
                    textBox5.Focus();
                }
                else
                {
                    label15.Text = "You Have To Pay Rs. " + Convert.ToString((l1 * a1) + (l2 * a2) + (l3 * a3) + (l4 * a4) + (l5 * a5));
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                textBox1.Enabled = true;
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
                textBox2.Enabled = true;
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
                textBox3.Enabled = true;
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
                textBox4.Enabled = true;
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
                textBox5.Enabled = true;
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
