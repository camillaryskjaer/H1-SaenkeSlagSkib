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
    internal class Player2 : Player
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
        /// <summary>
        /// Constructor for my player, that uses the 2 Instances of the 2 boards
        /// </summary>
        public Player2():base() 
        {
            this.board = BoardP2.Instance;
            this.hitBoard = HitBoardP2.Instance;
        }

    }
}
