using System;
using System.Threading.Tasks;
namespace myOOP
{
    public enum level
    {
        Basic, Silver, Gold, Platium
    }
    public abstract class Animal
    {
        public Animal()
        {
            this.level = myOOP.level.Basic;
        }
        public level? level{get;set;}
        protected string _color;
        public string color
        {
            set{this._color = value;}
        }
        public string getColor
        {
           get
           {
               if(this._color == "Red") return "Mau Do";
               if(this._color == "Green") return "Mau Xanh La Cay";
               return "Mau Xanh Nuoc Bien";
           } 
        }
        
        protected string food{get;set;}
        protected int _age{get;set;}
        public int age
        {
            set{this._age = value;}
        }
        public string getAge
        {
            get{return ""+this._age;}
        }
        
        protected double length{get;set;}
        
        protected double height{get;set;}
        
        protected int _pos;
        public int pos
        {
            set{this._pos = value;}
        }
        public string getPos
        {
            get{return ""+this._pos;}
        }
        public abstract void Run();
        public abstract void Go(); 
        public abstract void Action();
        public void ShowAge()
        {
            Console.WriteLine($"Age of {this.GetType().Name} = {this._age}");
        }
        public void Eat()
        {
            Console.WriteLine($"{this.GetType().Name} eat {this.food}");
        }
        public void Drink(string drinks)
        {
            Console.WriteLine($"{this.GetType().Name} drink {drinks}");
        }
        public void ShowColor()
        {
            Console.WriteLine($"{this.GetType().Name} {this.getColor}");
        }
    }
}