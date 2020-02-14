using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public partial class DashboardControl : UserControl
    {
        SwayStation station;
        Bitmap bmp;
        float angle = -20;

        public enum Needle
        {
            Off = -20,
            DatabaseOn = -10,
            ServerOn = 12,
            ClientsIn = 31,
            Menu = 57,
            GameInProgress = 90,
            Managers = 123,
            Clients20 = 150,
            Clients50 = 183
        }

        public DashboardControl(SwayStation sway)
        {
            InitializeComponent();
            station = sway;
        }

        private void RunAppBut_Click(object sender, EventArgs e)
        {
            station.Start();
            RunAppBut.Enabled = false;
        }

        private void RunAppBut_MouseHover(object sender, EventArgs e)
        {
            RunAppBut.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void DashboardControl_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(Properties.Resources.needle_256);
            int dpi = 96;
            using (Graphics G = this.CreateGraphics()) dpi = (int)G.DpiX;
            bmp.SetResolution(dpi, dpi);
            needlePanel.ClientSize = bmp.Size;
        }

        private void needlePanel_Paint(object sender, PaintEventArgs e)
        {
            if (bmp != null)
            {
                float bw2 = bmp.Width / 2f;    // really ought..
                float bh2 = bmp.Height / 2f;   // to be equal!!!
                e.Graphics.TranslateTransform(bw2, bh2);
                e.Graphics.RotateTransform(angle);
                e.Graphics.TranslateTransform(-bw2, -bh2);
                e.Graphics.DrawImage(bmp, 0, 0);
                e.Graphics.ResetTransform();
            }
        }

        private void ColorLabels()
        {
            if(angle < (float)Needle.DatabaseOn)
            {
                DatabaseLabel.ForeColor = Color.SaddleBrown;
                ServerLabel.ForeColor = Color.SaddleBrown;
                ClientsConnectedLabel.ForeColor = Color.SaddleBrown;
                menuAccessLabel.ForeColor = Color.SaddleBrown;
                gameInProgressLabel.ForeColor = Color.SaddleBrown;
                gameManagersUpLabel.ForeColor = Color.SaddleBrown;
                clients20Label.ForeColor = Color.SaddleBrown;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if(angle >= (float)Needle.DatabaseOn && angle < (float)Needle.ServerOn)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.SaddleBrown;
                ClientsConnectedLabel.ForeColor = Color.SaddleBrown;
                menuAccessLabel.ForeColor = Color.SaddleBrown;
                gameInProgressLabel.ForeColor = Color.SaddleBrown;
                gameManagersUpLabel.ForeColor = Color.SaddleBrown;
                clients20Label.ForeColor = Color.SaddleBrown;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if (angle >= (float)Needle.ServerOn && angle < (float)Needle.ClientsIn)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.Khaki;
                ClientsConnectedLabel.ForeColor = Color.SaddleBrown;
                menuAccessLabel.ForeColor = Color.SaddleBrown;
                gameInProgressLabel.ForeColor = Color.SaddleBrown;
                gameManagersUpLabel.ForeColor = Color.SaddleBrown;
                clients20Label.ForeColor = Color.SaddleBrown;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if (angle >= (float)Needle.ClientsIn && angle < (float)Needle.Menu)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.Khaki;
                ClientsConnectedLabel.ForeColor = Color.Khaki;
                menuAccessLabel.ForeColor = Color.SaddleBrown;
                gameInProgressLabel.ForeColor = Color.SaddleBrown;
                gameManagersUpLabel.ForeColor = Color.SaddleBrown;
                clients20Label.ForeColor = Color.SaddleBrown;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if (angle >= (float)Needle.Menu && angle < (float)Needle.GameInProgress)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.Khaki;
                ClientsConnectedLabel.ForeColor = Color.Khaki;
                menuAccessLabel.ForeColor = Color.Khaki;
                gameInProgressLabel.ForeColor = Color.SaddleBrown;
                gameManagersUpLabel.ForeColor = Color.SaddleBrown;
                clients20Label.ForeColor = Color.SaddleBrown;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if (angle >= (float)Needle.GameInProgress && angle < (float)Needle.Managers)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.Khaki;
                ClientsConnectedLabel.ForeColor = Color.Khaki;
                menuAccessLabel.ForeColor = Color.Khaki;
                gameInProgressLabel.ForeColor = Color.Khaki;
                gameManagersUpLabel.ForeColor = Color.SaddleBrown;
                clients20Label.ForeColor = Color.SaddleBrown;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if (angle >= (float)Needle.Managers && angle < (float)Needle.Clients20)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.Khaki;
                ClientsConnectedLabel.ForeColor = Color.Khaki;
                menuAccessLabel.ForeColor = Color.Khaki;
                gameInProgressLabel.ForeColor = Color.Khaki;
                gameManagersUpLabel.ForeColor = Color.Khaki;
                clients20Label.ForeColor = Color.SaddleBrown;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if (angle >= (float)Needle.Clients20 && angle < (float)Needle.Clients50)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.Khaki;
                ClientsConnectedLabel.ForeColor = Color.Khaki;
                menuAccessLabel.ForeColor = Color.Khaki;
                gameInProgressLabel.ForeColor = Color.Khaki;
                gameManagersUpLabel.ForeColor = Color.Khaki;
                clients20Label.ForeColor = Color.DarkRed;
                clients50Label.ForeColor = Color.SaddleBrown;
            }
            else if (angle >= (float)Needle.Clients50)
            {
                DatabaseLabel.ForeColor = Color.Khaki;
                ServerLabel.ForeColor = Color.Khaki;
                ClientsConnectedLabel.ForeColor = Color.Khaki;
                menuAccessLabel.ForeColor = Color.Khaki;
                gameInProgressLabel.ForeColor = Color.Khaki;
                gameManagersUpLabel.ForeColor = Color.Khaki;
                clients20Label.ForeColor = Color.DarkRed;
                clients50Label.ForeColor = Color.DarkRed;
            }
        }

        public void NeedleAngle(Needle needle)
        {
            angle = (float) needle;
            ColorLabels();
            needlePanel.Refresh();
        }

        private void dashboardTimer_Tick(object sender, EventArgs e)
        {
            //ts = station.timeElapsed.Elapsed;
            //string elapsedTime = String.Format("{0:00} hrs {1:00} mins {2:00} s",
            //ts.Hours, ts.Minutes, ts.Seconds);
            //databaseTimeLabel.Text = elapsedTime;
        }
    }
}
