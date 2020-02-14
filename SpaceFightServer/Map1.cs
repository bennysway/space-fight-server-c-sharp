using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

//Map details: 
// x: -36 ->  50
// y:  28 -> -26
// x:  44 tiles
// y:  28 tiles

//Spawn points
//spawn index   0       1       2       3       4       5       6       7
//tile          2,10    23,11   22,14   38,4    38,25   15,25   3,25    3,4
//coordinates   -31,9   11,7    9,1     41,21   41,-21  -5,-21  -29,-21 -29,21


namespace SpaceFightServer
{
    public static class Map1
    {

        public static int[,] map = new int[44, 28];
        public static List<KeyValuePair<int, int>> spawnPoints = new List<KeyValuePair<int, int>>();
        private static object my_lock = new object();
        private static int range = 1;

        internal static void InitializeMap()
        {
            Clear();
            InitializeSpawnPoints();
        }
        internal static void Clear()
        {
            for (int y = 0; y < 28; y++)
            {
                for (int x = 0; x < 44; x++)
                {
                    map[x, y] = -1;
                }
            }
            InitializeObstructionNebula();
        }
        private static void InitializeObstructionNebula()
        {
            //
            map[0, 6] = -2;
            map[0, 7] = -2;
            map[1, 6] = -2;
            map[1, 7] = -2;
            map[2, 6] = -2;
            map[2, 7] = -2;
            map[2, 8] = -2;
            map[3, 6] = -2;
            map[3, 7] = -2;
            map[3, 8] = -2;
            map[4, 7] = -2;
            map[4, 8] = -2;
            map[5, 7] = -2;
            map[5, 8] = -2;
            map[5, 9] = -2;
            map[6, 7] = -2;
            map[6, 8] = -2;
            map[6, 9] = -2;
            map[6, 10] = -2;
            map[6, 16] = -2;
            map[6, 17] = -2;
            map[7, 8] = -2;
            map[7, 9] = -2;
            map[7, 10] = -2;
            map[7, 11] = -2;
            map[7, 12] = -2;
            map[7, 13] = -2;
            map[7, 14] = -2;
            map[7, 15] = -2;
            map[7, 16] = -2;
            map[7, 17] = -2;
            map[8, 8] = -2;
            map[8, 9] = -2;
            map[8, 10] = -2;
            map[8, 11] = -2;
            map[8, 12] = -2;
            map[8, 13] = -2;
            map[8, 14] = -2;
            map[8, 15] = -2;
            map[8, 16] = -2;
            map[8, 17] = -2;
            map[9, 10] = -2;
            map[9, 11] = -2;
            map[9, 12] = -2;
            map[9, 13] = -2;
            map[9, 14] = -2;
            map[9, 15] = -2;
            map[10, 12] = -2;
            map[10, 13] = -2;
            map[3, 16] = -2;
            map[3, 17] = -2;
            map[4, 16] = -2;
            map[4, 17] = -2;
            map[5, 16] = -2;
            map[5, 17] = -2;
            //
            map[25, 5] = -2;
            map[25, 6] = -2;
            map[25, 7] = -2;
            map[25, 8] = -2;
            map[26, 5] = -2;
            map[26, 6] = -2;
            map[26, 7] = -2;
            map[26, 8] = -2;
            map[27, 6] = -2;
            map[27, 7] = -2;
            map[27, 8] = -2;
            map[28, 6] = -2;
            map[28, 7] = -2;
            map[28, 8] = -2;
            map[29, 6] = -2;
            map[29, 7] = -2;
            map[29, 8] = -2;
            map[30, 6] = -2;
            map[30, 7] = -2;
            map[30, 8] = -2;
            map[31, 5] = -2;
            map[31, 6] = -2;
            map[31, 7] = -2;
            map[31, 8] = -2;
            map[32, 5] = -2;
            map[32, 6] = -2;
            map[32, 7] = -2;
            map[32, 8] = -2;
            map[33, 2] = -2;
            map[33, 3] = -2;
            map[33, 4] = -2;
            map[33, 5] = -2;
            map[33, 6] = -2;
            map[33, 7] = -2;
            map[34, 0] = -2;
            map[34, 1] = -2;
            map[34, 2] = -2;
            map[34, 3] = -2;
            map[34, 4] = -2;
            map[34, 5] = -2;
            map[34, 6] = -2;
            map[34, 7] = -2;
            map[35, 0] = -2;
            map[35, 1] = -2;
            map[35, 2] = -2;
            map[35, 3] = -2;
            map[35, 4] = -2;
            map[35, 5] = -2;
            map[35, 6] = -2;
            //W
            map[7, 21] = -2;
            map[7, 22] = -2;
            map[7, 23] = -2;
            map[7, 24] = -2;
            map[8, 25] = -2;
            map[9, 21] = -2;
            map[9, 22] = -2;
            map[9, 23] = -2;
            map[9, 24] = -2;
            map[10, 25] = -2;
            map[11, 21] = -2;
            map[11, 22] = -2;
            map[11, 23] = -2;
            map[11, 24] = -2;
            //M
            map[14, 19] = -2;
            map[14, 20] = -2;
            map[14, 21] = -2;
            map[14, 22] = -2;
            map[14, 23] = -2;
            map[15, 18] = -2;
            map[16, 19] = -2;
            map[16, 20] = -2;
            map[16, 21] = -2;
            map[17, 18] = -2;
            map[18, 19] = -2;
            map[18, 20] = -2;
            map[18, 21] = -2;
            map[18, 22] = -2;
            map[18, 23] = -2;
            //i
            map[21, 22] = -2;
            map[21, 26] = -2;
            map[22, 20] = -2;
            map[22, 22] = -2;
            map[22, 23] = -2;
            map[22, 24] = -2;
            map[22, 25] = -2;
            map[22, 26] = -2;
            map[23, 26] = -2;
            //I
            map[26, 17] = -2;
            map[26, 23] = -2;
            map[27, 17] = -2;
            map[27, 18] = -2;
            map[27, 19] = -2;
            map[27, 20] = -2;
            map[27, 21] = -2;
            map[27, 22] = -2;
            map[27, 23] = -2;
            map[28, 17] = -2;
            map[28, 23] = -2;
            // /
            map[33, 23] = -2;
            map[34, 22] = -2;
            map[35, 21] = -2;
            map[36, 20] = -2;
            //17
            map[38, 20] = -2;
            map[38, 21] = -2;
            map[38, 22] = -2;
            map[38, 23] = -2;
            map[40, 20] = -2;
            map[41, 20] = -2;
            map[42, 20] = -2;
            map[42, 21] = -2;
            map[42, 22] = -2;
            map[42, 23] = -2;

            
        }

