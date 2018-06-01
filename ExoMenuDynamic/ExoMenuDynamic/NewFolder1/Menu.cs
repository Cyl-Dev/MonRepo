using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExoMenuDynamic.NewFolder1
{
    /// <summary>
    /// Gestion complete d'un menu
    /// </summary>
    public class Menu
    {
        private List<MenuItem> menuItems;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        public int GererMenu()
        {
            // Afficher le menu
            Afficher();

            return Choisir();
        }

        public void Afficher()
        {
            foreach (MenuItem item in menuItems)
                Console.WriteLine($"{item.Index}. {item.Libelle}");
        }

        public int Choisir()
        {
            // Demande une 1ere fois
            Console.WriteLine();
            Console.WriteLine("Entrer votre choix !");

            string saisie = Console.ReadLine();
            int numeroMenu = int.Parse(saisie);

            // Attend une entre valide
            while (true)
            {
                // Traverse la liste pour trouver correspondance
                foreach (MenuItem item in menuItems)
                {
                    if (numeroMenu == item.Index) return numeroMenu;
                }

                Console.WriteLine("Choix Invalide !");
                saisie = Console.ReadLine();
                numeroMenu = int.Parse(saisie);
            }
        }

        /// <summary>
        /// Insère un menuItem dans le menu 
        /// </summary>
        /// <param name="menuItem"></param>
        /// <exception cref="ArgumentException"> Si le numèro de l'item est déja présent</exception>

        public void AddItem(MenuItem menuItem) 
        {
            if (menuItems.Exists(x => x.Index == menuItem.Index)) throw new ArgumentException($"Ouh lolo !! Y'a 2 indices pareils !!");

            menuItems.Add(menuItem);
        }

    }
}