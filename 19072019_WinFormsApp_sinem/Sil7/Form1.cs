using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sil7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ogrenci o = new Ogrenci();
            //o.Yas = 20;
            int abcde = 5;
            Metot2(abcde);//Metot2(o)
            MessageBox.Show("Değeri :" + abcde);//abcde 5 olarak gelecek çünkü value type.
            //ancak ogr.Yas olduğunda 30 olarak gelecek çünkü Metot2(o)'da o'nun referansına giderek Metot2'ye girecek.   
            
        }
        //private void Metot2(Ogrenci ogr)
        //{
        //    ogr.Yas = 30;

        //}
        private void Metot2(int abcde)
        {
           abcde = 22;

        }
    }
    class Ogrenci
    {
        public int Yas { get; set; }

    }
}
