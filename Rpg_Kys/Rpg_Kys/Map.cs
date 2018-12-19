using System;
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
        public int y = 6;
        public Case[,] La_map = new Case[4, 6];
    
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
                    if (p.y <= 5 && p.y >= 0 && p.x >= 0 && p.x <= 5) { 
                        if (i == p.y && e == p.x)
                            Console.Write("[" + "la" + "]");
                        else
                            Console.Write("[" + "  " + "]");
                    }
                }
                Console.WriteLine();
            }
            if (p.y == 0 && p.x == 0)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 0 && p.x == 1)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 0 && p.x == 2)
                La_map[p.x, p.y] = new Case(Case.CaseType.Loot);

            if (p.y == 0 && p.x == 3)
                La_map[p.x, p.y] = new Case(Case.CaseType.Pdg);

            if (p.y == 1 && p.x == 0)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 1 && p.x == 1)
                La_map[p.x, p.y] = new Case(Case.CaseType.Loot);

            if (p.y == 1 && p.x == 2)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rien);

            if (p.y == 1 && p.x == 3)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 2)//ligne full enemy
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 4)//ligne full enemy
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 3 && p.x == 0)
                La_map[p.x, p.y] = new Case(Case.CaseType.Loot);

            if (p.y == 3 && p.x == 1)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 3 && p.x == 2)
                La_map[p.x, p.y] = new Case(Case.CaseType.Loot);

            if (p.y == 3 && p.x == 3)
                La_map[p.x, p.y] = new Case(Case.CaseType.Enigme);

            if (p.y == 5 && p.x == 0)
                La_map[p.x, p.y] = new Case(Case.CaseType.start);

            if (p.y == 5 && p.x == 1)
                La_map[p.x, p.y] = new Case(Case.CaseType.Loot);

            if (p.y == 5 && p.x == 2)
                La_map[p.x, p.y] = new Case(Case.CaseType.Rencontre);

            if (p.y == 5 && p.x == 3)
                La_map[p.x, p.y] = new Case(Case.CaseType.Enigme);
        }
    }
}
