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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
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
            textBox7.AutoCompleteCustomSource = source;
            textBox6.AutoCompleteCustomSource = source;
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
    }
}
