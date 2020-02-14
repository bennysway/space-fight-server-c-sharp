using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public class Client
    {

        public class Player
        {
            //
            //public int _index;
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
            public Player_role _role;
            public bool _isGaming;
            //
            public int x;
            public int y;
            public List<KeyValuePair<int, int>> _blockages = new List<KeyValuePair<int, int>>();

            public void Clear()
            {
                _id = "";
                _username = "";
                _password = "";
                _playerName = "";
                _isGaming = false;
                _blockages.Clear();
            }
        }

        public int _index;
        public string _ip;
        public TcpClient _socket;
        public NetworkStream _stream;
        private byte[] readbuffer;
        public Player _player;

        public Client()
        {
            _player = new Player();
        }

        public void Start()
        {
            
            _socket.SendBufferSize = 4096;
            _socket.ReceiveBufferSize = 4096;
            _stream = _socket.GetStream();
            readbuffer = new byte
                [4096];
            _stream.BeginRead(readbuffer, 0, _socket.ReceiveBufferSize, OnReceiveData, null);
        }

        private void OnReceiveData(IAsyncResult ar)
        {
            try
            {
                int readBytes = _stream.EndRead(ar);
                if(readBytes <= 0)
                {
                    CloseSocket();
                    return;
                }
                byte[] newBytes = new byte[readBytes];
                Buffer.BlockCopy(readbuffer, 0, newBytes, 0, readBytes);
                ServerHandleData.HandleData(_index, newBytes);
                _stream.BeginRead(readbuffer, 0, _socket.ReceiveBufferSize, OnReceiveData, null);
            }
            catch (Exception)
            {
                CloseSocket();
                return;
            }
        }

        private void CloseSocket()
        {
            _player.Clear();
            _socket.Close();
            _socket = null;
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayTCP.ClientCount--;
                SwayStation.station.gameLogic.Remove(SwayTCP.Clients[_index]);
                SwayStation.station.UpdateLog("Connection from ip: " + _ip + " has been terminated!\n");
                SwayStation.station.UpdateClientNumber(SwayTCP.ClientCount);
            });
            if(_player._isGaming)
                SwayTCP.SendPlayerRemoval(_index);
        }
    }
}
