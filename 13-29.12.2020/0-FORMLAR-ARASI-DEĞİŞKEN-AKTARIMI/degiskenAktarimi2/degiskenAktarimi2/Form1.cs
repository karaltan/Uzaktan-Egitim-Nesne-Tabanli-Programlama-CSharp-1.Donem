using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace degiskenAktarimi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kadi = textBox1.Text;

            Form2 yeni = new Form2();
            {
                // formu çağırırken değeri gönderiyorum

                yeni.kullaniciadi = this.textBox1.Text;
                //yeni.kullaniciadi = kadi;
            }
            yeni.Show(); // diğer form açıldı

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
