using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ListBox myListbox = new ListBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            myListbox.Size = new System.Drawing.Size(200, 100);
            myListbox.Location = new System.Drawing.Point(10, 10);
            myListbox.SelectedIndexChanged += new EventHandler(myListBox_SelectedIndexChanged);
            this.Controls.Add(myListbox);
            myListbox.MultiColumn = true;
            myListbox.SelectionMode = SelectionMode.MultiExtended;
            myListbox.BeginUpdate();
            for (int x = 1; x <= 100; x++)
            {
                myListbox.Items.Add("Eleman " + x.ToString());
            }
            myListbox.EndUpdate();
            //myListbox.SetSelected(1, true);
            //myListbox.SetSelected(2, true);
            //myListbox.SetSelected(4, true);

        }
        void myListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Seçtiğiniz içerik : " + myListbox.Items[myListbox.SelectedIndex].ToString());

        }

        private void button3_Click(object sender, EventArgs e)
        {
           //  eleman daha önce ekli mi diye sor???
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Ali");
            listBox1.Items.Add("Veli");
            listBox1.Items.Add("Ayşe");
            listBox1.Items.Add("Fatma");
            listBox1.Items.Add("Durmuş");
            listBox1.Items.Add("Sevcan");
            listBox1.Items.Add("Zeki");
            listBox1.Items.Add("Sercan");
            listBox1.Items.Add("Volkan");
            listBox1.Items.Add("Canan");
        }

    }
}
