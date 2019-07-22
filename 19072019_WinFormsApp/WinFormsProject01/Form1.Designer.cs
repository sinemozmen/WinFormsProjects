namespace WinFormsProject01
{
    partial class FrmDeneme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDeneme));
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.listBoxDoWhile = new System.Windows.Forms.ListBox();
            this.btnIEnum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnForEach = new System.Windows.Forms.Button();
            this.listBoxForEach = new System.Windows.Forms.ListBox();
            this.listBoxIENum = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxFor
            // 
            this.listBoxFor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.Location = new System.Drawing.Point(59, 78);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(120, 264);
            this.listBoxFor.TabIndex = 0;
            // 
            // btnFor
            // 
            this.btnFor.BackColor = System.Drawing.Color.Lime;
            this.btnFor.Location = new System.Drawing.Point(80, 366);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(86, 39);
            this.btnFor.TabIndex = 1;
            this.btnFor.Text = "For";
            this.btnFor.UseVisualStyleBackColor = false;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnWhile.Location = new System.Drawing.Point(227, 366);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(86, 39);
            this.btnWhile.TabIndex = 3;
            this.btnWhile.Text = "While";
            this.btnWhile.UseVisualStyleBackColor = false;
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.Location = new System.Drawing.Point(206, 78);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(120, 264);
            this.listBoxWhile.TabIndex = 2;
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDoWhile.Location = new System.Drawing.Point(374, 366);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(86, 39);
            this.btnDoWhile.TabIndex = 5;
            this.btnDoWhile.Text = "DoWhile";
            this.btnDoWhile.UseVisualStyleBackColor = false;
            // 
            // listBoxDoWhile
            // 
            this.listBoxDoWhile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxDoWhile.FormattingEnabled = true;
            this.listBoxDoWhile.Location = new System.Drawing.Point(353, 78);
            this.listBoxDoWhile.Name = "listBoxDoWhile";
            this.listBoxDoWhile.Size = new System.Drawing.Size(120, 264);
            this.listBoxDoWhile.TabIndex = 4;
            // 
            // btnIEnum
            // 
            this.btnIEnum.BackColor = System.Drawing.Color.Purple;
            this.btnIEnum.Location = new System.Drawing.Point(521, 366);
            this.btnIEnum.Name = "btnIEnum";
            this.btnIEnum.Size = new System.Drawing.Size(86, 39);
            this.btnIEnum.TabIndex = 7;
            this.btnIEnum.Text = "IEnum";
            this.btnIEnum.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(708, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sayılar = {10,20,35,28,34 } kümesinin içindeki sayıları ve en altına bu sayıların" +
    " toplamını göstererek döngü kodlarını yazınız.";
            // 
            // btnForEach
            // 
            this.btnForEach.BackColor = System.Drawing.Color.Yellow;
            this.btnForEach.Location = new System.Drawing.Point(668, 366);
            this.btnForEach.Name = "btnForEach";
            this.btnForEach.Size = new System.Drawing.Size(86, 39);
            this.btnForEach.TabIndex = 10;
            this.btnForEach.Text = "ForEach";
            this.btnForEach.UseVisualStyleBackColor = false;
            this.btnForEach.Click += new System.EventHandler(this.btnForEach_Click);
            // 
            // listBoxForEach
            // 
            this.listBoxForEach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxForEach.FormattingEnabled = true;
            this.listBoxForEach.Location = new System.Drawing.Point(647, 78);
            this.listBoxForEach.Name = "listBoxForEach";
            this.listBoxForEach.Size = new System.Drawing.Size(120, 264);
            this.listBoxForEach.TabIndex = 9;
       //     this.listBoxForEach.SelectedIndexChanged += new System.EventHandler(this.listBoxForEach_SelectedIndexChanged);
            // 
            // listBoxIENum
            // 
            this.listBoxIENum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBoxIENum.FormattingEnabled = true;
            this.listBoxIENum.Location = new System.Drawing.Point(500, 78);
            this.listBoxIENum.Name = "listBoxIENum";
            this.listBoxIENum.Size = new System.Drawing.Size(120, 264);
            this.listBoxIENum.TabIndex = 11;
            // 
            // FrmDeneme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(818, 431);
            this.Controls.Add(this.listBoxIENum);
            this.Controls.Add(this.btnForEach);
            this.Controls.Add(this.listBoxForEach);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIEnum);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.listBoxDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.listBoxWhile);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.listBoxFor);
            this.Name = "FrmDeneme";
            this.Text = "Döngüler ve ListBox Formu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxFor;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.ListBox listBoxDoWhile;
        private System.Windows.Forms.Button btnIEnum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnForEach;
        private System.Windows.Forms.ListBox listBoxForEach;
        private System.Windows.Forms.ListBox listBoxIENum;
    }
}

