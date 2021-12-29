using System;
using System.Collections;

namespace _05_boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myInts = new ArrayList();
            myInts.Add(10);
            myInts.Add(20);
            myInts.Add(35);
            // Unboxing occurs when an object is converted back to
            // stack-based data.
            int i = (int)myInts[0];
            // Now it is reboxed, as WriteLine() requires object types!
            Console.WriteLine("Value of your int: {0}", i);
        }
    }
}
