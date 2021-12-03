using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
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
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Ankit" && textBox2.Text == "123456")
                MessageBox.Show("Login Successfully");
            else if (textBox1.Text == "Ankit" && textBox2.Text != "123456")
                MessageBox.Show("You entered Wrong Password!");
            else if (textBox1.Text != "Ankit" && textBox2.Text == "123456")
                MessageBox.Show("You entered Wrong Username");
            else if (textBox1.Text != "Ankit" && textBox2.Text != "123456")
                MessageBox.Show("Please Enter Valid Username & Password");

        }
    }
}
