using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace comboBox_dortislem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double sonuc = 0;
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);

            if (comboBox1.SelectedItem.ToString() == "+") sonuc = a + b;
            else if (comboBox1.SelectedItem.ToString() == "-") sonuc = a- b;
            else if (comboBox1.SelectedItem.ToString() == "*") sonuc = a * b;
            else if (comboBox1.SelectedItem.ToString() == "/")
            {
                if (b == 0) MessageBox.Show("bölen 0 olamaz!");
                else sonuc = a / b;
            }

            label4.Text = sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
