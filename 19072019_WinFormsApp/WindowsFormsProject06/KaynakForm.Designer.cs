namespace WindowsFormsProject06
{
    partial class KaynakForm
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
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFontAyarla = new System.Windows.Forms.Button();
            this.btnRenkAyarla = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adi";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(122, 41);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdi.TabIndex = 1;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(122, 83);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(100, 20);
            this.textBoxSoyadi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadi";
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(122, 125);
            this.textBoxAciklama.Multiline = true;
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(100, 52);
            this.textBoxAciklama.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Açıklama";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(316, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 62);
            this.label4.TabIndex = 6;
            this.label4.Text = "Önemli Not!!\r\nHedef Form üzerindeki bütün kontrollerdeki modifier özelliğini publ" +
    "ic yaptık.";
            // 
            // btnFontAyarla
            // 
            this.btnFontAyarla.Location = new System.Drawing.Point(95, 201);
            this.btnFontAyarla.Name = "btnFontAyarla";
            this.btnFontAyarla.Size = new System.Drawing.Size(75, 23);
            this.btnFontAyarla.TabIndex = 7;
            this.btnFontAyarla.Text = "Font Ayarla";
            this.btnFontAyarla.UseVisualStyleBackColor = true;
            this.btnFontAyarla.Click += new System.EventHandler(this.btnFontAyarla_Click);
            // 
            // btnRenkAyarla
            // 
            this.btnRenkAyarla.Location = new System.Drawing.Point(189, 201);
            this.btnRenkAyarla.Name = "btnRenkAyarla";
            this.btnRenkAyarla.Size = new System.Drawing.Size(75, 23);
            this.btnRenkAyarla.TabIndex = 8;
            this.btnRenkAyarla.Text = "Renk Ayarla";
            this.btnRenkAyarla.UseVisualStyleBackColor = true;
            this.btnRenkAyarla.Click += new System.EventHandler(this.btnRenkAyarla_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(149, 265);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(75, 42);
            this.btnGonder.TabIndex = 10;
            this.btnGonder.Text = "Gonder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(55, 265);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 42);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.btnFontAyarla_Click);
            // 
            // KaynakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 377);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnRenkAyarla);
            this.Controls.Add(this.btnFontAyarla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.label1);
            this.Name = "KaynakForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxAdi;
        public System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFontAyarla;
        private System.Windows.Forms.Button btnRenkAyarla;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

