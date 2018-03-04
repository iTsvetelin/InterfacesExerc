using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Rebelion
{
    public class Citizen : Human,IIdentifiable
    {
        public string Id { get; set; }

        public Citizen(string name, int age, string id,string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
            this.Food = 0;
            
        }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}
