using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            radioButton1.Focus();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Put the value in the box","Message");
                textBox1.Focus();
            }
            else
            {
                if (radioButton1.Checked)
                    label2.Text = Convert.ToString((x * 1.8) + 32);
                else if (radioButton2.Checked)
                    label2.Text = Convert.ToString(x + 273.15);
                else if (radioButton3.Checked)
                    label2.Text = Convert.ToString((x - 32) / 1.8);
                else if (radioButton4.Checked)
                    label2.Text = Convert.ToString((x + 459.67) * 5 / 9);
                else if (radioButton5.Checked)
                    label2.Text = Convert.ToString(x - 273.15);
                else if (radioButton6.Checked)
                    label2.Text = Convert.ToString((x * 9 / 5) - 459.67);
            }
        }
    }
}
