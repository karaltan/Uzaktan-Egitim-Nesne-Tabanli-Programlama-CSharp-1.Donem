using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace menuKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Blue;
            label2.ForeColor = Color.Yellow;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Red;
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
            label2.ForeColor = Color.White;
        }
    }
}
