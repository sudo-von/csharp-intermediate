using System;

namespace _12_exception_handling
{
    class Program
    {
        static byte y, z;
        static void Main(string[] args)
        {
            y = byte.MaxValue;
            z = 2;
            CheckedAdd();
            CheckedMultiplication();
            UncheckedAdd();
            UncheckedMultiplication();
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }

        private static void CheckedAdd()
        {
            try
            {
                Console.WriteLine("### Checked Add ###");
                Console.WriteLine($"x = {y} + {z}");
                Console.WriteLine($"x = {checked((byte)(y + z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedAdd: {oex.Message}");
            }
        }

        private static void CheckedMultiplication()
        {
            try
            {
                Console.WriteLine("### Checked Multiplication ###");
                Console.WriteLine($"x = {y} x {z}");
                Console.WriteLine($"x = {checked((byte)(y * z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedMultiplication: {oex.Message}");
            }
        }

        private static void UncheckedAdd()
        {
            try
            {
                Console.WriteLine("### Unchecked Add ###");
                Console.WriteLine($"x = {y} + {z}");
                Console.WriteLine($"x = {unchecked((byte)(y + z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedAdd: {oex.Message}");
            }
        }

        private static void UncheckedMultiplication()
        {
            try
            {
                Console.WriteLine("### Unchecked Multiplication ###");
                Console.WriteLine($"x = {y} x {z}");
                Console.WriteLine($"x = {unchecked((byte)(y * z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedMultiplication: {oex.Message}");
            }
        }

    }
}
