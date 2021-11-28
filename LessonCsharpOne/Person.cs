using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class Person
    {
        private string name; // encapsulation
        private int age;
        private TcId tcId;

        public TcId TcId
        {
            get { return tcId; }
            set { tcId = value; }
        }
        public string Name 
        {
            get { return name; }
            set { name = value.ToUpper(); }
        }
        public int Age
        {
            get { return age; }
        }
        public Person()
        {
            Console.WriteLine("Constructor çağırıldı.");
            this.name = "";
            this.age = 0;
        }

        public Person(string value)
        {
            this.name = value;
            this.age = 0;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person(string name, int age, TcId tcId)
        {
            this.tcId = tcId;
            Name = name;
            this.age = age;
        }

        public string getName()
        {
            return name.ToUpper();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public int getAge()
        {
            return age;
        }

        //public void setAge(int age)
        //{
        //    this.age = age;
        //}

        public void happyBirthday()
        {
            this.age++;
        }
    }
}
