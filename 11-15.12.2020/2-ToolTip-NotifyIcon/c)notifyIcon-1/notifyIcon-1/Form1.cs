using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;

namespace notifyIcon_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState==FormWindowState.Minimized)
            {
                //notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                //notifyIcon1.BalloonTipText = "Bildirim içeriği";
                //notifyIcon1.BalloonTipTitle = "Bildirim başlığı";
                //notifyIcon1.Text = "Bildirim Text";
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else
            {
                notifyIcon1.Visible = false;
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            //using System.Reflection;
        }

        private void notifyIcon1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }
    }
}
