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
        private List<int> AgeList = new List<int>();
        private Person _minPerson = new Person("max",1);
        private int _AgeSum = 0;
        private double _GpaAvg = 0; 
        public Classroom(string name)
        {
            this.name = name;
        }
        public void addPersonToClass(Person person)
        {
            this.persons.Add(person);
            this._AgeSum += person.getAge();
            if (person.getAge() < _minPerson.getAge() )
            {
                this._minPerson = person;
            }
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
        
        public int AgeSum()
        {
            return AgeList.Sum();
        }

        public double getGpaAvg()
        {
            double _GpaAvg = 0.0;
            foreach (Person person in this.persons)
            {
                _;
            }
            return _GpaAvg;
        }
    }
}
