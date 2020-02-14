using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public partial class DatabaseControl : UserControl
    {
        //ServerInterface serverInterface;
        SwayStation station;
        AddPlayerPopUp.AddPlayerMode mode = AddPlayerPopUp.AddPlayerMode.Add;


        public DatabaseControl(SwayStation sway)
        {
            InitializeComponent();
            station = sway;
            Util.colorListViewHeader(ref playerList, Color.Black, Color.Khaki);
        }
        

        private void DatabaseControl_Load(object sender, EventArgs e)
        {
            playerList.Columns.Add("playerID", "ID", 50);
            playerList.Columns.Add("userName", "User Name", 100);
            playerList.Columns.Add("password", "Password", 100);
            playerList.Columns.Add("playerName", "Name", 180);
            playerList.Columns.Add("health", "Health", 50);
            playerList.Columns.Add("ammo", "Ammo", 50);
            playerList.Columns.Add("banned", "Banned", 45);

            playerList.View = View.Details;
            playerList.FullRowSelect = true;

            station.UpdatePlayerDataBase();
        }

        private void refreshDatabase_Click(object sender, EventArgs e)
        {
            station.UpdatePlayerDataBase();
        }

        private void deselect_Click(object sender, MouseEventArgs e)
        {
            playerList.SelectedItems.Clear();
        }
        

        internal ListView GetPlayerListView()
        {
            return playerList;
        }

        private void addPlayerBut_Click(object sender, EventArgs e)
        {
            AddPlayerPopUp popUp = new AddPlayerPopUp(station,mode);
            if (playerList.SelectedItems.Count > 0)
            {
                popUp.UpdateComponents(
                    playerList.SelectedItems[0].SubItems[0].Text,
                    playerList.SelectedItems[0].SubItems[1].Text,
                    playerList.SelectedItems[0].SubItems[2].Text,
                    playerList.SelectedItems[0].SubItems[3].Text,
                    playerList.SelectedItems[0].SubItems[4].Text,
                    playerList.SelectedItems[0].SubItems[5].Text,
                    playerList.SelectedItems[0].SubItems[6].Text
                    );
            }
                
            popUp.Show();
        }

        private void playerList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (playerList.SelectedItems.Count != 0)
            {
                addPlayerBut.Text = "Edit Player...";
                mode = AddPlayerPopUp.AddPlayerMode.Update;
            }
            else
            {
                addPlayerBut.Text = "Add Player...";
                mode = AddPlayerPopUp.AddPlayerMode.Add;
            }
        }

        private void playerDelete_Click(object sender, EventArgs e)
        {
            if (playerList.SelectedItems.Count > 0)
                station.DeletePlayer(int.Parse(playerList.SelectedItems[0].SubItems[0].Text),true);
        }

        private void playerDetailsBut_Click(object sender, EventArgs e)
        {
            if(playerList.SelectedItems.Count > 0)
            {
                string username = playerList.SelectedItems[0].SubItems[1].Text;
                List<string>[] details = station.UpdatePlayerDataBase(username);
                playerName.Text = details[3][0];
                OnlineStatusLabel.Text = "Offline";
                MapLabel.Text = details[6][0];
                HealthLabel.Text = details[4][0];
                AmmoLabel.Text = details[5][0];
                RankLabel.Text = details[7][0];
                ScoreLabel.Text = details[8][0];
                BannedLabel.Visible = (details[9][0].Equals("yes"));
                DetailsPanel.Visible = true;
            }
        }

        private void DatabaseControl_MouseClick(object sender, MouseEventArgs e)
        {
            if (DetailsPanel.Visible)
            {
                DetailsPanel.Visible = false;
            }
        }

        private void playerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            playerDetailsBut_Click(sender, e);
        }

        private void DatabaseControl_Click(object sender, EventArgs e)
        {
            playerDetailsBut_Click(sender, e);
        }

        private void DeselectButton_Click(object sender, EventArgs e)
        {

        }

        private void playerList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
