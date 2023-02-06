using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Classroom
    {
        private string name;
        private List<Person> persons = new List<Person>();
        private List<double> GpaList = new List<double>();
        private List<string> NameList = new List<string>();
        private List<int> AgeList = new List<int>();
        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPersonToClass(Person person)
        {
            this.persons.Add(person);
        }
        
        public string showAllPersoninclass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\t";
                result += p.getAge() + "\t";
                result += p.getGrade() + "\t";
            }
            return result;
        }
        public void addPerson(Person person)
        {
            persons.Add(person);
            GpaList.Add(person.Grade);
            AgeList.Add(person.Age);
        }

        public int AgeSum()
        {
            return AgeList.Sum();
        }

        //public double ChangeListToArray()
        //{
        //    double result4 = 0;
        //    foreach (Person f in persons)
        //    {
        //        result4 += f.getGrade();
        //    }
        //    return result4;
        //}
        //private double[] doubleList = ChangeListToArray().ToArray();

        //public double showMaxPersoninclass() 
        //{
        //    double result3 = 2;
        //    foreach (var u in this.persons)
        //    {
        //        result3 = u.maxPersonGrade();
        //    }
        //    return result3;
        //}
    }
}
