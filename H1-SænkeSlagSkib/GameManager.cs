using H1_SænkeSlagSkib.Boards;
using H1_SænkeSlagSkib.Boards.Ai;
using H1_SænkeSlagSkib.Boards.Player1;
using H1_SænkeSlagSkib.Materials;
using H1_SænkeSlagSkib.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib
{
    public class GameManager
    {
        private readonly List<Player> players = new();
        private readonly Player1 p1;
        private readonly Player2 p2;
        
        public GameManager()
        {
            //Instanciates players
            players.Add(new Player1());
            players.Add(new Player2());

            //Type casting from player, to the specific player
            p1 = (Player1)players[0];
            p2 = (Player2)players[1];

            //Generates map for both players
            p1.GenerateMap(((BoardP1)p1.Board).BoardArray, p1.Ships);
            p2.GenerateMap(((BoardP2)p2.Board).BoardArray, p2.Ships);


        }
        /// <summary>
        /// Updates and get all infor for a round
        /// </summary>
        /// <param name="player"></param>
        /// <returns></returns>
        public (string[,], Material[,], int) RoundInfo(int player)
        {
            string[,] hitBoard = { };
            Material[,] board = { };
            p2.HealthUpdate();
            p1.HealthUpdate();
            int health = 0;
            switch (player)
            {
                case 1:
                    hitBoard =((HitBoard)p1.HitBoard).HitBoardArray;
                    board = ((MaterialBoard)p1.Board).BoardArray;
                    health = p1.Health;
                    break;
                case 2:
                    hitBoard = ((HitBoard)p2.HitBoard).HitBoardArray;
                    board = ((MaterialBoard)p2.Board).BoardArray;
                    health = p2.Health;
                    break;
            }
            if (p2.Health == 0 || p1.Health == 0)
            {
                EndGame?.Invoke(this, EventArgs.Empty);
            }
            return (hitBoard, board, health);
        }
        /// <summary>
        /// Method to shoot board
        /// </summary>
        /// <param name="cord"></param>
        /// <param name="player"></param>
        /// <returns></returns>
        public string ShootBoard(string cord, int player)
        {
            string response = "";


            switch (player)
            {
                case 1:
                    response = p1.ShootBoard(((HitBoardP1)p1.HitBoard).HitBoardArray,((BoardP2)p2.Board).BoardArray,cord);
                    break;
                case 2:
                    response = p2.ShootBoard(((HitBoardP2)p2.HitBoard).HitBoardArray,((BoardP1)p1.Board).BoardArray, cord);
                    break;
            }

            return response;
            
        }
        public event EventHandler EndGame;
        
    }
}
