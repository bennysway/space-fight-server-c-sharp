using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public partial class ServerInterface : Form
    {
        //Back end Control
        SwayStation station;
        //Controls
        DashboardControl dashboardControl;
        ClientsControl clientsControl;
        MapsControl mapsControl;
        DatabaseControl databaseControl;
        StoreControl storeControl;
        OptionsControl optionsControl;
        ConsoleControl consoleControl;

        //checks
        public bool database_running = false;
        public bool server_running = false;
        

        //Window Dragging
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        //Enumerators
        public enum ServerStatus
        {
            Connected = 1, Disconnected, Busy
        }
        public enum DatabaseStatus
        {
            Connected = 1, Disconnected, Downloading, Writing, Unavailable
        }
        public enum Menus
        {
            Dashboard = 1, Clients, Maps, Database, StoreItems, Options, Console
        }



        public ServerInterface()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        internal void setDatabaseConnectionStatus(DatabaseStatus status)
        {
            switch(status)
            {
                case DatabaseStatus.Connected:
                    databaseConnectionIcon.BackgroundImage = Properties.Resources.db_connected_32;
                    databaseConnectionLabel.Text = "Database Connected";
                    break;
                case DatabaseStatus.Disconnected:
                    databaseConnectionIcon.BackgroundImage = Properties.Resources.db_close_32;
                    databaseConnectionLabel.Text = "Database Disconnected";
                    break;
                case DatabaseStatus.Downloading:
                    databaseConnectionIcon.BackgroundImage = Properties.Resources.db_download_32;
                    databaseConnectionLabel.Text = "Connecting to Database";
                    break;
                case DatabaseStatus.Writing:
                    databaseConnectionIcon.BackgroundImage = Properties.Resources.db_write_32;
                    databaseConnectionLabel.Text = "Writing Database";
                    break;
                default:
                    databaseConnectionIcon.BackgroundImage = Properties.Resources.db_close_32;
                    databaseConnectionLabel.Text = "Database Disconnected";
                    break;
            }
        }
        internal ListView GetClientListView()
        {
            return clientsControl.GetClientListView();
        }

        internal string GetTypedMessage()
        {
            return clientsControl.GetTypedMessage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void dashboardbutton_Click(object sender, EventArgs e)
        {
            subtitlelabel.Text = "Dashboard";
            if (!mainPanel.Controls.Contains(dashboardControl))
                mainPanel.Controls.RemoveAt(0);
            if (dashboardControl == null)
                dashboardControl = new DashboardControl(station);
            mainPanel.Controls.Add(dashboardControl);
        }

        internal ListView GetPlayerListView()
        {
            return databaseControl.GetPlayerListView();
        }

        private void clientbutton_Click(object sender, EventArgs e)
        {
            subtitlelabel.Text = "Clients";
            if(!mainPanel.Controls.Contains(clientsControl))
                mainPanel.Controls.RemoveAt(0);
            if (clientsControl == null)
                clientsControl = new ClientsControl(station);
            mainPanel.Controls.Add(clientsControl);
        }

        private void itemsbutton_Click(object sender, EventArgs e)
        {
            subtitlelabel.Text = "Store Items";
            if (!mainPanel.Controls.Contains(storeControl))
                mainPanel.Controls.RemoveAt(0);
            if (storeControl == null)
                storeControl = new StoreControl();
            mainPanel.Controls.Add(storeControl);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardbutton_MouseEnter(object sender, EventArgs e)
        {
            
        }

       
        private void mapsbutton_Click(object sender, EventArgs e)
        {
            subtitlelabel.Text = "Maps";
            if (mapsControl == null)
                mapsControl = new MapsControl();
            if (!mainPanel.Controls.Contains(mapsControl))
                mainPanel.Controls.RemoveAt(0);
            mainPanel.Controls.Add(mapsControl);
        }

        private void databasebutton_Click(object sender, EventArgs e)
        {
            subtitlelabel.Text = "Database";
            if (databaseControl == null)
                databaseControl = new DatabaseControl(station);
            if (!mainPanel.Controls.Contains(databaseControl))
                mainPanel.Controls.RemoveAt(0);
            mainPanel.Controls.Add(databaseControl);
        }

        private void optionsbutton_Click(object sender, EventArgs e)
        {
            subtitlelabel.Text = "Options";
            if (optionsControl == null)
                optionsControl = new OptionsControl();
            if (!mainPanel.Controls.Contains(optionsControl))
                mainPanel.Controls.RemoveAt(0);
            mainPanel.Controls.Add(optionsControl);
        }

        private void consolebutton_Click(object sender, EventArgs e)
        {
            subtitlelabel.Text = "Console";
            if (consoleControl == null)
                consoleControl = new ConsoleControl(station);
            if (!mainPanel.Controls.Contains(consoleControl))
                mainPanel.Controls.RemoveAt(0);
            mainPanel.Controls.Add(consoleControl);
        }

        private void dashboardbutton_MouseHover(object sender, EventArgs e)
        {
            dashboardbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void clientbutton_MouseHover(object sender, EventArgs e)
        {
            clientbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void mapsbutton_MouseHover(object sender, EventArgs e)
        {
            mapsbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void databasebutton_MouseHover(object sender, EventArgs e)
        {
            databasebutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void storeitemsbutton_MouseHover(object sender, EventArgs e)
        {
            storeitemsbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void optionsbutton_MouseHover(object sender, EventArgs e)
        {
            optionsbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void consolebutton_MouseHover(object sender, EventArgs e)
        {
            consolebutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(37, 255, 203, 0);
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            if (Application.MessageLoop)
                Application.Exit();
            else
                Environment.Exit(1);
        }

        private void connectionlabel_Click(object sender, EventArgs e)
        {

        }

        public void setConnectionState(ServerStatus status)
        {
            switch (status)
            {
                case ServerStatus.Connected:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.connected_32;
                    serverConnectionLabel.Text = "Server Connected";
                    break;
                case ServerStatus.Disconnected:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.disconnected_32;
                    serverConnectionLabel.Text = "Server Disconnected";
                    break;
                case ServerStatus.Busy:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.time_32;
                    serverConnectionLabel.Text = "Server Busy";
                    break;
                default:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.db_close_32;
                    serverConnectionLabel.Text = "Server Disconnected";
                    break;
            }
        }

        public void setConnectionState(string status)
        {
            serverConnectionLabel.Text = status;
        }

        public void EnableNavigationButtons()
        {
            clientbutton.Enabled = true;
            mapsbutton.Enabled = true;
            databasebutton.Enabled = true;
            storeitemsbutton.Enabled = true;
            optionsbutton.Enabled = true;
            consolebutton.Enabled = true;
        }
        public void DisableNavigationButtons()
        {
            clientbutton.Enabled = false;
            mapsbutton.Enabled = false;
            databasebutton.Enabled = false;
            storeitemsbutton.Enabled = false;
            optionsbutton.Enabled = false;
            consolebutton.Enabled = false;
        }

        public void setConnectionNumber(int i)
        {
            clientnumber.Text = i.ToString();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void changeServerStatusImage(int state)
        {
            switch (state)
            {
                default:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.disconnected_32;
                    break;
                case 0:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.disconnected_32;
                    break;
                case 1:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.connected_32;
                    break;
                case 2:
                    serverConnectionIcon.BackgroundImage = Properties.Resources.transfare_32;
                    break;
            }
        }

        private void ServerInterface_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void SwitchMenu(Menus menu)
        {
            Object obj = new Object();
            EventArgs args = new EventArgs();
            switch (menu)
            {
                case Menus.Dashboard:
                    dashboardbutton_Click(obj, args);
                    break;
                case Menus.Clients:
                    clientbutton_Click(obj, args);
                    break;
                case Menus.Maps:
                    mapsbutton_Click(obj, args);
                    break;
                case Menus.Database:
                    databasebutton_Click(obj, args);
                    break;
                case Menus.StoreItems:
                    itemsbutton_Click(obj, args);
                    break;
                case Menus.Options:
                    optionsbutton_Click(obj, args);
                    break;
                case Menus.Console:
                    consolebutton_Click(obj, args);
                    break;

            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        public void removeCallBacks()
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void ServerInterface_Load(object sender, EventArgs e)
        {
            station = new SwayStation(this);
            dashboardControl = new DashboardControl(station);
            clientsControl = new ClientsControl(station);
            mapsControl = new MapsControl();
            databaseControl = new DatabaseControl(station);
            optionsControl = new OptionsControl();
            consoleControl = new ConsoleControl(station);
            storeControl = new StoreControl();
            mainPanel.Controls.Add(dashboardControl);
        }

        public void AppendToLog(string s)
        {
            if (consoleControl == null)
                consoleControl = new ConsoleControl(station);
            consoleControl.GetLogTextBox().AppendText(s);
        }

        public TextBox GetLogTextBox()
        {
            if (consoleControl == null)
                consoleControl = new ConsoleControl(station);
            return consoleControl.GetLogTextBox();
        }

        public void SetNeedle(DashboardControl.Needle needle)
        {
            dashboardControl.NeedleAngle(needle);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
