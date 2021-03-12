using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace menu_konusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //Environment.Exit(0);
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hakkinda frm = new hakkinda(); // hakkinda formu oluşturuluyor
            frm.ShowDialog(); // hakkinda formu çağırılıyor
            // .ShowDialog() ile çağırınca bu form kapatılmadan diğerine geçilemez!!

            //MessageBox.Show("Bu proje okul için hazırlanmıştır","AK SOFT",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe","karaltan.bmp");
        }

        private void hesapMakinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void boşPaintAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("mspaint.exe");
        }

        private void fORM2YEGEÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void fORM3GEÇToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm2 = new Form3();
            frm2.Show();
        }
    }
}
