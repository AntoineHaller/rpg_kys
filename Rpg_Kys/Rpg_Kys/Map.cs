﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Map
    {
        public int joueur_x;
        public int joueur_y;
        public int x = 4;
        public int y = 2;
        public Case[,] La_map = new Case[4, 2];
    
        public Map()
        {
        }

        public void Print_Map(Player p)
        {
            Console.WriteLine("\n Voici la map, à vous de vous déplacer");

            for (int i = 0; i < y; i++)
            {
                for (int e = 0; e < x; e++)
                {
                    if (p.y <= 1 && p.y >= 0 && p.x >= 0 && p.x <= 3) { 
                        if (i == p.y && e == p.x)
                            Console.Write("[" + "la" + "]");
                        else
                            Console.Write("[" + "  " + "]");
                    }
                }
                Console.WriteLine();
            }
            if (p.y == 0 && p.x == 0)
                La_map[p.x, p.y] = new Case(Case.CaseType.start, "Vous êtes en bas de votre immeuble, rien ne se passe.");
            if (p.y == 0 && p.x == 1)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre, "Vous croisez un de vos collegues, il ne semble pas vouloir vous laisser passer.");
            if (p.y == 0 && p.x == 2)
                La_map[p.x, p.y] = new Case(Case.CaseType.Loot, "En fouillant bien autour de vous, vous trouvez un objet intéressant.");
            if (p.y == 0 && p.x == 3)
                La_map[p.x, p.y] = new Case(Case.CaseType.Enigme, "Un post-it vous attend. Quelques lignes sont inscrites dessus. Vous vous sentez obligé d'y répondre.");
            if (p.y == 1 && p.x == 0)
                La_map[p.x, p.y] = new Case(Case.CaseType.Fotocopieuse, "Vous tombez nez à nez à une FOTOcopieuse. Pas le choix. Elle sent votre peur. Vous devez attendre qu'elle se rendorme.");
            if (p.y == 1 && p.x == 1)
                La_map[p.x, p.y] = new Case(Case.CaseType.Pdg, "Vous y êtes enfin. L'antre du boss final est devant vous.");
            if (p.y == 1 && p.x == 2)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre, "Vous croisez un de vos collegues, il ne semble pas vouloir vous laisser passer.");
            if (p.y == 1 && p.x == 3)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre, "Vous êtes en bas de votre immeuble, rien ne se passe.");
        }
    }
}
