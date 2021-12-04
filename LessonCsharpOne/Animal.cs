using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal abstract class Animal : IEat
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string SoundType { get; set; }
        

        public void makeSound()
        {
            Console.WriteLine(Name + " sounds " + SoundType);
        }

        public abstract void move();

        public abstract void eat();
    }
}
