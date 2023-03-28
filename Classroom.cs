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
        private List<Person> persons = new List<Person>();
        private List<double> lsgrade = new List<double>(); 
        private List<string> lsname = new List<string>();

        private string name;
        private int age;
        private double grade;
        private int _AgeSum = 0;
        private double _GpaAvg = 0;
        private double _GpaSum = 0;

        public Classroom(string name)
        {
            this.name = name;
        }

        public void addPerson2Class(Person p)
        {
            this.persons.Add(p);
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

        public void addGpa2Class()
        {
            foreach (Person p in persons) 
            {
                lsgrade.Add(p.Grade);
                lsname.Add(p.Name);
            }
        }
        public int showAgeAll()
        {
            int Result = 0;
            foreach (var p in this.persons)
            {
                Result += p.getAge();
            }
            return Result;
        }
        public double getMaxGrade()
        {
            double max = lsgrade.Max();
            return max;
        }

        public double getMinGrade()
        {
            double min = lsgrade.Min();
            return min;
        }

        public double getAvgGrade()
        {
            double avg = lsgrade.Average();
            return avg;
        }

        public string getNameMaxGrade()
        {
            return lsname[lsgrade.IndexOf(lsgrade.Max())];
        }

        public string getNameMinGrade()
        {
            return lsname[lsgrade.IndexOf(lsgrade.Min())];
        }
    }
}
