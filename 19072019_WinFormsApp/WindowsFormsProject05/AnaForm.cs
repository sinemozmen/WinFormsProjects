using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject05
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnArkaRenkDegistir_Click(object sender, EventArgs e)
        {

            //newlediğimiz ana formdaki verileri başka bir formda kullanmak için this ile RenkDeğiştirenForma
            //atıyoruz.
            //this-o anda aktif olan anaformu referans eder.
            //frm.Show();

            // Ana Form için yeni instance oluşturup, açılacak form'a parametre olarak gönderirsek, o an için 
            // aktif olan ana form instance'ını değil, yepyeni bir instance yollamış oluruz./
            //AnaForm frm19 = new AnaForm();
            //frm19.BackColor = Color.Aqua;
            //frm19.Text = "Maşallah Çok Zekisiniz.";
            //RenkDegistirenForm frm = new RenkDegistirenForm(frm19);
            //frm19.ShowDialog();

            /*1.YOL: ANA FORMUN AÇILACAK DİĞER FORMA CONSTRUCTOR ARACILIĞI ile 
                     REFERANS OLARAK GEÇİLMESİ
            /*Açılan forma this parametresi yollamak , o an aktif olan instance'ı 
             yani current instance'ı referance vermiş oluruz.
             Yeni açılacak formun constructorını da buna göe düzenlemeliyiz.*/

            RenkDegistirenForm frm = new RenkDegistirenForm(this);
            frm.ShowDialog();

            /* 2.YOL: ANAFORM'DAN AÇILAN 2.FORMUN CLASSINDA YENİ BİR PUBLİC PROPERTY TANIMLAYARAK 
             *        ANAFORM'A GEÇİRMEK İSTEDİĞİMİZ DEĞERİ BU PUBLİC PROPERTY ARACILIĞIYLA 2.FORMDAN
             *        ANAFORM'A TAŞINMASI*/
            //RenkDegistirenForm frm = new RenkDegistirenForm();
            //frm.ShowDialog();
            //this.BackColor = frm.newColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10000;
            //timer ile çalışacağımızda alt satır açılmalı
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RenkDegistirenForm frm = new RenkDegistirenForm(this);
            frm.ShowDialog();
            this.BackColor = frm.YeniRengiAl(BackColor);
        }
    }
}
