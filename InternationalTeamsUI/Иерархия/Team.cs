namespace InternationalTeamsUI.Иерархия
{
    public class Team
    {
        private string name;
        public string Name
        {
            get { return name; } //Название команды
            set
            {
                if (Form1.ListNameTeams.IndexOf(value) == -1)
                    name = value;
                else
                    throw new ApplicationException("Такая команда уже есть");
            }
        }
        private int count;
        public int Count//Доход
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
        private string trainer;
        public string Trainer { get { return trainer; } 
            set 
            {
                if (Trainer == string.Empty)
                    throw new ApplicationException("Проверьте введенные данные");
                trainer = value;
            } }
        public Team()//Пустой конструктор
        {
            Name = string.Empty;
            Count = 0;
            Trainer = string.Empty;
            Form1.ListTeams.Add(this);
            Form1.ListNameTeams.Add(this.Name);
        }
        public Team(string Name, int Salary, string Trainer)//Конструктор
        {            
            this.Name = Name;
            this.Count = Salary;
            this.Trainer = Trainer;
            Form1.ListTeams.Add(this);
            Form1.ListNameTeams.Add(this.Name);
        }
        public string ToString()
        {
            return this.Name + ";" + this.Count + ";" + this.Trainer;
        }
    }
}