        internal static void RemovePlayer(int index)
        {
            for (int y = 0; y < 28; y++)
            {
                for (int x = 0; x < 44; x++)
                {
                    if(map[x, y] == index)
                    {
                        map[x, y] = -1;
                    }
                }
            }
        }

        private static void InitializeSpawnPoints()
        {
            spawnPoints.Add(new KeyValuePair<int, int>(2, 10));
            spawnPoints.Add(new KeyValuePair<int, int>(23, 11));
            spawnPoints.Add(new KeyValuePair<int, int>(22, 14));
            spawnPoints.Add(new KeyValuePair<int, int>(38, 4));
            spawnPoints.Add(new KeyValuePair<int, int>(22, 14));
            spawnPoints.Add(new KeyValuePair<int, int>(38, 25));
            spawnPoints.Add(new KeyValuePair<int, int>(15, 25));
            spawnPoints.Add(new KeyValuePair<int, int>(3, 25));
            spawnPoints.Add(new KeyValuePair<int, int>(3, 4));
        }

        internal static void SpawnPlayer(int client_id)
        {
            int spawnIndex = 0;
            lock (my_lock)
            {
                bool isSpawned = false;
                while (!isSpawned)
                {
                    for (int i = 0; i < spawnPoints.Count; i++)
                    {
                        if (map[spawnPoints[i].Key, spawnPoints[i].Value] < 0)
                        {
                            map[spawnPoints[i].Key, spawnPoints[i].Value] = client_id;
                            isSpawned = true;
                            spawnIndex = i;
                            break;
                        }
                    }
                    Thread.Sleep(1000);
                }
            }
            SwayTCP.SendSpawnPoint(client_id, spawnIndex);
            SwayStation.station.GetInterface().Invoke((MethodInvoker)delegate
            {
                SwayStation.station.UpdateLog("Spawned player: " + client_id + " to spawn point: " + spawnIndex + "\n");
            });
        }

        internal static void MovePlayer(int index, int x, int y)
        {
            for (int clear_y = 0; clear_y < 28; clear_y++)
            {
                for (int clear_x = 0; clear_x < 44; clear_x++)
                {
                    if (map[clear_x, clear_y] == index)
                    {
                        map[clear_x, clear_y] = -1;
                    }
                }
            }
            map[x, y] = index;
            //BlockMovement(index, x, y);
        }

        public static void BlockMovement(long index, int x, int y)
        {
            int check_x, check_y;
            for (int iy = -1; iy <= 1; iy++)
            {
                for (int ix = -1; ix <= 1; ix++)
                {
                    check_x = x + ix;
                    check_y = y + iy;
                    if (check_x > 0 && check_x < 44 && check_y > 0 && check_y < 28)
                    {
                        if (map[check_x, check_y] > -1 && ix != 0 && iy != 0)
                        {
                            //send block to map[x + ix, y + iy]
                            //SwayTCP.SendBlock(index, check_x, check_y);
                            var result = SwayTCP.Clients[index]._player._blockages.Where(kvp => kvp.Key == check_x && kvp.Value == check_y );
                            if(result == null)
                            {
                                SwayTCP.Clients[index]._player._blockages.Add(new KeyValuePair<int, int>(check_x, check_y));
                                //add thread to block to listen for player leaving

                                ThreadPool.QueueUserWorkItem((i) =>
                                {
                                    WaitForBlockVacancy(index, check_x, check_y);
                                });
                            }
                            else
                            {
                                Console.WriteLine("Block Exists");
                            }
                        }
                    }
                        
                }
            }
        }

        private static void WaitForBlockVacancy(long index, int x, int y)
        {
            while (map[x,y] > -1)
            {
                Console.WriteLine("waiting for free block at: " + map[x, y]);
                Thread.Sleep(500);
            }
            //send unblock to tile x,y
            SwayTCP.Clients[index]._player._blockages.Remove(new KeyValuePair<int, int>(x, y));
            SwayTCP.SendUnblock(index, x, y);
        }

        public static string toString()
        {
            if(map != null)
            {
                string s_map = "";
                string s_player = "  ";
                for (int y = 0; y < 28; y++)
                {
                    s_map += "|";
                    for (int x = 0; x < 44; x++)
                    {
                        if (map[x, y] == -1)
                            s_map += " ";
                        else if (map[x, y] == -2)
                            s_map += "x";
                        else
                        {
                            if (map[x, y] >= (range - 1) * 10 && map[x, y] < range * 10)
                            {
                                s_player = map[x, y].ToString();
                                if (s_player.Length == 2)
                                    s_map += s_player[1];
                                else
                                    s_map += s_player;
                            }
                            else
                                s_map += ".";
                        }
                    }
                    s_map += "|";
                    s_map += Environment.NewLine;
                }
                return s_map;
            }
            else
                return "Map not available yet";

            
        }
    }
}
