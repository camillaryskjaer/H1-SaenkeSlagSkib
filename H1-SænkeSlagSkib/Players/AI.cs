using H1_SænkeSlagSkib.Boards;
using H1_SænkeSlagSkib.Boards.Ai;
using H1_SænkeSlagSkib.Boards.Player1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Players
{
    internal class AI : Player
    {

        protected internal Board board;
        protected private Board hitBoard;

        public Board HitBoard
        {
            get { return hitBoard; }
            protected internal set { hitBoard = value; }
        }
        public Board Board
        {
            get { return board; }
            set { board = value; }
        }
        public AI():base() 
        {
            this.board = BoardAi.Instance;
            this.hitBoard = HitBoardAi.Instance;
        }
        public void GenerateMap()
        {

        }
    }
}
