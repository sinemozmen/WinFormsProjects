using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject01
{
    public partial class FrmDonguler : Form
    {   //Project : Döngüler 

        int[] Dizi = { 10, 20, 25, 28, 34 };
        int toplam = 0;
        public FrmDonguler()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnFor_Click(object sender, EventArgs e)
        {
            Temizle();

            listBoxFor.Items.Clear();

            for (int i = 0; i < Dizi.Length; i++)
            {
                toplam = toplam + Dizi[i];
                // toplam += Dizi[i];
                listBoxFor.Items.Add(Dizi[i]);
            }
            listBoxFor.Items.Add("toplamDeger = " + toplam);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Temizle();
            listBoxForEach.Items.Clear();
            foreach (int d in Dizi)
            {
                toplam = toplam + d;
                listBoxForEach.Items.Add(d);
            }
            listBoxForEach.Items.Add("toplamDeger = " + toplam);
        }
        public void Temizle()
        {
            toplam = 0;
        }

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            Temizle();
            WhileDongu();
        }
        public void WhileDongu()
        {
            int i = 0;
            listBoxWhile.Items.Clear();
            while(i<Dizi.Length)
            {
                listBoxWhile.Items.Add(Dizi[i]);
                toplam += Dizi[i];
                i++;
            }
            listBoxWhile.Items.Add("Toplam = " + toplam);

        }

        public void BtnDoWhile_Click(object sender, EventArgs e)
        {
            Temizle();
            DoWhileDongusu();
        }
        public void DoWhileDongusu()
        {
            int i = 0;
            listBoxDowhile.Items.Clear();
            do
            {
                listBoxDowhile.Items.Add(Dizi[i]);
                toplam += Dizi[i];
                i++;


            } while (i < Dizi.Length);
            listBoxDowhile.Items.Add("Toplam = " + toplam);
        }

        private void BtnIENum_Click(object sender, EventArgs e)
        {
            Temizle();
            IEnumDongu();
        }
        public void IEnumDongu()
        {
            listBoxIEnum.Items.Clear();
            IEnumerator IENum = Dizi.GetEnumerator();//Dizi Ienumerabledan türüyor.
            while(IENum.MoveNext())
            {
                listBoxIEnum.Items.Add(IENum.Current);
                //Toplam+=Dizi[i];
                //i++;
                toplam += (int)IENum.Current;
            }
            listBoxIEnum.Items.Add("Toplam = " + toplam);

        }

        private void FrmDonguler_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, İlk Form Uygulamama Hoşgeldiniz!!");
        }
    }   
    
       

    
}
