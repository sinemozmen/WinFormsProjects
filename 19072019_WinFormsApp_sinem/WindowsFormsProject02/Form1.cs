using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject02
{
    public partial class Form1 : Form
    {   // Project : Textbox'a "yalnız Sayı" ya da yalnız "Karakter" girme
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_YalnizKarakter_KeyPress(object sender, KeyPressEventArgs e)
        {   //Key press default iken tüm karakterleri gösterecek

            e.Handled = !char.IsLetter(e.KeyChar) 
                && !char.IsControl(e.KeyChar) &&
                !char.IsSeparator(e.KeyChar);//Harf dışında bir şey girildiği zaman sistem handle edecek.
            // ve ekrana sadece harfleri gösterecek.

            if (e.KeyChar == '1')
                txt_YalnizKarakter.Text = "bir";
            if (e.KeyChar == 'a')
            {
                txt_YalnizKarakter.Text = "a ya bastınız";
            }
            

        }

        private void txt_YalnizKarakter_MouseEnter(object sender, EventArgs e)
        {
            txt_YalnizKarakter.BackColor = SystemColors.ButtonHighlight;
            txt_YalnizKarakter.BackColor = Color.LightGreen;
          //  txt_YalnizKarakter.BackColor = System.Drawing.SystemColors.ActiveCaption;
        }

        private void txt_YalnizKarakter_Resize(object sender, EventArgs e)
        {

        }

        private void txt_YalnizSayi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_YalnizSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.Handled = !char.IsNumber(e.KeyChar);
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        

        }

        private void txt_CharacterCasingToUpper_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToUpper.CharacterCasing = CharacterCasing.Upper;
            //Properties sekmesinden de yapılabilir :) 
        }

        private void txt_CharacterCasingToLower_KeyPress(object sender, KeyPressEventArgs e)
        {
            txt_CharacterCasingToLower.CharacterCasing = CharacterCasing.Lower;
        }

        private void txt_YalnizKarakter_MouseLeave(object sender, EventArgs e)
        {
            txt_YalnizKarakter.BackColor = Color.LightSkyBlue;
            //txt_YalnizKarakter.BackColor = DefaultBackColor;
        }
    }
}
