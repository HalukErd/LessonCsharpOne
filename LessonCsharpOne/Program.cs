using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            for (int row = 0; row < length; row++)
            {
                for (int column = 0; column < row; column++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}