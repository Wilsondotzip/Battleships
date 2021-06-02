using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipsTxt
{
   public class global
    {

        public static void startUp()
        {
            Console.WriteLine("Welcome to Battleships Text Edition Version 0.1");
            Console.WriteLine("Type 'start' to start or 'help' for help");
            readLine();

        }

        public static void readLine()
        {
            string userInput = (Console.ReadLine());

            if (userInput == "start")
            {
                newGame();
            }

        }

        public static void newGame()
        {
            Console.WriteLine("   +---+---+---+");
            Console.WriteLine("   | 1 | 2 | 3 |");
            Console.WriteLine("---+---+---+---+");
            Console.WriteLine(" 1 |   |   |   |");
            Console.WriteLine("---+---+---+---+");
            Console.WriteLine(" 2 |   |   |   |");
            Console.WriteLine("---+---+---+---+");
            Console.WriteLine(" 3 |   |   |   |");
            Console.WriteLine("---+---+---+---+");

            Console.WriteLine("Where do you want your ship? eg 1,1");
            string locationOne = (Console.ReadLine());
            int i = 0;
            int j = 0;
            while (i<9)
            {               
                int a1 = i;


              if (i==0)
                {
                Console.WriteLine("+---+---+");
                   
                }      

              else
                {
                    while (j>3)
                    {
                        Console.Write(" | " + a1);
                        j++;
                    }
                    
                }

               i++;

            }
            
            
           

        }


    }
}
