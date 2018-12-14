using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class ColleagueMedium : Enemy
    {
        public ColleagueMedium(string n) : base(n)
        {
            Defense = 2;
            Hp = 10;
            Vitesse = 5;
            Force = 5;
            Description = "";
        }
    }
}
