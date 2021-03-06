using System;
using System.Threading.Tasks;
namespace myOOP
{
    public class Dog : Animal
    {
         public  Dog(){
        }
        public  Dog(string color){
            this.color = color;
        }
        public Dog(string color, int age){
            this.color = color;
            this.age = age;
        }
        public Dog(string color, int age, string food){
            this.color = color;
            this.age = age;
            this.food = food;
        }
        public Dog(string color, int age, string food, double length)
        {
            this.color = color;
            this.age = age;
            this.food = food;
            this.length = length;
        }
        public Dog(string color, int age, string food, double length, double height)
        {
            this.color = color;
            this.age = age;
            this.food = food;
            this.length = length;
            this.height = height;
        }     
        public Dog(string color, int age, string food, double length, double height, int pos)
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
            this.pos = Int32.Parse(this.getPos) + 5;
            Console.WriteLine($"{this.GetType().Name} go");
            Console.WriteLine(this.getPos);
        }
        public override void Run()
        {
            Console.WriteLine("current position " + this.getPos);
            this.pos = Int32.Parse(this.getPos) + 10;
            Console.WriteLine($"{this.GetType().Name} run:");
            Console.WriteLine(this.getPos);
        }
        public override void Action()
        {
            Console.WriteLine("Guaw guaw");
        }
        public static Animal operator+(Dog a, Dog b)
        {
            Animal cat = new Cat();
            cat.level = a.level + 1;
            if(cat.level > myOOP.level.Platium)
                cat.level = myOOP.level.Platium;
            return cat;
        }
        public static Animal operator-(Dog a, Dog b)
        {
            Animal mouse = new Mouse();
            mouse.level = a.level - 1;
            if(mouse.level < myOOP.level.Basic)
                mouse.level = myOOP.level.Basic;
            return mouse;
        }
        public override string B4()
        {
            return "Gogo ";
        }
    }
}