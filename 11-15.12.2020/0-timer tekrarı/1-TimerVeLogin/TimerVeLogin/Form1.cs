using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimerVeLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (textBox1.Text=="kullanıcı adı") textBox1.Clear();
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") textBox1.Text = "kullanıcı adı";
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            if (textBox2.Text == "parola") textBox2.Clear();
        }

        private void textBox2_MouseLeave(object sender, EventArgs e)
        {
            if (textBox2.Text == "") textBox2.Text = "parola";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value -= 1;
            }
            catch (Exception hata)
            {
                timer1.Enabled = false;
                MessageBox.Show("Verilen sürede giriş yapamadınız. Program kapatılacaktır...");
                Application.Exit();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "karaltan" & textBox2.Text == "12345")
            {
                timer1.Enabled = false;
                MessageBox.Show("Başarılı giriş...");
                MessageBox.Show("diğer gorma yönleniyorsunuz...");
                //buraya diğer forma geçiş kodları gelecektir...
            }
        }
    }
}
