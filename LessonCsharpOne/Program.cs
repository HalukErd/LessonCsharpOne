using System;
using LessonCsharpOne;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal patiayak = new Dog("patiayak", "karaKöpek");
            Animal haku = new Cat("Haku", "Tekir");
            Animal tweety = new Bird("Tweety", "Kanarya");
            Animal nagini = new Snake("Nagini", "Piton");
            Car car = new Car();
            IEat hungryCar = new Car();
            //IEat hungryCar = new IEat(); //hatalı
            //Animal animal = new Animal(); //hatalı
            makeAnimalSound(patiayak);
            makeAnimalSound(haku);
            makeAnimalSound(tweety);
            makeAnimalSound(nagini);

            makeAnimalMove(patiayak);
            makeAnimalMove(haku);
            makeAnimalMove(tweety);
            makeAnimalMove(nagini);

            feed(patiayak);
            feed(haku);
            feed(tweety);
            feed(nagini);
            feed(car);
            feed(hungryCar);
        }

        public static void makeAnimalSound(Animal animal)
        {
            animal.makeSound();
        }
        public static void makeAnimalMove(Animal animal)
        {
            animal.move();
        }
        
        public static void feed(IEat hungry)
        {
            hungry.eat();
        }


    }
}