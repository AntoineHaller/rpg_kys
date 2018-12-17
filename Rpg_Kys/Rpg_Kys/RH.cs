using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class RH : Player
    {
        public RH(string n) : base(n)
        {
            Taille = 180;
            Poids = 65;
            Charisme = 12;
            Inteligence = 7;
            Defense = 1;
            Hp = 25;
            Vitesse = 5;
            Force = 5;
            Inventaire[1] = new Weapon("lettre de licenciement", "Une petite lettre de licenciement! A utiliser sans modération.", 1, Weapon.WeaponType.Lettre_de_licenciement, 1, 1);
            Type = PlayerType.RH;
        }

        public int Attack_Player_RH()
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
                    return 10;
                default:
                    Console.WriteLine("Mauvaise touche: AUCUNE ATTAQUE NE SERA EFFECTUE!");
                    return 0;
            }
        }


        public override int Attack()
        {
            return Attack_Player_RH();
        }
    }
}
