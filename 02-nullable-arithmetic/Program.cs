using System;

namespace _02_nullable_arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            // Any normal value type can be made nullable.
            int? x;
            double? y;
            // Alternate syntax that hardly anyone uses.
            Nullable<decimal> z = 1234.5m;
            // Reference types are already nullable.
            // string? badString;
            // Nullable types may not be "doubly" nullable.
            // But why the odd error message?
            // int?? badInt;
            // Nullable arithmetic is exactly like normal arithmetic.

            x = 123;
            y = 456.7;

            double? s = x + y;

            // ... but there is also a null value;

            x = null;
            s = x + y; // Now what is s?

            /*
                Most operators in C# are "lifted to nullable". They
                behave normally when give non-null operands, but
                produce null when *any* operando is null. The sum of
                a value you don't know with a value you do know results
                in a value you don't know. Nulls thereby *propagate*.

                (bools are an exception to this rule, but we won't go into the
                details in this time).

                Using an instance member on a null *reference* causes
                an exception, but *most* instance member can be used on null value types:
            */

            bool hasValue = x.HasValue;
            string text = x.ToString();
            int valueOrDefault1 = x.GetValueOrDefault();
            int valueOrDefault2 = x.GetValueOrDefault(10);

            // The value property may only be used on non-nulls.
            int value;
            // value = x.Value;
            if(y != null)
                Console.WriteLine("not null");

            // The null coalescing operator is similar to GetValueOrDefault:

            value = x ?? 10;
            x = 123;
            value = x ?? 10;
        }
    }
}
