using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject10
{   //MDI (Multiple Document Interface) ve ManuStrip basit ornegi 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void konuşöaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeni1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeni frm1 = new FormYeni();
            frm1.Show();
            frm1.MdiParent = this; // frm1 formunun parent'i form1'dir.Bu form Form1'in içinde açılacak.
        }

        private void yeni2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeni2 frm2 = new FormYeni2();
            frm2.Show();
            frm2.MdiParent = this;
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeni3 frm3 = new FormYeni3();
            frm3.Show();// MDİ özelliği vermedik.
        }

        private void merhabaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba De");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;//contain eden form Form1'dir.
        }
    }
}
