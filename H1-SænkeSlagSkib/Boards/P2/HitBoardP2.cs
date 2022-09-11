using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Ai
{
    internal sealed class HitBoardP2:HitBoard
    {
        private static HitBoardP2? instance = null;
        /// <summary>
        /// Singleton for Hitboard player 2
        /// </summary>
        private HitBoardP2():base()
        {

        }
        public static HitBoardP2? Instance
        {
            get
            {
                instance ??= new HitBoardP2();
                return instance;
            }
        }
    }
}
