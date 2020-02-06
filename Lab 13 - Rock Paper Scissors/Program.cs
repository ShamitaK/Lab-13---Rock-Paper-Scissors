using System;

namespace Lab_13___Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            //lots of catching up, you got this! :) work on connecting the classes
            bool userContinue = true;
            Console.WriteLine("Welcome To Rock Paper Scissors!");

            do
            {
                Console.WriteLine("1. Rock");
                Console.WriteLine("2. Paper");
                Console.WriteLine("3. Scissors");
                Console.Write("Please pick a number: ");

                Console.WriteLine("Awesome choice! Who do you want to play against: ");
                Console.WriteLine("1. Rockstar \t 2.Randy");
                int userAgainst = int.Parse(Console.ReadLine().ToLower());


                //have to figure out how to tie this generate roshambo to this and that it includes ties. 
                if (userAgainst == 1)
                {
                    RockPlayer rockStar = new RockPlayer();
                    //GeneratreRoshambo
                }
                else if (userAgainst == 2)
                {
                    //GenerateRoshambo
                }
                else
                {
                    Console.WriteLine("Invalid Entry. 1. Rockstar, 2. Randy Please Enter a number: ");
                }



            }
            while (userContinue);

            //create a for loop to display the wins and losses. 



            string choice;
            //maybe add a switch statement for roshambo?
            switch ()
            {
                case 1:
                    if ( || )
                        break;
                case 2:
                    break;
                case 3:
                    break;
            }

            //add wins and losses and have it printed out. 
        }
    }
}
