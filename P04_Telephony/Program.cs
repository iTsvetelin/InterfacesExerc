using System;

namespace P04_Telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneNumbers = Console.ReadLine().Split(' ');
            var sites = Console.ReadLine().Split(' ');

            Smartphone phone = new Smartphone();

            foreach(var phoneNumber in phoneNumbers)
            {
                var res = phone.Call(phoneNumber);
                Console.WriteLine(res);
            }

            foreach(var site in sites)
            {
                var res = phone.Browse(site);

                Console.WriteLine(res);
            }

        }
    }
}
