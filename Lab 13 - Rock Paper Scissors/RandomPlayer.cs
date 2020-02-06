using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    class RandomPlayer : Player
    {
        public RandomPlayer()
        {

        }
        
        public RandomPlayer()
        {
            Random randomizer = new Random();
            Name = "Randy";
            
        }

        public override Roshambo GenerateRoshambo()
        {
            int random = randomizer.Next(1, 4);
            Enum.TryParse(Enum.GetName(typeof(Roshambo), random), out Roshambo choice);
            return choice;
        }
    }
}





