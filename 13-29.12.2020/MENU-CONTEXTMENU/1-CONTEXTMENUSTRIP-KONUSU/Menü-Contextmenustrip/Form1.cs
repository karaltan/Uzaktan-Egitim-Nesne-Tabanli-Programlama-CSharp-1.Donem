using System;
using System.Drawing;
using System.Windows.Forms;
namespace contextmenustrip_kontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KalınToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name,textBox1.Font.Size, 
                            textBox1.Font.Style ^ FontStyle.Bold);
        }
        private void EğikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name,textBox1.Font.Size, 
                            textBox1.Font.Style ^ FontStyle.Italic);
        }
        private void AltıÇiziliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font.Name,textBox1.Font.Size, 
                            textBox1.Font.Style ^ FontStyle.Underline);
        }
        private void KesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0) //seçili kısmın uzunluğu
                textBox1.Cut();
            else
                MessageBox.Show("Seçili Alan Yok");
        }
        private void KopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.Copy();
            else
                MessageBox.Show("Seçili Alan Yok");
        }
        private void YapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
    }
}
