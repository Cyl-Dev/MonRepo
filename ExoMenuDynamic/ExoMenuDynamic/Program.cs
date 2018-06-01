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
            try
            {
                menu.AddItem(new MenuItem("Ajouter", 1));
                menu.AddItem(new MenuItem("Supprimer", 1));
                menu.AddItem(new MenuItem("Quiter", 4));
            }
            catch(ArgumentException) {
                
                Console.WriteLine("Error de doublon !");
            }



            int menuItem = menu.GererMenu();

            Console.WriteLine("Vous avez choisi : " + menuItem);

            Console.ReadLine();
        }
 
    }

}
