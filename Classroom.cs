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
        private int _AgeSum = 0;
        private double _GpaAvg = 0;
        private double _GpaSum = 0;
        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPersonToClass(Person person)
        {
            this.persons.Add(person);
            this._AgeSum += person.getAge();
            this._GpaSum += person.getGrade();
        }

        public string showAllPersoninclass()
        {
            string result = "";
            foreach (Person p in this.persons)
            {
                result += p.getName() + "\t";
                result += p.getAge() + "\t";
                result += p.getGrade() + "\t\r\n";
            }
            return result;
        }
        public double getGpaSum()
        {
            return _GpaSum;
        }

        public int PersonCount()
        {
            return this.persons.Count();
        }
        public double getGpaAvg()
        {
            double _GpaAvg = 0;
            foreach (Person person in this.persons)
            {
                _GpaAvg += _GpaAvg + person.getGrade();
            }
            return this._GpaAvg / this.persons.Count;
        }

        public int getAgeSum()
        {
            return this._AgeSum;
        }
    }
}
