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
            Inventaire[1] = new Weapon("bloc-note", "Un super bloc-note pour prendre des notes!", 1, Weapon.WeaponType.bloc_note, 1);
        }


        public int Attack_Player_Stagiaire()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Player_Stagiaire();
        }
    }
}
