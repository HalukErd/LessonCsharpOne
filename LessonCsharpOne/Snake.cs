using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class Snake : Animal
    {
        public bool Poison { get; set; }

        public Snake(string name, string type)
        {
            Name = name;
            Type = type;
            
        }

        public override void move() {
            Console.WriteLine(Name + " crawls");
        }

        public override void eat()
        {
            Console.WriteLine(Name + " eats " + FoodType);
        }
    }
}
