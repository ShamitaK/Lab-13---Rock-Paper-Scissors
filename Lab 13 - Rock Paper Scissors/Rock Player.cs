using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    class RockPlayer : Player
    {
   
        public RockPlayer()
        {
            Name = "Rockstar";
            
        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }

    }
}
