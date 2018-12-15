using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class ColleagueFast : Enemy
    {
        public ColleagueFast(string n) : base(n)
        {
            Defense = 0;
            Hp = 5;
            Vitesse = 9;
            Force = 2;
            Description = "";
        }

        public int Attack_Bot_Fast()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Bot_Fast();
        }
    }
}
