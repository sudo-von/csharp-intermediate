using System;

namespace _03_oop
{
    class VirtualClass
    {
        public virtual void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the base class");
        }
    }

    class DerivedVirtualClass : VirtualClass
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the Derive class");
        }
    }
    class virtualClass
    {
        static void Main(string[] args)
        {
            new DerivedVirtualClass().VirtualMethod();
            Console.ReadKey();
        }
    }
}
