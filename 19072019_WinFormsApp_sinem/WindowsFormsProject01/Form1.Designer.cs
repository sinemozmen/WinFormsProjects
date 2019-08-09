namespace WindowsFormsProject01
{
    partial class FrmDonguler
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
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.listBoxDowhile = new System.Windows.Forms.ListBox();
            this.listBoxIEnum = new System.Windows.Forms.ListBox();
            this.listBoxForEach = new System.Windows.Forms.ListBox();
            this.BtnFor = new System.Windows.Forms.Button();
            this.BtnWhile = new System.Windows.Forms.Button();
            this.BtnDoWhile = new System.Windows.Forms.Button();
            this.BtnIENum = new System.Windows.Forms.Button();
            this.BtnForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayılar = {10, 20, 25, 28, 34,} kümesinin içindeki sayıları ve en altına bu sayıl" +
    "arın toplamını gösterecek döngü kodlarını yazınız.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBoxFor
            // 
            this.listBoxFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.Location = new System.Drawing.Point(15, 71);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(120, 290);
            this.listBoxFor.TabIndex = 1;
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.Location = new System.Drawing.Point(141, 71);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(120, 290);
            this.listBoxWhile.TabIndex = 3;
            this.listBoxWhile.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxDowhile
            // 
            this.listBoxDowhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxDowhile.FormattingEnabled = true;
            this.listBoxDowhile.Location = new System.Drawing.Point(267, 71);
            this.listBoxDowhile.Name = "listBoxDowhile";
            this.listBoxDowhile.Size = new System.Drawing.Size(120, 290);
            this.listBoxDowhile.TabIndex = 4;
            // 
            // listBoxIEnum
            // 
            this.listBoxIEnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxIEnum.FormattingEnabled = true;
            this.listBoxIEnum.Location = new System.Drawing.Point(393, 71);
            this.listBoxIEnum.Name = "listBoxIEnum";
            this.listBoxIEnum.Size = new System.Drawing.Size(120, 290);
            this.listBoxIEnum.TabIndex = 5;
            // 
            // listBoxForEach
            // 
            this.listBoxForEach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listBoxForEach.FormattingEnabled = true;
            this.listBoxForEach.Location = new System.Drawing.Point(519, 71);
            this.listBoxForEach.Name = "listBoxForEach";
            this.listBoxForEach.Size = new System.Drawing.Size(120, 290);
            this.listBoxForEach.TabIndex = 6;
            // 
            // BtnFor
            // 
            this.BtnFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnFor.Location = new System.Drawing.Point(38, 386);
            this.BtnFor.Name = "BtnFor";
            this.BtnFor.Size = new System.Drawing.Size(75, 23);
            this.BtnFor.TabIndex = 7;
            this.BtnFor.Text = "For";
            this.BtnFor.UseVisualStyleBackColor = false;
            this.BtnFor.Click += new System.EventHandler(this.BtnFor_Click);
            // 
            // BtnWhile
            // 
            this.BtnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BtnWhile.Location = new System.Drawing.Point(166, 386);
            this.BtnWhile.Name = "BtnWhile";
            this.BtnWhile.Size = new System.Drawing.Size(75, 23);
            this.BtnWhile.TabIndex = 8;
            this.BtnWhile.Text = "While";
            this.BtnWhile.UseVisualStyleBackColor = false;
            this.BtnWhile.Click += new System.EventHandler(this.BtnWhile_Click);
            // 
            // BtnDoWhile
            // 
            this.BtnDoWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BtnDoWhile.Location = new System.Drawing.Point(289, 386);
            this.BtnDoWhile.Name = "BtnDoWhile";
            this.BtnDoWhile.Size = new System.Drawing.Size(75, 23);
            this.BtnDoWhile.TabIndex = 9;
            this.BtnDoWhile.Text = "DoWhile";
            this.BtnDoWhile.UseVisualStyleBackColor = false;
            this.BtnDoWhile.Click += new System.EventHandler(this.BtnDoWhile_Click);
            // 
            // BtnIENum
            // 
            this.BtnIENum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnIENum.Location = new System.Drawing.Point(415, 386);
            this.BtnIENum.Name = "BtnIENum";
            this.BtnIENum.Size = new System.Drawing.Size(75, 23);
            this.BtnIENum.TabIndex = 10;
            this.BtnIENum.Text = "IENum";
            this.BtnIENum.UseVisualStyleBackColor = false;
            this.BtnIENum.Click += new System.EventHandler(this.BtnIENum_Click);
            // 
            // BtnForEach
            // 
            this.BtnForEach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnForEach.Location = new System.Drawing.Point(544, 386);
            this.BtnForEach.Name = "BtnForEach";
            this.BtnForEach.Size = new System.Drawing.Size(75, 23);
            this.BtnForEach.TabIndex = 11;
            this.BtnForEach.Text = "ForEach";
            this.BtnForEach.UseVisualStyleBackColor = false;
            this.BtnForEach.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmDonguler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsProject01.Properties.Resources.denizresmi;
            this.ClientSize = new System.Drawing.Size(665, 431);
            this.Controls.Add(this.BtnForEach);
            this.Controls.Add(this.BtnIENum);
            this.Controls.Add(this.BtnDoWhile);
            this.Controls.Add(this.BtnWhile);
            this.Controls.Add(this.BtnFor);
            this.Controls.Add(this.listBoxForEach);
            this.Controls.Add(this.listBoxIEnum);
            this.Controls.Add(this.listBoxDowhile);
            this.Controls.Add(this.listBoxWhile);
            this.Controls.Add(this.listBoxFor);
            this.Controls.Add(this.label1);
            this.Name = "FrmDonguler";
            this.Text = "Döngüler";
            this.Load += new System.EventHandler(this.FrmDonguler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxFor;
        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.ListBox listBoxDowhile;
        private System.Windows.Forms.ListBox listBoxIEnum;
        private System.Windows.Forms.ListBox listBoxForEach;
        private System.Windows.Forms.Button BtnFor;
        private System.Windows.Forms.Button BtnWhile;
        private System.Windows.Forms.Button BtnDoWhile;
        private System.Windows.Forms.Button BtnIENum;
        private System.Windows.Forms.Button BtnForEach;
    }
}

