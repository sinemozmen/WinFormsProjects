using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject06
{
    public partial class KaynakForm : Form
    {
        Font f1, f2, f3;
        Color c1, c2, c3;

        public KaynakForm()
        {
            InitializeComponent();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            textBoxAdi.Clear();
            textBoxSoyadi.Clear();
            textBoxAciklama.Clear();

            textBoxAdi.Font = f1;
            textBoxSoyadi.Font = f2;
            textBoxAciklama.Font = f3;


            textBoxAdi.ForeColor = c1;
            textBoxSoyadi.ForeColor = c2;
            textBoxAciklama.ForeColor = c3;
        }

        private void btnFontAyarla_Click(object sender, EventArgs e)
        {

            f1 = textBoxAdi.Font;
            f2 = textBoxSoyadi.Font;
            f3 =  textBoxAciklama.Font;

            FontDialog yeniFont = new FontDialog();
            yeniFont.ShowDialog();

            textBoxAdi.Font = yeniFont.Font;
            textBoxSoyadi.Font = yeniFont.Font;
            textBoxAciklama.Font = yeniFont.Font;
        }


        private void btnRenkAyarla_Click(object sender, EventArgs e)
        {

            c1 = textBoxAdi.ForeColor;
            c2 = textBoxSoyadi.ForeColor;
            c3 = textBoxAciklama.ForeColor;

            ColorDialog newColor = new ColorDialog();
            newColor.ShowDialog();

            textBoxAdi.ForeColor = newColor.Color;
            textBoxSoyadi.ForeColor = newColor.Color;
            textBoxAciklama.ForeColor = newColor.Color;
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            //HedefForm hedef = new HedefForm(this);
            //hedef.ShowDialog();

            HedefForm hedef = new HedefForm();
            hedef.labelAdi.Text = textBoxAdi.Text;
            hedef.labelSoyadi.Text  = textBoxSoyadi.Text;
            hedef.labelAciklama.Text = textBoxAciklama.Text;

            hedef.labelAdi.Font = textBoxAdi.Font;
            hedef.labelSoyadi.Font = textBoxSoyadi.Font;
            hedef.labelAciklama.Font = textBoxAciklama.Font;

            hedef.labelAdi.ForeColor = textBoxAdi.ForeColor;
            hedef.labelSoyadi.ForeColor = textBoxSoyadi.ForeColor;
            hedef.labelAciklama.ForeColor = textBoxAciklama.ForeColor;

            hedef.ShowDialog();
        }

    }
}
