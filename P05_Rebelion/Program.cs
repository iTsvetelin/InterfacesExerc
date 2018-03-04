using System;
using System.Collections.Generic;

namespace P05_Rebelion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            
            List<Human> buyers = new List<Human>();

            var totalCustomers = int.Parse(Console.ReadLine());

            for(int i = 0; i < totalCustomers; i++)
            {
                input = Console.ReadLine();

                var inputTokens = input.Split(' ');
                if(inputTokens.Length == 3)
                {
                    Rebel rebel = new Rebel(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2]);
                    buyers.Add(rebel);

                }else if(inputTokens.Length == 4)
                {
                    Citizen citizen = new Citizen(inputTokens[0], int.Parse(inputTokens[1]), inputTokens[2], inputTokens[3]);
                    buyers.Add(citizen);
                }
            }

            
            while ((input = Console.ReadLine()) != "End")
            {
                foreach(var buyer in buyers)
                {
                    if(buyer.Name == input)
                    {
                        buyer.BuyFood();
                    }

                }

                //switch (type)
                //{
                //    case "Citizen":
                //        Citizen citizen = new Citizen(inputTokens[1], int.Parse(inputTokens[2]), inputTokens[3], inputTokens[4]);
                //        almosteveryone.Add(citizen);
                //        break;
                //    case "Robot":
                //        //I don't think so.
                //        break;
                //    case "Pet":
                //        Pet pet = new Pet(inputTokens[1], inputTokens[2]);
                //        almosteveryone.Add(pet);
                //        break;
                //}
            }
            var totalFood = 0;
            foreach(var human in buyers)
            {
                totalFood += human.Food;
            }
            Console.WriteLine(totalFood);
           // string key = Console.ReadLine();
           //
           // foreach(var iden in almosteveryone)
           // {
           //     var year = iden.Birthdate.Split('/')[2];
           //     if(key == year)
           //     {
           //         Console.WriteLine(iden.Birthdate);
           //     }
           // }
        }  
    }
}
