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
            var totalRemoves = int.Parse(Console.ReadLine());

            AddCollection addCollection = new AddCollection();
            AddRemoveCollection addRemCollection = new AddRemoveCollection();
            MyList myList = new MyList();

            List<StringBuilder> inputResults = new List<StringBuilder>
            {
                new StringBuilder(),
                new StringBuilder(),
                new StringBuilder()
            };
            List<StringBuilder> outputResults = new List<StringBuilder>
            {
                new StringBuilder(),
                new StringBuilder()
            };

            List<IAddable> addCollections = new List<IAddable>
            {

                addCollection,
                addRemCollection,
                myList
            };
            List<IRemoveable> removeCollections = new List<IRemoveable>
            {
               addRemCollection,
               myList
            };

            foreach (var token in inputTokens)
            {
                foreach (var colection in addCollections)
                {
                    var result = colection.Add(token);
                    var currentIndex = addCollections.IndexOf(colection);
                    inputResults[currentIndex].Append($"{result} ");
                } 
            }

            for(int i = 0; i < totalRemoves; i++)
            {
                foreach(var collection in removeCollections)
                {
                    var result = collection.Remove();
                    var currentIndex = removeCollections.IndexOf(collection);
                    outputResults[currentIndex].Append($"{result} ");
                }
            }

            foreach (var result in inputResults)
            {
                Console.WriteLine(result.ToString().TrimEnd());
            }
            foreach(var result in outputResults)
            {
                Console.WriteLine(result.ToString().TrimEnd());
            }
        }
    }
}
