using System;
using System.Collections.Generic;

namespace _07_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Generics *****\n");
            // This List<> can hold only Person objects.
            List<Person> morePeople = new List<Person>();
            morePeople.Add(new Person ("Frank", "Black", 50));
            Console.WriteLine(morePeople[0]);
            // This List<> can hold only integers.
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
            // Compile-time error! Can't add Person object
            // to a list of ints!
            // moreInts.Add(new Person());
        }
    }
}
