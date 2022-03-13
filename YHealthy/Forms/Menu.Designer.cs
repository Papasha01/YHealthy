
namespace YHealthy.Forms
{
    partial class Menu
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
            this.buttonRecList = new System.Windows.Forms.Button();
            this.buttonEditDoc = new System.Windows.Forms.Button();
            this.buttonEditPat = new System.Windows.Forms.Button();
            this.buttonAddPat = new System.Windows.Forms.Button();
            this.buttonAddDoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRecList
            // 
            this.buttonRecList.Location = new System.Drawing.Point(12, 12);
            this.buttonRecList.Name = "buttonRecList";
            this.buttonRecList.Size = new System.Drawing.Size(170, 23);
            this.buttonRecList.TabIndex = 0;
            this.buttonRecList.Text = "Список записей";
            this.buttonRecList.UseVisualStyleBackColor = true;
            this.buttonRecList.Click += new System.EventHandler(this.buttonRecList_Click);
            // 
            // buttonEditDoc
            // 
            this.buttonEditDoc.Location = new System.Drawing.Point(12, 98);
            this.buttonEditDoc.Name = "buttonEditDoc";
            this.buttonEditDoc.Size = new System.Drawing.Size(170, 23);
            this.buttonEditDoc.TabIndex = 0;
            this.buttonEditDoc.Text = "Изменить профиль доктора";
            this.buttonEditDoc.UseVisualStyleBackColor = true;
            this.buttonEditDoc.Click += new System.EventHandler(this.buttonEditDoc_Click);
            // 
            // buttonEditPat
            // 
            this.buttonEditPat.Location = new System.Drawing.Point(12, 127);
            this.buttonEditPat.Name = "buttonEditPat";
            this.buttonEditPat.Size = new System.Drawing.Size(170, 23);
            this.buttonEditPat.TabIndex = 0;
            this.buttonEditPat.Text = "Изменить профиль пациента";
            this.buttonEditPat.UseVisualStyleBackColor = true;
            this.buttonEditPat.Click += new System.EventHandler(this.buttonEditPat_Click);
            // 
            // buttonAddPat
            // 
            this.buttonAddPat.Location = new System.Drawing.Point(12, 69);
            this.buttonAddPat.Name = "buttonAddPat";
            this.buttonAddPat.Size = new System.Drawing.Size(170, 23);
            this.buttonAddPat.TabIndex = 0;
            this.buttonAddPat.Text = "Добавить пациента";
            this.buttonAddPat.UseVisualStyleBackColor = true;
            this.buttonAddPat.Click += new System.EventHandler(this.buttonAddPat_Click);
            // 
            // buttonAddDoc
            // 
            this.buttonAddDoc.Location = new System.Drawing.Point(12, 41);
            this.buttonAddDoc.Name = "buttonAddDoc";
            this.buttonAddDoc.Size = new System.Drawing.Size(170, 23);
            this.buttonAddDoc.TabIndex = 0;
            this.buttonAddDoc.Text = "Добавить доктора";
            this.buttonAddDoc.UseVisualStyleBackColor = true;
            this.buttonAddDoc.Click += new System.EventHandler(this.buttonAddDoc_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 165);
            this.Controls.Add(this.buttonEditPat);
            this.Controls.Add(this.buttonEditDoc);
            this.Controls.Add(this.buttonAddDoc);
            this.Controls.Add(this.buttonAddPat);
            this.Controls.Add(this.buttonRecList);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.VisibleChanged += new System.EventHandler(this.Menu_VisibleChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRecList;
        private System.Windows.Forms.Button buttonEditDoc;
        private System.Windows.Forms.Button buttonEditPat;
        private System.Windows.Forms.Button buttonAddPat;
        private System.Windows.Forms.Button buttonAddDoc;
    }
}