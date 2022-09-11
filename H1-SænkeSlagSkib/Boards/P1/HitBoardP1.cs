using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Player1
{
    internal sealed class HitBoardP1:HitBoard
    {
        private static HitBoardP1? instance = null;

        /// <summary>
        /// Singleton for Hitboard Player1
        /// </summary>
        private HitBoardP1() : base()
        {
        }
        public static HitBoardP1? Instance
        {
            get 
            { 
                instance ??= new HitBoardP1(); 
                return instance;
            } 
        }
    }
}
