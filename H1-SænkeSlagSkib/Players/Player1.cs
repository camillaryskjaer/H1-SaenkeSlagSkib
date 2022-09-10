using H1_SænkeSlagSkib.Boards;
using H1_SænkeSlagSkib.Boards.Player1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Players
{
    internal class Player1 : Player
    {
        private Board board;
        private Board hitBoard;

        public Board Board
        {
            get { return board; } 
            protected internal set { board = value; } 
        }
        public Board HitBoard
        {
            get { return hitBoard; }
            protected internal set { hitBoard = value; }
        }

        public Player1():base()
        {
            this.board = BoardPlayer1.Instance;
            this.hitBoard = HitBoardPlayer1.Instance;
            
        }
        protected internal void StartGame()
        {

        }
    }
}
