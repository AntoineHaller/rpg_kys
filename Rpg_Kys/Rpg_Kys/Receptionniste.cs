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
            Inventaire[1] = new Weapon("costume", "Un super costume!", 2, Weapon.WeaponType.costume, 1);
            Type = PlayerType.Receptionniste;
        }

        public int Attack_Player_Receptionniste()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Player_Receptionniste();
        }
    }
}
