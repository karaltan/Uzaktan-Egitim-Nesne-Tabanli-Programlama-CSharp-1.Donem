using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace olaylar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 1 Click olayı gerçekleşti, \n Click olayı=mouse sol tuşa basıp çektikten sonraki olaydır");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Buton 2 Click olayı gerçekleşti");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // formun temel olayı Load dır...
            // formun içine girince click değil load açılır...
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            label2.Text = "şu anda sol tuş basılıdır!!!";
            this.BackColor = Color.Red;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            label2.Text = "şu anda sol tuşu bıraktın!!!";
            this.BackColor = Color.Azure;
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
           // MessageBox.Show("üstümden git :D");
            label4.BackColor = Color.LimeGreen;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
           // label4.BackColor = Color.Wheat;
            label4.BackColor = Color.FromArgb(255,255, 192);
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("benim durumumu değiştirdin");
            //onaylı olup olmaması if ile bulunur.....
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("benim durumumu değiştirdin");
            //onaylı olup olmaması if ile bulunur.....
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bana tıkladın");
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("benden bir eleman seçtin");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            label5.Text="beni açtın :=)";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("benden bir eleman seçtin");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form Kapanmıştır, Hayırlı Günler...");
        }
    }
}
