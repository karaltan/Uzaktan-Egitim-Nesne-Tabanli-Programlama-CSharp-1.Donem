using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace comboBox_sehir_ilce
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Kocaeli");
            comboBox1.Items.Add("Ankara");
            comboBox1.Items.Add("Bursa");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)//ilk eleman seçildiyse
            {
                comboBox2.Items.Clear();
                //comboBox2.Text = "";
                comboBox2.Items.Add("İZMİT");
                comboBox2.Items.Add("KANDIRA");
                comboBox2.Items.Add("GEBZE");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                //comboBox2.Text = "";
                comboBox2.Items.Add("MAMAK");
                comboBox2.Items.Add("KIZILCAHAMAM");
                comboBox2.Items.Add("ETİMESGUT");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
               // comboBox2.Text = "";
                comboBox2.Items.Add("NİLÜFER");
                comboBox2.Items.Add("ORHANGAZİ");
                comboBox2.Items.Add("GEMLİK");
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
    }
}
