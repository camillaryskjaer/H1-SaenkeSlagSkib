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
        private List<Ship> ships = new List<Ship>();
        private Material[,] board;

        public Material[,] BoardArray
        {
            get { return board; }
            set { board = value; }
        }

        public MaterialBoard()
        {
            Water water = new Water();
            board = new Material[,]
            {
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},
                {water},{water }, { water}, {water }, { water}, { water}, { water}, { water}, {water }, { water},

            };
            AddShips();
        }
        private void AddShips()
        {
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
        }
    }
}
