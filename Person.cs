using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Person
    {
        private List<Person> persons = new List<Person>();

        public string Name;
        private int Age;
        public double Grade;

        public Person(string Name, int iAge, double iGrade)
        {
            this.Name = Name;
            this.Age = 2565 - iAge;
            this.Grade = iGrade;
        }

        public int getAge()
        {
            return this.Age;
        }

        public string getName()
        {
            return this.Name;
        }

        public double getGrade()
        {
            return this.Grade;
        }
    }
}
