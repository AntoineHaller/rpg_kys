using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Map
    {
        public static int hauteur = 4;
        public static int largeur = 2;
        public Case[,] La_map = new Case[largeur, hauteur];

        public Map()
        {
            for (int j = 0; j < hauteur; j++)
            {
                for (int i = 0; i < largeur; i++)
                {
                    if(j == 0)
                        La_map[i, j] = new Case(Case.CaseType.Rien, "Vous êtes en bas de votre immeuble, rien ne se passe.");
                    if(j == 1)
                        La_map[i, j] = new Case(Case.CaseType.Rencontre, "Vous croisez un de vos collegues, il ne semble pas vouloir vous laisser passer.");
                    if (j == 2)
                        La_map[i, j] = new Case(Case.CaseType.Loot, "En fouillant bien autour de vous, vous trouvez un objet intéressant.");
                    if (j == 3 && i ==1)
                        La_map[i, j] = new Case(Case.CaseType.Enigme, "Un post-it vous attend. Quelques lignes sont inscrites dessus. Vous vous sentez obligé d'y répondre.");
                    if (j == 3)
                        La_map[i, j] = new Case(Case.CaseType.Fotocopieuse, "Vous tombez nez à nez à une FOTOcopieuse. Pas le choix. Elle sent votre peur. Vous devez attendre qu'elle se rendorme.");
                    if (j == 4 && i == 2)
                        La_map[i, j] = new Case(Case.CaseType.Pdg, "Vous y êtes enfin. L'antre du boss final est devant vous.");
                    if (j == 4)
                        La_map[i, j] = new Case(Case.CaseType.Rencontre, "Vous croisez un de vos collegues, il ne semble pas vouloir vous laisser passer.");


                }
            }
        }

        public void Print_Map()
        {
            for (int i = 0; i < largeur; i++)
            {
                for (int e = 0; e < hauteur; e++)
                {
                    Console.Write("[" + "  " + "]");
                }
                Console.WriteLine();
            }
        }

        public string GetDescription(int x, int y) //retourne la description de la case
        {
            string s = La_map[x, y].Description;
            return s;
        }
    }
}
