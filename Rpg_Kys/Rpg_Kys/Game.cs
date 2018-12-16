using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Game
    {
        public Player p;
        public Map plateau;

        public Game()
        {
            //TODO Faire le constructeur
        }

        public void StartGame()
        {
            //TODO Lancer le jeu
        }

        public void Choix_Perso()
        {
            Console.WriteLine("C'est le moment de chosir un personnage!"); //TODO MANU ecrire un peu plus
            Console.WriteLine("1 - Un(e) petit(e) stagiaire");
            Console.WriteLine("2 - Un(e) professionnel(le) chargé(e) des ressources humaines");
            Console.WriteLine("3 - Un(e) receptionniste");
            Console.WriteLine("4 - LE DEV!");
            Console.WriteLine("5 - Un(e) comptable");

            int choix_personnage = Menu.AskChoice(1, 5); //choix du personnage

            Console.WriteLine("Donnez un petit nom à votre personnage: "); 
            string nom_personnage = Console.ReadLine(); //assignation du nom du personnage

            switch (choix_personnage) //creation du personnage
            {
                case 1:
                    Stagiaire stagiaire1 = new Stagiaire(nom_personnage);
                    Console.WriteLine("Très bon choix! blablabla"); //TODO MANU si tu peux améliorer un peu les textes
                    break;
                case 2:
                    RH rh1 = new RH(nom_personnage);
                    Console.WriteLine("Très bon choix! blablabla");
                    break;
                case 3:
                    Receptionniste receptionniste1 = new Receptionniste(nom_personnage);
                    Console.WriteLine("Très bon choix! blablabla");
                    break;
                case 4:
                    LE_DEV le_dev1 = new LE_DEV(nom_personnage);
                    Console.WriteLine("Très bon choix! blablabla");
                    break;
                case 5:
                    Comptable comptable1 = new Comptable(nom_personnage);
                    Console.WriteLine("Très bon choix! blablabla");
                    break;
            }
        }

        public void Deplacement()
        {
            PrintChoix(); //TODO Faire la fonction Printchoix 
            int choix = Menu.AskChoice(0, 4);
            //TODO Recuperer la case
            //TODO test le contenu de la case
            //TODO lancer un combat ? ou...
        }
    }
}
