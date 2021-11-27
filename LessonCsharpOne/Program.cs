using System;
using LessonCsharpOne;
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Person personD = new Person();
            personD.setName("Defne");
            personD.setAge(15);
            Person personH; //int a;
            personH = new Person(); // a = 5;
            personH.setName("Haluk");
            personH.setAge(28);

            Console.WriteLine(personD.getName());
            Console.WriteLine(personD.getAge());
            
            Console.WriteLine(personH.getName());
            Console.WriteLine(personH.getAge());
            personH.happyBirthday();
            Console.WriteLine(personH.getName());
            Console.WriteLine(personH.getAge());
            
            personD.setName("Defne");
            personD.setAge(15);

            Person personB = new Person();
            Console.WriteLine(personB.getName());
            Console.WriteLine(personB.getAge());

            //Person personAhmet = new Person("Ahmet", 21);
            //Console.WriteLine(personAhmet.getName());
            //Console.WriteLine(personAhmet.getAge());

            Person personAhmet = new Person("Ahmet");
            Console.WriteLine(personAhmet.getName());
            Console.WriteLine(personAhmet.getAge());
            
        }

    }
}