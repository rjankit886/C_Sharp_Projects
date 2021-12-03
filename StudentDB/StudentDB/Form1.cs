using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentDB
{
    public partial class Form1 : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds;
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ankitDataSet.Ankit' table. You can move, or remove it, as needed.
            this.ankitTableAdapter.Fill(this.ankitDataSet.Ankit);

            string cnn = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = E:\Program\Ankit.accdb";
            con = new OleDbConnection(cnn);
            con.Open();
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cmm = "insert into Ankit(id,name,age,gender,per) values(?,?,?,?,?)";
            cmd = new OleDbCommand(cmm);
            con.Open();
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("?", textBox1.Text);
            cmd.Parameters.AddWithValue("?", textBox2.Text);
            cmd.Parameters.AddWithValue("?", textBox3.Text);
            cmd.Parameters.AddWithValue("?", comboBox1.Text);
            cmd.Parameters.AddWithValue("?", textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Inserted Successfuly", "Message");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmm = "delete from Ankit where id='" + textBox8.Text +"'";
            cmd = new OleDbCommand(cmm, con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
                MessageBox.Show("Data Deleted", "Message");
            else
                MessageBox.Show("Data Not Found!","Information");
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
