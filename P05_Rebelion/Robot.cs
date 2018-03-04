using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Rebelion
{
    public class Robot : IIdentifiable
    {
        public string Model { get; set; }

        public string Id { get; set; }

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }
    }
}
