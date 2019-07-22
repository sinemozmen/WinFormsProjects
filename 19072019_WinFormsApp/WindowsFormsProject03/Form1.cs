using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject03
{
    public partial class Form1 : Form
    {
        // Project : Event Order for Keys 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxOlay_KeyDown(object sender, KeyEventArgs e)
        {
            Yaz("KeyDown oldu");
        }
        private void Yaz(string OlayAdi)//Sadece bu class içinde kullanılabilir
        {
            /*String concatenation*/
            //string str = DateTime.Now + " " + OlayAdi;
            //listBoxOlay.Items.Add(str);

            /*String class'ının Format methodu kullanarak : */

            listBoxOlay.Items.Add(string.Format("{1} {0}", OlayAdi, DateTime.Now));
            /*String interpolation*/

            //string s2 = $"{DateTime.Now} {OlayAdi}";
            //listBoxOlay.Items.Add(s2);
        }

        private void textBoxOlay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Yaz("KeyPress oldu");
        }

        private void textBoxOlay_KeyUp(object sender, KeyEventArgs e)
        {
            Yaz("KeyUp oldu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxOlay.Items.Clear();
        }
    }
}
