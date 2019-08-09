using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sil5
{
    public partial class Form1 : Form
    {
        private string[] medeniDurumlar = { "Evli", "Bekar", "Boşanmış", "Eşini Kaybetmiş" };
        public Form1()
        {
            InitializeComponent();
        }
        private enum EnumMedeniDurumlar
        {
            Evli=11,
            Bekar = 22,
            Bosanmis = 13,
            EsiniKaybetmis = 14

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string item in medeniDurumlar)
            {
                cmbMedeniDurumlar.Items.Add(item);
            }
            //indexlerle çalışırken hata almayı önlemek için kontrol koymalıyız:
            if(cmbMedeniDurumlar.Items.Count>0)
                cmbMedeniDurumlar.SelectedIndex = 0;
            //cmbMedeniDurumlar.SelectedItem = "Bekar";

            //MessageBox.Show(Convert.ToString(EnumMedeniDurumlar.Evli));// Evli olarak yazdıracak.Enum'daki string değeri yazdıracak.
            //MessageBox.Show(((int)EnumMedeniDurumlar.Bekar).ToString());//22 olarak gösterecek.Enum'ın int değerini gösterecek.

            //cmbMedeniDurumlar2.Items.AddRange(Enum.GetNames(typeof(EnumMedeniDurumlar)));

            //cmbMedeniDurumlar2.Items.AddRange(Enum.GetValues(typeof(EnumMedeniDurumlar)));

            foreach (int item in Enum.GetValues(typeof(EnumMedeniDurumlar)))
            {
                cmbMedeniDurum3.Items.Add(item);
            }
        }
    }
}
