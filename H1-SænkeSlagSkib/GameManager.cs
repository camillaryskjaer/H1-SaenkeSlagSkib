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
        List<Player> players = new List<Player>();
        private Player1 p1;
        private AI ai;
        
        public GameManager()
        {

            players.Add(new Player1());
            players.Add(new AI());
            p1 = (Player1)players[0];

            ai = (AI)players[1];


        }
        public (string[,], Material[,]) RoundInfo(int player)
        {
            string[,] playerHit = { };
            Material[,] enemyBoard = { };
            switch (player)
            {
                case 1:
                    playerHit =((HitBoard)p1.HitBoard).HitBoardArray;
                    enemyBoard = ((MaterialBoard)ai.Board).BoardArray;
                    break;
                case 2:
                    playerHit = ((HitBoard)ai.HitBoard).HitBoardArray;
                    enemyBoard = ((MaterialBoard)p1.Board).BoardArray;
                    break;
            }
            return (playerHit, enemyBoard);
        }
        public string Runtime(string cord, int player)
        {
            string response = "";


            switch (player)
            {
                case 1:
                    response = p1.ShootBoard(((HitBoardPlayer1)p1.HitBoard).HitBoardArray,((BoardAi)ai.Board).BoardArray,cord);

                    break;
                case 2:
                    response = ai.ShootBoard(((HitBoardAi)ai.HitBoard).HitBoardArray,((BoardPlayer1)p1.Board).BoardArray, cord);
                    break;
            }
            return response;
            
        }
        
    }
}
