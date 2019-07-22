using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsProject01
{
    public partial class FrmDeneme : Form 
    {
        int[] Dizi = { 10, 20, 35, 28, 34 };
        int Toplam;

        public FrmDeneme()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            Temizle();// Toplam = 0;// her tıklandığında toplamamaması için toplamın scopeta sıfırlanması gerekir.
            ForDongusu();
            // Aşağıdaki FOR DONGUSU yerine yukarıdaki methodu tanımlayarak kullandık.
            //listBoxFor.Items.Clear();//Listboxın içindeki tüm itemları siler.

            //for(int i = 0; i<Dizi.Length;i++)
            //{
            //    Toplam = Toplam + Dizi[i];
            //    //Toplam += Dizi [i];
            //    listBoxFor.Items.Add(Dizi[i]);

            //}
            //listBoxFor.Items.Add("Toplam Değer = " + Toplam);
        }
        public void ForDongusu()
        {

            listBoxFor.Items.Clear();//Listboxın içindeki tüm itemları siler.

            for (int i = 0; i < Dizi.Length; i++)
            {
                Toplam = Toplam + Dizi[i];
                //Toplam += Dizi [i];
                listBoxFor.Items.Add(Dizi[i]);

            }
            listBoxFor.Items.Add("Toplam Değer = " + Toplam);

        }
        

        private void btnForEach_Click(object sender, EventArgs e)
        {
            Temizle();// her tıklandığında toplamamaması için toplamın scopeta sıfırlanması gerekir.
            listBoxForEach.Items.Clear();//Listboxın içindeki tüm itemları siler.
            foreach (int d in Dizi)
            {
                Toplam = Toplam + d;
                listBoxForEach.Items.Add(d);
            }
            listBoxForEach.Items.Add("Toplam Değer = " + Toplam);
        }
        public void Temizle()
        {
            Toplam = 0;

        }
    }
}
