using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fontDialogKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowEffects = true;
            fontDialog1.ShowColor=true;

            //fontDialog1.MaxSize = 20;
            fontDialog1.MinSize = 12;

            fontDialog1.ShowApply = true;
            fontDialog1.ShowHelp = true;  

            //fontDialog1.ShowDialog(); // iletişim kutusu açılıyor
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                label1.Text = "Font: "+ fontDialog1.Font.Name.ToString();
                label2.Text = "Boyut: "+fontDialog1.Font.Size.ToString();
                label3.Text = "Kalın Mı? "+fontDialog1.Font.Bold.ToString();

                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }

            // diğer kullanım
            // DialogResult result = fontDialog1.ShowDialog();
            //if (result == DialogResult.OK) { 
               // kodlar
            //}


        }
    }
}
