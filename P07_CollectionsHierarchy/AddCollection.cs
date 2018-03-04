using P07_CollectionsHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07_CollectionsHierarchy
{
    public class AddCollection : IAddable
    {
        private List<string> collection;

        public AddCollection()
        {
            this.Collection = new List<string>();
        }

        private List<string> Collection
        {
            get { return collection; }
            set { collection = value; }
        }


        public int Add(string item)
        {
            this.Collection.Add(item);
            var result = this.Collection.IndexOf(item);
            return result;
        }
    }
}
