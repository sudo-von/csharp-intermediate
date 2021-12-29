using System;

namespace _13_chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an int to divide Max Int By");
            try{
                LineReader.ReadLines();
            }catch(DivideByZeroException)
            {
                Console.WriteLine("Quit trying to divide by zero");
            }
        }
    }

    static class LineReader
    {
        public static void ReadLines()
        {
            while(true)
            {
                try{
                    TheGreatDivider.MaxIntDividedBy(Console.ReadLine());
                }catch(FormatException ex)
                {
                    Console.WriteLine("Caught: " + ex.Message);
                }
                catch(ArgumentException)
                {
                    Console.WriteLine("Enter a number");
                }
            }
        }
    }

    static class TheGreatDivider
    {
        public static void MaxIntDividedBy(string number)
        {
            if(string.IsNullOrWhiteSpace(number)){
                throw new ArgumentException("Nothing entered", "number"); 
            }
            Console.WriteLine(int.MaxValue / int.Parse(number));
        }
    }
}
