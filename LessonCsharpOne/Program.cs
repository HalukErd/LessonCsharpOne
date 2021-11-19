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



        }
    }
}