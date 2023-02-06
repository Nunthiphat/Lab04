using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Person
    {
        private string Name;
        private int Age;
        private Double Grade;
        

        public Person(string iName, int iAge)
        {
            this.Name = iName;
            this.Age = 2565 - iAge;
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
