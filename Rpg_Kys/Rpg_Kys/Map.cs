using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Map
    {
        public static int hauteur = 5;
        public static int largeur = 3;
        public Case[,] La_map = new Case[largeur, hauteur];

        public Map()
        {
            for (int i = 0; i < largeur; i++)
            {
                for (int j = 0; j < hauteur; j++)
                {
                    Random r = new Random(DateTime.Now.Millisecond);
                    La_map[i, j] = new Case(); //TODO random case
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
