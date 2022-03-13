
namespace YHealthy.Forms
{
    partial class RecordAdd
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
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.textBoxPat = new System.Windows.Forms.TextBox();
            this.dataGridViewDoc = new System.Windows.Forms.DataGridView();
            this.dataGridViewPat = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRecord.Location = new System.Drawing.Point(473, 316);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(117, 23);
            this.buttonAddRecord.TabIndex = 0;
            this.buttonAddRecord.Text = "Выполнить";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 302);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(299, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Доктор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пациент";
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(65, 14);
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(514, 20);
            this.textBoxDoc.TabIndex = 4;
            this.textBoxDoc.TextChanged += new System.EventHandler(this.textBoxDoc_TextChanged);
            // 
            // textBoxPat
            // 
            this.textBoxPat.Location = new System.Drawing.Point(65, 158);
            this.textBoxPat.Name = "textBoxPat";
            this.textBoxPat.Size = new System.Drawing.Size(514, 20);
            this.textBoxPat.TabIndex = 4;
            this.textBoxPat.TextChanged += new System.EventHandler(this.textBoxPat_TextChanged);
            // 
            // dataGridViewDoc
            // 
            this.dataGridViewDoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoc.Location = new System.Drawing.Point(65, 40);
            this.dataGridViewDoc.Name = "dataGridViewDoc";
            this.dataGridViewDoc.Size = new System.Drawing.Size(514, 111);
            this.dataGridViewDoc.TabIndex = 5;
            this.dataGridViewDoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDoc_MouseClick);
            // 
            // dataGridViewPat
            // 
            this.dataGridViewPat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPat.Location = new System.Drawing.Point(65, 184);
            this.dataGridViewPat.Name = "dataGridViewPat";
            this.dataGridViewPat.Size = new System.Drawing.Size(514, 111);
            this.dataGridViewPat.TabIndex = 5;
            this.dataGridViewPat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewPat_MouseClick);
            // 
            // RecordAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 351);
            this.Controls.Add(this.dataGridViewPat);
            this.Controls.Add(this.dataGridViewDoc);
            this.Controls.Add(this.textBoxPat);
            this.Controls.Add(this.textBoxDoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.buttonAddRecord);
            this.Name = "RecordAdd";
            this.Text = "RecordAdd";
            this.Load += new System.EventHandler(this.RecordAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.TextBox textBoxPat;
        private System.Windows.Forms.DataGridView dataGridViewDoc;
        private System.Windows.Forms.DataGridView dataGridViewPat;
    }
}