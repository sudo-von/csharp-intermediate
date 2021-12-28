using System;

namespace _03_oop
{
    public abstract class Employee
    {
       public virtual void LeaderName(){}
    }

    public class hrDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. jone");
        }
    }
    public class itDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. Tom");
        }
    }

    public class financeDepart : Employee
    {
        public override void LeaderName()
        {
            Console.WriteLine("Mr. Linus");
        }
    }

}
