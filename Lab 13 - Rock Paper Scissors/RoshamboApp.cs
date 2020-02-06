using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    class RoshamboApp
    {
        public static void PickTeamChoice()
        {
            int teamResponse;
            Console.WriteLine("Which team would you like to go up against? Press 1 for Team Water or 2 for Team Fire");
            teamResponse = int.Parse(Console.ReadLine());

            if (teamResponse == 1)
            {
                Console.WriteLine("Awesome, Let's go Rockstar! WOOT WOOT");
            }
            else if (teamResponse == 2)
            {
                Console.WriteLine("Let's Go Randy! ");
            }
            else
            {
                Console.WriteLine("Error, please just pick either 1 or 2 for your team choice.");
            }
        }
    }
}
