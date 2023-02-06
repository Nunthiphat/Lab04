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
        

        public Person(string iName, int iAge, double iGrade)
        {
            this.Name = iName;
            this.Age = iAge;
            this.Grade = iGrade;
        }

        public int getAge()
        {
            this.Age = 2566 - this.Age;
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

    //    private List<Person> persons = new List<Person>();

    //    public double maxPersonGrade()
    //    {
    //        double result2 = getGrade();
    //        double general = getGrade();
    //        foreach (Person i in this.persons)
    //        {
    //            if (general > i.Grade)
    //            {
    //                result2 = persons.Count;
    //            }
    //        }
    //        return result2;
    //    }

    //    public string NamemaxPersonGrade()
    //    {
    //        double result2 = 0;
    //        string maxGradeName = "";
    //        double general;
    //        foreach (var i in this.persons)
    //        {
    //            general = i.getGrade();
    //            result2 += i.getGrade();
    //            if (i.getGrade())
    //            {
    //                result2 = i.getGrade();
    //                maxGradeName = i.getName();
    //            }
    //        }
    //        return maxGradeName;
    //    }
    }
}
