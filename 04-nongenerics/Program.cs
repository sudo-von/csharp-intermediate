using System;
// You must import System.Collections to access the ArrayList.
using System.Collections;

namespace _04_nongenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList strArray = new ArrayList();
            strArray.AddRange(new string[] { "First", "Second", "Third" });
            // Show number of items in ArrayList.
            System.Console.WriteLine("This collection has {0} items.", strArray.Count);
            System.Console.WriteLine();
            // Add a new item and display current count.
            strArray.Add("Fourth!");
            System.Console.WriteLine("This collection has {0} items.", strArray.Count);
            // Display contents.
            foreach (string s in strArray)
            {
                System.Console.WriteLine("Entry: {0}", s);
            }
            System.Console.WriteLine();
        }
    }
}
