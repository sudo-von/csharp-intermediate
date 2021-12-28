using System;

namespace _03_oop
{
    public class Father
    {
        public Father(string name)
        {
            Console.WriteLine("Father class constructor, this is his name: " + name);
        }

        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }
    public class Child : Father
    {
        public Child(string fatherName, string childName) : base(fatherName)
        {
            Console.WriteLine("child class constructor, this is his name: " + childName);
        }
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }
}
