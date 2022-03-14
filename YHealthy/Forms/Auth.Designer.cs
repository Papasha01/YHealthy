
namespace YHealthy.Forms
{
    partial class Auth
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
            this.SignIn = new System.Windows.Forms.Button();
            this.txLog = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txPas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(212)))), ((int)(((byte)(226)))));
            this.SignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.SignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SignIn.Location = new System.Drawing.Point(433, 73);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(122, 33);
            this.SignIn.TabIndex = 23;
            this.SignIn.Text = "Войти";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // txLog
            // 
            this.txLog.BackColor = System.Drawing.SystemColors.Window;
            this.txLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txLog.Location = new System.Drawing.Point(136, 9);
            this.txLog.Multiline = true;
            this.txLog.Name = "txLog";
            this.txLog.Size = new System.Drawing.Size(419, 26);
            this.txLog.TabIndex = 21;
            this.txLog.Text = "papasha";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPassword.Location = new System.Drawing.Point(12, 41);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 20);
            this.labelPassword.TabIndex = 20;
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
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(136, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(160, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Показать/Скрыть пароль ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txPas
            // 
            this.txPas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txPas.Location = new System.Drawing.Point(136, 41);
            this.txPas.Name = "txPas";
            this.txPas.PasswordChar = '*';
            this.txPas.Size = new System.Drawing.Size(419, 26);
            this.txPas.TabIndex = 25;
            this.txPas.Text = "123";
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 131);
            this.Controls.Add(this.txPas);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.txLog);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox txLog;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txPas;
    }
}