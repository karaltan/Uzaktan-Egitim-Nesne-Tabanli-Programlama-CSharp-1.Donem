using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   //değişken tanımlama
            string kadi, parola;
            //verileri almak
            kadi=textBox1.Text;
            parola = textBox2.Text;
            //veri karşılaştırma (if)
            if (kadi == "admin" & parola == "123")
            {
                //yeni form açılıyor  
                //proje->add windows form ile yeni form eklenir
                Form2 yeniform = new Form2();
                yeniform.Show();
                this.Hide();
            }
            else
                MessageBox.Show("HATALI GİRİŞ!!", "HATA");

        }
    }
}
