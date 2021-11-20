using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
        }

        static int factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static int factorialRecursive(int number)
        {
            if(number == 1)
                return 1;
            return number * factorial(number - 1);
        }
    }
}