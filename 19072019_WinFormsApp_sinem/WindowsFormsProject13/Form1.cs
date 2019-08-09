using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject13
{
    public partial class Form1 : Form
    {

        public Dictionary<string, double> kahveFiyat = new Dictionary<string, double>();
        public Dictionary<string, double> sogukIcecek = new Dictionary<string, double>();
        public Dictionary<string, double> sicakIcecek = new Dictionary<string, double>();


        public Form1()
        {
            InitializeComponent();
  
        }




        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kahveFiyat.Add("Misto", 4.5);
            kahveFiyat.Add("Americano", 5.75);
            kahveFiyat.Add("Bianco", 6);
            kahveFiyat.Add("Macchiato", 6.75);
            kahveFiyat.Add("Con Panna", 8);
            kahveFiyat.Add("Mocha", 7.75);
            sicakIcecek.Add("Çay", 3);
            sicakIcecek.Add("Hot Chocolate", 4.5);
            sicakIcecek.Add("Chai Tea Latte ", 6.5);
            sogukIcecek.Add("Cola", 5.5);
            sogukIcecek.Add("Fanta", 5);

            foreach (string item in kahveFiyat.Keys)
            {
                cmbKahve.Items.Add(item);
            }
            foreach (string item in sogukIcecek.Keys)
            {
                cmbSogukIcecek.Items.Add(item);
            }
            foreach (string item in sicakIcecek.Keys)
            {
                cmbSicakIcecek.Items.Add(item);
            }

        }

        private void CmbKahve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
