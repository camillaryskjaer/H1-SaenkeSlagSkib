using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Player1
{
    internal sealed class HitBoardPlayer1:HitBoard
    {
        private static HitBoardPlayer1? instance = null;


        private HitBoardPlayer1() : base()
        {
        }
        public static HitBoardPlayer1? Instance
        {
            get 
            { 
                instance ??= new HitBoardPlayer1(); 
                return instance;
            } 
        }
    }
}
