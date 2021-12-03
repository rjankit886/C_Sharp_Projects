using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CheckNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int z = Convert.ToInt32(textBox1.Text);
            if (z % 2 == 0)
                label2.Text = z + " is Even Number";
            else
                label2.Text = z + " is Odd Number";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int z = Convert.ToInt32(textBox1.Text);
            int i;
            
            if (z == 2 || z == 3)
                label2.Text = z + " is a Prime Number";
            
            for (i = 2; i <= z / 2; i++)
            {
                if (z % i == 0)
                {
                    label2.Text = z + " is not a Prime Number";
                    break;
                }
                else
                    label2.Text = z + " is a Prime Number";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i, backup, fact = 1, a, sum = 0;
            int z = Convert.ToInt32(textBox1.Text);
            backup=z;
            while (z > 0)
            {
                a = z % 10;
                for (i = 1; i <= a; i++)
                    fact *= i;
                sum += fact;
                fact = 1;
                z /= 10;
            }
            if (sum == backup)
                label2.Text = backup + " is a Strong Number";
            else
                label2.Text = backup + " is not a Strong Number";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int backup, a, sum = 0;
            int z = Convert.ToInt32(textBox1.Text);
            backup = z;
            
            while (z > 0)
            {
                a = z % 10;
                sum += a*a*a;
                z /= 10;
            }
            if (sum == backup)
                label2.Text = backup + " is a Armstrong Number";
            else
                label2.Text = backup + " is not a Armstrong Number";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int backup, a, sum = 0;
            int z = Convert.ToInt32(textBox1.Text);
            backup = z;
            while (z > 0)
            {
                a = z % 10;
                sum = sum*10+a;
                z /= 10;
            }
            if (sum == backup)
                label2.Text = backup + " is a Palindrome Number";
            else
                label2.Text = backup + " is not a Palindrome Number";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
    }
}
