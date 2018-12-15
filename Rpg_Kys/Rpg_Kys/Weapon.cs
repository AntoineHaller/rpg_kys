using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Weapon : Equipment
    {
        public enum WeaponType { Balai, Clavier, Missile_Nucleaire, cv, bloc_note, costume, calculatrice }; //TODO mettre les bonnes armes
        public WeaponType Type;
        public int Rarity; //en liaison avec des couleurs

        public Weapon(string name, string description, int weight, WeaponType t, int rarity) : base(name, description, weight)
        {
            Type = t;
            Rarity = rarity;
        }

        public override void PickUp_Object()
        {
            base.PickUp_Object();
            Console.WriteLine("C'est objet est un " + Name + "!");
        }

        public override void Use_Object()
        {
            base.Use_Object();
            Console.WriteLine("C'est objet est un " + Name + "!");
        }
    }
}
