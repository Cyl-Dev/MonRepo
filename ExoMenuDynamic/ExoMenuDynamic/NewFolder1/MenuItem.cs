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

            public MenuItem(string libelle, int index)
            {
                Libelle = libelle;
                Index = index;
            }
    }


}
