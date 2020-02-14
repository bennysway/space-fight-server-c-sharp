using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public class GameLogic
    {
        Thread AllowMovement;
        Thread SpawnPlayerThread;
        Client tempSpawnClient;
        List<Client> GameClients;
        ThreadStart FindSpawnPointThreadStarter;
        List<string> blockQueue;



        public GameLogic()
        {
            GameClients = new List<Client>();
            blockQueue = new List<string>();
            AllowMovement = new Thread(AllowMovementFunction) { IsBackground = true };
            FindSpawnPointThreadStarter = new ThreadStart(() => AllowSpawnFunction(tempSpawnClient));
            FindSpawnPointThreadStarter += () =>
            {
                SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
                {
                    SwayStation.station.UpdateClientList();
                    SwayStation.station.UpdateNeedle();
                });
            };
            InitMap();
            AllowMovement.Start();
        }
       
        public void InitMap()
        {
            Map1.InitializeMap();
        }

        private void AllowSpawnFunction(Client client)
        {
            Map1.SpawnPlayer(client._index);
            client._player._role = PlayerRole.GetNextEnumValueOf(client._player._role);
            client._player._isGaming = true;
            GameClients.Add(client);
        }

        private void AllowMovementFunction()
        {
            int deltaX;
            int deltaY;
            int i;
            int j;
            string blockHash;
            while (true)
            {
                for(int client1 = 0; client1 < GameClients.Count; client1++)
                {
                    for (int client2 = client1 + 1; client2 < GameClients.Count; client2++)
                    {
                        deltaX = Math.Abs(GameClients[client1]._player.x - GameClients[client2]._player.x);
                        deltaY = Math.Abs(GameClients[client1]._player.y - GameClients[client2]._player.y);
                        i = GameClients[client1]._index;
                        j = GameClients[client2]._index;
                        blockHash = (((i + j) * (i + j + 1) / 2) + j) + "";
                        if (!(deltaX == 0 & deltaY == 0))
                        {
                            if (deltaX < 2)
                            {
                                if (deltaY < 2)
                                {
                                    if (!blockQueue.Contains(blockHash))
                                    {
                                        blockQueue.Add((((i + j) * (i + j + 1) / 2) + j) + "");
                                        SwayTCP.SendBlock(GameClients[client1]._index, GameClients[client2]._index, GameClients[client1]._player.x, GameClients[client1]._player.y, GameClients[client2]._player.x, GameClients[client2]._player.y);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void RemoveBlockHash(long index1, long index2)
        {
            string blockHash = (((index1 + index2) * (index1 + index2 + 1) / 2) + index2) + "";
            blockQueue.Remove(blockHash);
        }

        public void SpawnGamer(Client client)
        {
            tempSpawnClient = client;
            SpawnPlayerThread = new Thread(FindSpawnPointThreadStarter) { IsBackground = true };
            SpawnPlayerThread.Start();
            client._player._isGaming = true;
        }
        

        internal void Remove(Client client)
        {
            client._player._isGaming = false;
            client._player._role = PlayerRole.GetPreviousEnumValueOf(client._player._role);
            GameClients.Remove(client);
            Map1.RemovePlayer(client._index);
        }

        internal void IncomingMovement(int index, int x, int y)
        {
            Map1.MovePlayer(index, x, y);
        }
    }
}
