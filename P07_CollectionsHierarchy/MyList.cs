using P07_CollectionsHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07_CollectionsHierarchy
{
    public class MyList : IAddable,IRemoveable,IUsedCountable

    {
        private List<string> mineList;

        public MyList()
        {
            this.MineList = new List<string>(100);
        }

        private List<string> MineList
        {
            get { return mineList; }
            set { mineList = value; }
        }

        public int Used => this.MineList.Count;

        public int Add(string item)
        {
            this.MineList.Insert(0, item);
            return 0;
        }

        public string Remove()
        {
            var result = this.MineList[0];
            this.MineList.RemoveAt(0);
            return result;
        }
    }
}
