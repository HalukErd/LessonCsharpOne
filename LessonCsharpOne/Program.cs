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
                for (int column = 0; column < length; column++)
                {
                    if (column == row || (column + row) == length - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}