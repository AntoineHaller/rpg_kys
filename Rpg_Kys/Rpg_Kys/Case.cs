using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Case
    {
        public enum CaseType { Rien, Fotocopieuse, Pdg, Rencontre, Loot, Enigme } //rouge fond enigme cheval blanc

        public CaseType Type;
        public string Description;
        private int Sleep = 4000;

        public Case(CaseType type, string description)
        {
            Type = type;
            Description = description;


            Random r = new Random(DateTime.Now.Millisecond);

            if (Type == CaseType.Rien)
            {
                Console.WriteLine("Rien ne se passe. GO NEXT.");
            }

            if (Type == CaseType.Fotocopieuse)
            {
                Thread.Sleep(Sleep);
                Console.WriteLine("Une page a été imprimé");
                Thread.Sleep(Sleep);
                Console.WriteLine("ZzzzZ");
                Thread.Sleep(Sleep);
                Console.WriteLine("Une autre page a été imprimé");
                Thread.Sleep(Sleep);
                Console.WriteLine("Et une de plus!");
                Thread.Sleep(Sleep);
                Console.WriteLine("C'est long ?");
                Thread.Sleep(Sleep);
                Console.WriteLine("J'espère que c'est bientot fini....");
                Thread.Sleep(Sleep);
                Console.WriteLine("Vous pouvez y aller.");
                Thread.Sleep(Sleep);
                Console.WriteLine("....");
                Thread.Sleep(Sleep);
                Console.WriteLine("Maintenant");
            }

            if (Type == CaseType.Pdg)
            {
                PDG Boss = new PDG("José");
            }

            if (Type == CaseType.Rencontre)
            {
                if (r.Next() % 100 >= 80)
                {
                    ColleagueMedium enemy = new ColleagueMedium("Jozyane Balavoine");
                }
                if(r.Next() % 100 >=50 && r.Next() % 100 < 80)
                {
                    ColleagueFast enemy = new ColleagueFast("Frédéric l'accro du sport");
                }
                if (r.Next() % 100 > 100 && r.Next() % 100 < 50)
                {
                    ColleagueWeak enemy = new ColleagueWeak("Thomas N. la t");
                }

                if (r.Next() % 100 <= 10)
                {
                    ColleagueStrong enemy = new ColleagueStrong("Manager enervé");
                }
            }

            if (Type == CaseType.Loot)
            {
                if (r.Next() % 100 > 50)
                {
                    //TODO arme random
                }

                if (r.Next() % 100 < 10)
                {
                    Weapon GGWP = new Weapon("La petite BOMBE NUCLEAIRE", "Ca fait boumm quand ça explose. Mais c'est lourd.", 100, Weapon.WeaponType.Missile_Nucleaire, 5, 15);
                }
            }
            

            if (Type == CaseType.Enigme)
            {
                Console.WriteLine("C'est très les enigmes");
                //TO DO Enigme
            }
        }
    }
}
