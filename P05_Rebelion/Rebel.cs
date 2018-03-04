using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Rebelion
{
    public class Rebel : Human
    {
       

        public string Group { get; set; }

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
            this.Food = 0;
        }
        public override void BuyFood()
        {
            this.Food += 5;
        }
    }
}
