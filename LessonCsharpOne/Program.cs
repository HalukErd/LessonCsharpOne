using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHiTo("Defne", "Sağıroğlu");
            SayHiTo("Haluk", "Erdoğan");
            SayHiTo("Haluk");
            SayHiTo("Defne", 15);
            SayHiTo();

            PrintResult(SumTwoNumbers(123, 125));
            double result = DivideTwoNumbers(414, 4);
            PrintResult(result);
        }

        static void SayHiTo(String name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        static void SayHiTo(String name = "Stranger", String lastName = "")
        {
            Console.WriteLine("Hello {0} {1}", name, lastName);
        }

        static void SayHiTo(String name, int age)
        {
            Console.WriteLine("Hello {0}, you are {1}", name, age);
        }

        static int SumTwoNumbers(int x, int y)
        {
            return x + y;
        }

        static double DivideTwoNumbers(double x, double y)
        {
            return x / y;
        }

        static void PrintResult(double result)
        {
            Console.WriteLine("Sonucun: {0}", result);
        }
    }
}