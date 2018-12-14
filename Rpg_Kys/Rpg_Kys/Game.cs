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
