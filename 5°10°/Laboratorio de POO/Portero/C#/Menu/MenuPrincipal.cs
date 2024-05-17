using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class MenuPrincipal
    {
        public List<Menu> menu = new List<Menu>();
        int posMenu = 0;

        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            // Recorro el diccionario
            posMenu = 0;
            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(posMenu++, subMenu.Key, subMenu.Value));
            }
            posMenu = 0;
        }
        public void dibujar()
        {
            Console.Clear();
            int columna = 1;
            int fila = 1;
            Console.SetCursorPosition(columna, fila++);
            Console.WriteLine(menu[posMenu].nombreMenu);
            
            foreach (string item in menu[posMenu].items)
            {
                if (menu[posMenu].posItem == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(columna, fila++);
                Console.Write(item);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            
            /*foreach (string item in items)
            {
                if (primerItem)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    primerItem = false;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.SetCursorPosition(columna, fila++);
                Console.Write(item);
            }*/
        }

        public void abajo()
        {
            if (menu[posMenu].posItem < menu[posMenu].items.Length)
                menu[posMenu].posItem++;
            else
                menu[posMenu].posItem = 0;
            this.dibujar();
        }

        public void arriba()
        {
            if (menu[posMenu].posItem > 0)
                menu[posMenu].posItem--;
            else
                menu[posMenu].posItem = menu[posMenu].items.Length - 1;
            this.dibujar();
        }        

        public void izq()
        {
            menu[posMenu].posItem = 0;

            if (posMenu > 0)
                posMenu--;
            else
                posMenu = menu.Count - 1;

            this.dibujar();
        }

        public void der()
        {
            menu[posMenu].posItem = 0;

            if (posMenu < menu.Count - 1)
                posMenu++;
            else 
                posMenu = 0;

            this.dibujar();
        }
    }
}
