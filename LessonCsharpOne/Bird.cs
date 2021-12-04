using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class Bird : Animal
    {
        
        public string Wing { get; set; }

        public Bird(string name, string type)
        {
            Name = name;
            Type = type;
            SoundType = "cik cik";
        }
        
        //public Bird(string name, string type, string soundType)
        //{
        //    Name = name;
        //    Type = type;
        //    changeSoundType(soundType);
        //}

        //public void tweet()
        //{
        //    Console.WriteLine(Name + " sounds cik cik");
        //}

        public void fly()
        {
            Console.WriteLine(Name + " can fly");
        }

        public override void move()
        {
            Console.WriteLine(Name + " flies");
        }

        public override void eat()
        {
            Console.WriteLine(Name + " eats " + FoodType);
        }
    }
}
