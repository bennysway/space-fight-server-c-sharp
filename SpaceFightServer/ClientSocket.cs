using System.Net.Sockets;

namespace SpaceFightServer
{
    public class ClientSocket
    {
        public Socket _socket { get; set; }
        public string _name;

        public ClientSocket(Socket s)
        {
            _socket = s;
        }
    }
}
