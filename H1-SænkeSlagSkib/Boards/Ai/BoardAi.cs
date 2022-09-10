using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Ai
{
    internal sealed class BoardAi : MaterialBoard
    {
        private static BoardAi? instance = null;
        private BoardAi() : base()
        {

        }
        public static BoardAi? Instance
        {
            get
            {
                instance ??= new BoardAi();
                return instance;
            }
        }
    }
}
