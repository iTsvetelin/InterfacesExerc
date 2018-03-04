using P06_MilitaryElite.Enums;
using P06_MilitaryElite.Implementations;
using P06_MilitaryElite.Interfaces;
using P06_MilitaryElite.SomeModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            IList<Soldier> allPrivates = new List<Soldier>();
            IList<Soldier> allSoldiers = new List<Soldier>();
            while((input = Console.ReadLine()) != "End")
            {
                var inputTokens = input.Split(' ');
                string militaryType = inputTokens[0];
                string id = inputTokens[1];
                string firstName = inputTokens[2];
                string lastName = inputTokens[3];
                if(militaryType == "Spy")
                {
                    var codenumber = int.Parse(inputTokens[4]);
                    Soldier soldierSpy = new Spy(id, firstName, lastName, codenumber);
                    allSoldiers.Add(soldierSpy);
                    continue;
                }
                decimal salary = decimal.Parse(inputTokens[4]);
                Soldier soldier =  null;
                switch (militaryType)
                {
                    case "Private":
                        soldier = new Private(id,firstName,lastName,salary);
                        allPrivates.Add(soldier);
                        break;
                    case "LeutenantGeneral":
                        IEnumerable<Soldier> privates = ParsePrivates(inputTokens,allPrivates);
                        soldier = new LeutenantGeneral(id, firstName, lastName, salary,privates);
                        break;
                    case "Engineer":
                        Enum.TryParse(inputTokens[5], out Corps corps);
                        if(corps == Corps.None)
                        {
                            continue;
                        }
                        IEnumerable<Repair> repairs = ParseRepairs(inputTokens);
                        soldier = new Engineer(id, firstName, lastName, salary,corps,repairs);
                        break;
                    case "Commando":
                        Enum.TryParse(inputTokens[5], out corps);
                        if (corps == Corps.None)
                        {
                            continue;
                        }
                        IEnumerable<Mission> missions = ParseMissions(inputTokens);
                        soldier = new Commando(id, firstName, lastName, salary, corps, missions);
                        break;
                }
                allSoldiers.Add(soldier);

            }
            foreach(var soldier in allSoldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        


        //tested
        private static IEnumerable<Soldier> ParsePrivates(string[] input, IList<Soldier> availablePrivates)
        {
            IList<Soldier> result = new List<Soldier>();
            for(int i = 5; i < input.Length; i++)
            {
                Soldier privateSold = availablePrivates.First(p => p.Id == input[i]);
                result.Add(privateSold);
            }

            return result;
        }
        
        //tested
        private static IEnumerable<Repair> ParseRepairs(string[] input)
        {
            IList<Repair> result = new List<Repair>();
            for (int i = 6; i < input.Length; i++)
            {
                var name = input[i];
                i++;
                var worked = int.Parse(input[i]);
                var repair = new Repair(name,worked);
                result.Add(repair);
            }

            return result;
            //tested
        }

        //tested
        private static IEnumerable<Mission> ParseMissions(string[] input)
        {
            IList<Mission> result = new List<Mission>();
            for (int i = 6; i < input.Length; i++)
            {
                var name = input[i];
                i++;
                Enum.TryParse(input[i], out State state);
                if(state == State.None)
                {
                    continue;
                }
                var mission = new Mission(name, state);
                result.Add(mission);
            }
            return result;
        }

    }
}
