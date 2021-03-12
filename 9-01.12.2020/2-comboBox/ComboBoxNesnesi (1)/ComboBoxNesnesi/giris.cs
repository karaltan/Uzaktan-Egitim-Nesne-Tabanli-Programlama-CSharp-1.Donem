using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxNesnesi
{
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string secilen = comboBox1.SelectedItem.ToString();
            label2.Text = secilen+" seçtiniz";
        }

        private void button2_Click(object sender, EventArgs e)
        {
          int sira=comboBox1.SelectedIndex;
          label3.Text =(sira+1).ToString() + ". sıradakini seçtin";

          label4.Text = comboBox1.Items[sira].ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.SelectedIndex = 1;
            }
            catch (ArgumentOutOfRangeException hata)
            {
                MessageBox.Show("Listede Olmayan Bir İndis Hatası");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = comboBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // comboBox1.Items.Remove("Diğer");
           comboBox1.Items.RemoveAt(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Belirtilmemiş");
           // comboBox1.Items.Insert(0, "Belirtilmemiş");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();//tüm elemanları siler. dikkatli kullanılmalıdır
        }
    }
}
