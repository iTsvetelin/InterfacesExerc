using System;
using System.Collections.Generic;
using System.Text;

namespace P06_MilitaryElite.SomeModels
{
    public class Repair
    {
        public Repair(string name, int worked)
        {
            this.PartName = name;
            this.HoursWorked = worked;
        }

        public string PartName { get; set; }

        public int HoursWorked { get; set; }

        public override string ToString()
        {
            var result = $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
            return result;
        }
    }
}
