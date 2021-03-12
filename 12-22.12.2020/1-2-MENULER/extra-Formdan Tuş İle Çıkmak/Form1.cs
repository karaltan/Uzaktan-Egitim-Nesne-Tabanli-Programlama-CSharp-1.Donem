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

        void cikis(object sender, KeyEventArgs e)
        {

            if (e.Control && e.KeyCode == Keys.G)
            {
                DialogResult cikis = MessageBox.Show
                        ("Ctrl+C tuşlarına basıldı. Çıkmak istediğinize emin misiniz",
                        "Çıkış", MessageBoxButtons.OKCancel);
                if (cikis == DialogResult.OK) Application.Exit();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            cikis(sender, e);
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cikis(sender,e);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cikis(sender, e);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            cikis(sender, e);
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            cikis(sender, e);
        }
    }
}
