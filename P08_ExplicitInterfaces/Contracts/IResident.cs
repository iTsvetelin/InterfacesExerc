using System;
using System.Collections.Generic;
using System.Text;

namespace P08_ExplicitInterfaces.Contracts
{
    public interface IResident
    {
        string Name { get; }

        string Country { get; }
        
        void GetName();
    }
}
