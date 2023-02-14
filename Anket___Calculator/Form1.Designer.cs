namespace Anket___Calculator
{
    partial class Form1_Anket
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_search = new System.Windows.Forms.TextBox();
            this.grpB_anket = new System.Windows.Forms.GroupBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.tb_country = new System.Windows.Forms.TextBox();
            this.tb_fatherName = new System.Windows.Forms.TextBox();
            this.tb_surname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_load = new System.Windows.Forms.Button();
            this.rb_male = new System.Windows.Forms.RadioButton();
            this.rb_female = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_country = new System.Windows.Forms.Label();
            this.lbl_fatherName = new System.Windows.Forms.Label();
            this.lbl_gender = new System.Windows.Forms.Label();
            this.grpB_anket.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(78, 11);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(100, 23);
            this.tb_search.TabIndex = 0;
            // 
            // grpB_anket
            // 
            this.grpB_anket.Controls.Add(this.lbl_gender);
            this.grpB_anket.Controls.Add(this.lbl_fatherName);
            this.grpB_anket.Controls.Add(this.lbl_country);
            this.grpB_anket.Controls.Add(this.lbl_city);
            this.grpB_anket.Controls.Add(this.lbl_phone);
            this.grpB_anket.Controls.Add(this.lbl_date);
            this.grpB_anket.Controls.Add(this.lbl_surname);
            this.grpB_anket.Controls.Add(this.lbl_name);
            this.grpB_anket.Controls.Add(this.btn_save);
            this.grpB_anket.Controls.Add(this.rb_female);
            this.grpB_anket.Controls.Add(this.rb_male);
            this.grpB_anket.Controls.Add(this.btn_load);
            this.grpB_anket.Controls.Add(this.dateTimePicker1);
            this.grpB_anket.Controls.Add(this.tb_surname);
            this.grpB_anket.Controls.Add(this.tb_fatherName);
            this.grpB_anket.Controls.Add(this.tb_country);
            this.grpB_anket.Controls.Add(this.tb_phone);
            this.grpB_anket.Controls.Add(this.tb_city);
            this.grpB_anket.Controls.Add(this.tb_name);
            this.grpB_anket.Controls.Add(this.tb_search);
            this.grpB_anket.Location = new System.Drawing.Point(228, 1);
            this.grpB_anket.Name = "grpB_anket";
            this.grpB_anket.Size = new System.Drawing.Size(292, 437);
            this.grpB_anket.TabIndex = 1;
            this.grpB_anket.TabStop = false;
            this.grpB_anket.Text = "Anket";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(78, 63);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(206, 23);
            this.tb_name.TabIndex = 0;
            this.tb_name.TextChanged += new System.EventHandler(this.tb_name_TextChanged);
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(78, 227);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(206, 23);
            this.tb_city.TabIndex = 1;
            this.tb_city.TextChanged += new System.EventHandler(this.tb_city_TextChanged);
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(78, 256);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(206, 23);
            this.tb_phone.TabIndex = 2;
            this.tb_phone.TextChanged += new System.EventHandler(this.tb_phone_TextChanged);
            // 
            // tb_country
            // 
            this.tb_country.Location = new System.Drawing.Point(78, 198);
            this.tb_country.Name = "tb_country";
            this.tb_country.Size = new System.Drawing.Size(206, 23);
            this.tb_country.TabIndex = 3;
            this.tb_country.TextChanged += new System.EventHandler(this.tb_country_TextChanged);
            // 
            // tb_fatherName
            // 
            this.tb_fatherName.Location = new System.Drawing.Point(78, 121);
            this.tb_fatherName.Name = "tb_fatherName";
            this.tb_fatherName.Size = new System.Drawing.Size(206, 23);
            this.tb_fatherName.TabIndex = 4;
            this.tb_fatherName.TextChanged += new System.EventHandler(this.tb_fatherName_TextChanged);
            // 
            // tb_surname
            // 
            this.tb_surname.Location = new System.Drawing.Point(78, 92);
            this.tb_surname.Name = "tb_surname";
            this.tb_surname.Size = new System.Drawing.Size(206, 23);
            this.tb_surname.TabIndex = 5;
            this.tb_surname.TextChanged += new System.EventHandler(this.tb_surname_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(84, 297);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btn_load
            // 
            this.btn_load.AutoSize = true;
            this.btn_load.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_load.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_load.Location = new System.Drawing.Point(209, 10);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 31);
            this.btn_load.TabIndex = 7;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_male.Location = new System.Drawing.Point(99, 347);
            this.rb_male.Name = "rb_male";
            this.rb_male.Size = new System.Drawing.Size(51, 17);
            this.rb_male.TabIndex = 8;
            this.rb_male.TabStop = true;
            this.rb_male.Text = "Male";
            this.rb_male.UseVisualStyleBackColor = true;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_female.Location = new System.Drawing.Point(198, 347);
            this.rb_female.Name = "rb_female";
            this.rb_female.Size = new System.Drawing.Size(62, 17);
            this.rb_female.TabIndex = 9;
            this.rb_female.TabStop = true;
            this.rb_female.Text = "Female";
            this.rb_female.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btn_save.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_save.Location = new System.Drawing.Point(37, 400);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(223, 31);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.Location = new System.Drawing.Point(3, 70);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "Name";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_surname.Location = new System.Drawing.Point(3, 95);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(53, 13);
            this.lbl_surname.TabIndex = 12;
            this.lbl_surname.Text = "Surname";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_date.Location = new System.Drawing.Point(3, 303);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(31, 13);
            this.lbl_date.TabIndex = 13;
            this.lbl_date.Text = "Date";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phone.Location = new System.Drawing.Point(3, 259);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(41, 13);
            this.lbl_phone.TabIndex = 14;
            this.lbl_phone.Text = "Phone";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_city.Location = new System.Drawing.Point(3, 230);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(27, 13);
            this.lbl_city.TabIndex = 15;
            this.lbl_city.Text = "City";
            // 
            // lbl_country
            // 
            this.lbl_country.AutoSize = true;
            this.lbl_country.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_country.Location = new System.Drawing.Point(3, 201);
            this.lbl_country.Name = "lbl_country";
            this.lbl_country.Size = new System.Drawing.Size(49, 13);
            this.lbl_country.TabIndex = 16;
            this.lbl_country.Text = "Country";
            // 
            // lbl_fatherName
            // 
            this.lbl_fatherName.AutoSize = true;
            this.lbl_fatherName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_fatherName.Location = new System.Drawing.Point(3, 124);
            this.lbl_fatherName.Name = "lbl_fatherName";
            this.lbl_fatherName.Size = new System.Drawing.Size(74, 13);
            this.lbl_fatherName.TabIndex = 17;
            this.lbl_fatherName.Text = "Father Name";
            // 
            // lbl_gender
            // 
            this.lbl_gender.AutoSize = true;
            this.lbl_gender.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_gender.Location = new System.Drawing.Point(3, 347);
            this.lbl_gender.Name = "lbl_gender";
            this.lbl_gender.Size = new System.Drawing.Size(45, 13);
            this.lbl_gender.TabIndex = 18;
            this.lbl_gender.Text = "Gender";
            // 
            // Form1_Anket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpB_anket);
            this.Name = "Form1_Anket";
            this.Text = "Anket";
            this.grpB_anket.ResumeLayout(false);
            this.grpB_anket.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox tb_search;
        private GroupBox grpB_anket;
        private Label lbl_gender;
        private Label lbl_fatherName;
        private Label lbl_country;
        private Label lbl_city;
        private Label lbl_phone;
        private Label lbl_date;
        private Label lbl_surname;
        private Label lbl_name;
        private Button btn_save;
        private RadioButton rb_female;
        private RadioButton rb_male;
        private Button btn_load;
        private DateTimePicker dateTimePicker1;
        private TextBox tb_surname;
        private TextBox tb_fatherName;
        private TextBox tb_country;
        private TextBox tb_phone;
        private TextBox tb_city;
        private TextBox tb_name;
    }
}