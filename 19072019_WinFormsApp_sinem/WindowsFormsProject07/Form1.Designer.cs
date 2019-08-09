namespace WindowsFormsProject07
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
            this.picTom = new System.Windows.Forms.PictureBox();
            this.picJerry = new System.Windows.Forms.PictureBox();
            this.panelBitis = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJerry)).BeginInit();
            this.SuspendLayout();
            // 
            // picTom
            // 
            this.picTom.Image = global::WindowsFormsProject07.Properties.Resources.tom_ve_jerry_resized;
            this.picTom.Location = new System.Drawing.Point(27, 359);
            this.picTom.Name = "picTom";
            this.picTom.Size = new System.Drawing.Size(302, 267);
            this.picTom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTom.TabIndex = 1;
            this.picTom.TabStop = false;
            // 
            // picJerry
            // 
            this.picJerry.Image = global::WindowsFormsProject07.Properties.Resources.resized_jerry1;
            this.picJerry.Location = new System.Drawing.Point(27, 38);
            this.picJerry.Name = "picJerry";
            this.picJerry.Size = new System.Drawing.Size(302, 281);
            this.picJerry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picJerry.TabIndex = 0;
            this.picJerry.TabStop = false;
            // 
            // panelBitis
            // 
            this.panelBitis.BackColor = System.Drawing.Color.Red;
            this.panelBitis.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBitis.Location = new System.Drawing.Point(1122, 0);
            this.panelBitis.Margin = new System.Windows.Forms.Padding(4);
            this.panelBitis.Name = "panelBitis";
            this.panelBitis.Size = new System.Drawing.Size(100, 766);
            this.panelBitis.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStart.Location = new System.Drawing.Point(36, 682);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(213, 72);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start the Game";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1222, 766);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.panelBitis);
            this.Controls.Add(this.picTom);
            this.Controls.Add(this.picJerry);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picTom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picJerry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picJerry;
        private System.Windows.Forms.PictureBox picTom;
        private System.Windows.Forms.Panel panelBitis;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
    }
}

