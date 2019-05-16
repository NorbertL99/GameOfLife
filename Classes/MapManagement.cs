// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me

using System;
using System.Collections.Generic;
using Game_Of_Life.Interfaces;

namespace Game_Of_Life.Classes
{
    class MapManagement : IMapManagament
    {
        /// <summary>
        /// Class constructor
        /// </summary>
        public MapManagement()
        {

        }
        /// <summary>
        /// This method is used to calculate new map for each step
        /// </summary>
        /// <param name="logicalMap">Current simulation map</param>
        /// <param name="mapSize">Map size</param>
        /// <param name="toPopulate">Count of alive block needed to populate death block</param>
        /// <param name="lowerDepopulation">Count of block needed to depoplate alive block (lower)</param>
        /// <param name="upperDepopulation">Count of block needed to depoplate alive block (upper)</param>
        /// <param name="toAlive1">Count of block needed to alive block stay alive (1)</param>
        /// <param name="toAlive2">Count of block needed to alive block stay alive (2)</param>
        /// <returns>Calculated map</returns>
        public int[,] calculateMap(int[,] logicalMap, int mapSize, int toPopulate, int lowerDepopulation, int upperDepopulation, int toAlive1, int toAlive2)
        {
            List<int> toRemoveX = new List<int>();
            List<int> toRemoveY = new List<int>();
            List<int> toAddX = new List<int>();
            List<int> toAddY = new List<int>();
            int aliveBlock = 0;
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        if (logicalMap[j + 1, i] == 1) aliveBlock++;
                        if (logicalMap[j, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i + 1] == 1) aliveBlock++;
                    }
                    else if (i == 39 && j == 39)
                    {
                        if (logicalMap[j - 1, i] == 1) aliveBlock++;
                        if (logicalMap[j, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i - 1] == 1) aliveBlock++;
                    }
                    else if (i == 0 && j == 39)
                    {
                        if (logicalMap[j - 1, i] == 1) aliveBlock++;
                        if (logicalMap[j, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i + 1] == 1) aliveBlock++;
                    }
                    else if (i == 39 && j == 0)
                    {
                        if (logicalMap[j + 1, i] == 1) aliveBlock++;
                        if (logicalMap[j, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i - 1] == 1) aliveBlock++;
                    }
                    else if (i == 0 && j > 0)
                    {
                        if (logicalMap[j - 1, i] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i] == 1) aliveBlock++;
                        if (logicalMap[j, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i + 1] == 1) aliveBlock++;
                    }
                    else if (i > 0 && j == 0)
                    {
                        if (logicalMap[j, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i + 1] == 1) aliveBlock++;
                    }
                    else if (i == 39 && j > 0)
                    {
                        if (logicalMap[j, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i - 1] == 1) aliveBlock++;
                    }
                    else if (i > 0 && j == 39)
                    {
                        if (logicalMap[j, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i + 1] == 1) aliveBlock++;
                    }
                    else
                    {
                        if (logicalMap[j, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j - 1, i + 1] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i - 1] == 1) aliveBlock++;
                        if (logicalMap[j + 1, i + 1] == 1) aliveBlock++;
                    }
                    if (logicalMap[j, i] == 0)
                    {
                        if (aliveBlock == toPopulate)
                        {
                            toAddX.Add(j);
                            toAddY.Add(i);
                        }
                    }
                    else
                    {
                        if (aliveBlock <= lowerDepopulation)
                        {
                            toRemoveX.Add(j);
                            toRemoveY.Add(i);
                        }
                        else if (aliveBlock >= upperDepopulation)
                        {
                            toRemoveX.Add(j);
                            toRemoveY.Add(i);
                        }
                        else if (aliveBlock == toAlive1 || aliveBlock == toAlive2)
                        {
                            toAddX.Add(j);
                            toAddY.Add(i);
                        }
                    }
                    aliveBlock = 0;
                }
            }
            for (int i = 0; i < toRemoveX.Count; i++)
            {
                logicalMap[toRemoveX[i], toRemoveY[i]] = 0;
            }
            for (int i = 0; i < toAddX.Count; i++)
            {
                logicalMap[toAddX[i], toAddY[i]] = 1;
            }
            toAddX.Clear();
            toAddY.Clear();
            toRemoveX.Clear();
            toRemoveY.Clear();
            return logicalMap;
        }
        /// <summary>
        /// This method is used to get current count of population
        /// </summary>
        /// <param name="logicalMap">Current simulation map</param>
        /// <param name="mapSize">Map size</param>
        /// <returns>Count of populate</returns>
        public int getPopulate(int[,] logicalMap, int mapSize)
        {
            int populate = 0;
            for(int i = 0; i < mapSize; i++)
            {
                for(int j = 0; j < mapSize; j++)
                {
                    if (logicalMap[j, i] == 1) populate = populate + 1;
                }
            }
            return populate;
        }
        /// <summary>
        /// This method is used to set random map
        /// </summary>
        /// <param name="logicalMap">Current simulation map</param>
        /// <param name="mapSize">Map size</param>
        /// <returns>Random map</returns>
        public int[,] setRandom(int[,] logicalMap, int mapSize)
        {
            Random random = new Random();
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (random.Next(0, 100) > 70) logicalMap[j, i] = 1;
                    else logicalMap[j, i] = 0;
                }
            }
            return logicalMap;
        }
    }
}
