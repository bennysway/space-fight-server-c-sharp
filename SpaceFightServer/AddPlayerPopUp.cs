using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public partial class AddPlayerPopUp : Form
    {
        SwayStation station;
        AddPlayerMode mode;
        int id;
        string isBanned;

        public enum AddPlayerMode
        {
            Add = 1, Update
        }

        public AddPlayerPopUp(SwayStation sway, AddPlayerMode _mode)
        {
           
            InitializeComponent();
            station = sway;
            mode = _mode;
        }

        public void UpdateComponents(string _id, string _username,string _password, string _playerName,  string _health, string _ammo, string _isBanned)
        {
            id = int.Parse(_id);
            usernameInput.Text = _username;
            playerNameInput.Text = _playerName;
            passwordInput.Text = _password;
            healthTrackBar.Value = int.Parse(_health);
            healthAmount.Text = healthTrackBar.Value.ToString();
            ammoTrackBar.Value = int.Parse(_ammo);
            ammoAmount.Text = ammoTrackBar.Value.ToString();
            bannedCheck.Checked = (_isBanned.Equals("yes"));
        }
        
        private void usernameInput_Leave(object sender, EventArgs e)
        {
            if(mode == AddPlayerMode.Add)
            {
                if (usernameInput.Text.Equals(""))
                {
                    MessageBox.Show("Username is empty");
                }
                List<string>[] check = SwayStation.station.UpdatePlayerDataBase(usernameInput.Text);
                if (check[0].Count > 0)
                {
                    MessageBox.Show("Username is already taken");
                    usernameInput.Clear();
                }
            }
            
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddPlayerPopUp_Load(object sender, EventArgs e)
        {
            switch (mode)
            {
                case AddPlayerMode.Add:
                    Title.Text = "Add Player";
                    addBut.Text = "Add";
                    break;
                case AddPlayerMode.Update:
                    Title.Text = "Edit Player";
                    addBut.Text = "Edit";
                    break;
            }
        }

        private void healthTrackBar_Scroll(object sender, EventArgs e)
        {
            healthAmount.Text = healthTrackBar.Value.ToString();
        }

        private void ammoTrackBar_Scroll(object sender, EventArgs e)
        {
            ammoAmount.Text = ammoTrackBar.Value.ToString();
        }

        private void addBut_Click(object sender, EventArgs e)
        {
            if (ValidateFields()){
                switch (mode)
                {
                    case AddPlayerMode.Add:
                        station.AddPlayer(usernameInput.Text,
                            playerNameInput.Text,
                            passwordInput.Text,
                            healthTrackBar.Value.ToString(),
                            ammoTrackBar.Value.ToString(),
                            isBanned);
                            station.UpdatePlayerDataBase();


                        Close();
                    break;
                    case AddPlayerMode.Update:
                        station.UpdatePlayer(id,usernameInput.Text,
                            playerNameInput.Text,
                            passwordInput.Text,
                            healthTrackBar.Value.ToString(),
                            ammoTrackBar.Value.ToString(),
                            isBanned);
                            station.UpdatePlayerDataBase();

                        Close();
                        break;
                }
            }
        }

        private bool ValidateFields()
        {
            if (usernameInput.Text.Equals(""))
            {
                MessageBox.Show("Username is empty");
                return false;
            }
            else if (!Regex.IsMatch(usernameInput.Text, "^[a-zA-Z][a-zA-Z0-9]*$"))
            {
                MessageBox.Show("Username contains invalid characters");
                usernameInput.SelectAll();
                return false;
            }
            else if (passwordInput.Text.Equals(""))
            {
                MessageBox.Show("Password is blank");
                return false;
            }
            else if (playerNameInput.Text.Equals(""))
            {
                MessageBox.Show("Player Name cannot be empty :)");
                return false;
            }
            isBanned = (bannedCheck.Checked) ? "yes" : "no";
            return true;


        }
    }
}
