namespace BANK_TEST
{
    partial class CreateUser_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.date_textbox = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.male_gender = new System.Windows.Forms.RadioButton();
            this.female_gender = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(298, 76);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(83, 27);
            this.name_textbox.TabIndex = 1;
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(460, 76);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.Size = new System.Drawing.Size(83, 27);
            this.surname_textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "DOB";
            // 
            // date_textbox
            // 
            this.date_textbox.Location = new System.Drawing.Point(298, 259);
            this.date_textbox.Name = "date_textbox";
            this.date_textbox.Size = new System.Drawing.Size(305, 27);
            this.date_textbox.TabIndex = 6;
            this.date_textbox.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(628, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 47);
            this.button2.TabIndex = 7;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(307, 175);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.Size = new System.Drawing.Size(210, 27);
            this.password_textbox.TabIndex = 9;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(243, 130);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(46, 20);
            this.email_label.TabIndex = 10;
            this.email_label.Text = "Email";
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(307, 130);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(210, 27);
            this.email_textbox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender";
            // 
            // male_gender
            // 
            this.male_gender.AutoSize = true;
            this.male_gender.Location = new System.Drawing.Point(14, 26);
            this.male_gender.Name = "male_gender";
            this.male_gender.Size = new System.Drawing.Size(63, 24);
            this.male_gender.TabIndex = 14;
            this.male_gender.TabStop = true;
            this.male_gender.Text = "Male";
            this.male_gender.UseVisualStyleBackColor = true;
            // 
            // female_gender
            // 
            this.female_gender.AutoSize = true;
            this.female_gender.Location = new System.Drawing.Point(83, 26);
            this.female_gender.Name = "female_gender";
            this.female_gender.Size = new System.Drawing.Size(78, 24);
            this.female_gender.TabIndex = 15;
            this.female_gender.TabStop = true;
            this.female_gender.Text = "Female";
            this.female_gender.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.male_gender);
            this.groupBox1.Controls.Add(this.female_gender);
            this.groupBox1.Location = new System.Drawing.Point(307, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 58);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // CreateUser_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.surname_textbox);
            this.Controls.Add(this.name_textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateUser_Form";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox name_textbox;
        private TextBox surname_textbox;
        private Label label2;
        private Button button1;
        private Label label3;
        private DateTimePicker date_textbox;
        private Button button2;
        private Label label4;
        private TextBox password_textbox;
        private Label email_label;
        private TextBox email_textbox;
        private Label label5;
        private RadioButton male_gender;
        private RadioButton female_gender;
        private GroupBox groupBox1;
    }
}