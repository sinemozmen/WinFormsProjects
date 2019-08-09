namespace WindowsFormsProject13
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbKahve = new System.Windows.Forms.ComboBox();
            this.cmbSicakIcecek = new System.Windows.Forms.ComboBox();
            this.cmbSogukIcecek = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.rdNormal = new System.Windows.Forms.RadioButton();
            this.rdYagsız = new System.Windows.Forms.RadioButton();
            this.rdBoya = new System.Windows.Forms.RadioButton();
            this.rdTall = new System.Windows.Forms.RadioButton();
            this.rdGrande = new System.Windows.Forms.RadioButton();
            this.rdVerti = new System.Windows.Forms.RadioButton();
            this.dudKahve = new System.Windows.Forms.DomainUpDown();
            this.dudSicakIcecek = new System.Windows.Forms.DomainUpDown();
            this.dudSogukIcecek = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dudSogukIcecek);
            this.groupBox2.Controls.Add(this.dudSicakIcecek);
            this.groupBox2.Controls.Add(this.dudKahve);
            this.groupBox2.Controls.Add(this.cmbSogukIcecek);
            this.groupBox2.Controls.Add(this.cmbSicakIcecek);
            this.groupBox2.Controls.Add(this.cmbKahve);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürünler";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdTall);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.rdGrande);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rdVerti);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.rdBoya);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.rdYagsız);
            this.groupBox3.Controls.Add(this.checkBox2);
            this.groupBox3.Controls.Add(this.rdNormal);
            this.groupBox3.Location = new System.Drawing.Point(12, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 159);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Extralar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(82, 28);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(82, 64);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(121, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefon";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(82, 103);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(121, 20);
            this.txtAdres.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Soğuk\r\nİçecek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sıcak\r\nİçecek";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kahve";
            // 
            // cmbKahve
            // 
            this.cmbKahve.FormattingEnabled = true;
            this.cmbKahve.Location = new System.Drawing.Point(82, 39);
            this.cmbKahve.Name = "cmbKahve";
            this.cmbKahve.Size = new System.Drawing.Size(121, 21);
            this.cmbKahve.TabIndex = 9;
            this.cmbKahve.SelectedIndexChanged += new System.EventHandler(this.CmbKahve_SelectedIndexChanged);
            // 
            // cmbSicakIcecek
            // 
            this.cmbSicakIcecek.FormattingEnabled = true;
            this.cmbSicakIcecek.Location = new System.Drawing.Point(82, 83);
            this.cmbSicakIcecek.Name = "cmbSicakIcecek";
            this.cmbSicakIcecek.Size = new System.Drawing.Size(121, 21);
            this.cmbSicakIcecek.TabIndex = 10;
            // 
            // cmbSogukIcecek
            // 
            this.cmbSogukIcecek.FormattingEnabled = true;
            this.cmbSogukIcecek.Location = new System.Drawing.Point(82, 122);
            this.cmbSogukIcecek.Name = "cmbSogukIcecek";
            this.cmbSogukIcecek.Size = new System.Drawing.Size(121, 21);
            this.cmbSogukIcecek.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(23, 68);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(37, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "1x";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(23, 92);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(37, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "2x";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // rdNormal
            // 
            this.rdNormal.AutoSize = true;
            this.rdNormal.Location = new System.Drawing.Point(126, 67);
            this.rdNormal.Name = "rdNormal";
            this.rdNormal.Size = new System.Drawing.Size(58, 17);
            this.rdNormal.TabIndex = 4;
            this.rdNormal.TabStop = true;
            this.rdNormal.Text = "Normal";
            this.rdNormal.UseVisualStyleBackColor = true;
            // 
            // rdYagsız
            // 
            this.rdYagsız.AutoSize = true;
            this.rdYagsız.Location = new System.Drawing.Point(126, 92);
            this.rdYagsız.Name = "rdYagsız";
            this.rdYagsız.Size = new System.Drawing.Size(56, 17);
            this.rdYagsız.TabIndex = 5;
            this.rdYagsız.TabStop = true;
            this.rdYagsız.Text = "Yağsız";
            this.rdYagsız.UseVisualStyleBackColor = true;
            // 
            // rdBoya
            // 
            this.rdBoya.AutoSize = true;
            this.rdBoya.Location = new System.Drawing.Point(126, 115);
            this.rdBoya.Name = "rdBoya";
            this.rdBoya.Size = new System.Drawing.Size(49, 17);
            this.rdBoya.TabIndex = 6;
            this.rdBoya.TabStop = true;
            this.rdBoya.Text = "Boya";
            this.rdBoya.UseVisualStyleBackColor = true;
            // 
            // rdTall
            // 
            this.rdTall.AutoSize = true;
            this.rdTall.Location = new System.Drawing.Point(257, 115);
            this.rdTall.Name = "rdTall";
            this.rdTall.Size = new System.Drawing.Size(42, 17);
            this.rdTall.TabIndex = 9;
            this.rdTall.TabStop = true;
            this.rdTall.Text = "Tall";
            this.rdTall.UseVisualStyleBackColor = true;
            // 
            // rdGrande
            // 
            this.rdGrande.AutoSize = true;
            this.rdGrande.Location = new System.Drawing.Point(257, 92);
            this.rdGrande.Name = "rdGrande";
            this.rdGrande.Size = new System.Drawing.Size(60, 17);
            this.rdGrande.TabIndex = 8;
            this.rdGrande.TabStop = true;
            this.rdGrande.Text = "Grande";
            this.rdGrande.UseVisualStyleBackColor = true;
            // 
            // rdVerti
            // 
            this.rdVerti.AutoSize = true;
            this.rdVerti.Location = new System.Drawing.Point(257, 68);
            this.rdVerti.Name = "rdVerti";
            this.rdVerti.Size = new System.Drawing.Size(46, 17);
            this.rdVerti.TabIndex = 7;
            this.rdVerti.TabStop = true;
            this.rdVerti.Text = "Verti";
            this.rdVerti.UseVisualStyleBackColor = true;
            // 
            // dudKahve
            // 
            this.dudKahve.Items.Add("1");
            this.dudKahve.Items.Add("2");
            this.dudKahve.Items.Add("3");
            this.dudKahve.Items.Add("4");
            this.dudKahve.Items.Add("5");
            this.dudKahve.Items.Add("6");
            this.dudKahve.Items.Add("7");
            this.dudKahve.Items.Add("8");
            this.dudKahve.Items.Add("9");
            this.dudKahve.Location = new System.Drawing.Point(257, 43);
            this.dudKahve.Name = "dudKahve";
            this.dudKahve.Size = new System.Drawing.Size(80, 20);
            this.dudKahve.TabIndex = 12;
            // 
            // dudSicakIcecek
            // 
            this.dudSicakIcecek.Location = new System.Drawing.Point(257, 83);
            this.dudSicakIcecek.Name = "dudSicakIcecek";
            this.dudSicakIcecek.Size = new System.Drawing.Size(80, 20);
            this.dudSicakIcecek.TabIndex = 13;
            // 
            // dudSogukIcecek
            // 
            this.dudSogukIcecek.Location = new System.Drawing.Point(257, 122);
            this.dudSogukIcecek.Name = "dudSogukIcecek";
            this.dudSogukIcecek.Size = new System.Drawing.Size(80, 20);
            this.dudSogukIcecek.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Shot";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Süt";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "İçecek Boyutu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Adet";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(438, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(331, 511);
            this.listBox1.TabIndex = 2;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(25, 592);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(345, 23);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(424, 592);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(345, 23);
            this.btnSiparisVer.TabIndex = 4;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 661);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kahve Siparişi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DomainUpDown dudSogukIcecek;
        private System.Windows.Forms.DomainUpDown dudSicakIcecek;
        private System.Windows.Forms.DomainUpDown dudKahve;
        private System.Windows.Forms.ComboBox cmbSogukIcecek;
        private System.Windows.Forms.ComboBox cmbSicakIcecek;
        private System.Windows.Forms.ComboBox cmbKahve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.RadioButton rdNormal;
        private System.Windows.Forms.RadioButton rdYagsız;
        private System.Windows.Forms.RadioButton rdBoya;
        private System.Windows.Forms.RadioButton rdTall;
        private System.Windows.Forms.RadioButton rdGrande;
        private System.Windows.Forms.RadioButton rdVerti;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnSiparisVer;
    }
}

