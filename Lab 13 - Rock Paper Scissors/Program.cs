using System;

namespace Lab_13___Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Next time try to clean this up and add this into the roshambo app. 

            //used these two variable towards the bottom, to display wins between computer and user
            int compWins = 0;
            int playerWins = 0;

            Roshambo computerChoice = Roshambo.Rock;
            Roshambo computerChoice2 = Roshambo.Paper;
            Roshambo computerChoice3 = Roshambo.Scissors;

            Console.WriteLine("Welcome To Rock Paper Scissors!\n");

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Awesome choice! Who do you want to play against: ");
                Console.WriteLine("\t1. Rockstar \t 2.Randy\n");
                int choiceEnemy = int.Parse(Console.ReadLine().ToLower());

                Console.WriteLine("\t1. Rock \n\t2. Paper \n\t3. Scissors");
                Console.Write("Please only pick a number for: ");
                int userChoice = int.Parse(Console.ReadLine());
                try
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    if (choiceEnemy == 1)
                    {

                        RockPlayer rockstar = new RockPlayer();
                        computerChoice = rockstar.GenerateRoshambo();

                        if (computerChoice == Roshambo.Rock && userChoice == 1)
                        {

                            Console.WriteLine("\nIt's a tie!\n");
                        }
                        else if (computerChoice == Roshambo.Rock && userChoice == 2)
                        {
                            Console.WriteLine("\nPaper beats rock, you win!\n");
                            compWins = 0;
                            playerWins += 1;
                        }
                        else if (computerChoice == Roshambo.Rock && userChoice == 3)
                        {
                            Console.WriteLine("\nUh oh, rock beats scissors. You Lose!\n");
                            compWins += 1;
                            playerWins = 0;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter 1 or 2 or 3");
                        }
                    }
                    else if (choiceEnemy == 2)
                    {
                        RandomPlayer randy = new RandomPlayer();
                        computerChoice = randy.GenerateRoshambo();
                        if (computerChoice == Roshambo.Rock && userChoice == 1 || computerChoice2 == Roshambo.Paper && userChoice == 2 || computerChoice3 == Roshambo.Scissors && userChoice == 3)
                        {
                            Console.WriteLine("\nIt's a tie!\n");
                        }
                        else if (computerChoice == Roshambo.Rock && userChoice == 3 || computerChoice3 == Roshambo.Paper && userChoice == 1 || computerChoice2 == Roshambo.Scissors && userChoice == 2)
                        {
                            Console.WriteLine("\nUh oh, You lose!\n");
                            compWins++;
                            playerWins = 0;
                        }
                        else if (computerChoice == Roshambo.Rock && userChoice == 2 || computerChoice2 == Roshambo.Paper && userChoice == 3 || computerChoice3 == Roshambo.Scissors && userChoice == 1)
                        {
                            Console.WriteLine("\nAmazing, You win!\n");
                            compWins = 0;
                            playerWins++;
                        }
                        else
                        {
                            Console.WriteLine("\nPlease enter 1 or 2 or 3");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease Enter a Valid Number!");
                    }
                }
                catch
                {
                    Console.WriteLine("\nPlease enter a number!");
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\nHere are the rankings:");
                Console.WriteLine($"Wins: {playerWins} \nLosses: {compWins}");
            }
            while (Continue());
            //RoshamboApp();
        }
        public static bool Continue()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nWould you like to Continue? y/n");
            string userContinue = Console.ReadLine().ToLower();
            if (userContinue == "y")
            {
                return true;
            }
            else if(userContinue == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Please enter either 'y' or 'n' to continue or not");
                return Continue();
            }
        }
    }
}
