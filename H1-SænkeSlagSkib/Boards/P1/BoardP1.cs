using H1_SænkeSlagSkib.Materials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Player1
{
    internal sealed class BoardP1 : MaterialBoard
    {
        private static BoardP1? instance = null;
        /// <summary>
        /// Singleton for board to Player1
        /// </summary>
        private BoardP1() : base()
        {

        }
        public static BoardP1 Instance
        {
            get
            {
                instance ??= new BoardP1();
                return instance;
            }
        }
    }
}
