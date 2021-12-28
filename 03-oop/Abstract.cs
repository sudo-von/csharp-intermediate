using System;

namespace _03_oop
{
    public abstract class Employess
    {
        public void DisplayDefaultData(){
            Console.WriteLine("Default data");
        }
        public abstract void DisplayData();
    }

    public class DerivedEmployees : Employess
    {
        public override void DisplayData()
        {
            Console.WriteLine("Abstract class method");
        }
    }
}
