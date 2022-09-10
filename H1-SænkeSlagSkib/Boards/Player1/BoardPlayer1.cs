using H1_SænkeSlagSkib.Materials;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards.Player1
{
    internal sealed class BoardPlayer1 : MaterialBoard
    {
        private static BoardPlayer1? instance = null;
        
        private BoardPlayer1() : base()
        {

        }
        public static BoardPlayer1 Instance
        {
            get
            {
                instance ??= new BoardPlayer1();
                return instance;
            }
        }
    }
}
