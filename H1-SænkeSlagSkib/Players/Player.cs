using H1_SænkeSlagSkib.Materials;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Players
{
    internal class Player
    {
        private int health;
        private List<Ship> ships = new();

        public List <Ship> Ships
        {
            get { return ships; }
            private set { ships = value; }
        }

        public int Health
        {
            get { return health; }
            protected internal set { health = value; }
        }
        /// <summary>
        /// Constructor to adding all ships on the map
        /// </summary>
        public Player()
        {
            AddShips();
        }

        /// <summary>
        /// Method to set health variable to the right health
        /// </summary>
        public void HealthUpdate()
        {
            health = 0;
            for (int i = 0; i < ships.Count; i++)
            {
                health += ships[i].Health;
            }
        }
        /// <summary>
        /// Instanciates all the ships, and puts them on a list
        /// </summary>
        private void AddShips()
        {
            ships.Add(new Ship(Ship.ShipEnum.HangarSkib, 5));
            ships.Add(new Ship(Ship.ShipEnum.SlagSkib, 4));
            ships.Add(new Ship(Ship.ShipEnum.SlagSkib, 4));
            ships.Add(new Ship(Ship.ShipEnum.Destroyer, 3));
            ships.Add(new Ship(Ship.ShipEnum.Destroyer, 3));
            ships.Add(new Ship(Ship.ShipEnum.Ubåd, 3));
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
            ships.Add(new Ship(Ship.ShipEnum.PatruljeBåd, 2));
        }
        /// <summary>
        /// Method to shoot on the map
        /// </summary>
        /// <param name="hitBoard"></param>
        /// <param name="enemyBoard"></param>
        /// <param name="cords"></param>
        /// <returns></returns>
        public string ShootBoard(string[,] hitBoard, Material[,] enemyBoard, string cords)
        {
            char[] cordsArray = cords.ToCharArray();
            string responseString;
            int firstCordInt = Convert.ToInt32(cordsArray[0].ToString())-1;
            int secondCordInt = 0;
            switch (cordsArray[1].ToString().ToLower())
            {
                case "a":
                    secondCordInt = 0;
                    break;
                case "b":
                    secondCordInt = 1;
                    break;
                case "c":
                    secondCordInt = 2;
                    break;
                case "d":
                    secondCordInt = 3;
                    break;
                case "e":
                    secondCordInt = 4;
                    break;
                case "f":
                    secondCordInt = 5;
                    break;
                case "g":
                    secondCordInt = 6;
                    break;
                case "h":
                    secondCordInt = 7;
                    break;
                case "i":
                    secondCordInt = 8;
                    break;
                case "j":
                    secondCordInt = 9;
                    break;
            }
            if (enemyBoard[firstCordInt, secondCordInt].Type == "Ship")
            {
                Ship ship = (Ship)enemyBoard[firstCordInt, secondCordInt];
                ship.HitHealth();
            }
            if(((Ship)enemyBoard[firstCordInt, secondCordInt]).Health == 0)
            {
                responseString = "Ship down!";
            }
            else
            {
                responseString = enemyBoard[firstCordInt, secondCordInt].Hitsound;

            }
            enemyBoard[firstCordInt, secondCordInt] = new HitMarker();

            hitBoard[firstCordInt+1, secondCordInt+1] = ("[X]");
            return responseString;
        }

        /// <summary>
        /// Random generations that put all ships on the board, it will try to put the ship Horizontaly first, and then Verticly if it could place it Horizontaly,if neither Verticly nor Horizontaly works, it will try with a new position and it will keep doing this to all ships are placed 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="ships"></param>
        public void GenerateMap(Material[,] board, List<Ship> ships)
        {

            for (int i = 0; i < ships.Count; i++)
            {
                bool place = false;
                while (!place)
                {
                    bool alreadyShip = false;
                    Random r = new();
                    int randomY = r.Next(board.GetLength(0) - 1);
                    int randomX = r.Next(board.GetLength(1) - 1);
                    Ship ship = ships[i];
                    if (board[randomX, randomY].Type != "Ship")
                    {
                        if (randomX + ship.Length <= (board.GetLength(1) - 1))
                        {

                            for (int j = randomX; j < (randomX + ship.Length); j++)
                            {
                                if (board[randomY, j].Type == "Ship")
                                {
                                    alreadyShip = true;
                                }
                            }
                            if (!alreadyShip)
                            {
                                for (int j = randomX; j < (randomX + ship.Length); j++)
                                {
                                    board[randomY, j] = ship;
                                }
                                place = true;
                            }
                        }
                        else if((randomY-ship.Length) >= 0)
                        {
                            for (int j = randomY; j > (randomY - ship.Length); j--)
                            {
                                if (board[j, randomX].Type == "Ship")
                                {
                                    alreadyShip = true;
                                }
                            }
                            if (!alreadyShip)
                            {
                                for (int j = randomY; j > (randomY - ship.Length); j--)
                                {
                                    board[j, randomX] = ship;
                                }
                                place = true;
                            }
                        }
                    }
                }
                
            
            }
        }
    }
}
