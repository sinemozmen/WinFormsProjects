﻿namespace WindowsFormsProject05
{
    partial class AnaForm
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
            this.btnArkaRenkDegistir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnArkaRenkDegistir
            // 
            this.btnArkaRenkDegistir.Location = new System.Drawing.Point(150, 12);
            this.btnArkaRenkDegistir.Name = "btnArkaRenkDegistir";
            this.btnArkaRenkDegistir.Size = new System.Drawing.Size(84, 55);
            this.btnArkaRenkDegistir.TabIndex = 0;
            this.btnArkaRenkDegistir.Text = "Arka Plan Rengini Değiştirme";
            this.btnArkaRenkDegistir.UseVisualStyleBackColor = true;
            this.btnArkaRenkDegistir.Click += new System.EventHandler(this.btnArkaRenkDegistir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AnaForm
            // 
            this.AcceptButton = this.btnArkaRenkDegistir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 237);
            this.Controls.Add(this.btnArkaRenkDegistir);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArkaRenkDegistir;
        private System.Windows.Forms.Timer timer1;
    }
}

