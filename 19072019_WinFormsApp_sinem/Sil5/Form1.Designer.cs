namespace Sil5
{
    partial class Form1
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
            this.cmbMedeniDurumlar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMedeniDurumlar2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMedeniDurum3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbMedeniDurumlar
            // 
            this.cmbMedeniDurumlar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeniDurumlar.FormattingEnabled = true;
            this.cmbMedeniDurumlar.Location = new System.Drawing.Point(225, 51);
            this.cmbMedeniDurumlar.Name = "cmbMedeniDurumlar";
            this.cmbMedeniDurumlar.Size = new System.Drawing.Size(229, 24);
            this.cmbMedeniDurumlar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Medeni Durumlar";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(88, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Medeni Durumlar 2";
            // 
            // cmbMedeniDurumlar2
            // 
            this.cmbMedeniDurumlar2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMedeniDurumlar2.FormattingEnabled = true;
            this.cmbMedeniDurumlar2.Location = new System.Drawing.Point(225, 124);
            this.cmbMedeniDurumlar2.Name = "cmbMedeniDurumlar2";
            this.cmbMedeniDurumlar2.Size = new System.Drawing.Size(229, 24);
            this.cmbMedeniDurumlar2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(88, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Medeni Durumlar 3 ";
            // 
            // cmbMedeniDurum3
            // 
            this.cmbMedeniDurum3.FormattingEnabled = true;
            this.cmbMedeniDurum3.Location = new System.Drawing.Point(225, 184);
            this.cmbMedeniDurum3.Name = "cmbMedeniDurum3";
            this.cmbMedeniDurum3.Size = new System.Drawing.Size(229, 24);
            this.cmbMedeniDurum3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbMedeniDurum3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbMedeniDurumlar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMedeniDurumlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMedeniDurumlar;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMedeniDurumlar2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedeniDurum3;
    }
}

