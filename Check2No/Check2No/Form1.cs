using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Check2No
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter The Range");
                label3.Text = "";
            }
            else
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (y > x)
                {
                    label3.Text = "";
                    for (int i = x; i <= y; i++)
                    {
                        if (i % 2 == 0)
                            label3.Text += Convert.ToString(i + ", ");
                    }
                }
                else
                {
                    MessageBox.Show("Starting Range Can't be Greater Than End Range");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label3.Text = "";
                    textBox1.Focus();
                }
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter The Range");
                label3.Text = "";
            }
            else
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (y > x)
                {
                    label3.Text = "";
                    for (int i = x; i <= y; i++)
                    {
                        if (i % 2 != 0)
                            label3.Text += Convert.ToString(i + ", ");
                    }
                }
                else
                {
                    MessageBox.Show("Starting Range Can't be Greater Than End Range");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label3.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter The Range");
                label3.Text = "";
            }
            else
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (y > x)
                {
                    label3.Text = "";
                    for (int i = x; i <= y; i++)
                    {
                        if (i<4)
                        {
                            if (i == 2)
                                label3.Text += Convert.ToString(i + ", ");
                            if (i == 3)
                                label3.Text += Convert.ToString(i + ", ");
                        }
                        else
                        {
                            bool isPrime = true;
                            for (int j = 2; j <= i / 2; j++)
                            {
                                if (i % j == 0)
                                {
                                    isPrime = false;
                                    break;
                                }
                                else
                                    isPrime = true;
                            }
                            if(isPrime==true)
                                label3.Text += Convert.ToString(i + ", ");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Starting Range Can't be Greater Than End Range");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label3.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter The Range");
                label3.Text = "";
            }
            else
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (y > x)
                {
                    label3.Text = "";
                    for (int i = x; i <= y; i++)
                    {
                        int backup, fact = 1, a, sum = 0;
                        backup = i;
                        while (backup != 0)
                        {
                            a = backup % 10;
                            for (int j = 1; j <= a; j++)
                                fact *= j;
                            sum += fact;
                            fact = 1;
                            backup /= 10;
                        }
                        if (sum == i)
                            label3.Text += Convert.ToString(i + ", ");
                    }
                }
                else
                {
                    MessageBox.Show("Starting Range Can't be Greater Than End Range");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label3.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter The Range");
                label3.Text = "";
            }
            else
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (y > x)
                {
                    label3.Text = "";
                    for (int i = x; i <= y; i++)
                    {
                        int backup, a, sum = 0;
                        backup = i;
                        while (backup != 0)
                        {
                            a = backup % 10;
                            sum += a*a*a;
                            backup /= 10;
                        }
                        if (sum == i)
                            label3.Text += Convert.ToString(i + ", ");
                    }
                }
                else
                {
                    MessageBox.Show("Starting Range Can't be Greater Than End Range");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label3.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter The Range");
                label3.Text = "";
            }
            else
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (y > x)
                {
                    label3.Text = "";
                    for (int i = x; i <= y; i++)
                    {
                        int backup, a, sum = 0;
                        backup = i;
                        while (backup != 0)
                        {
                            a = backup % 10;
                            sum = sum * 10 + a;
                            backup /= 10;
                        }
                        if (sum == i)
                            label3.Text += Convert.ToString(i + ", ");
                    }
                }
                else
                {
                    MessageBox.Show("Starting Range Can't be Greater Than End Range");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    label3.Text = "";
                    textBox1.Focus();
                }
            }
        }
    }
}
