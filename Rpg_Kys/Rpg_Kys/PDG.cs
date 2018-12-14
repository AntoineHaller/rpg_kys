using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class PDG : Enemy
    {
        public PDG(string n) : base(n)
        {
            Defense = 10;
            Hp = 50;
            Vitesse = 10;
            Force = 20;
            Description = "";
        }
    }
}
