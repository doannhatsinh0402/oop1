using System;
using System.Threading.Tasks;
namespace myOOP
{
    public class Snake : Animal
    {
        public  Snake(){
        }
        public  Snake(string color){
            this.color = color;
        }
        public Snake(string color, int age){
            this.color = color;
            this.age = age;
        }
        public Snake(string color, int age, string food){
            this.color = color;
            this.age = age;
            this.food = food;
        }
        public Snake(string color, int age, string food, double length)
        {
            this.color = color;
            this.age = age;
            this.food = food;
            this.length = length;
        }
        public Snake(string color, int age, string food, double length, double height)
        {
            this.color = color;
            this.age = age;
            this.food = food;
            this.length = length;
            this.height = height;
        }
        public Snake(string color, int age, string food, double length, double height, int pos)
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
            this.pos = Int32.Parse(this.getPos) + 3;
            Console.WriteLine($"{this.GetType().Name} go");
            Console.WriteLine(this.getPos);
        }
        public override void Run()
        {
            Console.WriteLine("current position " + this.getPos);
            this.pos = Int32.Parse(this.getPos) + 7;
            Console.WriteLine($"{this.GetType().Name} run:");
            Console.WriteLine(this.getPos);
        }
        public override void Action()
        {
            Console.WriteLine("Khezz Khezz");
        }
    }
}