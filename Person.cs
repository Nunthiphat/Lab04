using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Person
    {
        private string Name;
        private int Age;
        private Double Grade; 
        public Person (string iName, int iAge, double iGrade)
        {
            this.Name = iName;
            this.Age = 2566 - iAge;
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
