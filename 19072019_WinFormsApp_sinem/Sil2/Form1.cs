﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sil2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   


        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = 5;
            int sayi2 = 13;
            int toplam = sayi1 + sayi2;
            MessageBox.Show(Convert.ToString(toplam));

        }
    }
}
