using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class LE_DEV : Player
    {
        public LE_DEV(string n) : base(n)
        {
            Taille = 120;
            Poids = 140;
            Charisme = -1;
            Inteligence = 8;
            Defense = 3;
            Hp = 35;
            Vitesse = 2;
            Force = 8;
        }

        public int Attack_Player_DEV()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Player_DEV();
        }
    }
}
