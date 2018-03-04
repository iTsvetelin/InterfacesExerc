using P07_CollectionsHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07_CollectionsHierarchy
{
    public class AddRemoveCollection : IAddable, IRemoveable
    {
        private List<string> collection;

        public AddRemoveCollection()
        {
            this.Collection = new List<string>(100);
        }

        private List<string> Collection
        {
            get { return collection; }
            set { collection = value; }
        }
        
        public int Add(string item)
        {
            this.Collection.Insert(0, item);

            return 0;
        }

        public string Remove()
        {
            var totalItems = this.Collection.Count;
            var lastItemIndex = totalItems - 1;
            var result = this.Collection[lastItemIndex];
            this.Collection.RemoveAt(lastItemIndex);

            return result;
        }
    }
}
