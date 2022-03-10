
namespace YHealthy.Forms
{
    partial class Record_List
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.LBIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox1.Location = new System.Drawing.Point(136, 82);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(167, 22);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Показывать пароль";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignIn.Location = new System.Drawing.Point(433, 121);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(122, 33);
            this.SignIn.TabIndex = 15;
            this.SignIn.Text = "Войти";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBPassword.Location = new System.Drawing.Point(136, 50);
            this.TBPassword.Multiline = true;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(419, 26);
            this.TBPassword.TabIndex = 14;
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBEmail.Location = new System.Drawing.Point(136, 9);
            this.TBEmail.Multiline = true;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(419, 26);
            this.TBEmail.TabIndex = 13;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPassword.Location = new System.Drawing.Point(12, 50);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelEmail.Location = new System.Drawing.Point(12, 9);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 20);
            this.labelEmail.TabIndex = 11;
            this.labelEmail.Text = "Email";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelTimer.Location = new System.Drawing.Point(368, 111);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(0, 46);
            this.labelTimer.TabIndex = 17;
            this.labelTimer.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1200;
            // 
            // LBIncorrect
            // 
            this.LBIncorrect.AutoSize = true;
            this.LBIncorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LBIncorrect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LBIncorrect.Location = new System.Drawing.Point(330, 82);
            this.LBIncorrect.Name = "LBIncorrect";
            this.LBIncorrect.Size = new System.Drawing.Size(225, 20);
            this.LBIncorrect.TabIndex = 18;
            this.LBIncorrect.Text = "Неверный логин или пароль";
            this.LBIncorrect.Visible = false;
            // 
            // Record_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 180);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.LBIncorrect);
            this.Name = "Record_List";
            this.Text = "Record_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label LBIncorrect;
    }
}