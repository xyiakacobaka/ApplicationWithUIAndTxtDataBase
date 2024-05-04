using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTeamsUI.Иерархия
{
    public class Match
    {
        public Team team1;
        public Team team2;
        private int prise;
        public int Prise { get { return prise; } 
            set {
                if (value < 0)
                    throw new ArgumentException("Призовые не могут быть меньше нуля");
                prise = value;
            } }
        public Match() 
        {
            team1 = new Team();
            team2 = new Team();
        }
        public Match(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }
    }
}
