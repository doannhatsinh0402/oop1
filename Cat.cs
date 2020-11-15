using System;
using System.Threading.Tasks;
namespace myOOP
{
    public class Cat : Animal
    {
         public  Cat(){
        }
        public  Cat(string color){
            this.color = color;
        }
        public Cat(string color, int age){
            this.color = color;
            this.age = age;
        }
        public Cat(string color, int age, string food){
            this.color = color;
            this.age = age;
            this.food = food;
        }
        public Cat(string color, int age, string food, double length)
        {
            this.color = color;
            this.age = age;
            this.food = food;
            this.length = length;
        }
        public Cat(string color, int age, string food, double length, double height)
        {
            this.color = color;
            this.age = age;
            this.food = food;
            this.length = length;
            this.height = height;
        }
        public Cat(string color, int age, string food, double length, double height, int pos)
        {
            this.color = color;
            this.age = age;
            this.pos = pos;
            this.food = food;
            this.length = length;
            this.height = height;
        }
        public override void Go()
        {
            Console.WriteLine("current position " + this.getPos);
            this.pos = Int32.Parse(this.getPos) + 4;
            Console.WriteLine($"{this.GetType().Name} go");
            Console.WriteLine(this.getPos);
        }
        public override void Run()
        {
            Console.WriteLine("current position " + this.getPos);
            this.pos = Int32.Parse(this.getPos) + 9;
            Console.WriteLine($"{this.GetType().Name} run:");
            Console.WriteLine(this.getPos);
        }
        public override void Action()
        {
            Console.WriteLine("Meow Meow");
        }
        public static Animal operator+(Cat a, Cat b)
        {
            Animal dog = new Dog();
            dog.level = a.level + 1;
            return dog;
        }
        public static Animal operator-(Cat a, Cat b)
        {
            Animal snake = new Snake();
            snake.level = a.level - 1;
            if(snake.level < 0)
                snake.level = 0;
            return snake;
        }
    }
}