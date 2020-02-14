using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public class SwayStation
    {
        //Server Thread
        public static SwayStation station;


        //Server Health
        public bool StationActive { get; set; }
        public Stopwatch timeElapsed { get; set; }
        //Server parts check
        public bool DatabaseConnection { get; private set; }
        public bool ServerRunning { get; private set; }
        //Server info
        public string ServerName { get; set; }
        //Server Storage
        private Hashtable _IndexIdTable;
        List<SpaceClient> _clients;
        Hashtable _managingWaitingList;
        int _clientNumber;
        DashboardControl.Needle _needle;
        

        //Server to Network
        private DatabaseHandler database;

        //ServerLogic
        public GameLogic gameLogic = new GameLogic();

        //Server to UI
        ///Open menus
        private enum Menus
        {
            Dashboard = 1, Clients, Maps, StoreItems, Options, Console
        }
        private static ServerInterface serverInterface;

        
        //init
        public SwayStation(ServerInterface _serverInstance)
        {
            station = this;

            //to be called inside on load
            timeElapsed = new Stopwatch();
            serverInterface = _serverInstance;
            database = new DatabaseHandler(this);
            _clients = new List<SpaceClient>();
            if (!Directory.Exists("log"))
                Directory.CreateDirectory("log");
            _IndexIdTable = new Hashtable();
            _managingWaitingList = new Hashtable();


        }

        //Startup
        public void Start()
        {
            //init game logic first
            gameLogic.InitMap();
            
            DatabaseConnection = database.ConnectDatabase();
            //_needle = DashboardControl.Needle.DatabaseOn;
            //serverInterface.SetNeedle(_needle);
            UpdateNeedle();
            SetupServer();
            ServerRunning = true;
            //_needle = DashboardControl.Needle.ServerOn;
            //serverInterface.SetNeedle(_needle);
            UpdateNeedle();
            //timeElapsed.Start();
            serverInterface.EnableNavigationButtons();
        }

        static void SetupServer()
        {
            for (int i = 0; i < Constants.MAX_PLAYERS; i++)
            {
                SwayTCP.Clients[i] = new Client();
                Types.TempPlayer[i] = new Types.TempPlayerRec(); 
            }
            ServerHandleData.InitPackets();
            SwayTCP.InitializeNetwork();
        }


        #region "Master UI Control"
        //Dashboard
        public void ChangeServerStatusUI(ServerInterface.ServerStatus status)
        {
            switch (status)
            {
                case ServerInterface.ServerStatus.Connected:
                case ServerInterface.ServerStatus.Busy:
                    ServerRunning = true;
                    break;
                case ServerInterface.ServerStatus.Disconnected:
                    ServerRunning = false;
                    break;
                default:
                    ServerRunning = false;
                    break;
            }
            serverInterface.setConnectionState(status);
        }
        public void ChangeServerStatusUI(ServerInterface.ServerStatus status, string text)
        {
            ChangeServerStatusUI(status);
            serverInterface.setConnectionState(text);
        }

        internal Form GetInterface()
        {
            return serverInterface;
        }
        
        //Clients
        public void UpdateClientNumber(int clients)
        {
            _clientNumber = clients;
            serverInterface.setConnectionNumber(clients);
            
            UpdateClientList();
            UpdateNeedle();
        }

        

        internal ListView GetPlayerListView()
        {
            return serverInterface.GetPlayerListView();
        }

        internal void SwitchMenu(ServerInterface.Menus menu)
        {
            serverInterface.SwitchMenu(menu);
        }

        public void PopulatePlayerLV(string playerID, string username,string password, string playerName, string health, string ammo, string isBanned)
        {
            string[] row = { playerID,username,password, playerName,  health, ammo, isBanned };
            GetPlayerListView().Items.Add(new ListViewItem(row));
        }
        public void AddPlayer(string _username, string _playerName, string _password, string _health, string _ammo, string _isBanned)
        {
            database.Insert(_username, _playerName, _password, _health, _ammo, _isBanned);
        }
        public void UpdatePlayer(int _id, string _username, string _playerName, string _password, string _health, string _ammo, string _isBanned)
        {
            database.Update(_id,_username,_playerName,_password,_health,_ammo,_isBanned);
        }
        public void DeletePlayer(int _id,bool popUp = false)
        {
            database.Delete(_id,popUp);
        }
        internal void BanPlayer(int index)
        {
            List<string>[] tempPlayer = database.Select(SwayTCP.Clients[index]._player._username);
            UpdatePlayer(int.Parse(tempPlayer[0][0]),
                tempPlayer[1][0],
                tempPlayer[3][0],
                tempPlayer[2][0],
                tempPlayer[4][0],
                tempPlayer[5][0],
                "yes");
            SwayTCP.Clients[index]._player._banned = true;
            UpdateLog(tempPlayer[3][0] + " has been banned.\n");
            UpdateClientList();
            UpdateNeedle();
        }

        internal void AddClientPairing(int index, string id, string username)
        {
            SwayTCP.Clients[index]._player._id = id;
            SwayTCP.Clients[index]._player._username = username;
            SwayTCP.Clients[index]._player._role = Player_role.player;
            SwayTCP.Clients[index]._player._isGaming = false;
            UpdateClientList();
            UpdateNeedle();

        }
        internal void DeleteClientPairing(int index)
        {

            SwayTCP.Clients[index]._player._id = null;
            SwayTCP.Clients[index]._player._username = null;
            SwayTCP.Clients[index]._player._role = 0;
            SwayTCP.Clients[index]._player._isGaming = false;
            UpdateClientList();
            UpdateNeedle();
        }
        internal void DeleteClient(int index)
        {
            SwayTCP.Clients[index]._player = null;
            UpdateClientList();
            UpdateNeedle();
        }
        

        internal void UpdateNeedle()
        {
            if (DatabaseConnection)
            {
                _needle = DashboardControl.Needle.DatabaseOn;
                if (ServerRunning)
                {
                    _needle = DashboardControl.Needle.ServerOn;
                    if (SwayTCP.ClientCount > 0)
                    {
                        _needle = DashboardControl.Needle.ClientsIn;
                        if(GetAllLoggedInClients().Count > 0)
                        {
                            _needle = DashboardControl.Needle.Menu;
                            if(GetPlayingClients().Count > 0)
                            {
                                _needle = DashboardControl.Needle.GameInProgress;
                                if(GetAllManagers().Count > 0)
                                {
                                    _needle = DashboardControl.Needle.Managers;
                                }
                                if(GetAllClients().Count > 20)
                                {
                                    _needle = DashboardControl.Needle.Clients20;
                                    if(GetAllClients().Count > 50)
                                    {
                                        _needle = DashboardControl.Needle.Clients50;
                                    }
                                }
                            }
                        }
                        
                    }
                }
            }
            else
            {
                _needle = 0;
            }
            serverInterface.SetNeedle(_needle);

        }
        internal void CheckGamingAccess()
        {
            int count = 0;
            for (int i = 0; i < SwayTCP.Clients.Length; i++)
            {
               
                if (SwayTCP.Clients[i]._player._isGaming != false)
                {
                    count++;
                    break;
                }

            }
            if (_needle < DashboardControl.Needle.GameInProgress && count > 0)
            {
                _needle = DashboardControl.Needle.GameInProgress;
                serverInterface.SetNeedle(_needle);
            }
            else if (_needle == DashboardControl.Needle.GameInProgress && count < 1)
            {
                _needle = DashboardControl.Needle.Menu;
                serverInterface.SetNeedle(_needle);
            }
        }
        
        public List<string>[] UpdatePlayerDataBase(string username = "")
        {
            return database.Select(username);
        }
        //To Client functions
        internal void AddClientManagingWaitingList(int index)
        {
            SwayTCP.Clients[index]._player._role = Player_role.applicant;
            UpdateLog("Privilage request from " + SwayTCP.Clients[index]._player._username + " to manage game.\n");
            UpdateClientList();
            UpdateNeedle();
        }
        internal void RemoveClientManagingPrivilage(int index)
        {
            SwayTCP.Clients[index]._player._role = Player_role.player;
            UpdateLog("Privilage removed from " + SwayTCP.Clients[index]._player._username + " to manage game.\n");
            UpdateClientList();
            UpdateNeedle();
        }
        internal void SpawnClient(int index)
        {
            gameLogic.SpawnGamer(SwayTCP.Clients[index]);
            UpdateClientList();
            UpdateNeedle();
        }
        internal void ClientLeftGame(int index)
        {
            gameLogic.Remove(SwayTCP.Clients[index]);
            UpdateClientList();
            UpdateNeedle();
        } 
        internal void GrantClientManagingPrivilages(int index)
        {
            SwayTCP.Clients[index]._player._role = Player_role.manager;
            UpdateLog("Privilage granted to " + SwayTCP.Clients[index]._player._username + " to manage game.\n");
            SwayTCP.SendManagementPrivilage(index);
            UpdateClientList();
            UpdateNeedle();
        }
        

        public void UpdateClientNumber()
        {
            serverInterface.setConnectionNumber(SwayTCP.ClientCount);
            UpdateClientList();
            UpdateNeedle();
        }
        internal Client GetClientFromIP(string _ip)
        {
            for (int i = 0; i < Constants.MAX_PLAYERS; i++)
            {
                if (SwayTCP.Clients[i]._ip!=null && SwayTCP.Clients[i]._ip.Equals(_ip))
                    return SwayTCP.Clients[i];
            }
            return null;
        }
        public ListView GetClientListView() { return serverInterface.GetClientListView(); }
        public List<long> GetSelectedClients()
        {
            int numberOfSelected = GetClientListView().SelectedItems.Count;
            List<long> indices = new List<long>();
            for (int i = 0; i < numberOfSelected; i++)
            {
                Client _client = GetClientFromIP(GetClientListView().SelectedItems[i].SubItems[0].Text);
                if (_client != null)
                    indices.Add(_client._index);
            }
            return indices;
        }
        public List<long> GetAllClients()
        {
            int numberOfClients = GetClientListView().Items.Count;
            List<long> indices = new List<long>();
            for (int i = 0; i < numberOfClients; i++)
            {
                Client _client = GetClientFromIP(GetClientListView().Items[i].SubItems[0].Text);
                if (_client != null)
                    indices.Add(_client._index);
            }
            return indices;
        }
        public List<long> GetAllManagers()
        {
            int numberOfClients = GetClientListView().Items.Count;
            List<long> indices = new List<long>();
            for (int i = 0; i < numberOfClients; i++)
            {
                if (GetClientListView().Items[i].SubItems[2].Text.Equals("manager"))
                    indices.Add(GetClientFromIP(GetClientListView().Items[i].SubItems[0].Text)._index);
            }
            return indices;
        }
        public List<long> GetAllLoggedInClients()
        {
            int numberOfClients = GetClientListView().Items.Count;
            List<long> indices = new List<long>();
            for (int i = 0; i < numberOfClients; i++)
            {
                if (!GetClientListView().Items[i].SubItems[1].Text.Equals(""))
                    indices.Add(GetClientFromIP(GetClientListView().Items[i].SubItems[0].Text)._index);
            }
            return indices;
        }
        public List<long> GetPlayingClients()
        {
            int numberOfClients = GetClientListView().Items.Count;
            List<long> indices = new List<long>();
            for (int i = 0; i < numberOfClients; i++)
            {
                Client _client = GetClientFromIP(GetClientListView().Items[i].SubItems[0].Text);
                if (_client != null && _client._player._isGaming)
                    indices.Add(_client._index);
            }
            return indices;
        }
        public void SendToSelectedClients()
        {
            UpdateLog("Sending Message to Selected: \"" + serverInterface.GetTypedMessage() + "\"\n");
            SwayTCP.SendMessageToSelected(serverInterface.GetTypedMessage());
        }
        public void SendToEveryone()
        {
            UpdateLog("Sending Message to Everyone: \"" + serverInterface.GetTypedMessage() + "\"\n");
            SwayTCP.SendMessageToAll(serverInterface.GetTypedMessage());
        }
        public void UpdateClientList()
        {
            GetClientListView().Items.Clear();
            foreach (Client client in SwayTCP.Clients)
            {
                if (client._socket != null)
                {
                    string role;
                    switch (client._player._role) {
                        case Player_role.player:
                            role = "player";
                            break;
                        case Player_role.playing:
                            role = "playing";
                            break;
                        case Player_role.manager:
                            role = "manager";
                            break;
                        case Player_role.applicant:
                            role = "applicant";
                            break;
                        case Player_role.managing:
                            role = "managing";
                            break;
                        default:
                            role = "unknown";
                            break;
                }
                    string[] row = { client._ip, client._player._username, role };
                    GetClientListView().Items.Add(new ListViewItem(row));
                }
            }
        }
        
        //Database
        public void ChangeDatabaseStatusUI(ServerInterface.DatabaseStatus status)
        {
            switch (status)
            {
                case ServerInterface.DatabaseStatus.Connected:
                case ServerInterface.DatabaseStatus.Writing:
                case ServerInterface.DatabaseStatus.Downloading:
                    DatabaseConnection = true;
                    break;
                case ServerInterface.DatabaseStatus.Unavailable:
                case ServerInterface.DatabaseStatus.Disconnected:
                    DatabaseConnection = false;
                    break;
                default:
                    DatabaseConnection = false;
                    break;
            }
            serverInterface.setDatabaseConnectionStatus(status);
        }

        

        internal void ConnectToDatabase()
        {
            if (!DatabaseConnection)
                database.ConnectDatabase();
        }

        //Console
        public void UpdateLog(string s)
        {
            AppendLog( Constants.TimeStamp() + s );
        }
        //public string GetLog() { return serverInterface.AppendToLog().Lines.ToString(); }
        public void AppendLog(string s)
        {
            serverInterface.AppendToLog(s);
        }



        #endregion

        public void LogToFile()
        {
            string file = ".\\log\\" + DateTime.Now.ToString("yyyy-M-d") + ".txt";
            if (!File.Exists(file))
            {
                File.Create(file).Dispose();
                using (TextWriter tw = new StreamWriter(file))
                {
                    tw.WriteLine("This is the log file of the " + DateTime.Now.ToString("yyyy-M-d"));
                    tw.Close();
                }
            }
            File.AppendAllLines(file, serverInterface.GetLogTextBox().Lines);
            serverInterface.GetLogTextBox().Clear();
            UpdateLog("Log Saved.\n");
        }

        //Database
        public void ToggleDatabaseConnection(bool connection)
        {
            DatabaseConnection = connection;

        }
    }
}
