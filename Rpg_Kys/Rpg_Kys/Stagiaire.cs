using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Stagiaire : Player
    {
        public Stagiaire(string n) : base(n)
        {
            Taille = 190;
            Poids = 60;
            Charisme = 1;
            Inteligence = 5;
            Defense = 1;
            Hp = 20;
            Vitesse = 12;
            Force = 16;
            Inventaire[1] = new Weapon("bloc-note", "Un super bloc-note pour prendre des notes!", 1, Weapon.WeaponType.bloc_note, 0, 0, 1);
            Type = PlayerType.Stagiaire;
        }


        public int Attack_Player_Stagiaire()
        {
            Console.WriteLine("C'est le moment de chosir une attaque!");
            Console.WriteLine("1 - Frappe du bibi");
            Console.WriteLine("2 - Esclave des temps modernes");
            Console.WriteLine("3 - Encore en formation");
            Console.WriteLine("4 - ulti");

            int choix_attack = Menu.AskChoice(1, 4);

            switch (choix_attack)
            {
                case 1:
                    Console.WriteLine("Frappe du bibi");
                    return Force;
                case 2:
                    Console.WriteLine("Esclave des temps modernes");
                    return Charisme;
                case 3:
                    Console.WriteLine("Encore en formation");
                    return Inteligence;
                case 4:
                    Console.WriteLine("IMMOLATION PAR LE FEU");
                    return 50; //utiliser qu'une seule fois
                default:
                    Console.WriteLine("Mauvaise touche: AUCUNE ATTAQUE NE SERA EFFECTUE!");
                    return 0;
            }
        }

        public override int Attack()
        {
            return Attack_Player_Stagiaire();
        }
    }
}
