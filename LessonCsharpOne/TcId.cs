using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonCsharpOne
{
    internal class TcId
    {
        private int tcNo;
        private string name;
        private string lastName;
        private Random random = new Random(); // instance'ı 

        public int TcNo
        {
            get { return tcNo; }
        }
        public string Name 
        { 
            get { return name; } 
            set { name = value; } 
        }
        public string LastName 
        { 
            get { return lastName; }
            set { lastName = value; }
        }

        public TcId(string name, string lastName)
        {
            if(tcNo.Equals(null) || tcNo.Equals(0))
            {
                this.tcNo = random.Next(10000000, 99999999);
            }
            this.name = name;
            this.lastName = lastName;
        }
    }
}
