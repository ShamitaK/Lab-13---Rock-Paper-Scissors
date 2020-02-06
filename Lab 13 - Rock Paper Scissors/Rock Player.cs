using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    class RockPlayer : Player
    {
        public override Roshambo BeRandom()
        {
            Random randomizer = new Random();
            int random = randomizer.Next(1, 4);
            Enum.TryParse(Enum.GetName(typeof(Roshambo), random), out Roshambo choice);
            return choice ;
        }
        public RockPlayer()
        {
            
            
        }
        public override Roshambo GenerateRoshambo()
        {
            Name = "Rockstar";
            return Roshambo.Rock;
        }

    }
}
