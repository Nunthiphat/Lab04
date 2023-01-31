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
        private List<Person> persons = new List <Person>();

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
                result += p.getName() + "\r\n";
            }
            return result;
        }
    }
}
