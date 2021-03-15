using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace degiskenAktarimi2
{
    public partial class Form2 : Form
    {
        // BURASI ÇOK ÖNEMLİ
        // public yapıyorum ki diğer formlardan ulaşabileyim
        public string kullaniciadi=string.Empty;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = kullaniciadi;
        }
    }
}
