using System;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public class Player
    {
        //
        public int _index;
        public string _id;
        public string _username;
        public string _password;
        public string _playerName;
        public int _health;
        public int _ammo;
        public string _map;
        public int _rank;
        public int _score;
        public bool _banned;
        //
        public string _ip;
        public Player_role _role;
        public bool _isGaming;
    }
}
