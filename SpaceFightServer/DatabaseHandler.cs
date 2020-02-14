using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Data;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public class DatabaseHandler
    {
        private string host;
        private string database;
        private string user;
        private string password;
        private string connectionString;
        private SwayStation station;

        public bool pooling = true;

        private MySqlConnection connection = null;
        private MySqlCommand command = null;
        private DataTable dataTable = new DataTable();
        private MySqlDataAdapter adapter;
        

        public DatabaseHandler(SwayStation sway)
        {
            station = sway;
            Initialize();
        }

        public bool ConnectDatabase()
        {
            //DontDestroyOnLoad(this);
            station.ChangeDatabaseStatusUI(ServerInterface.DatabaseStatus.Downloading);
            connection = new MySqlConnection(connectionString);
            OpenConnection();
            station.ChangeDatabaseStatusUI(ServerInterface.DatabaseStatus.Connected); ;
            station.UpdateLog("MySQL State: " + connection.State +"\n");
            CloseConnection();
            return true;
            
        }
        public void DisconnectDatabase()
        {
            if (connection != null)
            {
                if (connection.State.ToString() != "Closed")
                {
                    connection.Close();
                    station.ChangeDatabaseStatusUI(ServerInterface.DatabaseStatus.Disconnected);
                    Console.WriteLine("MySQL connection has been closed");
                }
                connection.Dispose();
            }
        }
        public void Initialize()
        {
            host = "den1.mysql2.gear.host";
            database = "spacefight";
            user = "spacefight";
            password = "...test1234";
            connectionString = "Server=" + host + ";Database=" + database + ";User=" + user + ";Password=" + password + ";Pooling=";
            if (pooling)
                connectionString += "true;";
            else
                connectionString += "false;";
        }
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;

            }
            catch (Exception ex)
            {
                station.UpdateLog(ex.Message + "\n");
                return false;
            }
        }
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;

            }
            catch (MySqlException e)
            {
                //error 0: host server is down
                //error 1042: username
                switch (e.Number)
                {
                    case 0:
                        station.UpdateLog("Wrong username or password" + "\n");
                        break;
                    case 1045:
                        station.UpdateLog("Database was not found" + "\n");
                        break;
                    case 1042:
                        station.UpdateLog("Unable to connect to server. Is the Server started or available?" + "\n");
                        break;
                    default:
                        break;
                }
                station.ChangeDatabaseStatusUI(ServerInterface.DatabaseStatus.Disconnected);
                return false;
            }
        }
        public void ExecuteNonQuery(string query)
        {
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        public void Insert(string _username, string _playerName, string _password, string _health, string _ammo, string _isBanned)
        {
            string query = "INSERT INTO `spacefight`.`playerdata` (`username`, `password`, `playername`, `health`, `ammo`, `isbanned`) VALUES('" + _username + "', '" + _password + "', '" + _playerName + "', '" + _health + "', '" + _ammo + "', '" + _isBanned + "')";
            ExecuteNonQuery(query);
        }
        public void Update(int _id, string _username, string _playerName, string _password, string _health, string _ammo, string _isBanned)
        {
            string query = "UPDATE `spacefight`.`playerdata` SET `username`='" + _username + "', `password`='" + _password + "', `playername`='" + _playerName + "', `health`='" + _health + "', `ammo`='" + _ammo + "', `isbanned`='" + _isBanned + "' WHERE `idplayerdata`='" + _id + "';";
            ExecuteNonQuery(query);
        }
        public void Delete(int _id,bool popUp = false)
        {
            string query;
            if (popUp)
            {
                DialogResult dialogResult = CustomMessageBox.Show("Are you sure you want to delete this player ? ", "Delete Player");
                if (dialogResult == DialogResult.Yes)
                {
                    query = "DELETE FROM `spacefight`.`playerdata` WHERE `idplayerdata`='" + _id + "';";
                    ExecuteNonQuery(query);
                    station.UpdateLog("Player : " + _id + " deleted from database \n");
                    station.UpdatePlayerDataBase();
                }
            }
            else
            {
                query = "DELETE FROM `spacefight`.`playerdata` WHERE `idplayerdata`='" + _id + "';";
                ExecuteNonQuery(query);
                station.UpdateLog("Player : " + _id + " deleted from database \n");
                station.UpdatePlayerDataBase();
            }

        }
        public void Refresh(int page = 1)
        {
            
        }
        public List<string>[] Select(string username = "",int page = 1)
        {
            string query;
            bool extended = false;
            List<string>[] list = new List<string>[10];
            string limit = " LIMIT " + (page - 1) * 1000 + ", " + 1000 * page;
            if (username.Equals(""))
                query = "SELECT * FROM spacefight.playerdata " + limit + ";";
            else
            {
                extended = true;
                query = "SELECT * FROM spacefight.playerdata WHERE username LIKE '" + username + "'";
            }

            for (int i = 0; i < 10; i++)
                list[i] = new List<string>();
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["idplayerdata"].ToString());
                    list[1].Add(dataReader["username"].ToString());
                    list[2].Add(dataReader["password"].ToString());
                    list[3].Add(dataReader["playername"].ToString());
                    list[4].Add(dataReader["health"].ToString());
                    list[5].Add(dataReader["ammo"].ToString());
                    list[6].Add(dataReader["map"].ToString());
                    list[7].Add(dataReader["rank"].ToString());
                    list[8].Add(dataReader["score"].ToString());
                    list[9].Add(dataReader["isbanned"].ToString());
                }
                if (!extended)
                {
                    station.GetPlayerListView().Items.Clear();
                    for (int i = 0; i < list[0].Count ; i++)
                        station.PopulatePlayerLV(list[0][i], list[1][i], list[2][i], list[3][i], list[4][i], list[5][i], list[9][i]);
                }
                
                dataReader.Close();
                CloseConnection();
            }
            return list;

        }
        
        public bool GetConnectionState()
        {
            if (connection.State.ToString().Equals("Open"))
                return true;
            else
                return false;
        }
    }
}