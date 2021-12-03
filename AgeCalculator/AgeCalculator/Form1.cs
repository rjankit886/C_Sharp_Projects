using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "DD";
            comboBox2.Text = "MM";
            comboBox3.Text = "YYYY";
            label2.Text = "";
            comboBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        int cd, cm, cy, bd, bm, by, xd, xm, xy;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "DD" || comboBox2.Text == "MM" || comboBox3.Text == "YYYY")
            {
                MessageBox.Show("Please Enter Valid Date");
                comboBox1.Focus();
            }
            else
            {
                bd = Convert.ToInt32(comboBox1.Text);
                by = Convert.ToInt32(comboBox3.Text);

                if (comboBox2.Text == ("JAN"))
                {
                    comboBox2.Text = ("1");
                    bm = Convert.ToInt32(comboBox2.Text);

                }
                else if (comboBox2.Text == ("FEB"))
                {
                    comboBox2.Text = ("2");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("MAR"))
                {
                    comboBox2.Text = ("3");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("APR"))
                {
                    comboBox2.Text = ("4");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("MAY"))
                {
                    comboBox2.Text = ("5");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("JUN"))
                {
                    comboBox2.Text = ("6");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("JUL"))
                {
                    comboBox2.Text = ("7");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("AUG"))
                {
                    comboBox2.Text = ("8");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("SEP"))
                {
                    comboBox2.Text = ("9");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("OCT"))
                {
                    comboBox2.Text = ("10");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("NOV"))
                {
                    comboBox2.Text = ("11");
                    bm = Convert.ToInt32(comboBox2.Text);
                }
                else if (comboBox2.Text == ("DEC"))
                {
                    comboBox2.Text = ("12");
                    bm = Convert.ToInt32(comboBox2.Text);
                }

                DateTime date = DateTime.Now.Date;
                cd = date.Day;
                cm = date.Month;
                cy = date.Year;

                int z = 0;
                if (cd >= bd)
                {
                    xd = cd - bd;
                    if (cm >= bm)
                    {
                        xm = cm - bm;
                        if (cy >= by)
                        {
                            xy = cy - by;
                        }
                        else
                        {
                            MessageBox.Show("Birth date can't be greater than current Date");
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            comboBox3.Text = "";
                            comboBox1.Focus();
                            z++;
                        }
                    }
                    else
                    {
                        cm += 12;
                        xm = cm - bm;
                        cy--;
                        if (cy >= by)
                        {
                            xy = cy - by;
                        }
                        else
                        {
                            MessageBox.Show("Birth date can't be greater than current Date");
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            comboBox3.Text = "";
                            comboBox1.Focus();
                            z++;
                        }
                    }
                }
                else
                {
                    if ((cm == 1) || (cm == 3) || (cm == 5) || (cm == 7) || (cm == 8) || (cm == 10) || (cm == 12))
                    {
                        cd += 31;
                        xd = cd - bd;
                        cm--;
                    }
                    else if ((cm == 4) || (cm == 6) || (cm == 9) || (cm == 11))
                    {
                        cd += 30;
                        xd = cd - bd;
                        cm--;
                    }
                    else
                    {
                        if (cy % 4 == 0)
                        {
                            cd += 29;
                            xd = cd - bd;
                            cm--;
                        }
                        else
                        {
                            cd += 28;
                            xd = cd - bd;
                            cm--;
                        }
                    }
                    if (cm >= bm)
                    {
                        xm = cm - bm;
                        if (cy >= by)
                        {
                            xy = cy - by;
                        }
                        else
                        {
                            MessageBox.Show("Birth date can't be greater than current Date");
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            comboBox3.Text = "";
                            comboBox1.Focus();
                            z++;
                        }
                    }
                    else
                    {
                        cm += 12;
                        xm = cm - bm;
                        cy--;
                        if (cy >= by)
                        {
                            xy = cy - by;
                        }
                        else
                        {
                            MessageBox.Show("Birth date can't be greater than current Date");
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            comboBox3.Text = "";
                            comboBox1.Focus();
                            z++;
                        }
                    }
                }
                if ((cm == 4) || (cm == 6) || (cm == 9) || (cm == 11))
                {
                    if (bd == 31)
                    {
                        MessageBox.Show("Please Enter Valid Date");
                        comboBox1.Text = "";
                        comboBox2.Text = "";
                        comboBox3.Text = "";
                        comboBox1.Focus();
                        z++;
                    }
                }
                else if (bm == 2)
                {
                    if (by % 4 == 0)
                    {
                        if (bd == 30 || bd == 31)
                        {
                            MessageBox.Show("Please Enter Valid Date");
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            comboBox3.Text = "";
                            comboBox1.Focus();
                            z++;
                        }

                    }
                    else
                    {
                        if (bd == 29 || bd == 30 || bd == 31)
                        {
                            MessageBox.Show("Please Enter Valid Date");
                            comboBox1.Text = "";
                            comboBox2.Text = "";
                            comboBox3.Text = "";
                            comboBox1.Focus();
                            z++;
                        }
                    }
                }

                if (z > 0)
                    label2.Text = "";
                else
                    label2.Text = (xy + " Years " + xm + " Months " + xd + " Days");
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}