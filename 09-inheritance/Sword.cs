using System;

namespace _09_inheritance
{
    class Sword : Weapon
    {
        public double StrikeLength{get;set;}
        public Sword(string name, double strikeLength)
        {
            this.Name = name;
            this.StrikeLength = strikeLength;
        }
    }
}
