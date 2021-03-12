using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mesajkutusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { // örnek: çıkış onayı almak
           DialogResult sonuc;
           sonuc = MessageBox.Show("Çıkmak istiyor musunuz?","ÇIKIŞ",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
           if (sonuc == DialogResult.Yes)
           {
               Application.Exit();
           }
           if (sonuc == DialogResult.No)
           {
               
           }

        }

        private void button2_Click(object sender, EventArgs e)
        {  
            int sonuc;
            sonuc = (int)MessageBox.Show("Çıkmak istiyor musunuz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == 6) //EVETe basmak 6 değeri döndürür
            {
                Application.Exit();
            }
            if (sonuc == 7)// HAYIRa basmak 7 değeri döndürür
            {

            }
        }

        }
    }

