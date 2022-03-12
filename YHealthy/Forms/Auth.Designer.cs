
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
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBEmail = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
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
            // TBPassword
            // 
            this.TBPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBPassword.Location = new System.Drawing.Point(136, 41);
            this.TBPassword.Multiline = true;
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(419, 26);
            this.TBPassword.TabIndex = 22;
            this.TBPassword.Text = "123";
            this.TBPassword.UseSystemPasswordChar = true;
            this.TBPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBPassword_KeyDown);
            // 
            // TBEmail
            // 
            this.TBEmail.BackColor = System.Drawing.SystemColors.Window;
            this.TBEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TBEmail.Location = new System.Drawing.Point(136, 9);
            this.TBEmail.Multiline = true;
            this.TBEmail.Name = "TBEmail";
            this.TBEmail.Size = new System.Drawing.Size(419, 26);
            this.TBEmail.TabIndex = 21;
            this.TBEmail.Text = "papasha";
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
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 134);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBEmail);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Name = "Auth";
            this.Text = "Auth";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelEmail;
    }
}