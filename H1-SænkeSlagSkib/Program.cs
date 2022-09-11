using System;
using System.Security.Cryptography;
using H1_SænkeSlagSkib.Materials;
namespace H1_SænkeSlagSkib
{
    public class Program
    {
        /// <summary>
        /// All user interface is done in this class
        /// </summary>
        public static void Main()
        {
            Console.OutputEncoding = System.Text.UTF8Encoding.UTF8;
            string[,] hitboard;
            Material[,] board;
            int health;
            Console.WriteLine("---------------");
            Console.WriteLine("Sænke Slag Skib");
            Console.WriteLine("---------------");

            do
            {
                Console.Clear();
                Thread.Sleep(2000); 
                Console.WriteLine("Start Game");
                Console.WriteLine("Press Enter");
                
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            Console.WriteLine("Game is about to start");
            //Instanciates the game manager
            GameManager gm = new();
            int player = 0;
            string cords;
            // Switch case to run game 
            switch (player)
            {
                case 0:
                    for (int i = 3; i >= 1; i--)
                    {
                        Console.Clear();
                        Console.WriteLine("Game is starting in");
                        Console.WriteLine(i);
                        Thread.Sleep(500);

                    }
                    player = 1;
                    goto case 1;
                case 1:
                    (hitboard, board, health) = gm.RoundInfo(player);
                    PrintBoards(hitboard, board, health);
                    cords = ReadCord();
                    Console.WriteLine(gm.ShootBoard(cords,player));
                    Thread.Sleep(2000);
                    player++;
                    goto case 2;
                case 2:
                    (hitboard, board, health) = gm.RoundInfo(player);
                    PrintBoards(hitboard, board, health);
                    cords = ReadCord();
                    Console.WriteLine(gm.ShootBoard(cords,player));
                    Thread.Sleep(2000);
                    player--;
                    goto case 1;

            }


        }

        //Custom event to close stop game, when its done
        public void c_EndGame(object sender, EventArgs e)
        {
            Console.WriteLine("Game is done");
            Environment.Exit(0);
        }
        //Method to recieve cords
        private static string ReadCord()
        {
            Console.WriteLine();
            Console.WriteLine("Where do you want to shoot? Example: '1a'");
            string cords = Console.ReadLine();
            return cords;
        }
        /// <summary>
        /// Prints the both boards
        /// </summary>
        /// <param name="hitboard"></param>
        /// <param name="board"></param>
        /// <param name="health"></param>
        private static void PrintBoards(string[,] hitboard, Material[,] board, int health)
        {
            Console.Clear();
            Console.WriteLine("Your lives {0}",health);
            Console.WriteLine("YOUR HITBOARD");
            for (int i = 0; i < hitboard.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < hitboard.GetLength(1); j++)
                {
                    Console.Write(hitboard[i, j].ToString());
                }
            }
            Console.WriteLine();
            Console.WriteLine("YOUR SHIP BOARD");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.WriteLine();
                if (i == 0)
                {
                    Console.WriteLine("[  ][A][B][C][D][E][F][G][H][I][J]");
                }
                if (i < 9)
                {
                    Console.Write("["+(i+1)+" ]");
                }
                else
                {
                    Console.Write("[" + (i + 1) + "]");
                }
                for (int j = 0; j < board.GetLength(1); j++)
                {


                    if (board[i,j].Type == "Water")
                    {
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.Write(board[i, j].Design);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                    }
                    else if (board[i,j].Type == "Ship")
                    {
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(board[i,j].Design);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                    }
                    else
                    {
                        Console.Write("[");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(board[i, j].Design);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("]");
                    }
                }
            }
        }
    }
}
