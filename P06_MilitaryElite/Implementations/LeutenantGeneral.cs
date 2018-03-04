using P06_MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.Implementations
{
    public class LeutenantGeneral : Soldier
    {


        public LeutenantGeneral(string id, string firstName, string lastName, decimal salary, IEnumerable<Soldier> privates)
            : base(id, firstName, lastName, salary)
        {
            Privates = privates;
        }

        public IEnumerable<Soldier> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine("Privates:");
            foreach(var privateSoldier in this.Privates)
            {
                resultBuilder.AppendLine($"  {privateSoldier.ToString()}");
            }

            return resultBuilder.ToString().TrimEnd();
        }
    }
}
