using H1_SænkeSlagSkib.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards
{
    internal class MaterialBoard:Board
    {
        private Material[,] board;

        public Material[,] BoardArray
        {
            get { return board; }
            set { board = value; }
        }
        /// <summary>
        /// Constructor to instanciate Material board for ships, water ETC.
        /// </summary>
        public MaterialBoard()
        {
            Water water = new Water();
            board = new Material[,]
            {
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water},
                {water,water,water,water,water,water,water,water,water,water}
            };
        }

    }
}
