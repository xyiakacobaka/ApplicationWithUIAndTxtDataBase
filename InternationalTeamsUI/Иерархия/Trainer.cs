using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTeamsUI.Иерархия
{
    public class Trainer : Person
    {        
        private int experince;
        public int Experince
        {
            get { return experince; } //Стаж
            set
            {
                if (value >= Age)
                    throw new ApplicationException("Ошибка. Проверьте введенное значение.");
                experince = value;
            }
        }
        private int salary;
        public int Salary { get { return salary; } 
            set 
            {                
                salary = value;                
            } }
        public Trainer(string LastName, string Name, int Age, int Experince, int Salary)
        {
            this.LastName = LastName;
            this.Name = Name;
            this.Age = Age;
            this.Experince = Experince;
            this.Salary = Salary;
            Form1.ListTrainers.Add(this);
            Form1.ListTrainersLastName.Add(this.LastName);
            Form1.ListPersons.Add(this);
            Form1.ListLastNamePersons.Add(this.LastName);
        }
        public string ToString()
        {
            return this.LastName + ";" + this.Name + ";" + this.Age + ";" + this.Experince + ";" + this.Salary;
        }
        public override void Status()
        {
            MessageBox.Show("Статус персоны: Тренер");
        }
    }
}
