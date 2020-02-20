using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection connect = new SqlConnection("Data source = 303-9\\MSSQLSERVERRR; Initial Catalog = BAZA; Integrated Security = true;");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand auth = new SqlCommand($"SELECT * FROM BAZA WHERE login  = '{textBox1.Text}' AND password = '{textBox2.Text}'", connect);
            if (auth != null) MessageBox.Show("OK");

        }
    }
}
