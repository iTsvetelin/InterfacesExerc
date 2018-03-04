using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Telephony
{
    public class Smartphone : IBrowseable, ICallable
    {



        public string Browse(string site)
        {
            foreach(char c in site)
            {
                if (char.IsDigit(c))
                {
                    return "Invalid URL!";
                }
            }
            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            foreach(char c in number)
            {
                if (!char.IsDigit(c))
                {
                    return "Invalid number!";
                }
            }
            return $"Calling... {number}";
        }
    }
}
