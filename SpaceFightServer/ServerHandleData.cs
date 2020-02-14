//using SwayBuffer;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public static class ServerHandleData
    {
        private delegate void Packet_(long index, byte[] data);
        private static Dictionary<long, Packet_> packets = new Dictionary<long, Packet_>();
        private static long pLength;

        public static void InitPackets()
        {
            Console.WriteLine("Initializing packets...");
            packets.Add((long)ClientPackets.CNewConnection, Packet_CNewAccount);
            packets.Add((long)ClientPackets.CLogin, Packet_CLogin);
            packets.Add((long)ClientPackets.CLogout, Packet_CLogout);
            packets.Add((long)ClientPackets.CRegister, Packet_CRegister);
            packets.Add((long)ClientPackets.CBan, Packet_CBan);
            packets.Add((long)ClientPackets.CManage, Packet_CManage);
            packets.Add((long)ClientPackets.CSpawn, Packet_CSpawn);
            packets.Add((long)ClientPackets.CLeftGame, Packet_LeftGame);
            packets.Add((long)ClientPackets.CPosition, Packet_CPosition);
            packets.Add((long)ClientPackets.CRealtimePosition, Packet_CRealtimePosition);
            packets.Add((long)ClientPackets.CUnblock, Packet_CUnblock);
            //input
            packets.Add((long)ClientPackets.CInput, Packet_CInput);
            packets.Add((long)ClientPackets.CBullet, Packet_CShoot);
        }

        

        public static void HandleData(long index, byte[] data)
        {
            byte[] Buffer;
            Buffer = (byte[])data.Clone();

            if (Types.TempPlayer[index].Buffer == null) Types.TempPlayer[index].Buffer = new ByteBuffer();
            Types.TempPlayer[index].Buffer.WriteBytes(Buffer);

            if (Types.TempPlayer[index].Buffer.Count() == 0)
            {
                Types.TempPlayer[index].Buffer.Clear();
                return;
            }
            if (Types.TempPlayer[index].Buffer.Length() >= 4)
            {
                pLength = Types.TempPlayer[index].Buffer.ReadLong(false);
                if(pLength <= 0)
                {
                    Types.TempPlayer[index].Buffer.Clear();
                    return;
                }
            }
            if (Types.TempPlayer[index].Buffer.Length() >= 4)
            {
                pLength = Types.TempPlayer[index].Buffer.ReadLong(false);
                if (pLength <= 0)
                {
                    Types.TempPlayer[index].Buffer.Clear();
                    return;
                }
            }
            while (pLength > 0 & pLength <= Types.TempPlayer[index].Buffer.Length() - 8)
            {
                if (pLength <= Types.TempPlayer[index].Buffer.Length() -8)
                {
                    Types.TempPlayer[index].Buffer.ReadLong();
                    data = Types.TempPlayer[index].Buffer.ReadBytes((int)pLength);
                    HandleDataPackets(index, data);

                }
                pLength = 0;
                if(Types.TempPlayer[index].Buffer.Length() >= 4)
                {
                    pLength = Types.TempPlayer[index].Buffer.ReadLong(false);
                    if(pLength < 0)
                    {
                        Types.TempPlayer[index].Buffer.Clear();
                        return;
                    }
                }
            }

            if(pLength <= 1)
            {
                Types.TempPlayer[index].Buffer.Clear();
            }
        }
        public static void HandleDataPackets(long index, byte[] data)
        {
            long packetNum;
            ByteBuffer buffer;

            buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            packetNum = buffer.ReadLong();
            buffer = null;

            if (packetNum == 0) return;
            if(packets.TryGetValue(packetNum,out Packet_ packet))
            {
                packet.Invoke(index, data);
            }
        }

        //Packet Functions
        private static void Packet_CNewAccount(long index, byte[] data)
        {
            Console.WriteLine("Recieved Message.");
        }
        private static void Packet_CLogin(long index, byte[] data)
        {
            long packetNum;
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            packetNum = buffer.ReadLong();
            
            string username = buffer.ReadString();
            string password = buffer.ReadString();
            Console.WriteLine("Login Packet recieved: " + username + " " + password);
            List<string>[] check = SwayStation.station.UpdatePlayerDataBase(username);
            if(check[0].Count > 0)
            {
                if (check[(int)Sql_playerData.password][0].Contains(password))
                {
                    if (check[(int)Sql_playerData.isbanned][0].Equals("yes"))
                    {
                        string message = "You cannot log in, " + check[(int)Sql_playerData.username][0] + " is currently banned" ;
                        SwayTCP.SendBanMessage(index, message);
                        SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
                        {
                            SwayStation.station.UpdateLog(username + " attempted to log in but is banned\n");
                        });
                        
                    }
                    else
                    {
                        //array of random welcome messages here
                        
                        string playerData =
                            index +  "/" +
                            check[(int)Sql_playerData.playername][0] + "/" +
                            check[(int)Sql_playerData.health][0] + "/" +
                            check[(int)Sql_playerData.ammo][0] + "/" +
                            check[(int)Sql_playerData.rank][0] + "/" +
                            check[(int)Sql_playerData.score][0];

                        string message = "Welcome to Space Fight, " + check[(int)Sql_playerData.playername][0];
                        SwayTCP.SendLoginSuccess(index, message, playerData);
                        SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
                        {
                            SwayStation.station.AddClientPairing((int)index, check[0][0], check[1][0]);
                            SwayStation.station.UpdateLog(username + " successfully logged in.\n");
                        });
                        
                    }
                    

                }
                else
                {
                    //array of random welcome messages here
                    string message = "Wrong password.";
                    SwayTCP.SendLoginFail(index,message);
                    SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
                    {
                        SwayStation.station.UpdateLog(username + " entered wrong password.\n");
                    });
                    


                }
            } else
            {
                SwayTCP.SendCredentialsFail(index);

            }
            buffer = null;
        }
        private static void Packet_CBan(long index, byte[] data)
        {
            long packetNum;
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            packetNum = buffer.ReadLong();
            SwayStation.station.BanPlayer(buffer.ReadInteger());
            buffer = null;
        }
        private static void Packet_CLogout(long index, byte[] data)
        {
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayStation.station.UpdateLog(SwayTCP.Clients[index]._player._username + " logged out.\n");
                SwayStation.station.DeleteClientPairing((int)index);
            });
                
            SwayTCP.SendLogoutSuccess(index);
        }
        private static void Packet_CRegister(long index, byte[] data)
        {
            long packetNum;
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            packetNum = buffer.ReadLong();

            string username = buffer.ReadString();
            string password = buffer.ReadString();
            string playerName = buffer.ReadString();
            List<string>[] check = SwayStation.station.UpdatePlayerDataBase(username);
            if (check[0].Count > 0)
            {
                string message = "The username is already taken";
                SwayTCP.SendRegisterFail(index, message);
                SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
                {
                    SwayStation.station.UpdateLog("Username taken error: " + username + "\n");
                });

            }
            else
            {
                SwayStation.station.AddPlayer(username, playerName, password, "" + 1000, "" + 100, "no");
                check = SwayStation.station.UpdatePlayerDataBase(username);
                SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
                {
                    SwayStation.station.AddClientPairing((int)index, check[0][0], username);
                });
                string playerData = index + "/" +
                    check[(int)Sql_playerData.playername][0] + "/" +
                    check[(int)Sql_playerData.health][0] + "/" +
                    check[(int)Sql_playerData.ammo][0] + "/" +
                    check[(int)Sql_playerData.rank][0] + "/" +
                    check[(int)Sql_playerData.score][0];
                string message = "Registration successful, " + check[3][0];
                SwayTCP.SendRegisterSuccess(index, message, playerData);
            }
            buffer = null;
        }
        private static void Packet_CManage(long index, byte[] data)
        {
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayStation.station.UpdateLog(SwayTCP.Clients[index]._player._username + " has requested game privilages.\n");
                SwayStation.station.AddClientManagingWaitingList((int)index);
            });

            SwayTCP.SendManagingRequestRecieved(index);
        }
        private static void Packet_CSpawn(long index, byte[] data)
        {
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayStation.station.SpawnClient((int)index);
            });
            
        }
        private static void Packet_LeftGame(long index, byte[] data)
        {
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayStation.station.ClientLeftGame((int)index);
            });
            SwayTCP.SendPlayerRemoval(index);
        }
        private static void Packet_CPosition(long index, byte[] data)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            buffer.ReadLong();

            int x = buffer.ReadInteger();
            int y = buffer.ReadInteger();
            SwayTCP.Clients[index]._player.x = x;
            SwayTCP.Clients[index]._player.y = y;
            SwayStation.station.gameLogic.IncomingMovement((int)index, x, y);
            buffer = null;
        }
        private static void Packet_CRealtimePosition(long index, byte[] data)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            buffer.ReadLong();

            float x = buffer.ReadFloat();
            float y = buffer.ReadFloat();
            float rotation = buffer.ReadFloat();
            buffer = null;
            SwayTCP.SendRealtimeUpdateToAll((int)index, x, y, rotation);

        }
        private static void Packet_CInput(long index, byte[] data)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            buffer.ReadLong();
            ClientInput input = (ClientInput)buffer.ReadInteger();
            int isKeyPressed = buffer.ReadInteger();
            float x = buffer.ReadFloat();
            float y = buffer.ReadFloat();
            float rotation = buffer.ReadFloat();

            //handle logic
            SwayTCP.SendRealtimeInputToAll(index, input, isKeyPressed, x, y, rotation);
            buffer = null;
        }
        private static void Packet_CShoot(long index, byte[] data)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            buffer.ReadLong();
            float direction = buffer.ReadFloat();
            //handle logic
            SwayTCP.SendRealtimeDirectionToAll(index, direction);

        }
        private static void Packet_CUnblock(long index, byte[] data)
        {
            ByteBuffer buffer = new ByteBuffer();
            buffer.WriteBytes(data);
            buffer.ReadLong();
            long opponentIndex = buffer.ReadLong();
            SwayStation.station.gameLogic.RemoveBlockHash(index, opponentIndex);
            int x = buffer.ReadInteger();
            int y = buffer.ReadInteger();
            SwayTCP.SendUnblock(opponentIndex, x, y);
        }
        
    }
}
