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
    public partial class HedefForm : Form
    {
        public HedefForm(KaynakForm p)
        {
            InitializeComponent();

            labelAdi.Text = p.textBoxAdi.Text;
            labelSoyadi.Text = p.textBoxSoyadi.Text;
            labelAciklama.Text = p.textBoxAciklama.Text;

            labelAdi.Font = p.textBoxAdi.Font;
            labelSoyadi.Font = p.textBoxSoyadi.Font;
            labelAciklama.Font = p.textBoxAciklama.Font;

            labelAdi.ForeColor = p.textBoxAdi.ForeColor;
            labelSoyadi.ForeColor = p.textBoxSoyadi.ForeColor;
            labelAciklama.ForeColor = p.textBoxAciklama.ForeColor;
        }
        public HedefForm()
        {
            InitializeComponent();
        }
    }
}
