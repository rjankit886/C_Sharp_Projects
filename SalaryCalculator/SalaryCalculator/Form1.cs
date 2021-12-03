using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalaryCalculator
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
            textBox3.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do You Really Want To Exit ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
                MessageBox.Show("Please Fill the given entry Box", "Message");
            else if(textBox1.Text==""||textBox2.Text=="")
                MessageBox.Show("Please Fill Full profile of Employee", "Message");
            else if (textBox3.Text == "")
                MessageBox.Show("Please Enter the Basic Salary", "Message");
            else
            {
                int x = Convert.ToInt32(textBox3.Text);
                if (x <= 5000)
                    label12.Text = Convert.ToString(500);
                else
                    label12.Text = Convert.ToString(1000);
                
                label13.Text = Convert.ToString(x * 135 / 100);
                label14.Text = Convert.ToString(x * 20 / 100);
                label15.Text = Convert.ToString(x + Convert.ToInt32(label12.Text) + Convert.ToInt32(label13.Text) + Convert.ToInt32(label14.Text));
                label16.Text = Convert.ToString(Convert.ToInt32(label15.Text) * 10.2 / 100);
                label17.Text = Convert.ToString(Convert.ToInt32(label15.Text) * 5 / 100);
                label18.Text = Convert.ToString(200);
                label19.Text = Convert.ToString(Convert.ToInt32(label15.Text) - Convert.ToInt32(label16.Text) - Convert.ToInt32(label17.Text) - Convert.ToInt32(label18.Text));
            }
        }
    }
}
