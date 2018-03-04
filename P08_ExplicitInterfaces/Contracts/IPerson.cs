using System;
using System.Collections.Generic;
using System.Text;

namespace P08_ExplicitInterfaces.Contracts
{
    public interface IPerson
    {
        string Name { get; }

        string Country { get; }

        void GetName();
    }
}
