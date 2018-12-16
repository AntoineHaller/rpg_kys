using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Case
    {
        public enum CaseType { Rien, Fotocopieuse, Pdg, Rencontre, Loot, Enigme } //rouge fond enigme cheval blanc

        public CaseType Type;
        public string Description;

        public Case(CaseType type, string description)
        {
            Type = type;
            Description = description;

            Random r = new Random(DateTime.Now.Millisecond);

            if (r.Next() % 100 > 50 && Type == CaseType.Loot)
            {
               //TODO arme random
            }
            if (r.Next() % 100 < 10 && Type == CaseType.Loot)
            {
                Weapon GGWP = new Weapon("La petite BOMBE NUCLEAIRE", "Ca fait boumm quand ça explose. Mais c'est lourd.", 100, Weapon.WeaponType.Missile_Nucleaire, 5, 15);
            }
        }
    }
}
