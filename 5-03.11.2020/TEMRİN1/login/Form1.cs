using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad;
            int yas;

            ad = textBox1.Text;
            yas =Convert.ToInt32(textBox2.Text);

            if (yas >= 18)
                MessageBox.Show("ERGENSİNİZ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
                MessageBox.Show("TIFILSINIZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
