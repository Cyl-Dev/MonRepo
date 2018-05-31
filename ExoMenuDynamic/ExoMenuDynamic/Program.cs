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

            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem("Ajouter", 1));
            menuItems.Add(new MenuItem("Supprimer", 2));
            menuItems.Add(new MenuItem("Quitter", 5));
 
            int menuItem = GererMenu(menuItems);

            Console.WriteLine("Vous avez choisi : " + menuItem);

            Console.ReadLine();
        }

        private static int GererMenu(List<MenuItem> menu)
        {

            foreach (MenuItem item in menu)
                Console.WriteLine($"{item.Index}.  {item.Libelle}");


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

            return numeroMenuValide;
        }
    }

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
