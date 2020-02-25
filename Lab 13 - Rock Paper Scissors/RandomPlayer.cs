using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    class RandomPlayer : Player
    {
        
        public RandomPlayer()
        {
            Name = "Randy";
            
        }

        public override Roshambo GenerateRoshambo()
        {
            Random randomizer = new Random();
            int random = randomizer.Next(1, 4);
            Enum.TryParse(Enum.GetName(typeof(Roshambo), random), out Roshambo choice);
            return choice;
        }
    }
}


//.parse instead of try name?


