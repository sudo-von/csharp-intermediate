using System;
using System.Collections.Generic;

namespace _09_inheritance
{
    class Weapon
    {
        public Dictionary<string, int> stats;
        public string Name{get;set;}
        public void Attack()
        {
            Console.WriteLine("Perform attack!");
        }
    }
}
