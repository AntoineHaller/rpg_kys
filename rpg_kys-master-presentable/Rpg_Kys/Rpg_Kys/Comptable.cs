﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Comptable : Player
    {
        public Comptable(string n) : base(n)
        {
            Taille = 160;
            Poids = 60;
            Charisme = 3;
            Inteligence = 12;
            Defense = 1;
            Hp = 25;
            Vitesse = 7;
            Force = 7;
            Inventaire.Add(new Weapon("calculatrice", "Une super calculette!", 2, Weapon.WeaponType.calculatrice, 0, 0, 2));
            Type = PlayerType.Comptable;
        }

        public int Attack_Player_Comptable()
        {
            Console.WriteLine("C'est le moment de choisir une attaque!");
            Console.WriteLine("1 - Claque dans les dents!(FOR)");
            Console.WriteLine("2 - Salutations cordiales(CHAR)");
            Console.WriteLine("3 - Explications sur le prélévement à la source(INT)");
            Console.WriteLine("4 - LA GESTION DES COMPTES!(ULTI)");

            int choix_attack = Menu.AskChoice(1, 4);

            switch (choix_attack)
            {
                case 1:
                    Console.WriteLine("Claque dans les dents!");
                    return Force;
                case 2:
                    Console.WriteLine("Salutation cordiale");
                    return Charisme;
                case 3:
                    Console.WriteLine("Explication du prélévement à la source");
                    return Inteligence;
                case 4:
                    Console.WriteLine("LA GESTION DES COMPTES!");
                    return 10; //utiliser qu'une seule fois
                default:
                    Console.WriteLine("Mauvaise touche: AUCUNE ATTAQUE NE SERA EFFECTUE!");
                    return 0;
            }
        }

        public override int Attack()
        {
            return Attack_Player_Comptable();
        }
    }
}
