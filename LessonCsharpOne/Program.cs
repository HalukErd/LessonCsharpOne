using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] result = GetFibonaccis(25);
            //PrintArray(result);
            //Console.WriteLine(isPrime(18));

            Console.WriteLine(sumDigits(21378));
        }

        public static int sumDigits(int number)
        {
            int result = 0;
            string textOfNumber = Convert.ToString(number);
            for (int i = 0; i < textOfNumber.Length; i++)
            {
                result += (int)Char.GetNumericValue(textOfNumber[i]);
            }
            return result;
        }

        static int[] GetFibonaccis(int size)
        {
            int[] result = new int[size];
            result[0] = 0;
            result[1] = 1;
            for(int i = 2; i < size; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            return result;
        }

        public static void PrintArray(int[] arrayToPrint)
        {
            foreach (int i in arrayToPrint)
            {
                Console.WriteLine(i);
            }
        }

        public static bool isPrime(int number)
        {
            for (int i = 2; i < number/2; i++)
            {
                if ((number % i) ==0 )
                {
                    return false;
                }
            }
            return true;

        }
    }
}