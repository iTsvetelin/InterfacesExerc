using P06_MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.SomeModels
{
    public class Mission
    {
        public Mission(string name, State state)
        {
            this.CodeName = name;
            this.State = state;
        }

        public string CodeName { get; set; }

        public State State { get; set; }

        public override string ToString()
        {
            var result = $"Code Name: {this.CodeName} State: {this.State.ToString()}";
            return result;
        }
    }
}
