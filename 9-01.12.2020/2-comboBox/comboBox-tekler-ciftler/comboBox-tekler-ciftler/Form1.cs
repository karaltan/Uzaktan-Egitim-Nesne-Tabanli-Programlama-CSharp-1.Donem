using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace comboBox_tekler_ciftler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 1) comboBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            for (int i = 0; i <= 100; i=i+1)
            {
                if (i % 2 == 0) comboBox2.Items.Add(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form ilk açıldığında yapılaaklar buraya yazılır
            //MessageBox.Show("form yüklendi");
            for (int i = 0; i <= 100; i++)
            {
                comboBox1.Items.Add(i); comboBox2.Items.Add(i);
            }
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int top = 0;
            int adet=comboBox1.Items.Count;
            for (int i = 0; i < adet ; i++)
            {
                top = top +Convert.ToInt32(comboBox1.Items[i].ToString());
            }
            label1.Text = top.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int top = 0;
            int adet = comboBox2.Items.Count;
            for (int i = 0; i < adet; i++)
            {
                top = top + Convert.ToInt32(comboBox2.Items[i].ToString());
            }
            label2.Text = top.ToString();
        }
    }
}
