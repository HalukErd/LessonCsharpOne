﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

            int x = 10;
            int y = 9;
            Console.WriteLine(x > y); // returns True, because 10 is higher than 9

            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }

            string result = (time < 18) ? "Good day." : "Good evening.";
            Console.WriteLine(result);
        }
    }
}