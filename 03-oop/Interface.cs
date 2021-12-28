using System;

namespace _03_oop
{
    public interface Interface
    {
       void methodA();
       void methodB();
    }

    class DerivedInterface : Interface
    {
        public void methodA()
        {
            Console.WriteLine("implements method A");
        }
        public void methodB()
        {
            Console.WriteLine("implements method B");
        }
    }
}
