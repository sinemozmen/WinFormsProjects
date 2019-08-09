using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject09
{
    public partial class Form1 : Form
    {
        int sallamaSayisi;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblZar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sallamaSayisi++;
            if(sallamaSayisi>10)
            {
                timer1.Stop();
                int zar1, zar2;
                Random rnd = new Random();
                zar1 = rnd.Next(0, 6);
                zar2 = rnd.Next(0, 6);

                lblZar1.ImageIndex = zar1;
                lblZar2.ImageIndex = zar2;



            }
            else
            {
                if (sallamaSayisi%2==0)
                {
                    btnSalla.Left += 20;
                    lblZar1.Left -= 20;
                    lblZar2.Left += 20;
                }
                else 
                {
                    btnSalla.Left-= 20;
                    lblZar1.Left += 20;
                    lblZar2.Left -= 20;
                }
                           

            }
        }

        private void btnSalla_Click(object sender, EventArgs e)
        {
            sallamaSayisi = 0;
            timer1.Start();
        }
    }
}
