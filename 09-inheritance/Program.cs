using System;

namespace _09_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Sword swd = new Sword("Sword of fury", 20.0);
            Character von = new Character("VoN", swd);
            von.Speak();
            von.Weapon.Attack();
        }
    }
}
