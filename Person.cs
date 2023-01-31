using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Person
    {
        private string name { get; set; }
        private double gpa { get; set; }
        private int birthYear { get; set; }

        //public Person(string name, int bYear, double gpa)
        //{
          //  this.name = name;
            //this.gpa = gpa;
            //this.birthYear = 2566 - bYear;
        //}
        private string Name;
        private int Age;
        private Double Grade;
        public Person (string iName, int iAge, double iGrade)
        {
            this.Name = iName;
            this.Age = 2566 - iAge;
            this.Grade = iGrade;
            if (iAge > Age)
            {
                this.Age = iAge;
            }
            if (iGrade > Grade)
            {
                this.Grade = iGrade;
            }
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
