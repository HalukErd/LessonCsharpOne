using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class Cat : Animal
    {
        public string Leg { get; set; }

        public Cat(string name, string type)
        {
            Name = name;
            Type = type;
            SoundType = "miyav miyav";
        }
        //public void miyav()
        //{
        //    Console.WriteLine(Name + " sounds miyav");
        //}

        public void climb()
        {
            Console.WriteLine(Name + " can climb");
        }

        public override void move()
        {
            Console.WriteLine(Name + " runs with an esthetic");
        }

        public override void eat()
        {
            Console.WriteLine(Name + " eats proPlan");
        }
    }
}
