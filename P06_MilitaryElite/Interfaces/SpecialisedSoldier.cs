using System;
using System.Collections.Generic;
using System.Text;
using P06_MilitaryElite.Enums;

namespace P06_MilitaryElite.Interfaces
{
    public abstract class SpecialisedSoldier : Soldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary,Corps corps)
            :base(id,firstName,lastName,salary)
        {
            this.Corps = corps;
        }

        public Corps Corps {get; set;}

        public override string ToString()
        {
            var result = base.ToString() + Environment.NewLine + $"Corps: {this.Corps.ToString()}";
            return result;
        }
    }
}
