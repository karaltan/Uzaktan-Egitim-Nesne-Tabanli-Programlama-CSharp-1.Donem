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
            // yakalarken FormIsmi.degiskenismi olarak

            string gelendeger = login.kullaniciad;
            label1.Text="MERHABA:"+gelendeger;


            if (gelendeger == "smtal") // bu kişi admindi
            {
                yÖNETİMSELARAÇLARToolStripMenuItem.Enabled = true;
                this.Text = "@admin"; // form başlığı değiştiriliyor
                this.BackColor = Color.Aqua;

                pictureBox1.Image = Image.FromFile("resimler\\admin.png");
            }
            if (gelendeger == "karaltan") // bu kişi userdı
            {    //yÖNETİMSELARAÇLARToolStripMenuItem.Enabled = false;

                // ya da 
                //yÖNETİMSELARAÇLARToolStripMenuItem.Visible = false;

                //ana menüyü göremesin
                menuStrip1.Visible = false;

                this.Text = "@user";// form başlığı değiştiriliyor
                this.BackColor = Color.LightGray;

                pictureBox1.Image = Image.FromFile("resimler\\user.png");
            }
                 
        }

        private void yÖNETİMSELARAÇLARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
