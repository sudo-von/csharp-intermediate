using System;

namespace _03_oop
{
    public static class StaticDemo
    {
        static int x = 10, y;
        public static void Calcute()
        {
            y = x * x;
            Console.WriteLine(y);
        }
    }
}
