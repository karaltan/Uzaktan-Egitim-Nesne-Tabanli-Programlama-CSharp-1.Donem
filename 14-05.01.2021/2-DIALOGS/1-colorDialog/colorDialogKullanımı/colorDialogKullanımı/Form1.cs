using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace colorDialogKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // özel renk tanımlama butonu açılır
            colorDialog1.FullOpen=true;

            //custom colors
         colorDialog1.CustomColors = new int[]
                                {
                                    ColorTranslator.ToOle(Color.Blue), 
                                    ColorTranslator.ToOle(ColorTranslator.FromHtml("#FFCC99"))
                                };

        
            if (colorDialog1.ShowDialog() == DialogResult.OK)
         {
             label1.Text = colorDialog1.Color.Name;
             //this.BackColor = colorDialog1.Color; // formun arka planını değiştir
             button1.BackColor = colorDialog1.Color;
         }
            
           
          // colorDialog1.ShowDialog();


            // seçili rengi resetlemek
           colorDialog1.Reset();
        }
    }
}
