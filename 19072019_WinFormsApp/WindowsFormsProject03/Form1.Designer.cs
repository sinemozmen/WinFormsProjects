namespace WindowsFormsProject03
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
            this.textBoxOlay = new System.Windows.Forms.TextBox();
            this.listBoxOlay = new System.Windows.Forms.ListBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOlay
            // 
            this.textBoxOlay.BackColor = System.Drawing.Color.Turquoise;
            this.textBoxOlay.Location = new System.Drawing.Point(38, 27);
            this.textBoxOlay.Multiline = true;
            this.textBoxOlay.Name = "textBoxOlay";
            this.textBoxOlay.Size = new System.Drawing.Size(190, 76);
            this.textBoxOlay.TabIndex = 0;
            this.textBoxOlay.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxOlay_KeyDown);
            this.textBoxOlay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOlay_KeyPress);
            this.textBoxOlay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxOlay_KeyUp);
            // 
            // listBoxOlay
            // 
            this.listBoxOlay.FormattingEnabled = true;
            this.listBoxOlay.Location = new System.Drawing.Point(38, 155);
            this.listBoxOlay.Name = "listBoxOlay";
            this.listBoxOlay.Size = new System.Drawing.Size(190, 173);
            this.listBoxOlay.TabIndex = 1;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(38, 336);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 383);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.listBoxOlay);
            this.Controls.Add(this.textBoxOlay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOlay;
        private System.Windows.Forms.ListBox listBoxOlay;
        private System.Windows.Forms.Button btnTemizle;
    }
}

