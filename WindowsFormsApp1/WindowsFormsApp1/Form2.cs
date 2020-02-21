using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        public SqlConnection connect = new SqlConnection("Data source = 303-9\\MSSQLSERVERRR; Initial Catalog = BAZA; Integrated Security = true;");

        public Form2()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            var source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
            {
                "Уфа", "Анаконда", "Артем", "Москва", "Савва", "Артур",
            });
            City1.AutoCompleteCustomSource = source;
            City2.AutoCompleteCustomSource = source;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.afk < DateTime.UtcNow)
            {
                Form1 fm = (Form1)Application.OpenForms[0];
                fm.Show();
                this.Close();
            }
        }

        private void Form2_Deactivate(object sender, EventArgs e)
        {
            Properties.Settings.Default.afk = DateTime.UtcNow.AddMinutes(1);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFile.DefaultExt = "Img";
            openFile.Filter = "image files (*.jpg;*.png)|*.jpg;*.png";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                var myImmage = Image.FromFile(openFile.FileName);
                FileInfo info = new FileInfo(openFile.FileName);
                if (((float)myImmage.Width / (float)myImmage.Height == 0.75f) && (info.Length <= 2097152))
                {
                    pictureBox1.Image = Image.FromFile(openFile.FileName);
                }
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = "";
            string surname = "";
            string middlename = "";
            string job = "";
            string JobName = "";
            string Address = "";
            string City = "";
            string Email = "";
            string Phone = "";
            connect.Open();
            SqlCommand auth = new SqlCommand("INSERT INRO dbo.drivers([name], [surname], [middlename], [passport_serial], [passport_number], [postcode], [address], [address_life], [company], [job_name], [phone], [description]) VALUES(");
        }
    }
}
