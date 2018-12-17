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
            return Attack_Player_Receptionniste();
        }
    }
}
