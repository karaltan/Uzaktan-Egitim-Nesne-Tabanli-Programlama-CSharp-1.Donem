using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace folderDialogKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //KLASÖR SEÇME İLETİŞİM KUTUSU

            string secilenKlasorYolu;

            //varsayılan root klasörü değiştir
            // MASAÜSTÜ: Environment.SpecialFolder.Desktop;
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
           
            // yeni klasör oluştur butonu gösterme
            folderBrowserDialog1.ShowNewFolderButton = false;
          
            folderBrowserDialog1.Description = "Lütfen Bir Klasör Seçin";
            
            
            //*******************************
            folderBrowserDialog1.ShowDialog();//klasör iletişim kutusu açılıyor...
            //*******************************

            //seçilen klasörün yolu
            secilenKlasorYolu = folderBrowserDialog1.SelectedPath;
            label1.Text = secilenKlasorYolu;
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yol;
            //işlem yapmak
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Programs;
            
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                yol = folderBrowserDialog1.SelectedPath;
                label2.Text = yol;
                // diğer işlemleri yapılacak.
            }
            else
            {
                MessageBox.Show("Hiçbir Klasör Seçilmedi");
            }  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string seciliklasor="";
            //işlem yapmak
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Desktop;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                seciliklasor = folderBrowserDialog1.SelectedPath;
                label3.Text = seciliklasor;

                string seciliTur = comboBox1.Text;
                MessageBox.Show(seciliTur);

                if (seciliTur=="Metin Dosyaları")
                {
                    
                // txt dosyalarının olduğu klasörü aldık.
                System.IO.DirectoryInfo konum = new System.IO.DirectoryInfo(folderBrowserDialog1.SelectedPath);
                // klasördeki, sadece txt uzantılı dosyaları aldık
                System.IO.FileInfo[] Dosyalar = konum.GetFiles("*.txt");
                listBox1.Items.Clear();
                // Array List'imizi listbox1'in datasource'una aktardık.
                listBox1.DataSource = Dosyalar;
                }
                else if (seciliTur=="Resim Dosyaları")
                {
                // jpg dosyalarının olduğu klasörü aldık.
                System.IO.DirectoryInfo konum = new System.IO.DirectoryInfo(folderBrowserDialog1.SelectedPath);
                // klasördeki, sadece jpg uzantılı dosyaları aldık
                System.IO.FileInfo[] Dosyalar = konum.GetFiles("*.jpg");
                listBox1.Items.Clear();
                // Array List'imizi listbox1'in datasource'una aktardık.
                listBox1.DataSource = Dosyalar;

                }
                else if (seciliTur == "Video Dosyaları")
                {
                    // mp4 dosyalarının olduğu klasörü aldık.
                System.IO.DirectoryInfo konum = new System.IO.DirectoryInfo(folderBrowserDialog1.SelectedPath);
                // klasördeki, sadece mp4 uzantılı dosyaları aldık
                System.IO.FileInfo[] Dosyalar = konum.GetFiles("*.mp4");
                listBox1.Items.Clear();
                // Array List'imizi listbox1'in datasource'una aktardık.
                listBox1.DataSource = Dosyalar;

                }
                
            }
            else
            {
                MessageBox.Show("Hiçbir Klasör Seçilmedi");
            }  


            
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }
    }
}
