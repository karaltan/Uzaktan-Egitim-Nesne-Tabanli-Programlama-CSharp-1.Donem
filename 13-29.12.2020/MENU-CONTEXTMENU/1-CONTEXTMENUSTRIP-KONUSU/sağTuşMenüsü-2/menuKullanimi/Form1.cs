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
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Red;
        }
    }
}
