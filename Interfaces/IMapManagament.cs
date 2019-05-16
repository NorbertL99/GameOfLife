// Created by Norbert Lubaszka
// Contact: norbert.lubaszka@gmail.com
// All rights reserved ©
// If you want to use the source code contact me

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Of_Life.Interfaces
{
    interface IMapManagament
    {
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
        int[,] calculateMap(int[,] logicalMap, int mapSize, int toPopulate, int lowerDepopulation, int upperDepopulation, int toAlive1, int toAlive2);
        /// <summary>
        /// This method is used to get current count of population
        /// </summary>
        /// <param name="logicalMap">Current simulation map</param>
        /// <param name="mapSize">Map size</param>
        /// <returns>Count of populate</returns>
        int getPopulate(int[,] logicalMap, int mapSize);
        /// <summary>
        /// This method is used to set random map
        /// </summary>
        /// <param name="logicalMap">Current simulation map</param>
        /// <param name="mapSize">Map size</param>
        /// <returns>Random map</returns>
        int[,] setRandom(int[,] logicalMap, int mapSize);
    }
}
