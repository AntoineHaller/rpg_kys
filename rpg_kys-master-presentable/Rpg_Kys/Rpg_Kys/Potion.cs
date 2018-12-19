using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Potion : Equipment
    {
        public enum PotionType { Heal, Defence, Attack }
        public PotionType Type;

        public Potion(string name, string description, int weight, PotionType t) : base(name, description, weight)
        {
            Type = t;
        }

        public override void PickUp_Object()
        {
            base.PickUp_Object();
            Console.WriteLine("C'est une potion de " + Name + "!");
        }

        public override void Use_Object()
        {
            base.Use_Object();
            Console.WriteLine("C'est une potion de " + Name + "!");
        }
    }
}
