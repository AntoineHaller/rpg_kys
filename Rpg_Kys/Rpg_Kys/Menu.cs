using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Menu //TODO Faire une fonction startmenu() ?
    {
        public Menu()
        {
            PrintMenu();
            int choix = AskChoice(1, 4);
            switch (choix)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    Load();
                    break;
                case 3:
                    Apropos();
                    break;
                case 4:
                    Quit();
                    break;
            }
        }

        public void PrintMenu()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("                      /$$   /$$       /$$     /$$        /$$$$$$ ");
            Console.WriteLine("                     | $$  /$$/      |  $$   /$$/       /$$__  $$");
            Console.WriteLine("                     | $$ /$$/        \\  $$ /$$/       | $$  \\__/");
            Console.WriteLine("                     | $$$$$/          \\  $$$$/        |  $$$$$$ ");
            Console.WriteLine("                     | $$  $$           \\  $$/          \\____  $$");
            Console.WriteLine("                     | $$\\  $$           | $$           /$$  \\ $$");
            Console.WriteLine("                     | $$ \\  $$          | $$          |  $$$$$$/");
            Console.WriteLine("                     |__/  \\__/          |__/           \\______/ " + "\n\n\n");


            Console.WriteLine("Bienvenue dans le monde merveilleux de KYS\n");
            Console.WriteLine("La vie en entreprise n'est pas toujours radieuse. Heureusement vous avez trouvé la solution à votre malheur.");
            Console.WriteLine("Votre but est d'atteindre le dernier étage de la tour dans laquelle vous travaillez.");
            Console.WriteLine("Cependant vous devez faire attention, de nombreux obstacles vous barreront la route.\n");

            Console.WriteLine("1 - Nouvelle partie");
            Console.WriteLine("2 - Charger une partie");
            Console.WriteLine("3 - A propos");
            Console.WriteLine("4 - Quitter");


        }

        public static int AskChoice(int min, int max)
        {
            //utilisable partout
            //demander une valeur entre un et 4, mais faut que ca return un chiffre entre 1 et 4

            //int result = Console.ReadLine()[0];

            int result = int.Parse(Console.ReadLine());

            while (result > max && result < min) //&& ou || ?
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;

        }

        public void StartGame()
        {
            Game();
        }

        public void Load()
        {
            //TODO Faire le Load
        }

        public void Apropos()
        {
            //TODO Faire le Apropos
        }

        public void Quit()
        {
            //TODO Faire le Quit
        }
    }
}
