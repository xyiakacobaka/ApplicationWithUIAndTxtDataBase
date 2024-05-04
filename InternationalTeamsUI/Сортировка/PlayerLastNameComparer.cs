using InternationalTeamsUI.Иерархия;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalTeamsUI.Сортировка
{
    public class PlayerLastNameComparer : IComparer<Player>
    {
        public int Compare(Player? x, Player? y)
        {
            if (x.LastName[0] < y.LastName[0])
                return 1;
            else if(x.LastName[0] > y.LastName[0])
                return -1;
            else
                return 0;
        }
    }
}
