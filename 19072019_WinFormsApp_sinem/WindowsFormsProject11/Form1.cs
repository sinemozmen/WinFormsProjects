using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = { txtId.Text.Trim() , txtAd.Text.Trim(), txtSoyad.Text.Trim() };
            if (txtAd.Text != "" && txtSoyad.Text != "")
            {
                ListViewItem listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                txtId.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    txtId.Text = item.SubItems[0].Text;
                    txtAd.Text = item.SubItems[1].Text;
                    txtSoyad.Text = item.SubItems[2].Text;
                }
        }
        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (txtAd.Text.Trim() != "" && txtSoyad.Text.Trim() != "")
                //Listviewitem seçili bir satırdır.Subitem'ları 0.hücre,1.hücre....
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                     item.SubItems[0].Text = txtId.Text;
                     item.SubItems[1].Text = txtAd.Text;
                     item.SubItems[2].Text = txtSoyad.Text;
                }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                for (int i = 0; i < listView1.SelectedItems.Count; i++)
                {
                    listView1.Items[i].Remove();
                }
            txtId.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("ID",129, HorizontalAlignment.Left);
            listView1.Columns.Add("AD", 129, HorizontalAlignment.Left);
            listView1.Columns.Add("SOYAD", 129, HorizontalAlignment.Left);
        }
        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
