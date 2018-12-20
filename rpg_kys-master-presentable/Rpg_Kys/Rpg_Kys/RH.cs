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
            Inventaire.Add(new Weapon("lettre de licenciement", "Une petite lettre de licenciement! A utiliser sans modération.", 1, Weapon.WeaponType.Lettre_de_licenciement, 0, 2, 0));
            Type = PlayerType.RH;
        }

        public int Attack_Player_RH()
        {
            Console.WriteLine("C'est le moment de choisir une attaque!");
            Console.WriteLine("1 - Poussée vigoureuse(FOR)");
            Console.WriteLine("2 - Charme ravageur(CHAR)");
            Console.WriteLine("3 - Communication non verbale(INT)");
            Console.WriteLine("4 - LICENCIEMENT IMMEDIAT(ULTI)");

            int choix_attack = Menu.AskChoice(1, 4);

            switch (choix_attack)
            {
                case 1:
                    Console.WriteLine("Poussée vigoureuse");
                    return Force;
                case 2:
                    Console.WriteLine("Charme ravageur");
                    return Charisme;
                case 3:
                    Console.WriteLine("Communication non verbale");
                    return Inteligence;
                case 4:
                    Console.WriteLine("LICENCIEMENT IMMEDIAT");
                    return 20;
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
