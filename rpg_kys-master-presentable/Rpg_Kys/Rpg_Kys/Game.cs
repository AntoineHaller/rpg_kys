using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_Kys
{
    class Game
    {
        public static Player p;
        public Map m;

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
            Console.WriteLine("Pour commencer il faut donner un petit nom à votre personnage: ");
            string nom_personnage = Console.ReadLine(); //assignation du nom du personnage
            Console.WriteLine("\nWOW c'est vraiment très original et ça sonne SUPER bien.");

            Console.WriteLine("\n\nIl faut maintenant choisir sa classe!"); 
            Console.WriteLine("Faites le bon choix, car le déroulement de votre épopée formidable pourrait bien en dépendre.");
            Console.WriteLine("Quel valeureux guerrier vous representera ?\n");
            Console.WriteLine("1 - Un(e) petit(e) stagiaire");
            Console.WriteLine("2 - Un(e) chargé(e) des ressources humaines");
            Console.WriteLine("3 - Un(e) receptionniste");
            Console.WriteLine("4 - LE DEV!");
            Console.WriteLine("5 - Un(e) comptable");

            int choix_personnage = Menu.AskChoice(1, 5); //choix du personnage

            

            switch (choix_personnage) //creation du personnage
            {
                case 1:
                    Stagiaire stagiaire1 = new Stagiaire(nom_personnage);
                    Console.WriteLine("\nStagiaire " + nom_personnage);
                    Console.WriteLine("\nTrès bon choix!"); 
                    Console.WriteLine("Il porte des cartons et court toute la journée pour ramener des cafés"); 
                    Console.WriteLine("Sa force et sa vitesse vous satisferont ... probablement");
                    System.Threading.Thread.Sleep(400);
                    Console.WriteLine("C'est le moment de commencer cette avAnture!");
                    System.Threading.Thread.Sleep(200);
                    p = stagiaire1;
                    m = new Map();
                    m.Print_Map(p);
                    while (true)
                    {
                        Case.Move_player(p);
                        m.Print_Map(p);
                    }
                    break;

                case 2:
                    RH rh1 = new RH(nom_personnage);
                    Console.WriteLine("\nRH " + nom_personnage);
                    Console.WriteLine("\nJe vois que son charisme et son bagoût vous plaisent.");
                    Console.WriteLine("Excellent choix! Il vous servira bien.");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("C'est le moment de commencer cette avAnture!");
                    System.Threading.Thread.Sleep(2000);
                    p = rh1;
                    m = new Map();
                    m.Print_Map(p);
                    while (true)
                    {
                        Case.Move_player(p);
                        m.Print_Map(p);
                    }
                    break;
                case 3:
                    Receptionniste receptionniste1 = new Receptionniste(nom_personnage);
                    Console.WriteLine("\nReceptionniste " + nom_personnage);
                    Console.WriteLine("\nExcellent choix!");
                    Console.WriteLine("Il est rapide! Et agréable! Et sympathique! Et je n'ai plus d'inspiration pour cette description.");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("C'est le moment de commencer cette avAnture!");
                    System.Threading.Thread.Sleep(2000);
                    p = receptionniste1;
                    m = new Map();
                    m.Print_Map(p);
                    while (true)
                    {
                        Case.Move_player(p);
                        m.Print_Map(p);
                    }
                    break;
                case 4:
                    LE_DEV le_dev1 = new LE_DEV(nom_personnage);
                    Console.WriteLine("\n" + nom_personnage + " LE DEV!");
                    Console.WriteLine("\nMEILLEUR CHOIX!");
                    Console.WriteLine("Il se nourrit exclusivement de McDo Nutella/Saucisson et ne se lave pas!");
                    Console.WriteLine("Du coup il est gros et a la peau épaisse!\n Donc il a beaucoup de points de vie!");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("C'est le moment de commencer cette GENIALE avAnture!");
                    System.Threading.Thread.Sleep(2000);
                    p = le_dev1;
                    m = new Map();
                    m.Print_Map(p);
                    while (true)
                    {
                        Case.Move_player(p);
                        m.Print_Map(p);
                    }
                    break;
                case 5:
                    Comptable comptable1 = new Comptable(nom_personnage);
                    Console.WriteLine("\nComptable " + nom_personnage);
                    Console.WriteLine("\nVous aussi vous avez toujours trouvé les lunettes sexy?");
                    System.Threading.Thread.Sleep(4000);
                    Console.WriteLine("C'est le moment de commencer cette avAnture!");
                    System.Threading.Thread.Sleep(2000);
                    p = comptable1;
                    m = new Map();
                    m.Print_Map(p);
                    while (true)
                    {
                        Case.Move_player(p);
                        m.Print_Map(p);
                    }
                    break;
            }   
        }
    }
}
