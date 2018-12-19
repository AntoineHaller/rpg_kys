using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Menu
    {

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

        public static int AskChoice(int min, int max)
        {
            int result = int.Parse(Console.ReadLine());

            while (result > max && result < min)
            {
                result = int.Parse(Console.ReadLine());
            }
            return result;
        }

        public void StartGame()
        {
            Console.WriteLine("La partie commence!");
            Game g = new Game();
            g.Choix_Perso();
        }

        public static void Load()
        {
            //TODO Faire le Load
        }

        public static void Apropos()
        {
            Console.WriteLine("Nous sommes honorés que vous preniez la peine de venir nous voir ici!");
            Console.WriteLine("Ce jeu a été réalisé par Antoine AH et Emmanuela Papyrus");
            Console.WriteLine("Il represente l'accomplissement d'une vie entière de durs labeurs");
            Console.WriteLine("Souscrivez à un abonnement!");
            Thread.Sleep(3000);
        }

        public static void Quit()
        {
            Console.WriteLine("Ce n'est pas grave de céder face à l'adversité.");
            Thread.Sleep(5000);
            Environment.Exit(0);
        }
    }
}
