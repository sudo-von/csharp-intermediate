using System;
using System.Collections.Generic;

namespace _09_inheritance
{
    class Character
    {
        private string name;
        public Weapon Weapon; 
        public Character(string name, Weapon weapon){
            this.name = name;
            this.Weapon = weapon;
        }
        public void Speak(){
            Console.WriteLine($"Hello, my name is {name}");
        }
    }
}
