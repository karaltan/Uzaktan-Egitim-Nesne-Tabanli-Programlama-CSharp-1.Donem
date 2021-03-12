using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat=0,sonuc=0;

            fiyat =Convert.ToDouble( textBox1.Text);

            if (checkBox1.Checked)
            {
                sonuc = fiyat + (fiyat * 18) / 100;
            }
            else
            {
                sonuc = fiyat;
            }

            label2.Text = sonuc.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "fiyat giriniz";

        }

 
    }
}
