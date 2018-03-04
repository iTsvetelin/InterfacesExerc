using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Rebelion
{
    public abstract class Human : INameable, IBirthable, IBuyer
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Birthdate { get; set; }

        public int Food { get; set; }

        public abstract void BuyFood();
        
    }
}
