using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            String password = "c1234";
            Console.Write("Write password door: ");
            String enteredPassword = Console.ReadLine();
            
            if(enteredPassword.Equals(password))
            {
                Console.WriteLine("Tık.");
            } else
            {
                Console.WriteLine("Daat.");
            }
        }
    }
}