using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace degiskenAktarimi
{
    public partial class Form1 : Form
    {
        // BURASI ÇOK ÖNEMLİİİİİİİİİİİİİİİ
        public static int x = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = 0;
            label1.Text = x.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            x = 1;
            label1.Text = x.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        { 
            this.Hide();

            Form2 yeni = new Form2();
            yeni.ShowDialog();

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
