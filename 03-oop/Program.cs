using System;

namespace _03_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer();
            obj.displayData();
            Console.WriteLine(obj.CustID);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Address);
            /* Partial example. */
            Partial obj2 = new Partial();
            obj2.greet = "Hello";
            obj2.Greet();
            /* Static example. */
            StaticDemo.Calcute();
            /* Overloading example. */
            Overloading obj3 = new Overloading();
            obj3.setName("sudo");
            obj3.setName("sudo "," von ");
            obj3.setName("sudo ","chmod","von");
            /* Inheritance. */
            Father fObj = new Father("Sudo");
            fObj.FatherMethod();
            /* Here Child object can access both class methods. */
            Child cObj = new Child("Sudo","Von");
            cObj.FatherMethod();
            cObj.ChildMethod();
            /* Virtual example. */
            DerivedVirtualClass dvc = new DerivedVirtualClass();
            dvc.VirtualMethod();
            /* Hiding example. */
            DerivedHidingClass dhc = new DerivedHidingClass();
            dhc.VirtualMethod();
            /* Abstract example. */
            DerivedEmployees de = new DerivedEmployees();
            de.DisplayData();
            de.DisplayDefaultData();
            /* Sealed example. */
            SealedClass sc = new SealedClass();
            sc.Greet();
            /* Interface example. */
            DerivedInterface di = new DerivedInterface();
            di.methodA();
            di.methodB();
            /* Polymorphism. */
            hrDepart hd = new hrDepart();
            itDepart id = new itDepart();
            financeDepart fd = new financeDepart();
            hd.LeaderName();
            id.LeaderName();
            fd.LeaderName();
        }
    }

    class Customer
    {
        public int CustID;
        public string Name;
        public string Address;

        public Customer()
        {
            CustID=1101;
            Name="Tom";
            Address="USA";
        }

        public void displayData()
        {
            Console.WriteLine("Customer="+CustID);
            Console.WriteLine("Name="+Name);
            Console.WriteLine("Address="+Address);
        }
    }
}
