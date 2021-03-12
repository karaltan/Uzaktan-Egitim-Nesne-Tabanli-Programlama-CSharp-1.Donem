using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hesap;
            hesap = 0;

            try
            {
                if (checkBox1.Checked)
                    hesap = hesap + 1 * Convert.ToInt32(textBox1.Text);
                if (checkBox2.Checked)
                    hesap = hesap + 5 * Convert.ToInt32(textBox2.Text);
                if (checkBox3.Checked)
                    hesap = hesap + 10 * Convert.ToInt32(textBox3.Text);
                if (checkBox4.Checked)
                    hesap = hesap + 5 * Convert.ToInt32(textBox4.Text);
                if (checkBox5.Checked)
                    hesap = hesap + 1.5 * Convert.ToInt32(textBox5.Text);

                label1.Text = hesap.ToString() + " TL";
            }
            catch(Exception hata)
            {
                MessageBox.Show("Genel Hata Oluştu!","HATA");
            }

        }
    }
}
