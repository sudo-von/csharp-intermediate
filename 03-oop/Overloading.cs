using System;

namespace _03_oop
{
    class Overloading
    {
        public string name;
        public void setName(string last)
        {
            name = last;
        }

        public void setName(string first, string last)
        {
            name = first + "" + last;
        }

        public void setName(string first, string middle, string last)
        {
            name = first + "" + middle + "" + last;
        }
    }
}
