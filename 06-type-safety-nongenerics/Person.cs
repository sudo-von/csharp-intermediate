using System;
using System.Collections;

namespace _06_type_safety_nongenerics
{
    public class Person
    {
        public int Age {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public Person(){}
        public Person(string firstName, string lastName, int age)
            {
                Age = age;
                FirstName = firstName;
                LastName = lastName;
            }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }

    public class PersonCollection : IEnumerable
    {
        private ArrayList arPeople = new ArrayList();
        // Cast for caller.
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        // Insert only Person objects.
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }
        public void ClearPeople()
        {
            arPeople.Clear();
        }
        public int Count => arPeople.Count;
        // Foreach enumeration support.
        IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();
    }
    public class IntCollection : IEnumerable
    {
        private ArrayList arInts = new ArrayList();
        // Get an int (performs unboxing!).
        public int GetInt(int pos) => (int)arInts[pos];
        // Insert an int (performs boxing)!
        public void AddInt(int i)
        {
            arInts.Add(i);
        }
        public void ClearInts()
        {
            arInts.Clear();
        }
        public int Count => arInts.Count;
        IEnumerator IEnumerable.GetEnumerator() => arInts.GetEnumerator();
    }
}
