﻿using System;
using System.Threading.Tasks;

namespace myOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Dog("Red",8,"Rice",8.5,1,5);
            Animal Cat = new Cat("Green", 8,"catfood",3,1,5);
            Animal Snake = new Snake("Green", 8,"catfood",3,1,5);
            Animal Mouse = new Mouse("Green", 8,"catfood",3,1,5);
            Dog.Eat();
            Dog.Run();
            Dog.Go();
            Dog.Drink("coca");
            Dog.ShowAge();
            Dog.ShowColor();
            Cat.Eat();
            Cat.Run();
            Cat.Go();
            Cat.Drink("volka");
            Cat.ShowAge();
            Cat.ShowColor();
            Snake.Run();
            Snake.Eat();
            Snake.Go();
            Snake.Drink("water");
            Snake.ShowAge();
            Snake.ShowColor();
            Mouse.Run();
            Mouse.Go();
            Mouse.Eat();
            Mouse.Drink("juice");
            Mouse.ShowAge();
            Mouse.ShowColor();
            User user1 = new User(19,"Man","doannhatsinh","25251325");
            user1.Pets.Add(Dog);
            user1.Pets.Add(Cat);
            for(int i = 0; i < user1.Pets.Count ; i++)
            {
                Console.WriteLine(user1.Pets[i].GetType().Name);
            }
            user1.Feeding(Dog);
            Console.WriteLine(Dog.level);
        }
    }
}