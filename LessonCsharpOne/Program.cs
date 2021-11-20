using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNum = { 10, 20, 30, 40 };
            Console.WriteLine(cars[0]);
            cars[0] = "Opel";
            Console.WriteLine(cars[0]);

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            // Sort a string
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());

            // Create an array of four elements, and add values later
            string[] cars2 = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars3 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars4 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars5 = { "Volvo", "BMW", "Ford", "Mazda" };


            // Declare an array
            string[] cars6;
            // Add values, using new
            cars6 = new string[] { "Volvo", "BMW", "Ford" };
            // Add values without using new (this will cause an error)
            // ERROR cars6 = { "Volvo", "BMW", "Ford"};


            Random rnd = new Random();
            string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
            string[] femalePetNames = { "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla" };

            // Generate random indexes for pet names.
            int mIndex = rnd.Next(malePetNames.Length);
            int fIndex = rnd.Next(femalePetNames.Length);

            // Display the result.
            Console.WriteLine("Suggested pet name of the day: ");
            Console.WriteLine("   For a male:     {0}", malePetNames[mIndex]);
            Console.WriteLine("   For a female:   {0}", femalePetNames[fIndex]);

            // The example displays output similar to the following:
            //       Suggested pet name of the day:
            //          For a male:     Koani
            //          For a female:   Maggie
        }
    }
}