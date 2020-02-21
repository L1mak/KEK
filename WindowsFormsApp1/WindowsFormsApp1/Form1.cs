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
            if (Properties.Settings.Default.TimeoutGlobal > DateTime.UtcNow)
            {
                button1.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            connect.Open();
            SqlCommand auth = new SqlCommand("SELECT * FROM dbo.auth WHERE login  = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'", connect);
            SqlDataReader sqr = auth.ExecuteReader();

            if (sqr.HasRows)
            {
                MessageBox.Show("Вы успешно авторизовались");
                Form2 fm = new Form2();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Попробуйте снова");
                Properties.Settings.Default.co++;
                if (Properties.Settings.Default.co > 2)
                {
                    Properties.Settings.Default.TimeoutGlobal = DateTime.UtcNow.AddMinutes(1);
                    button1.Enabled = false;
                }
            }
            Properties.Settings.Default.Save();
            connect.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           if (Properties.Settings.Default.TimeoutGlobal < DateTime.UtcNow && button1.Enabled == false)
           {
                Properties.Settings.Default.co = 0;
                button1.Enabled = true; 
           }
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {

        }
    }
}
