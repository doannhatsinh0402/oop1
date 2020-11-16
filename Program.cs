using System;
using System.Threading.Tasks;

namespace myOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Red",8,"Rice",8.5,1);
            Animal cat = new Cat("Green", 8,"catfood",3,1);
            Animal snake = new Snake();
            Animal mouse = new Mouse();
            Console.WriteLine(dog.ShowSkills());
            Console.WriteLine(cat.ShowSkills());
            Console.WriteLine(snake.ShowSkills());
            Console.WriteLine(mouse.ShowSkills());
        }
    }
}
