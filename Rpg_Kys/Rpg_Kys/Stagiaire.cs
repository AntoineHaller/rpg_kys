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
            Inventaire[1] = new Weapon("bloc-note", "Un super bloc-note pour prendre des notes!", 1, Weapon.WeaponType.bloc_note, 1, 1);
            Type = PlayerType.Stagiaire;
        }


        public int Attack_Player_Stagiaire()
        {
            Console.WriteLine("C'est le moment de chosir une attaque!");
            Console.WriteLine("1 - 1ere attaque");
            Console.WriteLine("2 - 2eme");
            Console.WriteLine("3 - 3eme");
            Console.WriteLine("4 - ulti");

            int choix_attack = Menu.AskChoice(1, 4);

            switch (choix_attack)
            {
                case 1:
                    Console.WriteLine("blablabla");
                    return Force;
                case 2:
                    Console.WriteLine("blablabla");
                    return Charisme;
                case 3:
                    Console.WriteLine("blablabla");
                    return Inteligence;
                case 4:
                    Console.WriteLine("blablabla");
                    return 10; //utiliser qu'une seule fois
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
