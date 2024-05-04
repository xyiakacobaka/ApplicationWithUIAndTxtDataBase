using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTeamsUI.Иерархия
{
    public class Person : IComparable<Person>
    {
        public string LastName { get; set; }//Фамилия
        public string Name { get; set; }//Имя
        public int Age { get; set; }//Возраст

        public int CompareTo(Person? person)
        {
            if (LastName[0] > person.LastName[0])
                return 1;
            else if (LastName[0] < person.LastName[0])
                return -1;
            else
                return 0;
        }
        public Person()
        {
            LastName = string.Empty;
            Name = string.Empty;
            Age = 0;
        }
        public Person(string LastName, string Name, int Age)
        {
            this.LastName = LastName;
            this.Name = Name;
            this.Age = Age;
        }
    }
}
