using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace progressBarKonusu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           timer1.Enabled = true; //timer tetiklendi
          //progressBar1.Value += 10;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //MessageBox.Show("1 sn geçti");
            try
            {
                progressBar1.Value += 10;
            }
            catch
            {
                timer1.Enabled = false;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        }
    }
}
