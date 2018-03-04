using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Rebelion
{
    public class Pet : IBirthable, INameable
    {
        public string Name { get; set; }

        public string Birthdate { get; set; }

        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }
    }
}
