using System.Collections.Generic;
using System;
namespace myOOP
{
    public class User : Human
    {
        public User(int age, string gender, string username, string password)
        {
            this.age = age;
            this.gender = gender;
            this.username = username;
            this.password = password;
            this.Pets  = new List<Animal>();
        }
        private string username {get;set;}
        private string password {get;set;}
        public List<Animal> Pets {set;get;}
        public void Feeding(Animal animal)
        {
            Console.WriteLine($"Cho {animal.GetType().Name} an");
            animal.Eat();
            animal.level++;
        }
    }
}