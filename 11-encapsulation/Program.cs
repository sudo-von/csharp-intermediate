using System;

namespace _11_encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("1","VoN","sudo@von.com");  
            Console.WriteLine(student.Greet());
        }
    }
}
