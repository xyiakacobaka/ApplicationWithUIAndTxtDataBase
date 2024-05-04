using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using InternationalTeamsUI;

namespace InternationalTeamsUI.Иерархия
{
    public class Player : Person
    {
        private string nickName;
        public string NickName { get { return nickName; } 
            set {
                if (value == string.Empty)
                    throw new ApplicationException("Проверьте введенные данные");
                if (Form1.ListNickNames.IndexOf(value) == -1)
                    nickName = value;
                else
                    throw new ApplicationException("Игрок с тем же никнеймом уже добавлен в базу данных. Вы можете его найти");
            } }
        
        private string rank;
        public string Rank
        {
            get { return rank; }//Ранг игрока
            set
            {
                rank = value;
            }
        }

        private int winGames;
        public int WinGames
        {
            get { return winGames; }//Количество выйгранных игры в соревновательной игре 
            set
            {
                if (value >= 0)
                    winGames = value;
                else
                    throw new ApplicationException("Проверьте введенные данные");
            }
        }
        private int loseGames;
        public int LoseGames
        {
            get { return loseGames; }//Количество выйгранных игры в соревновательной игре 
            set
            {
                if (value >= 0)
                    loseGames = value;
                else
                    throw new ApplicationException("Проверьте введенные данные");
            }
        }
        private int hoursInDota;
        public int HoursInDota
        {
            get { return hoursInDota; }
            set
            {
                if (value >= 0)
                    hoursInDota = value;
                else
                    throw new ApplicationException("Проверьте введенные данные");
            }
        }
        private string team;
        public string Team { get { return team; } 
            set {
                if (value == null)
                    throw new ApplicationException("Проверьте введенные данные");
                if (Form1.ListNameTeams.IndexOf(value) == -1)                    
                    throw new ApplicationException("Такого звания не существует. Проверьте правильность ввода названия!");
                team = value;
            } }

        public Player()//Пустой конструктор
        {
            Name = string.Empty;
            Age = 0;
            LastName = string.Empty;
            Rank = string.Empty;
            Form1.ListPlayers.Add(this);
            Form1.ListNickNames.Add(this.NickName);
            Form1.ListPlayersLastName.Add(this.LastName);
        }
        public Player(string LastName, string Name, int Age, string NickName, string Rank, int WinGame, int LoseGame, int HoursInDota, string Team)//Конструтор
        {
            Check(Team);
            this.Name = Name;
            this.Age = Age;
            this.LastName = LastName;
            this.Rank = Rank;
            this.NickName = NickName;
            this.WinGames = WinGame;
            this.LoseGames = LoseGame;
            this.HoursInDota = HoursInDota;
            this.Team = Team;
            Form1.ListPlayers.Add(this);
            Form1.ListNickNames.Add(this.NickName);
            Form1.ListPlayersLastName.Add(this.LastName);
        }
        private void Check(string Team)
        {
            int i = 0;
            foreach (Player player in Form1.ListPlayers)
            {
                if (player.Team == Team)
                {
                    i++;
                    if(i==5)
                        throw new ApplicationException("В команде не может быть больше 5 игроков");
                    continue;
                }                    
            }
        }
        private double result;
        public double WinRate(double WinGame, double LoseGame)//Метод по вычислению коэфициента побед
        {            
            result = WinGame / (WinGame+LoseGame);
            return Math.Round(result, 3);
        }
        public double DotaLife(double HoursInDota, double Age)//Процент жизни, который потратил игрок на Доту
        {
            result = HoursInDota / (Age * 365 *24);
            return Math.Round(result,2);
        }
        public string ToString()
        {
            return this.LastName + ";" + this.Name + ";" + this.Age + ";" + this.NickName + ";" + this.Rank + ";" + this.WinGames + ";" + 
                + this.LoseGames + ";" + this.HoursInDota + ";" + this.Team;
        }
    }
}
