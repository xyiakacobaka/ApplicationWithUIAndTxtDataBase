using InternationalTeamsUI.Исключения;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTeamsUI.Иерархия
{
    public abstract class Person
    {
        private string lastName;
        public string LastName { get { return lastName; }//Фамилия
            set {
                
                lastName = value;
                /*if (value == string.Empty)
                    throw new ApplicationException("Проверьте введенные данные");
                if (Form1.ListNickNames.IndexOf(value) == -1)
                    lastName = value;
                else
                    throw new ApplicationException("Игрок с тем же никнеймом уже добавлен в базу данных. Вы можете его найти");*/
            }
        }
        private string name;
        public string Name { get { return name; }//Имя
            set
            {
                name = value;
                /*if (value == string.Empty)
                    throw new ApplicationException("Проверьте введенные данные");
                if (Form1.ListNickNames.IndexOf(value) == -1)
                    lastName = value;
                else
                    throw new ApplicationException("Игрок с тем же никнеймом уже добавлен в базу данных. Вы можете его найти");*/
            }
        }
        private int age;
        public int Age { get { return age; }//Возраст
            set {
                age = value;
            } }
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
        public abstract void Status();
    }
}
