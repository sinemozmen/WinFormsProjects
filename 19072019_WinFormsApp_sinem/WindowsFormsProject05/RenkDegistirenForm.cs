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
    public partial class RenkDegistirenForm : Form
    {   //1.YOL için tanımlandı: //
        public AnaForm BağlananAnaForm;
        //2.YOL için tanımlandı: //
        public Color newColor { get; set; }
        public RenkDegistirenForm(AnaForm p)//this ile gelen formun cinsi AnaForm
        {
            InitializeComponent();
            BağlananAnaForm = p;
        }
        public RenkDegistirenForm()//this ile gelen formun cinsi AnaForm
        {
            InitializeComponent();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            /*1.YOL İÇİN YAZILDI:Anaform'a 2.formdan ulaşılması*/
            BağlananAnaForm.BackColor = YeniRengiAl(BağlananAnaForm.BackColor);

            /*2.YOL İÇİN YAZILDI:Anaform'a 2.formdan public property ile değer gönderilmesi*/
            //Color oldColor = Color.LightGray;
            //newColor = YeniRengiAl(oldColor);


            Hide();//renk değiştiren formun kapanıp arkadaki ana formun görüntülenmesini sağlar.
        }
        public Color RenkKodunaCevir(string RenkMetni)
        {
            switch (RenkMetni.ToLower())
            {
                case "kırmızı":
                    return Color.Red;
                case "mavi":
                    return Color.Blue;
                case "yeşil":
                    return Color.Green;
                default:
                    throw new NotImplementedException();//girilen renk yukarıdakilerden biri değil
            }
        }
        public Color YeniRengiAl(Color ÖncekiRenk)
        {
            try
            {
                return RenkKodunaCevir(txtRenkGirisi.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Girilen renk tanımlı değil.Önceki renk uygulandı.");
                return ÖncekiRenk;
            }
        }
        private void btnRenkDegistir_Enter(object sender, EventArgs e)
        {
           
        }
    }
}
