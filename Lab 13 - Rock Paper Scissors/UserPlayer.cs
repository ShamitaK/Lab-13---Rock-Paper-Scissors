using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    class UserPlayer : Player
    {
        public override Roshambo GenerateRoshambo()
        {
            int userResponse;
            switch (userResponse)
            {
                case 1:
                    if(userResponse == 1)
                    {
                        return Roshambo.Rock;
                    }
                    break;
                case 2:
                    if(userResponse == 2)
                    {
                        return Roshambo.Paper;
                    }
                    break;
                case 3:
                    if(userResponse == 3)
                    {
                        return Roshambo.Scissors;
                    }
                    break;
                default:
                    {
                        Console.WriteLine("Error value, please select a numeric value. 1. Rock, 2. Paper, or 3. Scissors");
                        
                    }
                    break;
            }
        }

        public static void GetUserChoice(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
