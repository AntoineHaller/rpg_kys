using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class ColleagueWeak : Enemy
    {
        public ColleagueWeak(string n) : base(n)
        {
            Defense = 0;
            Hp = 5;
            Vitesse = 4;
            Force = 2;
            Description = "";
        }

        public int Attack_Bot_Weak()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Bot_Weak();
        }
    }
}
