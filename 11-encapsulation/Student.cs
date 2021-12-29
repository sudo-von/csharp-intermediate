using System;

namespace _11_encapsulation
{
    class Student  
    {  
        private string ID { get; set; }  
        private string Name { get; set; }  
        private string Email { get; set; } 
        public Student(string id, string name, string email){
            this.ID = id;
            this.Name = name;
            this.Email = email;
        }

        public string Greet(){
            return $"Hello, my name is {Name}, and this is my email {Email}.";
        }

    }  
}
