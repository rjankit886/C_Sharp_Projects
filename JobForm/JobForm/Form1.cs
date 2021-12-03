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
    public partial class Form1 : Form
    {
        public static string t, r1, r2, b1, b2, c1, c2, c3, c4;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            comboBox1.Text = "Select One";
            comboBox2.Text = "Select One";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch!=8)
                e.Handled = true;
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t = textBox1.Text;
            b1 = comboBox1.Text;
            b2 = comboBox2.Text;
            if (radioButton1.Checked)
                r1 = radioButton1.Text;
            if (radioButton2.Checked)
                r1 = radioButton2.Text;
            if(checkBox1.Checked)
                c1=checkBox1.Text;
            if(checkBox2.Checked)
                c2=checkBox2.Text;
            if(checkBox3.Checked)
                c3=checkBox3.Text;
            if (checkBox4.Checked)
                c4 = checkBox4.Text;
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}