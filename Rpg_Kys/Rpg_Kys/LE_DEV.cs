using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class LE_DEV : Player
    {
        public LE_DEV(string n) : base(n)
        {
            Taille = 120;
            Poids = 140;
            Charisme = -1;
            Inteligence = 8;
            Defense = 3;
            Hp = 35;
            Vitesse = 2;
            Force = 8;
            Inventaire[1] = new Weapon("clavier" , "Un super clavier de G@merzz!", 2, Weapon.WeaponType.Clavier, 1, 2);
            Type = PlayerType.LE_DEV;
        }

        public int Attack_Player_DEV()
        {
            Console.WriteLine("C'est le moment de chosir une attaque!");
            Console.WriteLine("1 - 1ere attaque");
            Console.WriteLine("2 - 2eme");
            Console.WriteLine("3 - 3eme");
            Console.WriteLine("4 - ulti");

            int choix_attack = Menu.AskChoice(1, 4);

            switch (choix_attack) //TODO rajouté dmg arme
            {
                case 1:
                    Console.WriteLine("Coup de clavier");
                    return Force;
                case 2:
                    Console.WriteLine("Balbutiement maladroit");
                    return 0;
                case 3:
                    Console.WriteLine("Le C# pour les nuls");
                    return Inteligence;
                case 4:
                    Console.WriteLine("GG EZ");
                    return 10; //utiliser qu'une seule fois
                default:
                    Console.WriteLine("Mauvaise touche: AUCUNE ATTAQUE NE SERA EFFECTUE!");
                    return 0;
            }  
        }

        public override int Attack()
        {
            return Attack_Player_DEV();
        }
    }
}
