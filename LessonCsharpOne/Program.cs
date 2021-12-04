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
            //makeAnimalSound(patiayak);
            //makeAnimalSound(haku);
            //makeAnimalSound(tweety);
            //makeAnimalSound(nagini);

            //makeAnimalMove(patiayak);
            //makeAnimalMove(haku);
            //makeAnimalMove(tweety);
            //makeAnimalMove(nagini);

            //patiayak.FoodType = "Meat";
            //haku.FoodType = "Proplan";
            //tweety.FoodType = "corn";
            //nagini.FoodType = "everything";

            //feed(patiayak);
            //feed(haku);
            //feed(tweety);
            //feed(nagini);
            //feed(car);
            //feed(hungryCar);

            //runTime(RunTimeQuantity.PT40);
            try
            {
                makeAnimalFly(tweety);
                Console.WriteLine("----");
                makeAnimalFly(nagini);
            } catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Hatayi \"yakaladik.");
                Console.WriteLine(e.Message);
            }
        }

        public static void makeAnimalSound(Animal animal)
        {
            animal.makeSound();
        }
        public static void makeAnimalMove(Animal animal)
        {
            animal.move();
        }

        public static void makeAnimalFly(Animal animal)
        {
            if(animal is Bird)
            {
                ((Bird) animal).fly();
            } else
            {
                throw new InvalidCastException(animal.Name + " can't fly");
            }
            //try
            //{
            //    Console.WriteLine("I'm thinking whether animal can fly or not");
            //    ((Bird)animal).fly();
            //    Console.WriteLine("Your bird can really fly.");
            //    int[] myNum = new int[] {1,2,3};
            //    int a = myNum[5];
            //} 
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine("IndexOutOfException aldin");
            //} 
            //catch (InvalidCastException e)
            //{
            //    Console.WriteLine(animal.Name + " cant fly. ");
            //} 
            //finally
            //{
            //    Console.WriteLine("goodBye");
            //}
        }
        
        public static void feed(IEat hungry)
        {
            hungry.eat();
        }

        public static void runTime(RunTimeQuantity runTimeQuantity)
        {
            Console.WriteLine(runTimeQuantity.ToString());
        }
    }
}