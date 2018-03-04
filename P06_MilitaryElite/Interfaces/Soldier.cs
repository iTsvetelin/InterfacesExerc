using P06_MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.Interfaces
{
    public abstract class Soldier
    {
        public Soldier(string id, string firstName, string lastName, decimal salary)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Id { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            var result = $"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}";

            return result;
        }
    }
}
