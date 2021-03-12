using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progressBenzinBolumu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            label8.Text = progressBar1.Value.ToString();

            decimal benzin = numericUpDown1.Value;

            decimal odenecek = benzin * progressBar1.Value;

            label6.Text = odenecek.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value += 1;
                label8.Text = progressBar1.Value.ToString();

                decimal benzin = numericUpDown1.Value;

                decimal odenecek = benzin * progressBar1.Value;

                label6.Text = odenecek.ToString();
            }
            catch
            {
                timer1.Enabled = false;
                MessageBox.Show("FULLENDİ!!!");

            }
        }
    }
}
