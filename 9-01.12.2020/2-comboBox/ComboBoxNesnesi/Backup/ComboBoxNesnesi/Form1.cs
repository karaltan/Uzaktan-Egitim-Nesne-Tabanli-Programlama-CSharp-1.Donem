using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Object[] objects = { "Item 1", "Item 2", "Item 3", "Item 4", "Item 5" };
            comboBox1.Items.AddRange(objects);
            comboBox1.Items.Insert(0, "Lütfen Seçiniz");
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            int[] myData = { 1, 2, 3, 4, 5, 2, 1 };
            comboBox1.DataSource = myData;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("seçilen=" +comboBox1.Text + "\t indisi=" + comboBox1.SelectedIndex.ToString());

        }
    }
}
