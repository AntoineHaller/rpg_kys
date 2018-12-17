using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Receptionniste : Player
    {
        public Receptionniste(string n) : base(n)
        {
            Taille = 150;
            Poids = 70;
            Charisme = 8;
            Inteligence = 3;
            Defense = 1;
            Hp = 25;
            Vitesse = 11;
            Force = 7;
            Inventaire[1] = new Weapon("téléphone", "Un super nokia3210!", 2, Weapon.WeaponType.Telephone, 1, 1);
            Type = PlayerType.Receptionniste;
        }

        public int Attack_Player_Receptionniste()
        {
            Console.WriteLine("C'est le moment de chosir une attaque!");
            Console.WriteLine("1 - Frappe téléphonée");
            Console.WriteLine("2 - Conversation agréable");
            Console.WriteLine("3 - gné");
            Console.WriteLine("4 - ulti");

            int choix_attack = Menu.AskChoice(1, 4);

            switch (choix_attack)
            {
                case 1:
                    Console.WriteLine("Frappe téléphonée");
                    return Force;
                case 2:
                    Console.WriteLine("Conversation agréable");
                    return Charisme;
                case 3:
                    Console.WriteLine("gné by antoine");
                    return Inteligence;
                case 4:
                    Console.WriteLine("Appel du Supérieur");
                    return 10; //utiliser qu'une seule fois
                default:
                    Console.WriteLine("Mauvaise touche: AUCUNE ATTAQUE NE SERA EFFECTUE!");
                    return 0;
            }
        }

        public override int Attack()
        {
            return Attack_Player_Receptionniste();
        }
    }
}
