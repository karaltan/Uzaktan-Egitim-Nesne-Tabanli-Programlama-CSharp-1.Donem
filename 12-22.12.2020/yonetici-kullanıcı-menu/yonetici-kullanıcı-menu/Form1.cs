using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace yonetici_kullanıcı_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            // değişkeni yakala ve kullan
            string gelendeger = login.kullaniciad;
            textBox1.Text=gelendeger;
            label1.Text="MERHABA:"+gelendeger;


            if (gelendeger == "smtal")
                yÖNETİMSELARAÇLARToolStripMenuItem.Enabled = true;
            if (gelendeger == "karaltan")
                //yÖNETİMSELARAÇLARToolStripMenuItem.Enabled = false;
              
                // ya da 
               yÖNETİMSELARAÇLARToolStripMenuItem.Visible = false;
                 
        }

        private void yÖNETİMSELARAÇLARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
