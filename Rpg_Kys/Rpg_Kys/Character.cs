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
                return Hp = Hp - Attack();
            }
            else
            {
                return Hp;
            }

        }
    }
}
