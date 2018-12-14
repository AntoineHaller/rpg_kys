using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Stagiaire : Player
    {
        public Stagiaire(string n) : base(n)
        {
            Taille = 190;
            Poids = 60;
            Charisme = 1;
            Inteligence = 5;
            Defense = 1;
            Hp = 20;
            Vitesse = 12;
            Force = 16;
        }
    }
}
