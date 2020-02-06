using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_13___Rock_Paper_Scissors
{
    abstract class Player
    {
        public string RoshamboValue { get; set; }
        public string Name { get; set; }
        
        public Player()
        {

        }

        public Player(string name)
        {
            Name = name;
        }
        public abstract Roshambo GenerateRoshambo();
        
            //since Rock Player is inheriting this from Player
            //you essentially dont need to do anything. 
            
        
    }

    
}
