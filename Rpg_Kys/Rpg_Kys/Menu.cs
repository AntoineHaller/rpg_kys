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
            int choix = AskChoice(0, 3);
            switch (choix)
            {
                case 0:
                    StartGame();
                    break;
                case 1:
                    Load();
                    break;
                case 2:
                    Apropos();
                    break;
                case 3:
                    Quit();
                    break;
            }
        }

        public void PrintMenu()
        {
            //TODO Faire le PrintMenu
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
            //TODO Faire le StartGame
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
