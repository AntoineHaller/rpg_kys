using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Comptable : Player
    {
        public Comptable(string n) : base(n)
        {
            Taille = 160;
            Poids = 60;
            Charisme = 3;
            Inteligence = 12;
            Defense = 1;
            Hp = 25;
            Vitesse = 7;
            Force = 7;
        }
    }
}
