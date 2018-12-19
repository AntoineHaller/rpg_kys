using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Player : Character
    {
        public int y = 5; 
        public int x;
        protected int Taille;
        protected int Poids;
        protected int Charisme;
        protected int Inteligence;
        //public int Points;
        public Equipment[] Inventaire;
        public enum PlayerType { RH, Stagiaire, LE_DEV, Receptionniste, Comptable };
        public PlayerType Type;

        public Player(string n) : base(n)
        {
            Inventaire = new Equipment[5];
            Inventaire[0] = new Potion("café", "Une potion de soin qui vous rend 5 points de vie", 2, Potion.PotionType.Heal);
        }

        #region Les tests nuls
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
                return true;
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
                return true; 
            }
            else
            {
                return false;
            }
        }

        public bool Test_Taille(Player p1, int taille_necessaire)
        {
            if (p1.Taille > taille_necessaire)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        public bool Test_Poids(Player p1, int poids_necessaire)
        {
            if (p1.Poids > poids_necessaire)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
        //TEST du compteur de point: 
        public static void Compteur_Points()
        {
            //un bon début non ? 
        }
        //FIN TEST du compteur de point: 
        #endregion

        //Stats - BETA
        public void Vos_stats()
        {
            Console.WriteLine("Vos stats: \n");
            Console.WriteLine(Name);
            Console.WriteLine("\nForce: " + Force);
            Console.WriteLine("\nPoints de vie: " + Hp);
            Console.WriteLine("\nDéfense: " + Defense);
            Console.WriteLine("\nVitesse: " + Vitesse);
            Console.WriteLine("\nPoids: " + Poids);
            Console.WriteLine("\nTaille: " + Taille);
            Console.WriteLine("\nIntelligence: " + Inteligence);
            Console.WriteLine("\nCharisme: " + Charisme);
            //Console.WriteLine("Vos Points: " + Points);
        }

        //Info inventaire  -  BETA
        public void Votre_Inventaire()
        {
            Console.WriteLine("Contenu de votre inventaire: \n\n");
            Console.WriteLine(Inventaire); //TODO je sais sa ne marche pas mais bon hein on vera demain 

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
                case ConsoleKey.R:
                    Vos_stats();
                    break;
                default:
                    Console.WriteLine("ERREUR! Mauvaise touche!");
                    break;

            }
        }
    }
}
