using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentResult
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") && (textBox2.Text == ""))
            {
                MessageBox.Show("Please Enter Student Name & Roll No.");
                textBox1.Focus();
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter Student Name");
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Please Enter Roll No.");
                textBox2.Focus();
            }
            textBox8.Text = Convert.ToString(Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text));
            textBox9.Text = Convert.ToString((Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox5.Text) + Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text))/5);
            if (Convert.ToInt32(textBox9.Text) >= 70)
                textBox10.Text = "A";
            else if (Convert.ToInt32(textBox9.Text) >= 60 && Convert.ToInt32(textBox9.Text) < 70)
                textBox10.Text = "B";
            else if (Convert.ToInt32(textBox9.Text) >= 50 && Convert.ToInt32(textBox9.Text) < 60)
                textBox10.Text = "C";
            else if (Convert.ToInt32(textBox9.Text) >= 45 && Convert.ToInt32(textBox9.Text) < 50)
                textBox10.Text = "D";
            else if (Convert.ToInt32(textBox9.Text) >= 40 && Convert.ToInt32(textBox9.Text) < 45)
                textBox10.Text = "E";
            else
                textBox10.Text = "F";

        }
    }
}
