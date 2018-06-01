using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExoMenuDynamic.NewFolder1;

namespace ExoMenuDynamic
{
 //   public enum MenuItemIndex { Ajouter = 1, Supprimer, Quitter };

    class Program
    {
 
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Menu menu_Voyage = new Menu() { MenuParent = menu };
            Menu menu_Client = new Menu() { MenuParent = menu };
            Menu menu_Dossier = new Menu() { MenuParent = menu };

            try
            {

                menu.AddItem(new MenuItem("Voyage", 1, menu_Voyage, null));
                menu.AddItem(new MenuItem("Client", 2, menu_Client, null));
                menu.AddItem(new MenuItem("Dossiers", 3, menu_Dossier, null));

                menu_Voyage.AddItem(new MenuItem("Creer", 11, null, menu_Voyage));
                menu_Voyage.AddItem(new MenuItem("Rechercher", 12, null, menu_Voyage));
                menu_Voyage.AddItem(new MenuItem("Supprimer", 13, null, menu_Voyage));

                menu_Client.AddItem(new MenuItem("Creer", 21, null, menu_Client));
                menu_Client.AddItem(new MenuItem("Rechercher", 22, null, menu_Client));
                menu_Client.AddItem(new MenuItem("Supprimer", 23, null, menu_Client));

                menu_Dossier.AddItem(new MenuItem("Creer", 31, null, menu_Dossier));
                menu_Dossier.AddItem(new MenuItem("Rechercher", 32, null, menu_Dossier));
                menu_Dossier.AddItem(new MenuItem("Supprimer", 33, null, menu_Dossier));


            }
            catch (ArgumentException) {
                
                Console.WriteLine("Error de doublon !");
            }



            MenuItem menuItem = menu.GererMenu2();

            

            Console.WriteLine("Vous avez choisi : " + menuItem. +" "+ menuItem.Libelle);

 //           Console.WriteLine("Vous avez choisi : " + menuItem);


            Console.ReadLine();
        }
 
    }

}
