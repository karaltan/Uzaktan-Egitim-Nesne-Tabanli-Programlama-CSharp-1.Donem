using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toolTip_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("boş geçmeyelim", textBox1);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            toolTip1.Show("şu anda yazıyorsunuz...", textBox2,1000);
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Show("bana döneceksin..", textBox3, 1000);
        }
    }
}
