using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace folderDialogUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] dosyalar = System.IO.Directory.GetFiles(fbd.SelectedPath);
                foreach (string dosya in dosyalar)
                {
                    if(dosya.EndsWith(".jpg")||dosya.EndsWith(".jpeg")||dosya.EndsWith(".png"))
                        listBox1.Items.Add(dosya);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string resimYolu = listBox1.SelectedItem.ToString();
            pictureBox1.ImageLocation = resimYolu;
        }
    }
}