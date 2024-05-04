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
        private int count;
        public int Count//Количество команд, которые он тренировал
        {
            get { return count; }
            set
            {
                if (value >= 0)
                    count = value;
                else
                    throw new ApplicationException("Проверьте введенные данные");
            }
        }
        private int salary;
        public int Salary//Количество команд, которые он тренировал
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                    salary = value;
                else
                    throw new ApplicationException("Проверьте введенные данные");
            }
        }
        public Trainer()
        {
            experince = 0;
            count = 0;
        }
        public Trainer(int experince, int count)
        {
            Experince = experince;
            Count = count;
        }
    }
}
