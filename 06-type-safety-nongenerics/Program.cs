using System;
using System.Collections;

namespace _06_type_safety_nongenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            // The ArrayList can hold anything at all.
            ArrayList allMyObjects = new ArrayList();
            allMyObjects.Add(true);
            allMyObjects.Add(new OperatingSystem(PlatformID.MacOSX, new Version(10, 0)));
            allMyObjects.Add(66);
            allMyObjects.Add(3.14);
            /* Prior to generics, the only way you could address this issue of type safety was to create a custom (strongly typed) collection class manually. */
            Console.WriteLine("***** Custom Person Collection *****\n");
            PersonCollection myPeople = new PersonCollection();
            myPeople.AddPerson(new Person("Homer", "Simpson", 40));
            myPeople.AddPerson(new Person("Marge", "Simpson", 38));
            myPeople.AddPerson(new Person("Lisa", "Simpson", 9));
            myPeople.AddPerson(new Person("Bart", "Simpson", 7));
            myPeople.AddPerson(new Person("Maggie", "Simpson", 2));
            // This would be a compile-time error!
            // myPeople.AddPerson(new Car());
            foreach (Person p in myPeople)
            {
                Console.WriteLine(p);
            }
        }
    }
}
