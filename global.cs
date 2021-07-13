using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace BattleShipsTxt
{
   public class global
    {

        //public variables
        public static string userInput = "yes";
        public static int difficulty = 0;
        public static int aiSetup = 0;
        public static int aiLocation = 0;


        //end of public variables
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
           

            Console.WriteLine("Welcome to Battleships Text Edition Version 0.2");
            Console.WriteLine("Type 'start' to start or 'help' for help");
            readLine();

        }

         public static void readLine()
        {
             userInput = (Console.ReadLine());

            if ((userInput == "start") || (userInput == "s"))
            {
                newGame();
            }
            else if ((userInput == "help") || (userInput == "h"))
            {
                var arr = new[] {
                @"start, s - starts a new game",
                @"Havent written the help message yet, bad luck for you "
                };

                foreach (string line in arr)
                {
                    Console.WriteLine(line);
                }

                Console.ReadLine();
            }
            else
            {
                gamePlay();
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
            difficulty =  Int32.Parse(Console.ReadLine());             //x and y length (its a square)

            Console.WriteLine("Location X");
            int locationX = Int32.Parse(Console.ReadLine());

            Console.WriteLine("locationX Y:");
            int locationY = Int32.Parse(Console.ReadLine());

            int a = 1;
            int c = 1;
            int d = 1;

            int b = 1;

            int locationID = (difficulty * difficulty) - ((difficulty * (difficulty - locationY)) + (difficulty - locationX));
            
            
            
            int a1 = a;


            while (b < difficulty * difficulty)
            {

                 if (a == 1)
                 {
                    while (d <= difficulty)
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
                     while (c <= difficulty)
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
                   

                     while (d <= difficulty)
                     {
                        Console.Write("+---");
                        d++;
                        c = 1;
                     }

                    Console.Write("+");

                 }                                                                             
            }
            
            Console.WriteLine("Here is your ship Good luck...");
            readLine();

        }

        public static void gamePlay()
        {
            if (aiSetup != 1)
            {
                //generates ai ship location (only does once per game)
                int gridSize = difficulty * difficulty;

                Random rnd = new Random();

                aiLocation = rnd.Next(0, gridSize);
                aiSetup = 1;
                Console.WriteLine(aiLocation);
                gamePlay();
            }
            else
            {
                Console.WriteLine("Enter fire co-ords");
                Console.WriteLine("X");
                int locationX = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Y:");
                int locationY = Int32.Parse(Console.ReadLine());


                int aimID = (difficulty * difficulty) - ((difficulty * (difficulty - locationY)) + (difficulty - locationX)); //turn coords into locationID

                if (aimID == aiLocation)
                {
                    Console.WriteLine("You have sunk the enamy battleship and have won the game!");
                    Console.WriteLine("Type 'start' to play again");
                    readLine();

                }
                else
                {
                    Console.WriteLine("Shot unsuccsessful try again");
                    gamePlay();

                }
            }

            
           

            


        }
   }    
}
