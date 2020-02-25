using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    class RoshamboApp
    {
        public void PlayRPS()
        {
    
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
            else if (userContinue == "n")
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
