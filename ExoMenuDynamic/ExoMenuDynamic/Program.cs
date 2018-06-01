using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMenuDynamic
{
    class Program
    {

        static void Main(string[] args)
        {

            List<MenuItem> menuItems = new List<MenuItem>()
            {
                new MenuItem("Ajouter", 1),
                new MenuItem("Supprimer", 2),
                new MenuItem("Quitter", 5)

            };

            int menuItem = GererMenu(menuItems);

            Console.WriteLine("Vous avez choisi : " + menuItem);

            Console.ReadLine();
        }

        private static int GererMenu(List<MenuItem> menu)
        {
            // Affiche les elements du menu
            foreach (MenuItem item in menu)
                Console.WriteLine($"{item.Index}.  {item.Libelle}");

            // Demande lentree de choix
            Console.WriteLine();
            Console.WriteLine("Entrer votre choix !");

            string saisie = Console.ReadLine();
            int numeroMenu = int.Parse(saisie);

            // Attend une entre valide
            while (true)
            {
                // Traverse la liste pour trouver correspondance
                foreach (MenuItem item in menu)
                {
                    if (numeroMenu == item.Index)
                    {
                        return numeroMenu;
                    }
                }

                Console.WriteLine("Choix Invalide !");
                saisie = Console.ReadLine();
                numeroMenu = int.Parse(saisie);
            }

            /*
                        int numeroMenuValide = -1;
                        while (numeroMenuValide == -1)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Entrer votre choix !");

                            string saisie = Console.ReadLine();
                            int numeroMenu = int.Parse(saisie);

                            foreach (MenuItem item in menu)
                            {             
                                if (numeroMenu == item.Index)
                                {
                                    numeroMenuValide = numeroMenu;
                                    break;
                                }
                            }

                            if (numeroMenuValide == -1) Console.WriteLine("Choix Invalide !");
                        }
            */

  //          return numeroMenuValide;
        }
    }

    /// <summary>
    /// Représente la ligne d'un menu
    /// </summary>
    
    public class MenuItem
    {
        public string Libelle { get; set; }
        public int Index { get; set; }

        public MenuItem(string libelle, int index)
        {
            Libelle = libelle;
            Index = index;

        }
    }
}
