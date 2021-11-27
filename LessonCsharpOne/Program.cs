using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] cars = { "Volvo", "BMW", "Ford", "Mazda", "Vosvos" };
            //int[] myNum = { 10, 20, 30, 40 };
            //Console.WriteLine(cars[0]);
            //cars[0] = "Opel";
            //Console.WriteLine(cars[0]);

            //for (int i = 0; i < cars.Length; i++) // 0,1,2,3
            //{
            //    Console.WriteLine(cars[i]);
            //}
            //Console.WriteLine("--------");
            //foreach (string car in cars)
            //{
            //    Console.WriteLine(car);
            //}

            int[] myNumbers = { 9, 8, 7, 5, 4, 1 };
            int[] result = SortArray(myNumbers);
            PrintArray(result);
        }
        public static void PrintArray(int[] arrayToPrint)
        {
            foreach (int i in arrayToPrint)
            {
                Console.WriteLine(i);
            }
        }

        public static int[] SortArray(int[] mixedArray)
        {
            int temp;
            for (int j = 0; j < mixedArray.Length - 1; j++)
            {
                for (int i = 0; i < mixedArray.Length - j - 1; i++)
                {
                    if (mixedArray[i] > mixedArray[i + 1])
                    {
                        temp = mixedArray[i];
                        mixedArray[i] = mixedArray[i + 1];
                        mixedArray[i + 1] = temp;
                    }
                }
            }

            return mixedArray;
        }

        public static int[] SortArray2(int[] mixedArray)
        {
            int[] result = new int[mixedArray.Length];
            int lessOne = Int32.MaxValue;
            for (int j = 0; j < mixedArray.Length; j++)
            {

                for (int i = 0; i < mixedArray.Length; i++)
                {
                    if (j == 0 && mixedArray[i] < lessOne)
                    {
                        lessOne = mixedArray[i];
                    }
                    else
                    {
                        if (mixedArray[i] < lessOne && mixedArray[i] > result[j - 1])
                        {
                            lessOne = mixedArray[i];
                        }
                    }
                }
                result[j] = lessOne;
                lessOne = Int32.MaxValue;
            }
            return result;
        }

    }
}