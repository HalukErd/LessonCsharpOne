using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int r = 3;
            
            int result = Perm(n, r);
            Console.WriteLine(result);
        }

        static int Perm(int n, int r)
        {
            return Factorial(n) / Factorial(n - r);
        }


        static int Factorial(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static int FactorialRecursice(int number)
        {
            if(number == 1)
            {
                return 1;
            }
            return number * FactorialRecursice(number - 1);
        }
    }
}