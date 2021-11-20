using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("Enter the Number of values to be Sort : ");
            // read the string value (by default) and convert it in to integer  
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n]; // Array Declaration in C#  
            //Reading the values one by one  
            for (i = 1; i <= n; i++)
            {
                Console.Write("Enter the No " + i + ":");
                // read the string value (by default) and convert it in to integer  
                a[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            //Display the Ascending values one by one  
            Console.Write("Ascending Sort : ");
            for (i = 1; i <= n; i++)
            {
                Console.Write(a[i] + " ");
            }
        }

    }
}