using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject04
{
    public partial class Form1 : Form
    {   //Project: Event Orders for Mouse Movements 
        public Form1()
        {
            InitializeComponent();
        }
        //public string strButtonTemizleText,
        public Form1(string s )//constructor overlod, yazılabilmesi için sign. farklı olmalı 
        {
            InitializeComponent();
            btnTemizle.Text = s;
        }

        private void pnlOlay_MouseDown(object sender, MouseEventArgs e)
        {   
            //Mouse Down event'i gerçekleştiğinde bu method tetiklenecek
            //Bu bilgi Form1.Designer.cs dosyasında belirtiliyor.
            //Bu method kendi içerisinde Yaz methodunu çağırıyor.
            //Yaz method'u tek parametre alıyor
            // 1 adet string tipinde parametre alıyor.
            Yaz("MouseDown");
            //Yaz("MouseDown" + e.Button.ToString());
        }
        private void Yaz(string EventAdi)
        {
            listBoxOlay.Items.Add(string.Format("{1}{0}", EventAdi, DateTime.Now));
            listBoxOlay.SelectedIndex = this.listBoxOlay.Items.Count - 1;
        }

        private void pnlOlay_MouseEnter(object sender, EventArgs e)
        {
            Yaz("MouseEnter");
        }

        private void pnlOlay_MouseHover(object sender, EventArgs e)
        {
            Yaz("MouseHover");
        }

        private void pnlOlay_MouseLeave(object sender, EventArgs e)
        {
            Yaz("MouseLeave");
        }

        private void pnlOlay_MouseMove(object sender, MouseEventArgs e)
        {
            Yaz("MouseMove");
        }

        private void pnlOlay_MouseUp(object sender, MouseEventArgs e)
        {
            Yaz("MouseUp");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // btnTemizle.Text = strButtonTemizleText;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            listBoxOlay.Items.Clear();
        }
    }
}
