﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class ColleagueMedium : Enemy
    {
        public ColleagueMedium(string n) : base(n)
        {
            Defense = 2;
            Hp = 10;
            Vitesse = 5;
            Force = 5;
            Description = "";
        }

        public int Attack_Bot_Medium()
        {
            return Force;
        }

        public override int Attack()
        {
            return Attack_Bot_Medium();
        }

        public override int Test_Vitesse()
        {
            return base.Test_Vitesse();
        }
    }
}
