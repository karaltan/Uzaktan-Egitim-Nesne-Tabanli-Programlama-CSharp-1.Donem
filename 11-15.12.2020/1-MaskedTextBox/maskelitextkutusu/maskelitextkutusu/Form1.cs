using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = maskedTextBox1.Text;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (maskedTextBox1.MaskFull)
            {
                toolTip1.ToolTipTitle = "Giriş Reddedildi - Çok Fazla Data";
                toolTip1.Show("Daha fazla giremezsiniz!", maskedTextBox1, 0, 0, 5000);
            }
            else if (e.Position == maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Giriş Reddedildi - Karakter Sınırı Aşıldı";
                toolTip1.Show("Ekstra karakter ekleyemezsiniz!", maskedTextBox1, 0, 0, 5000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Giriş Reddedildi";
                toolTip1.Show("Sadece sayısal (0-9) değerler girebilirsiniz.", maskedTextBox1, 0, -20, 5000);
            }
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            toolTip1.Hide(maskedTextBox1);
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (e.Position != maskedTextBox1.Mask.Length)
            {
                toolTip1.ToolTipTitle = "Giriş Reddedildi - Karakter Sayısı";
                toolTip1.Show("Gerekenden (5) az karakter girildi!", maskedTextBox2, 0, 0, 5000);
            }
            else
            {
                toolTip2.ToolTipTitle = "Giriş Reddedildi";
                toolTip2.Show("sadece RAKAM yazmalısınız!", maskedTextBox2, 0, -20, 5000);
            }
        }
    }
}
