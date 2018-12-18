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

            //Item basiques
            if (r.Next() % 100 >= 10 && Type == CaseType.Loot)
            {
                Random r2 = new Random(DateTime.Now.Millisecond);
                
                if(r.Next() % 100 >= 90)
                {
                    Weapon balai = new Weapon("balai", "Un jolie balai!", 3, Weapon.WeaponType.Balai, 2, -1, 0);
                }
                if (r.Next() % 100 >= 80 && r.Next() % 100 < 90)
                {
                    Weapon carte_acces = new Weapon("carte d'accès", "Comme une carte bleu mais elle est pas bleu, ELLE EST ROUGE!!", 1, Weapon.WeaponType.Carte_acces, 0, 2, 2);
                }
                if (r.Next() % 100 >= 70 && r.Next() % 100 < 80)
                {
                    Weapon extincteur = new Weapon("extincteur", "Un SUPER extincteur, pour refroidir l'adversaire", 4, Weapon.WeaponType.Extincteur, 3, 0, 0);
                }
                if (r.Next() % 100 >= 60 && r.Next() % 100 < 70)
                {
                    Weapon bouquet_fleur = new Weapon("bouquet de fleur", "Bah c'est plusieurs fleurs qui ensemble forment un bouquet, rien d'execptionnel...", 2, Weapon.WeaponType.Bouquet_de_fleurs, 1, 2, 0);
                }
                if (r.Next() % 100 >= 50 && r.Next() % 100 < 60)
                {
                    Weapon agrafeuse = new Weapon("agrafeuse", "Une jolie agrafeuse!", 2, Weapon.WeaponType.agrafeuse, 2, 0, 1);
                }
                if (r.Next() % 100 >= 40 && r.Next() % 100 < 50)
                {
                    Weapon tablette = new Weapon("tablette", "Une jolie tablette!", 2, Weapon.WeaponType.tablette, 1, 1, 1);
                }
                if (r.Next() % 100 >= 30 && r.Next() % 100 < 40)
                {
                    Weapon micro_onde = new Weapon("four à micro onde", "Un jolie four à micro ondes!", 3, Weapon.WeaponType.micro_onde, 4, 0, 0);
                }
                if (r.Next() % 100 >= 20 && r.Next() % 100 < 30)
                {
                    Weapon panier_repas = new Weapon("panier repas", "Un jolie panier repas!", 2, Weapon.WeaponType.panier_repas, 2, 2, 0);
                }
                if (r.Next() % 100 >= 10 && r.Next() % 100 < 20)
                {
                    Weapon sapin = new Weapon("sapin de noel", "Un jolie sapin de nÖel!", 3, Weapon.WeaponType.sapin_noel, 2, 2, 0);
                }
                if (r.Next() % 100 >= 0 && r.Next() % 100 < 10)
                {
                    Weapon mouchoir = new Weapon("mouchoir", "C'est un simple mouchoir..", 1, Weapon.WeaponType.mouchoir, 0, 1, 0);
                }
            }

            //Item très rare
            if (r.Next() % 100 < 10 && Type == CaseType.Loot)
            {
                if (r.Next() % 100 >= 70)
                {
                    Weapon GGWP = new Weapon("La petite BOMBE NUCLEAIRE", "Ca fait boumm quand ça explose. Mais c'est lourd.", 100, Weapon.WeaponType.Missile_Nucleaire, 15, 0, 0);
                }
                if (r.Next() % 100 >= 60 && r.Next() % 100 < 70) //item op
                {
                    Weapon prof = new Weapon("Professeur Loïc Janin", "amuse toi manu", 1, Weapon.WeaponType.prof, 999, 999, 999);
                }
                if (r.Next() % 100 >= 50 && r.Next() % 100 < 60) //item pas de chance
                {
                    Weapon mcdo = new Weapon("Carte de fidélité McDonald", "Bien joué vous avez gagnez une carte de fidélité McDonald. Vous allez grossir jusqu'à en mourir. Bien joué.", 0, Weapon.WeaponType.mcdo, -100, -100, -999);
                }
                if (r.Next() % 100 >= 0 && r.Next() % 100 < 50)
                {
                    Weapon cheat = new Weapon("Cheat Codes", "R1, R2, L1, R2, Gauche, Bas, Droite, Haut, Gauche, Bas, Droite, Haut", 0, Weapon.WeaponType.cheat, 30, -5, -5);
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
