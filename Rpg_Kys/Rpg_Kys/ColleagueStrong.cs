using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class ColleagueStrong : Enemy
    {
        public ColleagueStrong(string n) : base(n)
        {
            Defense = 3;
            Hp = 20;
            Vitesse = 2;
            Force = 8;
            Description = "";
        }
    }
}
