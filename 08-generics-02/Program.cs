using System;

namespace _08_generics_02
{
    class Program
    {
        class Point{
            public string x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(AreEqual(2,2));
        }

        public static bool AreEqual<T>(T num1, T num2) where T:IComparable
        {
            return num1.CompareTo(num2) == 0;
        }
    }
}
