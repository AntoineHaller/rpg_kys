using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class ColleagueStrong : Enemy
    {
        public ColleagueStrong(string n) : base(n)
        {
            Defense = 3;
            Hp = 20;
            Vitesse = 2;
            Force = 8;
            Description = "";
        }

        public int Attack_Bot_Strong()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Bot_Strong();
        }
    }
}
