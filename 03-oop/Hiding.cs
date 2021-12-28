using System;

namespace _03_oop
{
    class HidingClass
    {
        public virtual void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the base class");
        }
    }

    class DerivedHidingClass : HidingClass
    {
        public new void VirtualMethod()
        {
            Console.WriteLine("virtual method defined in the Derive class");
            /* Still access the base class method. */
            base.VirtualMethod();
        }
    }
}
