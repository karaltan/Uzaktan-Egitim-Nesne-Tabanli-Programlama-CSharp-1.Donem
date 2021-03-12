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
            string hobilerim = "";

            if (checkBox1.Checked) hobilerim =hobilerim+ checkBox1.Text;
            if (checkBox2.Checked) hobilerim += checkBox2.Text;
            if (checkBox3.Checked) hobilerim += checkBox3.Text;

            label3.Text = hobilerim;



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //yüzmeyi seviyorsa ona tatil hediye et
            if (checkBox2.Checked) MessageBox.Show("TATİL KAZANDINIIIIIIIZ!!!");
            else MessageBox.Show("yüzmeyi seçmediniz");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //eğer fb seçili ise şampiyon yazsın

            if (radioButton2.Checked) MessageBox.Show("ŞAMPİYON!!!");
            else MessageBox.Show("fenerli olmalısın...");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string takim = "";

            if (radioButton1.Checked) takim = "BEŞİKTAŞ";
            else if (radioButton2.Checked) takim = "FENERBAHÇE";
            else if (radioButton3.Checked) takim = "GALATASARAY";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            // this ifadesi bu form demektir
            if (radioButton4.Checked) this.BackColor = Color.Red;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked) this.BackColor = Color.Yellow;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked) this.BackColor = Color.Blue;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked) this.BackColor = Color.Black;
        }
    }
}
