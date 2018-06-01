using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoMenuDynamic.NewFolder1
{
 
        /// <summary>
        /// Représente la ligne d'un menu
        /// </summary>
    public class MenuItem
    {
        public string Libelle { get; set; }
        public int Index { get; set; }

        public Menu SousMenu { get; set; }
        private Menu parentMenu;

        public MenuItem(string libelle, int index, Menu sousMenu, Menu pparentMenu)
        {
                Libelle = libelle;
                Index = index;
                SousMenu = sousMenu;
            parentMenu = pparentMenu;
        }

        public MenuItem(string libelle, int index)
        {
            Libelle = libelle;
            Index = index;
        }
    }


}
