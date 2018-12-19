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
        public enum CaseType { Rien, Fotocopieuse, Pdg, Rencontre, Loot, Enigme, start }

        public CaseType Type;
        public int Sleep = 4000;

        public Case(CaseType type)
        {
            Type = type;

            Random r = new Random(DateTime.Now.Millisecond);

            if (Type == CaseType.start)
            {
                Console.WriteLine("Vous êtes en bas de votre immeuble, c'est le début.");
                Console.WriteLine("A vous de vous déplacer sur la map!");
                
            }

            if (Type == CaseType.Rien)
            {
                Console.WriteLine("Vous êtes en bas de votre immeuble, rien ne se passe.");
                Console.WriteLine("Rien ne se passe. GO NEXT.");
            }

            if (Type == CaseType.Fotocopieuse)
            {
                Console.WriteLine("Vous tombez nez à nez à une FOTOcopieuse. Pas le choix. Elle sent votre peur. Vous devez attendre qu'elle se rendorme.");
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
                Console.WriteLine("Vous y êtes enfin. L'antre du boss final est devant vous.");
                PDG Boss = new PDG("José");
            }

            if (Type == CaseType.Rencontre)
            {
                Console.WriteLine("C'EST LA CASE RENCONTRE");
                Console.WriteLine("Rencontre");
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
                Console.WriteLine("En fouillant bien autour de vous, vous trouvez un objet intéressant.");
                Random r2 = new Random(DateTime.Now.Millisecond);
                
                if(r2.Next() % 100 >= 90)
                {
                    Weapon balai = new Weapon("balai", "Un jolie balai!", 3, Weapon.WeaponType.Balai, 2, -1, 0);
                }
                if (r2.Next() % 100 >= 80 && r2.Next() % 100 < 90)
                {
                    Weapon carte_acces = new Weapon("carte d'accès", "Comme une carte bleu mais elle est pas bleu, ELLE EST ROUGE!!", 1, Weapon.WeaponType.Carte_acces, 0, 2, 2);
                }
                if (r2.Next() % 100 >= 70 && r2.Next() % 100 < 80)
                {
                    Weapon extincteur = new Weapon("extincteur", "Un SUPER extincteur pour refroidir l'adversaire", 4, Weapon.WeaponType.Extincteur, 3, 0, 0);
                }
                if (r2.Next() % 100 >= 60 && r2.Next() % 100 < 70)
                {
                    Weapon bouquet_fleur = new Weapon("bouquet de fleur", "Bah c'est plusieurs fleurs qui ensemble forment un bouquet, rien d'execptionnel...", 2, Weapon.WeaponType.Bouquet_de_fleurs, 1, 2, 0);
                }
                if (r2.Next() % 100 >= 50 && r2.Next() % 100 < 60)
                {
                    Weapon agrafeuse = new Weapon("agrafeuse", "Une jolie agrafeuse, mais il manque les agrafes....", 2, Weapon.WeaponType.agrafeuse, 2, 0, 1);
                }
                if (r2.Next() % 100 >= 40 && r2.Next() % 100 < 50)
                {
                    Weapon tablette = new Weapon("tablette", "Tout dernier modèle AIrPaD XS 8 pour la modique somme de 92 billions de dollars", 2, Weapon.WeaponType.tablette, 1, 1, 1);
                }
                if (r2.Next() % 100 >= 30 && r2.Next() % 100 < 40)
                {
                    Weapon micro_onde = new Weapon("four à micro onde", "Four à micro-ondes pour recharger son téléphone", 3, Weapon.WeaponType.micro_onde, 4, 0, 0);
                }
                if (r2.Next() % 100 >= 20 && r2.Next() % 100 < 30)
                {
                    Weapon panier_repas = new Weapon("panier repas", "J'avais faim alors j'ai codé un panier repas", 2, Weapon.WeaponType.panier_repas, 2, 2, 0);
                }
                if (r2.Next() % 100 >= 10 && r2.Next() % 100 < 20)
                {
                    Weapon sapin = new Weapon("sapin de noel", "Un jolie sapin de nÖel! JOYEUX NOËL", 3, Weapon.WeaponType.sapin_noel, 2, 2, 0);
                }
                if (r2.Next() % 100 >= 0 && r2.Next() % 100 < 10)
                {
                    Weapon mouchoir = new Weapon("mouchoir", "C'est un simple mouchoir..", 1, Weapon.WeaponType.mouchoir, 0, 1, 0);
                }
            }

            //Item très rare
            if (r.Next() % 100 < 10 && Type == CaseType.Loot)
            {
                Random r3 = new Random(DateTime.Now.Millisecond);
                
                if (r3.Next() % 100 >= 70)
                {
                    Weapon GGWP = new Weapon("La petite BOMBE NUCLEAIRE", "Ca fait boumm quand ça explose. Mais c'est lourd.", 100, Weapon.WeaponType.Missile_Nucleaire, 15, 0, 0);
                }
                if (r3.Next() % 100 >= 60 && r3.Next() % 100 < 70) //item op
                {
                    Weapon prof = new Weapon("Professeur Loïc Janin", "Connaissance infinies, charisme infini, POUVOIR INFINI", 1, Weapon.WeaponType.prof, 999, 999, 999);
                }
                if (r3.Next() % 100 >= 50 && r3.Next() % 100 < 60) //item pas de chance
                {
                    Weapon mcdo = new Weapon("Carte de fidélité McDonald", "Bien joué vous avez gagnez une carte de fidélité McDonald. Vous allez grossir jusqu'à en mourir. Bien joué.", 0, Weapon.WeaponType.mcdo, -100, -100, -999);
                }
                if (r3.Next() % 100 >= 0 && r3.Next() % 100 < 50)
                {
                    Weapon cheat = new Weapon("Cheat Codes", "R1, R2, L1, R2, Gauche, Bas, Droite, Haut, Gauche, Bas, Droite, Haut", 0, Weapon.WeaponType.cheat, 30, -5, -5);
                }
            }
            

            if (Type == CaseType.Enigme)
            {
                Console.WriteLine("Un post-it vous attend. Quelques lignes sont inscrites dessus. Vous vous sentez obligé d'y répondre.");
                //TO DO Enigme
            }
        }

        public static void Move_player(Player p)
        {
            
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.S:
                        if (p.y < 1)
                        {
                            p.y++;
                            Console.WriteLine("En bas!");
                            Console.WriteLine("x="+p.x+"  y="+p.y);
                        }
                        else
                        {
                            Console.WriteLine("aie aie aie aie JAI BOUFFE LE MUR");
                        }
                        break;
                    case ConsoleKey.Z:
                        if (p.y > 0)
                        {
                            p.y--;
                            Console.WriteLine("En haut!");
                            Console.WriteLine("x=" + p.x + "  y=" + p.y);
                        }
                        else
                        {
                            Console.WriteLine("aie aie aie aie JAI BOUFFE LE MUR");
                        }
                        
                        break;
                    case ConsoleKey.Q:
                        if (p.x > 0)
                        {
                            p.x--;
                            Console.WriteLine("A Gauche!");
                            Console.WriteLine("x=" + p.x + "  y=" + p.y);
                        }
                        
                        else
                        {
                            Console.WriteLine("aie aie aie aie JAI BOUFFE LE MUR");
                        }
                        break;
                    case ConsoleKey.D:
                        if (p.x < 3)
                        {
                            p.x++;
                            Console.WriteLine("A Droite!");
                            Console.WriteLine("x=" + p.x + "  y=" + p.y);
                        }
                        else
                        {
                            Console.WriteLine("aie aie aie aie JAI BOUFFE LE MUR");
                        }
                        break;
                    default:
                        Console.WriteLine("ERREUR! Mauvaise touche!");
                        break;

                }
            
            
        }
    }
}
