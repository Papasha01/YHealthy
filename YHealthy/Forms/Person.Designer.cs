
namespace YHealthy.Forms
{
    partial class Person
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
            this.dtPickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.cbGenders = new System.Windows.Forms.ComboBox();
            this.textBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxINN = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxPassport = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPatronymic = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtPickerBirthday
            // 
            this.dtPickerBirthday.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(178)))), ((int)(((byte)(115)))));
            this.dtPickerBirthday.CalendarTrailingForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dtPickerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtPickerBirthday.Location = new System.Drawing.Point(164, 187);
            this.dtPickerBirthday.Name = "dtPickerBirthday";
            this.dtPickerBirthday.Size = new System.Drawing.Size(243, 26);
            this.dtPickerBirthday.TabIndex = 6;
            // 
            // cbGenders
            // 
            this.cbGenders.BackColor = System.Drawing.SystemColors.Window;
            this.cbGenders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbGenders.FormattingEnabled = true;
            this.cbGenders.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.cbGenders.Location = new System.Drawing.Point(164, 120);
            this.cbGenders.Name = "cbGenders";
            this.cbGenders.Size = new System.Drawing.Size(243, 28);
            this.cbGenders.TabIndex = 4;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPhone.Location = new System.Drawing.Point(164, 154);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(243, 26);
            this.textBoxPhone.TabIndex = 5;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxSurname.Location = new System.Drawing.Point(164, 9);
            this.textBoxSurname.Multiline = true;
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(243, 31);
            this.textBoxSurname.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxName.Location = new System.Drawing.Point(164, 46);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(243, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label12.Location = new System.Drawing.Point(12, 157);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Телефон";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.Location = new System.Drawing.Point(12, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "День рождения";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(12, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Пол";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Фамилия";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(12, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Имя";
            // 
            // TextBoxINN
            // 
            this.TextBoxINN.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBoxINN.Location = new System.Drawing.Point(164, 219);
            this.TextBoxINN.Name = "TextBoxINN";
            this.TextBoxINN.Size = new System.Drawing.Size(243, 26);
            this.TextBoxINN.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "INN (12)";
            // 
            // TextBoxPassport
            // 
            this.TextBoxPassport.BackColor = System.Drawing.SystemColors.Window;
            this.TextBoxPassport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TextBoxPassport.Location = new System.Drawing.Point(200, 251);
            this.TextBoxPassport.Name = "TextBoxPassport";
            this.TextBoxPassport.Size = new System.Drawing.Size(207, 26);
            this.TextBoxPassport.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "Серия № паспорта (10)";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSave.Location = new System.Drawing.Point(284, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 33);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Отчество";
            // 
            // textBoxPatronymic
            // 
            this.textBoxPatronymic.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxPatronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPatronymic.Location = new System.Drawing.Point(163, 83);
            this.textBoxPatronymic.Multiline = true;
            this.textBoxPatronymic.Name = "textBoxPatronymic";
            this.textBoxPatronymic.Size = new System.Drawing.Size(243, 31);
            this.textBoxPatronymic.TabIndex = 3;
            // 
            // Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 363);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.TextBoxPassport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxINN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerBirthday);
            this.Controls.Add(this.cbGenders);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPatronymic);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Name = "Person";
            this.Text = "Person";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtPickerBirthday;
        private System.Windows.Forms.ComboBox cbGenders;
        private System.Windows.Forms.MaskedTextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox TextBoxINN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TextBoxPassport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPatronymic;
    }
}