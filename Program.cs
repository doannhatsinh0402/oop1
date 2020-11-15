using System;
using System.Threading.Tasks;

namespace myOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Dog = new Dog("Red",8,"Rice",8.5,1);
            Animal Dog2 = new Dog();
            Animal Cat = new Cat("Green", 8,"catfood",3,1);
            Animal Cat2 = new Cat();
            Animal Snake = new Snake("Green", 8,"catfood",3,1);
            Animal Mouse = new Mouse("Green", 8,"catfood",3,1);
            Console.WriteLine(Dog.level);
            Console.WriteLine(Animal.countAM);
            Animal result = (Dog)Dog2 - (Dog)Dog;
            Animal result2 = (Cat)Cat + (Cat)Cat2;
            Console.WriteLine(result.GetType());
            Console.WriteLine(result2.GetType());
            Console.WriteLine(Dog2.level);
            Console.WriteLine(result.level);
            Console.WriteLine(result2.level);
        }
    }
}
