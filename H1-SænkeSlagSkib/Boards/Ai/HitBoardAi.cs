using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Ai
{
    internal sealed class HitBoardAi:HitBoard
    {
        private static HitBoardAi? instance = null;
        private HitBoardAi():base()
        {

        }
        public static HitBoardAi? Instance
        {
            get
            {
                instance ??= new HitBoardAi();
                return instance;
            }
        }
    }
}
