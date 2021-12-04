using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class Car : IEat
    {
        //public string FoodType
        //{
        //    get; set;
        //}
        //public void eat(string foodType)
        //{
        //    Console.WriteLine("Car eats " + foodType);
        //}
    
        public void eat()
        {
            Console.WriteLine("Car eats OIL");
        }
    }
}
