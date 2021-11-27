using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class Person
    {
        private string name;
        private int age;

        public Person()
        {
            Console.WriteLine("Constructor çağırıldı.");
            this.name = "";
            this.age = 0;
        }

        public Person(string name)
        {
            this.name = name;
            this.age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void happyBirthday()
        {
            this.age++;
        }
    }
}
