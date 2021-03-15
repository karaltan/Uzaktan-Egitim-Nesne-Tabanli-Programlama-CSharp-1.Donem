using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace openFileDialogKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //openFileDialog1.InitialDirectory = "C:\\Documents and Settings\\AltanKa\\Desktop\\blog";
            //openFileDialog1.InitialDirectory = @"C:\Documents and Settings\AltanKa\Desktop\blog";
          
            openFileDialog1.Filter = "Metin Dosyaları (*.txt)|*.txt|Tüm Dosyalar (*.*)|*.*|Word Dosyaları (*.docx)|*.docx";
            //openFileDialog1.Filter ="Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +"All files (*.*)|*.*";  
            openFileDialog1.FilterIndex = 3;
            
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.CheckFileExists = false;

            openFileDialog1.Title = "Bir Dosya Seçiniz..";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string secilenYol = openFileDialog1.FileName; // dosyanın yoluyla beraber alır
                label1.Text ="Yol: "+ secilenYol;
                string secilenDosya = openFileDialog1.SafeFileName; // sadece dosya ismini alır
                label2.Text = "Dosya: "+secilenDosya;

                string directory;
                directory = secilenYol.Substring(0, secilenYol.LastIndexOf('\\'));
                label4.Text = "Sadece Dizin:" +directory;


                pictureBox1.Image = Image.FromFile(secilenYol);

            }

        }
    }
}
