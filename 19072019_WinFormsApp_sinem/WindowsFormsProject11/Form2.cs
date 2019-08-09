using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject11
{

    public partial class Form2 : Form
    {
        List<Bilgiler> lstIsimSoyisim = new List<Bilgiler>();
        //Listbox a eklenip çıkartılacak dataları tutan liste
        public Form2()
        {
            InitializeComponent();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtAd.Text != "" && txtSoyad.Text != "")
            {
                //Bilgiler b1 = new Bilgiler();

                //b1.Id = txtID.Text;
                //b1.Ad = txtAd.Text;
                //b1.Soyad = txtSoyad.Text;

                //Simplified Object Initialization
                Bilgiler b1 = new Bilgiler
                {
                    Id = txtID.Text,
                    Ad = txtAd.Text,
                    Soyad = txtSoyad.Text
                };

                lstIsimSoyisim.Add(b1);

                ListBoxDoldur();
            }
            else
            {
                MessageBox.Show("Lütfen gerekli alanları doldurunuz");
                Temizle();
            }
            txtAd.Clear();
            txtSoyad.Clear();
            txtID.Clear();
        }

        private void ListBoxDoldur()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lstIsimSoyisim;

            listBox1.DisplayMember = "AdSoyad";
            listBox1.ValueMember = "Id";
        }

        private void Temizle()
        {
            txtID.Text = txtAd.Text = txtSoyad.Text = String.Empty;
            txtID.Focus();
        }
        private void btnDeğiştir_Click(object sender, EventArgs e)
        {
            //1.YOL
            if (listBox1.SelectedIndex >= 0 )
            {
                ((Bilgiler)listBox1.SelectedItem).Id = txtID.Text;
                ((Bilgiler)listBox1.SelectedItem).Ad = txtAd.Text;
                ((Bilgiler)listBox1.SelectedItem).Soyad = txtSoyad.Text;


                ListBoxDoldur();

            }
            else
            {
                MessageBox.Show("Lütfen değiştirmek istediğiniz satırı seçiniz.");
            }

            //2.YOL
            //if (listBox1.SelectedItem != null)
            //{
            //    foreach (Bilgiler blg in lstIsimSoyisim)
            //    {
            //        if (blg.Id == Convert.ToString(listBox1.SelectedValue))
            //        {
            //            lstIsimSoyisim.Remove(blg);
            //            break;
            //        }
            //    }
            //    Bilgiler blgDegismis = new Bilgiler();

            //    blgDegismis.Ad = txtAd.Text;
            //    blgDegismis.Soyad = txtSoyad.Text;
            //    blgDegismis.Id = txtID.Text;

            //    lstIsimSoyisim.Add(blgDegismis);

            //    listBox1.DataSource = null;
            //    listBox1.DataSource = lstIsimSoyisim;
            //    listBox1.DisplayMember = "AdSoyad";
            //    listBox1.ValueMember = "Id";
            //}
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string[] parcalar = Convert.ToString(listBox1.SelectedItems[0]).Split(' ');
            //    string Ad = parcalar[0];
            //    string Soyad = parcalar[2];
            if (listBox1.SelectedItem != null)
            {
                Bilgiler blg = (Bilgiler)listBox1.SelectedItem;
                txtAd.Text = blg.Ad;
                txtSoyad.Text = blg.Soyad;
                txtID.Text = blg.Id;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                foreach (Bilgiler blg in lstIsimSoyisim)
                {
                    if (blg.Id == Convert.ToString(listBox1.SelectedValue))
                    {
                        lstIsimSoyisim.Remove(blg);
                        break;
                    }
                }
                ListBoxDoldur();
            }
            txtID.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
        }
        class Bilgiler
        {
            public string Id { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public string AdSoyad
            {
                get
                { return Ad + " " + Soyad; }
                set
                {; }
            }
        }
    }
}
