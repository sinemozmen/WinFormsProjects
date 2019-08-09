using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject07
{
    public partial class Form1 : Form
    {
        int orgX1Value;
        int orgY1Value;
        int orgX2Value;
        int orgY2Value;
        public Form1()
        {
            InitializeComponent();
            orgX1Value = picJerry.Location.X;
            orgY1Value= picJerry.Location.Y;
            orgX2Value = picTom.Location.X;
            orgY2Value = picTom.Location.Y;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            picJerry.Left += rnd.Next(0, 15);//timer 1 her tik olduğunda pictur'a 0-15 arası random kadar resme left ekleyecek.
            picTom.Left += rnd.Next(0, 15);
            //pictureBax'lardan herhangi birinin Right özelliği, bitiş panelinin solundan büyük veya eşit
            //ise timer durdurulur.
            if(picJerry.Right>=panelBitis.Left|| picTom.Right>=panelBitis.Left)
            {
                timer1.Stop();
                string kazanan;
                if(picJerry.Right>=picTom.Right)
                {
                    kazanan = "Jerry";
                }else
                {
                    kazanan = "Tom";
                }
                DialogResult dr = MessageBox.Show(string.Format("{0} Kazandı", kazanan), "****WINNER****", MessageBoxButtons.YesNo);
                if(DialogResult==DialogResult.Yes)
                {
                    timer1.Stop();
                    picJerry.Top = orgY1Value;
                    picJerry.Left = orgX1Value;
                    picTom.Top = orgY2Value;
                    picTom.Left = orgX2Value;
                }
            
            }


        }
    }
}
