using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Player : Character
    {
        protected int Taille;
        protected int Poids;
        protected int Charisme;
        protected int Inteligence;

        public Player(string n) : base(n)
        {
        }

        public override int Damage()
        {
            if (Hp > 0)
            {
                Console.WriteLine("Dégats subis: " + (Attack() - Defense));
                return Hp = Hp - (Attack() - Defense);
            }
            else
            {
                Console.WriteLine("Game over!");
                return Hp;
            }
        }

        public bool Test_Intelligence(Player p1, int intelligence_necessaire)
        {
            if (p1.Inteligence > intelligence_necessaire)
            {
                return true; //TODO fonctionne ?
            }
            else
            {
                return false;
            }
        }

        public bool Test_Charisme(Player p1, int charisme_necessaire)
        {
            if (p1.Charisme > charisme_necessaire)
            {
                return true; //TODO fonctionne ?
            }
            else
            {
                return false;
            }
        }

        public void Move_player()
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Z:
                    Console.WriteLine("J'avance!");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("Je recule!");
                    break;
                case ConsoleKey.Q:
                    Console.WriteLine("A Gauche!");
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("A Droite!");
                    break;
                default:
                    Console.WriteLine("ERREUR! Mauvaise touche!");
                    break;

            }
        }
    }
}
