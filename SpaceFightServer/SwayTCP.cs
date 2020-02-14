using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public static class SwayTCP
    {
        public static Client[] Clients = new Client[Constants.MAX_PLAYERS];
        public static int ClientCount;
        public static TcpListener ServerSocket;

        public static void InitializeNetwork()
        {
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayStation.station.ChangeServerStatusUI(ServerInterface.ServerStatus.Busy, "Setting up server...\n");
                SwayStation.station.UpdateLog("Setting up server...\n");
            });
            Console.WriteLine("Setting up server...");
            ServerSocket = new TcpListener(IPAddress.Any, 5555);
            ServerSocket.Start();
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayStation.station.ChangeServerStatusUI(ServerInterface.ServerStatus.Connected);
                SwayStation.station.UpdateLog("Server is running.\n");
            });
            ClientCount = 0;
            Console.WriteLine("Server is running.");
            ServerSocket.BeginAcceptTcpClient(OnClientConnect, null);
        }
        private static void OnClientConnect(IAsyncResult ar)
        {
            TcpClient client = ServerSocket.EndAcceptTcpClient(ar);
            client.NoDelay = false;
            ServerSocket.BeginAcceptTcpClient(OnClientConnect, null);

            for(int i = 1; i< Constants.MAX_PLAYERS; i++)
            {
                if(Clients[i]._socket == null)
                {
                    Clients[i]._socket = client;
                    Clients[i]._index = i;
                    Clients[i]._ip = client.Client.RemoteEndPoint.ToString();
                    Clients[i].Start();
                    ClientCount++;
                    SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
                    {
                        SwayStation.station.UpdateClientNumber(ClientCount);
                        SwayStation.station.UpdateLog("New client connected from " + Clients[i]._ip + "\n");
                    });
                    SendWelcomeMessage(i);
                    return;
                }
            }
        }
        public static void SendDataTo(long index, byte[] data)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((data.GetUpperBound(0) - data.GetLowerBound(0)) + 1);
            buffer.WriteBytes(data);
            Clients[index]._stream.BeginWrite(buffer.ToArray(), 0, buffer.ToArray().Length, null, null);
            buffer = null;
        }
        public static void SendDataTo(List<long> index, byte[] data)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((data.GetUpperBound(0) - data.GetLowerBound(0)) + 1);
            buffer.WriteBytes(data);
            foreach (long _index in index)
                Clients[_index]._stream.BeginWrite(buffer.ToArray(), 0, buffer.ToArray().Length, null, null);
            buffer = null;
        }
        public static void SendMessageToSelected(string message)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SMessage);
            buffer.WriteString(message);
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SendDataTo(SwayStation.station.GetSelectedClients(), buffer.ToArray());
            });
            buffer = null;
        }
        public static void SendMessageToAll(string message)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SMessage);
            buffer.WriteString(message);
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SendDataTo(SwayStation.station.GetAllClients(), buffer.ToArray());
            });
            buffer = null;
        }
        public static void SendRealtimeUpdateToAll(int index,float x,float y, float rotation)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SPlayerRealtimeUpdate);
            buffer.WriteInteger(index);
            buffer.WriteFloat(x);
            buffer.WriteFloat(y);
            buffer.WriteFloat(rotation);
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SendDataTo(SwayStation.station.GetPlayingClients(), buffer.ToArray());
            });
            buffer = null;
        }
        public static void SendWelcomeMessage(long index)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SWelcome);
            buffer.WriteString("Welcome to Space Fight");
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendLoginSuccess(long index,string message, string playerData)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SSuccessfulLogIn);
            buffer.WriteString(message);
            buffer.WriteString(playerData);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendLoginFail(long index, string message)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SWrongPassword);
            buffer.WriteString(message);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendCredentialsFail(long index)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SWrongCredentials);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendLogoutSuccess(long index)
        {

            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SSuccessfulLogOut);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendBanMessage(long index, string message)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SBanLogin);
            buffer.WriteString(message);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendRegisterFail(long index, string message)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SRegisterFail);
            buffer.WriteString(message);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendRegisterSuccess(long index, string message, string playerData)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SSuccessfulRegister);
            buffer.WriteString(message);
            buffer.WriteString(playerData);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendManagingRequestRecieved(long index)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SReceivedManage);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendManagementPrivilage(int index)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SSuccessfulManage);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendSpawnPoint(int index, int pos)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SSpawnPlayer);
            buffer.WriteInteger(pos);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }
        internal static void SendPlayerRemoval(long index)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SRemovePlayer);
            buffer.WriteLong(index);
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SendDataTo(SwayStation.station.GetPlayingClients(), buffer.ToArray());
            });
            buffer = null;
        }

        internal static void SendBlock(long index1,long index2, int x1, int y1, int x2, int y2)
        {
            ByteBuffer buffer1 = new ByteBuffer();
            ByteBuffer buffer2 = new ByteBuffer();
            buffer1.WriteLong((long)ServerPackets.SBlock);
            buffer2.WriteLong((long)ServerPackets.SBlock);
            buffer1.WriteLong(index2);
            buffer2.WriteLong(index1);
            buffer1.WriteInteger(x2);
            buffer1.WriteInteger(y2);
            buffer2.WriteInteger(x1);
            buffer2.WriteInteger(y1);
            SendDataTo(index1, buffer1.ToArray());
            SendDataTo(index2, buffer2.ToArray());
            buffer1 = null;
            buffer2 = null;
        }
        internal static void SendUnblock(long index, int x, int y)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SUnblock);
            buffer.WriteInteger(x);
            buffer.WriteInteger(y);
            SendDataTo(index, buffer.ToArray());
            buffer = null;
        }

        internal static void SendRealtimeInputToAll(long index, ClientInput input, int isKeyPressed, float x, float y, float rotation)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SInput);
            buffer.WriteLong(index);
            buffer.WriteInteger((int)input);
            buffer.WriteInteger(isKeyPressed);
            buffer.WriteFloat(x);
            buffer.WriteFloat(y);
            buffer.WriteFloat(rotation);
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SendDataTo(SwayStation.station.GetPlayingClients(), buffer.ToArray());
            });
            buffer = null;
        }

        

        internal static void SendRealtimeDirectionToAll(long index, float direction)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteLong((long)ServerPackets.SBullet);
            buffer.WriteLong(index);
            buffer.WriteFloat(direction);
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SendDataTo(SwayStation.station.GetPlayingClients(), buffer.ToArray());
            });
            buffer = null;
        }
    }
}
