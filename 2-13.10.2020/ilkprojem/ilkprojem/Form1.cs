using System;
using System.Text;
using System.Windows.Forms;
namespace ilkprojem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {   //PROBLEM: 2 textboxa girilen sayıyı, TOPLA butonuna basınca toplayan 
            //ve sonucu 3.textboxta gösteren program
         
            //GİRİŞ : değişkenler tanımlanır
            int s1, s2,sonuc;

            //GELİŞME : değerler alınır, işlem yapılır
            // ** işlemler sağdan sola !!!!!!!!!!!!
            s1 =Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 + s2;

           // sonuc =Convert.ToInt32(textBox3.Text); //HATAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA

            //SONUÇ : çıktı
            textBox3.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {   // kutuları silmek

            textBox1.Text = "";  // değeri sil
            textBox2.Clear();    // değeri sil
            textBox3.Clear();    // değeri sil

            textBox1.Focus(); // imleci ilk kutuya odaklan
        }
    }
}
