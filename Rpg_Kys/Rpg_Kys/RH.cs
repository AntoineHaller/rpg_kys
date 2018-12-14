using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class RH : Player
    {
        public RH(string n) : base(n)
        {
            Taille = 180;
            Poids = 65;
            Charisme = 12;
            Inteligence = 7;
            Defense = 1;
            Hp = 25;
            Vitesse = 5;
            Force = 5;
        }
    }
}
