using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int posItem;

        public Menu(int posItem, string nombreMenu, string[] opciones)
        {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.posItem = posItem;
        }
    }
}
