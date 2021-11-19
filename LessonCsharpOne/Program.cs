using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(j);
                j++;
                if (j == 4)
                {
                    break;
                }
            }

            j = 0;
            while (j < 10)
            {
                if (j == 4)
                {
                    j++;
                    continue;
                }
                Console.WriteLine(j);
                j++;
            }
        }
    }
}