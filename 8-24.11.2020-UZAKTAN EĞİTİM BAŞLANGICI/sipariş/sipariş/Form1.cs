using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sipariş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hesap;
            hesap = 0;
            if (checkBox1.Checked)
                hesap = hesap + 1;
            if (checkBox2.Checked)
                hesap = hesap + 5;
            if (checkBox3.Checked)
                hesap = hesap + 10;
            if (checkBox4.Checked)
                hesap = hesap + 5;
            if (checkBox5.Checked)
                hesap = hesap + 1.5;

            label1.Text = hesap.ToString() + " TL";

        }
    }
}
