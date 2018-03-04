using P06_MilitaryElite.Enums;
using P06_MilitaryElite.Interfaces;
using P06_MilitaryElite.SomeModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.Implementations
{
    public class Engineer : SpecialisedSoldier
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps, IEnumerable<Repair> repairs)
            :base(id,firstName,lastName,salary,corps)
        {
            this.Repairs = repairs;
        }
        
        
        public IEnumerable<Repair> Repairs { get; set; }

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine("Repairs:");
            foreach(var repair in Repairs)
            {
                resultBuilder.AppendLine($"  {repair.ToString()}");
            }
            return resultBuilder.ToString().TrimEnd();
        }
    }
}
