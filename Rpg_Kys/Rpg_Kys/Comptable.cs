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
            Inventaire[1] = new Weapon("calculatrice", "Une super calculette!", 2, Weapon.WeaponType.calculatrice, 1, 1);
            Type = PlayerType.Comptable;
        }

        public int Attack_Player_Comptable()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Player_Comptable();
        }
    }
}
