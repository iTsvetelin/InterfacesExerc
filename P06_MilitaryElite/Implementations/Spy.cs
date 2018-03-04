using P06_MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.Implementations
{
    public class Spy : Soldier
    {

        public Spy(string id, string firstName, string lastName, int codeNumber) : base(id, firstName, lastName, 0)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; set; }

        public override string ToString()
        {
            var result = $"Name: {this.FirstName} {this.LastName} Id: {this.Id}{Environment.NewLine}Code Number: {this.CodeNumber}";

            return result;
        }
    }
}
