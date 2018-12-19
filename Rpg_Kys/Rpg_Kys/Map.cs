using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Map
    {
        public static int pos_x = 1;
        public static int pos_y = 0;
        public static int x = 4;
        public static int y = 2;
        public static Case[,] La_map = new Case[x, y];

        public Map()
        {
        }

        public static void position_joueur()
        {

        }

        public static void test_case_joueur(int j, int i)
        {
            if (j == 0 && i == 0)
                La_map[i, j] = new Case(Case.CaseType.Rien, "Vous êtes en bas de votre immeuble, rien ne se passe.");
            if (j == 1 && i == 0)
                La_map[i, j] = new Case(Case.CaseType.Rencontre, "Vous croisez un de vos collegues, il ne semble pas vouloir vous laisser passer.");
            if (j == 2 && i == 0)
                La_map[i, j] = new Case(Case.CaseType.Loot, "En fouillant bien autour de vous, vous trouvez un objet intéressant.");
            if (j == 3 && i == 0)
                La_map[i, j] = new Case(Case.CaseType.Enigme, "Un post-it vous attend. Quelques lignes sont inscrites dessus. Vous vous sentez obligé d'y répondre.");
            if (j == 0 && i == 1)
                La_map[i, j] = new Case(Case.CaseType.Fotocopieuse, "Vous tombez nez à nez à une FOTOcopieuse. Pas le choix. Elle sent votre peur. Vous devez attendre qu'elle se rendorme.");
            if (j == 1 && i == 1)
                La_map[i, j] = new Case(Case.CaseType.Pdg, "Vous y êtes enfin. L'antre du boss final est devant vous.");
            if (j == 2 && i == 1)
                La_map[i, j] = new Case(Case.CaseType.Rencontre, "Vous croisez un de vos collegues, il ne semble pas vouloir vous laisser passer.");
            if (j == 3 && i == 1)
                La_map[i, j] = new Case(Case.CaseType.Rencontre, "Vous croisez un de vos collegues, il ne semble pas vouloir vous laisser passer.");
        }


        public static void Print_Map()
        {
            Console.WriteLine("\n Voici la map, à vous de vous déplacer");

            for (int i = 0; i < y; i++)
            {
                for (int e = 0; e < x; e++)
                {
                    Console.Write("[" + "  " + "]");
                }
                Console.WriteLine();
            }

            Map.test_case_joueur(pos_x, pos_y);
        }

        public string GetDescription(int x, int y) //retourne la description de la case
        {
            string s = La_map[x, y].Description;
            return s;
        }
    }
}
