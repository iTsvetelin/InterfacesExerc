using P07_CollectionsHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07_CollectionsHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputTokens = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            var addCollection = new AddCollection();
            var addRemCollection = new AddRemoveCollection();
            var myList = new MyList();

            var addIndicesAddCollection = String.Empty;
            var addIndicesAddRemoveCollection = String.Empty;
            var addIndicesMyList = String.Empty;

            int indexOfAdding;
            foreach (var token in inputTokens)
            {
                indexOfAdding = addCollection.Add(token);
                addIndicesAddCollection += $"{indexOfAdding} ";

                indexOfAdding = addRemCollection.Add(token);
                addIndicesAddRemoveCollection += $"{indexOfAdding} ";

                indexOfAdding = myList.Add(token);
                addIndicesMyList += $"{indexOfAdding} ";
            }


            var totalRemoves = int.Parse(Console.ReadLine());

            var removedItemFromAddRemoveCollection = String.Empty;
            var removedItemFromMyList = String.Empty;

            var removedItem = String.Empty;
            for (int i = 0; i < totalRemoves; i++)
            {
                removedItem = addRemCollection.Remove();
                removedItemFromAddRemoveCollection += $"{removedItem} ";

                removedItem = myList.Remove();
                removedItemFromMyList += $"{removedItem} ";
            }

            Console.WriteLine(addIndicesAddCollection.TrimEnd());
            Console.WriteLine(addIndicesAddRemoveCollection.TrimEnd());
            Console.WriteLine(addIndicesMyList.TrimEnd());
            Console.WriteLine(removedItemFromAddRemoveCollection.TrimEnd());
            Console.WriteLine(removedItemFromMyList.TrimEnd());
        }
    }
}
