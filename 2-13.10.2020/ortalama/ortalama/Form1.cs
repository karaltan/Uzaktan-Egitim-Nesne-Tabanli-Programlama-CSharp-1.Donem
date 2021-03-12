using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ortalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  //TEMRİN : ORTALAMA HESABI
            double p1, p2, p3, ort;

            p1 = Convert.ToDouble(textBox1.Text);
            p2 = Convert.ToDouble(textBox2.Text);
            p3 = Convert.ToDouble(textBox3.Text);

            ort = (p1 + p2 + p3) / 3;

            textBox4.Text = ort.ToString();
        }
    }
}
