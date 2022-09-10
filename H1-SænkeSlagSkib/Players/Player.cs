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

        public int Health
        {
            get { return health; }
            protected internal set { health = value; }
        }

        public Player()
        {
            health = 17;
        }
        public void PlaceShip()
        {

        }
        public string ShootBoard(string[,] hitBoard, Material[,] enemyBoard, string cords)
        {
            string[] cordsArray = cords.Split(",");
            string responseString;
            int firstCordInt = Convert.ToInt32(cordsArray[0]);
            int secondCordInt = 0;
            switch (cordsArray[1].ToLower())
            {
                case "a":
                    secondCordInt = 1;
                    break;
                case "b":
                    secondCordInt = 2;
                    break;
                case "c":
                    secondCordInt = 3;
                    break;
                case "d":
                    secondCordInt = 4;
                    break;
                case "e":
                    secondCordInt = 5;
                    break;
                case "f":
                    secondCordInt = 6;
                    break;
                case "g":
                    secondCordInt = 7;
                    break;
                case "h":
                    secondCordInt = 8;
                    break;
                case "i":
                    secondCordInt = 9;
                    break;
                case "j":
                    secondCordInt = 10;
                    break;
            }
            if (enemyBoard[firstCordInt, secondCordInt].Type == "Ship")
            {
                Ship ship = (Ship)enemyBoard[firstCordInt, secondCordInt];
                ship.HitHealth();
            }
            enemyBoard[firstCordInt, secondCordInt] = new HitMarker();
            responseString = enemyBoard[firstCordInt, secondCordInt].Hitsound;

            hitBoard[firstCordInt, secondCordInt] = ("X");
            return responseString;
        }
    }
}
