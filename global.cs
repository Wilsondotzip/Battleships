using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipsTxt
{
   public class global
    {

        public static void startUp()
        {

            var arr = new[]
            {
                   
                    @" /$$$$$$$              /$$     /$$     /$$                  /$$$$$$  /$$       /$$                    ",
                    @"| $$__  $$            | $$    | $$    | $$                 /$$__  $$| $$      |__/                    ",
                    @"| $$  \ $$  /$$$$$$  /$$$$$$ /$$$$$$  | $$  /$$$$$$       | $$  \__/| $$$$$$$  /$$  /$$$$$$   /$$$$$$$",
                    @"| $$$$$$$  |____  $$|_  $$_/|_  $$_/  | $$ /$$__  $$      |  $$$$$$ | $$__  $$| $$ /$$__  $$ /$$_____/",
                    @"| $$__  $$  /$$$$$$$  | $$    | $$    | $$| $$$$$$$$       \____  $$| $$  \ $$| $$| $$  \ $$|  $$$$$$ ",
                    @"| $$  \ $$ /$$__  $$  | $$ /$$| $$ /$$| $$| $$_____/       /$$  \ $$| $$  | $$| $$| $$  | $$ \____  $$",
                    @"| $$$$$$$/|  $$$$$$$  |  $$$$/|  $$$$/| $$|  $$$$$$$      |  $$$$$$/| $$  | $$| $$| $$$$$$$/ /$$$$$$$/",
                    @"|_______/  \_______/   \___/   \___/  |__/ \_______/       \______/ |__/  |__/|__/| $$____/ |_______/ ",
                    @"                                                                                  | $$                ",
                    @"                                                                                  | $$                ",
                    @"                                                                                  |__/                ",


            };

            foreach (string line in arr)
                Console.WriteLine(line);
           

            Console.WriteLine("Welcome to Battleships Text Edition Version 0.1");
            Console.WriteLine("Type 'start' to start or 'help' for help");
            readLine();

        }

        public static void readLine()
        {
            string userInput = (Console.ReadLine());

            if ((userInput == "start") || (userInput == "s"))
            {
                newGame();
            }

        }


        public static void newGame()
        {

            Console.WriteLine("Here is an example board including co-ords");
            Console.WriteLine("   +---+---+---+");
            Console.WriteLine("   | 1 | 2 | 3 |");
            Console.WriteLine("---+---+---+---+");
            Console.WriteLine(" 1 |1,1|2,1|3,1|");
            Console.WriteLine("---+---+---+---+");
            Console.WriteLine(" 2 |1,2|2,2|3,2|");
            Console.WriteLine("---+---+---+---+");
            Console.WriteLine(" 3 |1,3|2,3|3,3|");
            Console.WriteLine("---+---+---+---+");

            Console.WriteLine("Set Dificulty: ");
            int x =  Int32.Parse(Console.ReadLine());             //x and y length (its a square)

            Console.WriteLine("Location X");
            int locationX = Int32.Parse(Console.ReadLine());

            Console.WriteLine("locationX Y:");
            int locationY = Int32.Parse(Console.ReadLine());

            int a = 1;
            int c = 1;
            int d = 1;

            int b = 1;

            int locationID = (x*x) - ((x * (x - locationY)) + (x-locationX));
            
            
            
            int a1 = a;


            while (b < x*x)
            {

                 if (a == 1)
                 {
                    while (d <= x)
                    {
                        Console.Write("+---");
                        d++;
                        c = 1;
                        
                    }

                    Console.Write("+");
                    a++;
                    

                 }

                 else 
                 {
                     Console.WriteLine();
                     while (c <= x)
                     {
                        if (b == locationID)
                        {
                            Console.Write("| " + "*" + " ");
                            c++;
                            d = 1;
                            b++;
                        }
                        Console.Write("|   ");
                        c++;
                        d = 1;
                        b++;
                    }

                     Console.Write("|");
                     Console.WriteLine();
                   

                     while (d <= x)
                     {
                        Console.Write("+---");
                        d++;
                        c = 1;
                     }

                    Console.Write("+");

                 }                                                                             
            }                            
        }
   }    
}
