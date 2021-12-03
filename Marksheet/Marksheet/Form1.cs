using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Marksheet
{
    public partial class Form1 : Form
    {
        int x=0, y=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8 && ch!=32)
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetterOrDigit(ch) && ch != 8)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
                e.Handled = true;
        }
        
        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox3.Text);
            textBox17.Text = Convert.ToString(x + y);
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            y = Convert.ToInt32(textBox10.Text);
            textBox17.Text = Convert.ToString(x + y);
        }
    }
}
