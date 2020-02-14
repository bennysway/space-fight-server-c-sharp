using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Net;
using System.Drawing;

namespace SpaceFightServer
{
    public partial class ClientsControl : UserControl
    {
        SwayStation station;
        public ClientsControl(SwayStation sway)
        {
           
            InitializeComponent();
            station = sway;
            Util.colorListViewHeader(ref detailClientList, Color.Black, Color.Khaki);
        }

        private void ClientsControl_Load(object sender, EventArgs e)
        {
            detailClientList.Columns.Add("ip", "IP", 105);
            detailClientList.Columns.Add("userName", "Username", 95);
            detailClientList.Columns.Add("role", "Role", 95);

            detailClientList.View = View.Details;
            detailClientList.FullRowSelect = true;

            station.UpdateClientList();
        }
        private void sendtoselected_Click(object sender, EventArgs e)
        {
            station.SendToSelectedClients();
        }
        private void sendtoall_Click(object sender, EventArgs e)
        {
            station.SendToEveryone();
        }

        private void clientlogtimer_Tick(object sender, EventArgs e)
        {
            station.LogToFile();
        }

        internal string GetTypedMessage()
        {
            return clientsinput.Text;
        }

        private void playerDetailsBut_Click(object sender, EventArgs e)
        {

        }

        private void clientslist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        internal ListView GetClientListView()
        {
            return detailClientList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> indexes = new List<int>();
            foreach(ListViewItem item in detailClientList.SelectedItems)
                station.GrantClientManagingPrivilages(station.GetClientFromIP(item.SubItems[0].Text)._index);
            
        }
    }
}
