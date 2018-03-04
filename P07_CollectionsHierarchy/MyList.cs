using P07_CollectionsHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P07_CollectionsHierarchy
{
    public class MyList : IAddable,IRemoveable,IUsedCountable

    {
        private List<string> mineList;

        public MyList()
        {
            this.MineList = new List<string>();
            this.Used = 0;
        }

        private List<string> MineList
        {
            get { return mineList; }
            set { mineList = value; }
        }

        public int Used { get;private set; }

        public int Add(string item)
        {
            this.MineList.Insert(0, item);
            this.Used++;
            return 0;
        }

        public string Remove()
        {
            var result = this.MineList.FirstOrDefault();
            this.MineList.RemoveAt(0);
            this.Used--;
            return result;
        }
    }
}
