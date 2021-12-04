using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class Dog : Animal
    {
        public string Leg { get; set; }
        

        public Dog(string name, string type)
        {
            Name = name;
            Type = type;
            SoundType = "hav hav";
        }
        //public void bark()
        //{
        //    Console.WriteLine(Name + " sounds Hav hav");
        //}

        public void learn()
        {
            Console.WriteLine(Name + " can learn");
        }

        public override void move()
        {
            Console.WriteLine(Name + " runs without caution");
        }

        public override void eat()
        {
            Console.WriteLine(Name + " eats " + FoodType);
        }
    }
}
