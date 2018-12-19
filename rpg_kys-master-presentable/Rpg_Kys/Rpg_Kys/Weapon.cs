using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Weapon : Equipment
    {
        public enum WeaponType { Balai, Clavier, Missile_Nucleaire, Lettre_de_licenciement, bloc_note, Telephone, calculatrice, Carte_acces, Extincteur, Bouquet_de_fleurs, agrafeuse, tablette, micro_onde, panier_repas, sapin_noel, prof, mouchoir, cheat, mcdo }; //TODO mettre les bonnes armes
        public WeaponType Type;
        public int Plus_de_degat;
        public int Plus_de_charisme;
        public int Plus_d_intelligence;

        public Weapon(string name, string description, int weight, WeaponType t, int plus_de_degat, int plus_de_charisme, int plus_d_intelligence) : base(name, description, weight)
        {
            Type = t;
            Plus_de_degat = plus_de_degat;
            Plus_de_charisme = plus_de_charisme;
            Plus_d_intelligence = plus_d_intelligence;
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
