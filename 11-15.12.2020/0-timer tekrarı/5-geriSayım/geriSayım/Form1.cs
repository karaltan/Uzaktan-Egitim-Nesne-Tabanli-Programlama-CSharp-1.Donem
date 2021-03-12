using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace geriSayım
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi = 3;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Text = sayi.ToString(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi--;
            label1.Text = sayi.ToString();
            if (sayi == 0)
            {
                timer1.Enabled = false;
                // buraya yeni form kodları gelecektir....
            }

        }
    }
}
