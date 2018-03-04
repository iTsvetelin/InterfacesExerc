using P06_MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.Implementations
{
    public class Private : Soldier
    {
        public Private(string id, string firstName, string lastName, decimal salary):
            base(id,firstName,lastName,salary)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
