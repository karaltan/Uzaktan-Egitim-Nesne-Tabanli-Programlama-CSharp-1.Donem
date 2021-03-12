using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace catchMeIfYouCan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            Random koordinat = new Random(); //yeni koordinatları rastgele sayıya atıyoruz
            
            button1.Left = Convert.ToInt32(koordinat.Next(this.Size.Width - button1.Size.Width));
                //burda butonun leftini ayarlıyoruz ve formun boyutu kadar ayarlıyoruz kendinide çıkardıkki en köşeye gitmesin
            button1.Top = Convert.ToInt32(koordinat.Next(this.Size.Height - button1.Height));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bravo Beni Yakaladınız.");
        }
    }
}
