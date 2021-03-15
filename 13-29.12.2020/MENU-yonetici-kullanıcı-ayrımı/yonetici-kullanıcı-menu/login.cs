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
    public partial class login : Form
    {
        // BURASI ÇOK ÖNEMLİİİİİİİİİİİİİİİ
        public static string kullaniciad;

        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. değişken taşıma yöntemi ile yapılmıştır....

            string kadi = textBox1.Text;
            string parola = textBox2.Text;

            // admin: smtal/1994 olarak kabul edilsin
            // user: karaltan/1981 olarak kabul edilsin

            // doğru login oluyor mu?
            if (kadi=="smtal" && parola=="1994" || kadi=="karaltan" && parola=="1981")
            {
                kullaniciad=kadi; // taşınacak değişken

                // kullanıcı adını diğer forma taşımam lazım
                Form1 frm = new Form1();
                frm.Show();

                this.Hide();
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
