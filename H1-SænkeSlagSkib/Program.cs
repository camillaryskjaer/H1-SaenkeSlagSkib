using System;
using System.Security.Cryptography;

namespace H1_SænkeSlagSkib
{
    public class Program
    {
        
        public static void Main()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Sænke Slag Skib");
            Console.WriteLine("---------------");

            do
            {
                Thread.Sleep(2000); 
                Console.Clear();
                Console.WriteLine("Start Game");
                Console.WriteLine("Press Enter");
                
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
            Console.WriteLine("Game is about to start");
            GameManager gm = new GameManager();
            int player = 0;
            string cords;
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
                    break;
                case 1:
                    gm.RoundInfo(player);
                    cords = Console.ReadLine();
                    Console.WriteLine(gm.Runtime(cords,player));
                    player++;
                    break;
                case 2:
                    gm.RoundInfo(player);
                    cords = Console.ReadLine();
                    Console.WriteLine(gm.Runtime(cords,player));
                    player--;
                    break;
            }

        }
        public void WriteConsole(string response)
        {
            Console.WriteLine(response);
        }
    }
}
