using System;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();
            string fname = "Haluk";
            sayHiTo(fname);
            int result = sumTwoNumbers(123, 462);
            Console.WriteLine(result);
            sayHiTo(fname, "Erd");
            sayHiTo();
            sayHiTo(lname: "Erd", fname: fname);
        }

        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void sayHiTo(string fname)
        {
            Console.WriteLine("Hello " + fname);
        }

        static void sayHiTo(string fname = "Stranger", string lname = "")
        {
            //string space;
            Console.WriteLine("Hello " + fname + " " + lname);
        }

        static int sumTwoNumbers(int x, int y)
        {
            return x + y;
        }


        static double sumTwoNumbers(double x, double y)
        {
            return x + y;
        }
    }
}