using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Receptionniste : Player
    {
        public Receptionniste(string n) : base(n)
        {
            Taille = 150;
            Poids = 70;
            Charisme = 8;
            Inteligence = 3;
            Defense = 1;
            Hp = 25;
            Vitesse = 11;
            Force = 7;
        }
    }
}
