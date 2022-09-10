﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_SænkeSlagSkib.Boards
{
    internal class HitBoard:Board
    {
        private string[,] hitBoard;

        public string[,] HitBoardArray
        {
            get { return hitBoard; }
            set { hitBoard = value; }
        }

        public HitBoard():base()
        {
            hitBoard = new string[,] 
            {
                {" "},{"A"},{"B"},{"C"},{"D"},{"E"},{"F"},{"G"},{"H"},{"I"},{"J"}, 
                {"1"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"2"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"3"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"4"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"5"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"6"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"7"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"8"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"9"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}, 
                {"10"},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "},{" "}
            };
        }
    }
}
