namespace WindowsFormsProject10
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeni1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeni2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konuşöaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.merhabaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.konuşöaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeni1ToolStripMenuItem,
            this.yeni2ToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // yeni1ToolStripMenuItem
            // 
            this.yeni1ToolStripMenuItem.Name = "yeni1ToolStripMenuItem";
            this.yeni1ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yeni1ToolStripMenuItem.Text = "Yeni1 ";
            this.yeni1ToolStripMenuItem.Click += new System.EventHandler(this.yeni1ToolStripMenuItem_Click);
            // 
            // yeni2ToolStripMenuItem
            // 
            this.yeni2ToolStripMenuItem.Name = "yeni2ToolStripMenuItem";
            this.yeni2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.yeni2ToolStripMenuItem.Text = "Yeni 2 ";
            this.yeni2ToolStripMenuItem.Click += new System.EventHandler(this.yeni2ToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // konuşöaToolStripMenuItem
            // 
            this.konuşöaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.merhabaToolStripMenuItem});
            this.konuşöaToolStripMenuItem.Name = "konuşöaToolStripMenuItem";
            this.konuşöaToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.konuşöaToolStripMenuItem.Text = "Konuşma";
            this.konuşöaToolStripMenuItem.Click += new System.EventHandler(this.konuşöaToolStripMenuItem_Click);
            // 
            // merhabaToolStripMenuItem
            // 
            this.merhabaToolStripMenuItem.Name = "merhabaToolStripMenuItem";
            this.merhabaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.merhabaToolStripMenuItem.Text = "MerhabaDe ";
            this.merhabaToolStripMenuItem.Click += new System.EventHandler(this.merhabaToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeni1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeni2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konuşöaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem merhabaToolStripMenuItem;
    }
}

