namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Middlename = new System.Windows.Forms.TextBox();
            this.Passport_Serial = new System.Windows.Forms.TextBox();
            this.City2 = new System.Windows.Forms.TextBox();
            this.City1 = new System.Windows.Forms.TextBox();
            this.Job = new System.Windows.Forms.TextBox();
            this.Job_name = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Address1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Address2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Passport_number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(607, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 59);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Индетификатор (GUID)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Адрес регистрации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Адрес проживания";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Место работы";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Должность";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(366, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Мобильный телефон";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(186, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Паспорт (серия и номер)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(366, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "e-mail";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(562, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Фотография";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(366, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Замечания";
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(28, 42);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(119, 20);
            this.Id.TabIndex = 15;
            // 
            // Surname
            // 
            this.Surname.Location = new System.Drawing.Point(28, 83);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(119, 20);
            this.Surname.TabIndex = 16;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(28, 122);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(119, 20);
            this.Name.TabIndex = 17;
            // 
            // Middlename
            // 
            this.Middlename.Location = new System.Drawing.Point(28, 161);
            this.Middlename.Name = "Middlename";
            this.Middlename.Size = new System.Drawing.Size(119, 20);
            this.Middlename.TabIndex = 18;
            // 
            // Passport_Serial
            // 
            this.Passport_Serial.Location = new System.Drawing.Point(189, 161);
            this.Passport_Serial.Name = "Passport_Serial";
            this.Passport_Serial.Size = new System.Drawing.Size(119, 20);
            this.Passport_Serial.TabIndex = 19;
            // 
            // City2
            // 
            this.City2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.City2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.City2.Location = new System.Drawing.Point(322, 264);
            this.City2.Name = "City2";
            this.City2.Size = new System.Drawing.Size(119, 20);
            this.City2.TabIndex = 20;
            // 
            // City1
            // 
            this.City1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.City1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.City1.Location = new System.Drawing.Point(29, 264);
            this.City1.Name = "City1";
            this.City1.Size = new System.Drawing.Size(119, 20);
            this.City1.TabIndex = 21;
            // 
            // Job
            // 
            this.Job.Location = new System.Drawing.Point(189, 78);
            this.Job.Name = "Job";
            this.Job.Size = new System.Drawing.Size(119, 20);
            this.Job.TabIndex = 22;
            // 
            // Job_name
            // 
            this.Job_name.Location = new System.Drawing.Point(189, 122);
            this.Job_name.Name = "Job_name";
            this.Job_name.Size = new System.Drawing.Size(119, 20);
            this.Job_name.TabIndex = 23;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(369, 36);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(119, 20);
            this.Phone.TabIndex = 24;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(369, 75);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(119, 20);
            this.Email.TabIndex = 25;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(369, 114);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(119, 20);
            this.Description.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(565, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(363, 161);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(198, 31);
            this.label14.TabIndex = 28;
            this.label14.Text = "ТЫК СЮДА ->";
            // 
            // Address1
            // 
            this.Address1.Location = new System.Drawing.Point(154, 264);
            this.Address1.Name = "Address1";
            this.Address1.Size = new System.Drawing.Size(119, 20);
            this.Address1.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Город";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(162, 238);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Точный адрес";
            // 
            // Address2
            // 
            this.Address2.Location = new System.Drawing.Point(447, 264);
            this.Address2.Name = "Address2";
            this.Address2.Size = new System.Drawing.Size(119, 20);
            this.Address2.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(464, 238);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(78, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Точный адрес";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(328, 238);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 33;
            this.label18.Text = "Город";
            // 
            // Passport_number
            // 
            this.Passport_number.Location = new System.Drawing.Point(189, 187);
            this.Passport_number.Name = "Passport_number";
            this.Passport_number.Size = new System.Drawing.Size(119, 20);
            this.Passport_number.TabIndex = 35;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Passport_number);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Address2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Address1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Job_name);
            this.Controls.Add(this.Job);
            this.Controls.Add(this.City1);
            this.Controls.Add(this.City2);
            this.Controls.Add(this.Passport_Serial);
            this.Controls.Add(this.Middlename);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Deactivate += new System.EventHandler(this.Form2_Deactivate);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Surname;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Middlename;
        private System.Windows.Forms.TextBox Passport_Serial;
        private System.Windows.Forms.TextBox City2;
        private System.Windows.Forms.TextBox City1;
        private System.Windows.Forms.TextBox Job;
        private System.Windows.Forms.TextBox Job_name;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Address1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Address2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Passport_number;
    }
}