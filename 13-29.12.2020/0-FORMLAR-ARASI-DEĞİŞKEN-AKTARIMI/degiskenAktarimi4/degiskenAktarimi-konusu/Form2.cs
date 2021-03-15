using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace degiskenAktarimi_konusu
{
    public partial class Form2 : Form
    {
        public string kullaniciAdi { 
            get; set; 
        }

        public string sifre { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = kullaniciAdi;
            
        }
    }
}
