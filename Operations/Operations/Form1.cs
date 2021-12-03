using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please Enter two Numbers");
            else
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text));
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please Enter two Numbers");
            else
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please Enter two Numbers");
            else
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please Enter two Numbers");
            else
            {
                if (textBox2.Text == "0")
                {
                    MessageBox.Show("Denomenator Can't be Zero");
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                else
                    textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text));
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Please Enter two Numbers");
            else
                textBox3.Text = Convert.ToString(Convert.ToInt32(textBox1.Text) % Convert.ToInt32(textBox2.Text));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }
    }
}
