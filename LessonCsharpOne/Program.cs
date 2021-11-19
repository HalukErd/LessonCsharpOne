using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.Write("Enter your first name: ");
            String fName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            String lName = Console.ReadLine();
            Console.WriteLine("Hello " + fName + " " + lName + ", welcome first class.");


            //int -stores integers(whole numbers), without decimals, such as 123 or - 123
            //double -stores floating point numbers, with decimals, such as 19.99 or - 19.99
            //char -stores single characters, such as 'a' or 'B'.Char values are surrounded by single quotes
            //string -stores text, such as "Hello World".String values are surrounded by double quotes
            //bool -stores values with two states: true or false

            int myNum3 = 5;
            double myDoubleNum = 5.99D;
            char myLetter = 'D';
            bool myBool = true;
            string myText = "Hello";
            long myNumLong = 15000000000L;
            float myNumFloat = 5.75F;

            string name = "John";
            Console.WriteLine(name);

            int myNum2 = 15;
            Console.WriteLine(myNum2);

            int myNum;
            myNum = 15;
            Console.WriteLine(myNum);

            const double pi = 3.14;
            //pi = 3;

            //Names can contain letters, digits and the underscore character(_)
            //Names must begin with a letter
            //Names should start with a lowercase letter and it cannot contain whitespace
            //Names are case sensitive("myVar" and "myvar" are different variables)
            //Reserved words(like C# keywords, such as int or double) cannot be used as names


            //int     4 bytes Stores whole numbers from - 2,147,483,648 to 2,147,483,647
            //long    8 bytes Stores whole numbers from - 9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            //float   4 bytes Stores fractional numbers. Sufficient for storing 6 to 7 decimal digits
            //double  8 bytes Stores fractional numbers.Sufficient for storing 15 decimal digits
            //bool    1 bit   Stores true or false values
            //char    2 bytes Stores a single character / letter, surrounded by single quotes
            //string  2 bytes per character   Stores a sequence of characters, surrounded by double quotes

            //Implicit Casting(automatically) -converting a smaller type to a larger type size
            //char -> int -> long -> float -> double

            //Explicit Casting(manually) - converting a larger type to a smaller size type
            //double -> float -> long -> int -> char

            //Implicit Casting
            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9

            //Explicit Casting
            double myDouble2 = 9.78;
            int myInt2 = (int)myDouble;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.78
            Console.WriteLine(myInt2);      // Outputs 9

            int myInt3 = 10;
            double myDouble3 = 5.25;
            bool myBool3 = true;

            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

        }
    }
}