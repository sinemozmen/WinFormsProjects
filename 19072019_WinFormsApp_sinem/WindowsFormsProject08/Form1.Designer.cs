﻿namespace WindowsFormsProject08
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
            this.btnHedef = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHedef
            // 
            this.btnHedef.Location = new System.Drawing.Point(325, 382);
            this.btnHedef.Name = "btnHedef";
            this.btnHedef.Size = new System.Drawing.Size(97, 42);
            this.btnHedef.TabIndex = 0;
            this.btnHedef.Text = "Hedef";
            this.btnHedef.UseVisualStyleBackColor = true;
            this.btnHedef.Click += new System.EventHandler(this.btnHedef_Click);
            this.btnHedef.MouseEnter += new System.EventHandler(this.btnHedef_MouseEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHedef);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHedef;
    }
}

