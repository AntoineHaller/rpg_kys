using System;
using System.Threading;


namespace Rpg_Kys
{
    class Case
    {
        public enum CaseType { Rien, Fotocopieuse, Pdg, Rencontre, Loot, Enigme, start }

        public CaseType Type;
        public int Sleep = 4000;
        public int small = 1000;
        Menu m = new Menu();

        public Case(CaseType type)
        {
            Type = type;

            Random r = new Random(DateTime.Now.Millisecond);

            if (Type == CaseType.start)
            {
                Console.WriteLine("\n\nVous êtes en bas de votre immeuble, c'est le début.\nLe début de votre épopée formidable.\nElle sera contée aux générations futures cherchant à s'extirper du joug du capitalisme ravageur!\n Ou pas d'ailleurs.");
                Thread.Sleep(small);
                Console.WriteLine("A vous de vous déplacer dans ces couloirs sans fin dont bizarrement vous n'avez pas le moindre souvenir! En utilisant ZQSD.");

            }

            if (Type == CaseType.Rien)
            {
                Thread.Sleep(small);
                Console.WriteLine("Rien ne se passe. GO NEXT.");
            }

            if (Type == CaseType.Fotocopieuse)
            {
                Thread.Sleep(small);
                Console.WriteLine("\n\nVous tombez nez à nez à une FOTOcopieuse. Pas le choix. Elle sent votre peur. Vous devez attendre qu'elle se rendorme.");
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
                Thread.Sleep(small);
                Console.WriteLine("\n\nVous y êtes enfin. L'antre du boss final est devant vous.");
                PDG Boss = new PDG("José");
                Console.WriteLine(Boss.Name + " est confortablement installé derrière son bureau.\nIl se lève. Vous toise et vous ordonne de repartir travailler.");
                Console.WriteLine("Mais vous n'êtes pas la pour ça! NON JOSE! NOUS NE SOMMES PAS LA POUR CELA. Ta tyrannie prend fin ici et MAINTENANT! \n tutututTUTUTUtututu *Musique de combat épique*");
                while (Boss.Hp > 0 && Game.p.Hp > 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(Boss.Name + " a " + Boss.Hp + " points de vie");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vous en avez " + Game.p.Hp);
                    Console.ForegroundColor = ConsoleColor.White;
                    Boss.Hp -= Game.p.Attack();
                    Game.p.Hp -= Boss.Attack();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Vous perdez " + Boss.Attack() + " points de vie");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (Boss.Hp <= 0)
                {
                    Console.WriteLine("Vous êtes victorieux!");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Félicitations, vous êtes tout de même mort");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(Sleep * 2);
                    m.PrintMenu();
                }
                else
                {
                    Console.WriteLine("Vous êtes mort. Reset du continuum espace-temps.");
                    Thread.Sleep(Sleep * 2);
                    m.PrintMenu();
                }
            }

            if (Type == CaseType.Rencontre)
            {
                Random r4 = new Random(DateTime.Now.Millisecond);
                Thread.Sleep(small);
                Console.WriteLine("\n\nCase Rencontre\n");
                if (r4.Next() % 100 >= 80)
                {
                    ColleagueMedium enemy = new ColleagueMedium("Jozyane Balavoine");
                    Console.WriteLine(enemy.Name + " vous approche. Elle vous a toujours effrayé!\n");
                    while(enemy.Hp>0 && Game.p.Hp >0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(enemy.Name + " a " + enemy.Hp + " points de vie");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vous en avez " + Game.p.Hp);
                        Console.ForegroundColor = ConsoleColor.White;

                        if (enemy.Test_Vitesse()>Game.p.Test_Vitesse())
                        {
                            Game.p.Hp -= enemy.Attack();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nVous perdez " + enemy.Attack() + " points de vie");
                            Console.ForegroundColor = ConsoleColor.White;

                            if (Game.p.Hp > 0)
                            {
                                int dégats = Game.p.Attack();
                                enemy.Hp -= dégats;
                                Console.WriteLine("Vous avez infligé " + dégats);
                            }
                        }
                        if (enemy.Test_Vitesse() < Game.p.Test_Vitesse())
                        {
                            enemy.Hp -= Game.p.Attack();
                            if (enemy.Hp > 0)
                            {
                                Game.p.Hp -= enemy.Attack();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vous perdez " + enemy.Attack() + " points de vie");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }


                    }
                    if (enemy.Hp <= 0)
                        Console.WriteLine("\n\nVous êtes victorieux!\nJozyane repart dans son antre.\n\n Il vous reste " + Game.p.Hp +" points de vie.");
                    else
                    {
                        Console.WriteLine("Vous êtes mort. Reset du continuum espace-temps.");
                        Thread.Sleep(Sleep*2);
                        m.PrintMenu();
                    }

                }
                if (r4.Next() % 100 >= 50 && r4.Next() % 100 < 80)
                {
                    ColleagueFast enemy = new ColleagueFast("Frédéric l'accro du sport");
                    Console.WriteLine(enemy.Name + " court vers vous. Il n'est pas aussi musclé qu'il le pense mais son cardio est à toute épreuve!");
                    while (enemy.Hp > 0 && Game.p.Hp > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(enemy.Name + " a " + enemy.Hp + " points de vie");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vous en avez " + Game.p.Hp);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (enemy.Test_Vitesse() > Game.p.Test_Vitesse())
                        {
                            Game.p.Hp -= enemy.Attack();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nVous perdez " + enemy.Attack() + " points de vie");
                            Console.ForegroundColor = ConsoleColor.White;

                            if (Game.p.Hp > 0)
                            {
                                int dégats = Game.p.Attack();
                                enemy.Hp -= dégats;
                                Console.WriteLine("Vous avez infligé " + dégats);
                            }
                        }
                        if (enemy.Test_Vitesse() < Game.p.Test_Vitesse())
                        {
                            enemy.Hp -= Game.p.Attack();
                            if (enemy.Hp > 0)
                            {
                                Game.p.Hp -= enemy.Attack();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vous perdez " + enemy.Attack() + " points de vie");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    if (enemy.Hp <= 0)
                        Console.WriteLine("Vous êtes victorieux!\nIl court vers le distributeur pour s'acheter une potion energisante!\n\n Il vous reste " + Game.p.Hp + " points de vie.");
                    else
                    {
                        Console.WriteLine("Vous êtes mort. Reset du continuum espace-temps.");
                        Thread.Sleep(Sleep * 2);
                        m.PrintMenu();
                    }
                }
                if (r4.Next() % 100 > 10 && r4.Next() % 100 < 50)
                {
                    ColleagueWeak enemy = new ColleagueWeak("Thomas N. la t");
                    Console.WriteLine(enemy.Name + " est là. Vous le méprisez du plus profond de votre être. Il ne vaut RIEN!");
                    while (enemy.Hp > 0 && Game.p.Hp > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(enemy.Name + " a " + enemy.Hp + " points de vie");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vous en avez " + Game.p.Hp);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (enemy.Test_Vitesse() > Game.p.Test_Vitesse())
                        {
                            Game.p.Hp -= enemy.Attack();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nVous perdez " + enemy.Attack() + " points de vie");
                            Console.ForegroundColor = ConsoleColor.White;

                            if (Game.p.Hp > 0)
                            {
                                int dégats = Game.p.Attack();
                                enemy.Hp -= dégats;
                                Console.WriteLine("Vous avez infligé " + dégats);
                            }
                        }
                        if (enemy.Test_Vitesse() < Game.p.Test_Vitesse())
                        {
                            enemy.Hp -= Game.p.Attack();
                            if (enemy.Hp > 0)
                            {
                                Game.p.Hp -= enemy.Attack();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vous perdez " + enemy.Attack() + " points de vie");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    if (enemy.Hp <= 0)
                        Console.WriteLine("Vous êtes victorieux!\nIl s'incline et reconnait votre supériorité.\n\n Il vous reste " + Game.p.Hp + " points de vie.");
                    else
                    {
                        Console.WriteLine("Vous êtes mort. Reset du continuum espace-temps.");
                        Thread.Sleep(Sleep * 2);
                        m.PrintMenu();
                    }
                }

                if (r4.Next() % 100 <= 10)
                {
                    ColleagueStrong enemy = new ColleagueStrong("Le Manager enervé");
                    Console.WriteLine(enemy.Name + " vous regarde. Il a l'air de vouloir en découdre.");
                    while (enemy.Hp > 0 && Game.p.Hp > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(enemy.Name + " a " + enemy.Hp + " points de vie");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Vous en avez " + Game.p.Hp);
                        Console.ForegroundColor = ConsoleColor.White;
                        if (enemy.Test_Vitesse() > Game.p.Test_Vitesse())
                        {
                            Game.p.Hp -= enemy.Attack();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n\nVous perdez " + enemy.Attack() + " points de vie");
                            Console.ForegroundColor = ConsoleColor.White;

                            if (Game.p.Hp > 0)
                            {
                                int dégats = Game.p.Attack();
                                enemy.Hp -= dégats;
                                Console.WriteLine("Vous avez infligé " + dégats);
                            }
                        }
                        if (enemy.Test_Vitesse() < Game.p.Test_Vitesse())
                        {
                            enemy.Hp -= Game.p.Attack();
                            if (enemy.Hp > 0)
                            {
                                Game.p.Hp -= enemy.Attack();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Vous perdez " + enemy.Attack() + " points de vie");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }
                    }
                    if (enemy.Hp <= 0)
                        Console.WriteLine("Vous êtes victorieux!\nRien à dire. C'était clean.\n\nIl vous reste " + Game.p.Hp + " points de vie.");
                    else
                    {
                        Console.WriteLine("Vous êtes mort. Reset du continuum espace-temps.");
                        Thread.Sleep(Sleep * 2);
                        m.PrintMenu();
                    }
                }
            }

            //Item basiques
            if (r.Next() % 100 >= 10 && Type == CaseType.Loot)
            {
                Thread.Sleep(small);
                Console.WriteLine("\n\nEn fouillant bien autour de vous, vous trouvez un objet intéressant. \n LES OBJETS NE FONCTIONNENT PAS ENCORE");
                Random r2 = new Random(DateTime.Now.Millisecond);

                if (r2.Next() % 100 >= 90)
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
                Thread.Sleep(small);
                Console.WriteLine("\n\nUn post-it vous attend. Quelques lignes sont inscrites dessus. Vous vous sentez obligé d'y répondre.");
                Console.WriteLine("\n\n De quelle couleur était le cheval Blanc d'Henry IV?");
                string reponse = Console.ReadLine();
                while(reponse.ToLower() != "rouge")
                {
                    Console.WriteLine("Essaie encore, ce n'est pourtant pas compliqué!");
                    reponse = Console.ReadLine();
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bravo! Vous pouvez continuer à vous déplacer!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void Move_player(Player p)
        {

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.S:
                    if (p.y < 5)
                    {
                        p.y++;
                        Console.WriteLine("\n\nEn bas!");
                        //Console.WriteLine("x=" + p.x + "  y=" + p.y);
                    }
                    else
                    {
                        Console.WriteLine("\n\naie aie aie aie JAI BOUFFE LE MUR");
                    }
                    break;
                case ConsoleKey.Z:
                    if (p.y > 0)
                    {
                        p.y--;
                        Console.WriteLine("\n\nEn haut!");
                       // Console.WriteLine("x=" + p.x + "  y=" + p.y);
                    }
                    else
                    {
                        Console.WriteLine("\n\naie aie aie aie JAI BOUFFE LE MUR");
                    }

                    break;
                case ConsoleKey.Q:
                    if (p.x > 0)
                    {
                        p.x--;
                        Console.WriteLine("\n\nA Gauche!");
                        //Console.WriteLine("x=" + p.x + "  y=" + p.y);
                    }

                    else
                    {
                        Console.WriteLine("\n\naie aie aie aie JAI BOUFFE LE MUR");
                    }
                    break;
                case ConsoleKey.D:
                    if (p.x < 3)
                    {
                        p.x++;
                        Console.WriteLine("\n\nA Droite!");
                        //Console.WriteLine("x=" + p.x + "  y=" + p.y);
                    }
                    else
                    {
                        Console.WriteLine("\n\naie aie aie aie JAI BOUFFE LE MUR");
                    }
                    break;
                case ConsoleKey.R:
                    p.Vos_stats();
                    break;
                default:
                    Console.WriteLine("\n\nERREUR! Mauvaise touche!");
                    break;

            }


        }
    }
}
