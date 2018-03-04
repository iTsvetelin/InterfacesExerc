using P08_ExplicitInterfaces.Contracts;
using System;
using System.Collections.Generic;

namespace P08_ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Citizen> citizens = new List<Citizen>();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                var inputTokens = input.Split(' ');
                var name = inputTokens[0];
                var country = inputTokens[1];
                var age = int.Parse(inputTokens[2]);

                var citizen = new Citizen(name, country, age);
                citizens.Add(citizen);
            }

            foreach(var citizen in citizens)
            {
                IResident c = (IResident)citizen;
                IPerson d = (IPerson)citizen;

                d.GetName();
                c.GetName();
            }
        }
    }
}
