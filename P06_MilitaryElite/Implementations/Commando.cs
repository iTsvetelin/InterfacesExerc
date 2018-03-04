using P06_MilitaryElite.Enums;
using P06_MilitaryElite.Interfaces;
using P06_MilitaryElite.SomeModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.Implementations
{
    public class Commando : SpecialisedSoldier
    {
        private Corps corps;

        public Commando(string id, string firstName, string lastName, decimal salary, Corps corps, IEnumerable<Mission> missions)
            :base(id,firstName,lastName,salary,corps)
        {
            this.Missions = missions;
        }
        
        public IEnumerable<Mission> Missions {get;set;}

        public override string ToString()
        {
            var resultBuilder = new StringBuilder();
            resultBuilder.AppendLine(base.ToString())
                .AppendLine("Missions:");
            foreach(var mission in this.Missions)
            {
                resultBuilder.AppendLine($"  {mission.ToString()}");
            }
            
            return resultBuilder.ToString().TrimEnd();
        }
    }
}
