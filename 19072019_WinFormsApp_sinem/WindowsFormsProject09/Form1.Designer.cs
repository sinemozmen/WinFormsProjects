namespace WindowsFormsProject09
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblZar1 = new System.Windows.Forms.Label();
            this.lblZar2 = new System.Windows.Forms.Label();
            this.btnSalla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "zar1.png");
            this.ımageList1.Images.SetKeyName(1, "zar2.png");
            this.ımageList1.Images.SetKeyName(2, "zar3.png");
            this.ımageList1.Images.SetKeyName(3, "zar4.png");
            this.ımageList1.Images.SetKeyName(4, "zar5.png");
            this.ımageList1.Images.SetKeyName(5, "zar6.png");
            // 
            // lblZar1
            // 
            this.lblZar1.ImageIndex = 0;
            this.lblZar1.ImageList = this.ımageList1;
            this.lblZar1.Location = new System.Drawing.Point(48, 55);
            this.lblZar1.Name = "lblZar1";
            this.lblZar1.Size = new System.Drawing.Size(123, 122);
            this.lblZar1.TabIndex = 0;
            this.lblZar1.Click += new System.EventHandler(this.lblZar1_Click);
            // 
            // lblZar2
            // 
            this.lblZar2.ImageIndex = 0;
            this.lblZar2.ImageList = this.ımageList1;
            this.lblZar2.Location = new System.Drawing.Point(223, 55);
            this.lblZar2.Name = "lblZar2";
            this.lblZar2.Size = new System.Drawing.Size(126, 122);
            this.lblZar2.TabIndex = 1;
            // 
            // btnSalla
            // 
            this.btnSalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalla.Location = new System.Drawing.Point(135, 245);
            this.btnSalla.Name = "btnSalla";
            this.btnSalla.Size = new System.Drawing.Size(110, 73);
            this.btnSalla.TabIndex = 2;
            this.btnSalla.Text = "Salla";
            this.btnSalla.UseVisualStyleBackColor = false;
            this.btnSalla.Click += new System.EventHandler(this.btnSalla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumOrchid;
            this.ClientSize = new System.Drawing.Size(380, 355);
            this.Controls.Add(this.btnSalla);
            this.Controls.Add(this.lblZar2);
            this.Controls.Add(this.lblZar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label lblZar1;
        private System.Windows.Forms.Label lblZar2;
        private System.Windows.Forms.Button btnSalla;
        private System.Windows.Forms.Timer timer1;
    }
}

