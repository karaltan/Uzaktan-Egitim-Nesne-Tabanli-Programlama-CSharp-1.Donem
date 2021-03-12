using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ÇözBeni
{
    public partial class Form1 : Form
    {
        int sure = 5; //genel değişken, tüm form ve nesneler kullanır
        int bomba=-1;

        public Form1()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--; // sure=sure-1;
            label2.Text = sure.ToString();
            if (sure == 0) timer1.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bomba = rnd.Next(0, 2);
            // 0=kırmızı seçilirse bomba çözülür
            // 1=mavi seçilirse bomba çözülür
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked & bomba == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("BOMBAYI ÇÖZDÜNÜZ...");
            }
            else if (radioButton1.Checked & bomba == 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("BOOOOOOOOOOOOM!!!!!");

            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked & bomba == 1)
            {
                timer1.Enabled = false;
                MessageBox.Show("BOMBAYI ÇÖZDÜNÜZ...");
            }
            else if (radioButton2.Checked & bomba == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("BOOOOOOOOOOOOM!!!!!");

            }
        }
    }
}
