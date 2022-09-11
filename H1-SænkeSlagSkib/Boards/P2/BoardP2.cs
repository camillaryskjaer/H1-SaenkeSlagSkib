using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Ai
{
    internal sealed class BoardP2 : MaterialBoard
    {
        private static BoardP2? instance = null;
        /// <summary>
        /// Singleton for board player 2
        /// </summary>
        private BoardP2() : base()
        {

        }
        public static BoardP2? Instance
        {
            get
            {
                instance ??= new BoardP2();
                return instance;
            }
        }
    }
}
