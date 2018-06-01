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

        public Menu MenuParent { get; set; }
        private MenuItem choixSousMenuItem;

        public Menu()
        {
            menuItems = new List<MenuItem>();
        }

        public int GererMenu()
        {
            // Afficher le menu
            Afficher();

            int choixMenu = Choisir();

            return choixMenu;
        }

        public MenuItem GererMenu2()
        {
            // Afficher le menu
            Afficher();

            MenuItem choixMenu = Choisir2();

            return choixMenu;
        }


        public void Afficher()
        {
            foreach (MenuItem item in menuItems)
                Console.WriteLine($"{item.Index}. {item.Libelle}");
            Console.WriteLine("0. Retour");
        }

        public MenuItem Choisir2()
        {

            // Demande une 1ere fois
            Console.WriteLine();
            Console.WriteLine("Entrer votre choix !");

            string saisie = Console.ReadLine();
            int numeroMenu = int.Parse(saisie);

            //           if (numeroMenu == 0) return 0;

            // Attend une entre valide
            while (true)
            {
                // Traverse la liste pour trouver correspondance
                foreach (MenuItem item in menuItems)
                {
                    Console.WriteLine(">> " + item.Index);

                    if (numeroMenu == item.Index)
                    {
                        if (item.SousMenu == null) return item;
                        {
                            choixSousMenuItem = item;
                            return item.SousMenu.GererMenu2();
                        }
                    };
                }

                Console.WriteLine("Choix Invalide !");
                saisie = Console.ReadLine();
                numeroMenu = int.Parse(saisie);
            }
        }


        public int Choisir()
        {
            // Demande une 1ere fois
            Console.WriteLine();
            Console.WriteLine("Entrer votre choix !");

            string saisie = Console.ReadLine();
            int numeroMenu = int.Parse(saisie);

 //           if (numeroMenu == 0) return 0;

                // Attend une entre valide
                while (true)
            {
                // Traverse la liste pour trouver correspondance
                foreach (MenuItem item in menuItems)
                {
                    Console.WriteLine(">> " + item.Index);

                    if (numeroMenu == item.Index)
                    {                     
                        if (item.SousMenu == null) return numeroMenu;
                        {
                            choixSousMenuItem = item;
                            return item.SousMenu.GererMenu(); }
                    };
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

/*
        public string GetLibelle(int Index)
        {

            foreach(MenuItem menuItem in menuItems)
            {
                if (menuItem.Index == Index) return menuItem.Libelle;
            }
            return "";
        }
*/


    }
}