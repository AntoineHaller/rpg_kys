using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Character
    {
        public string Name;
        protected int Hp;
        protected int Force;
        protected int Defense;
        protected int Vitesse;
        

        //TODO rajouter inventaire

        public Character(string n)
        {
            Name = n;
        }

        public virtual int Attack()
        {
            return 2;
        }

        public virtual int Damage()
        {
            if (Hp > 0)
            {
                Console.WriteLine("Dégats effectués: " + (Attack() - Defense));
                return Hp = Hp - (Attack() - Defense);
            }
            else
            {
                Console.WriteLine("Personnage décédé");
                return Hp;
            }
        }

        public bool Test_Vitesse(Character p1, int vitesse_necessaire) //TODO character p1 fonctionne ? ou faut faire cette fonction dans player et dans enemy ?
        {
            if (p1.Vitesse > vitesse_necessaire)
            {
                return true; //TODO fonctionne ?
            }
            else
            {
                return false;
            }
        }
    }
}
