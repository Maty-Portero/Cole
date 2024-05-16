using System;
using System.Collections.Generic;

namespace Menu
{
    class Item
    {
        string opcion;
    }

    class MenuPrincipal
    {
        public List<Menu> menu = new List<Menu>();
        int numeroMenu = 0;

        public MenuPrincipal(Dictionary<string, string[]> menus) {
            // Recorro el diccionario
            int pos = 1;
            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(0, subMenu.Key, subMenu.Value));
            }
        }

        public void dibujar(int columna, int fila, int subMenu)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(columna, fila++);
            Console.WriteLine(menu[subMenu - 1].nombreMenu);            

            foreach (string item in menu[subMenu-1].items)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(columna, fila++);

                // Verifica si el ítem actual es el seleccionado para cambiar el color
                if (item ==  menu[numeroMenu].items[menu[numeroMenu].posMenu])
                {
                    Console.BackgroundColor = ConsoleColor.Red; // Cambia el color de fondo a verde
                    Console.ForegroundColor = ConsoleColor.Black; // Cambia el color del texto a negro
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                }

                Console.WriteLine(item); // Imprime la opción del menú
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Gray;

            }
        }
        public void arriba()
        {
            // Decrementa el índice del ítem seleccionado
            menu[numeroMenu].posMenu--;
            // Verifica si el índice se ha vuelto negativo, en cuyo caso vuelve al último ítem del menú
            if (menu[numeroMenu].posMenu < 0)
                menu[numeroMenu].posMenu = menu[numeroMenu].items.Length - 1;
        }

        public void abajo()
        {
            // Incrementa el índice del ítem seleccionado
            menu[numeroMenu].posMenu++;
            // Verifica si el índice se ha vuelto mayor o igual al número de ítems, en cuyo caso vuelve al primer ítem del menú
            if (menu[numeroMenu].posMenu >= menu[numeroMenu].items.Length)
                menu[numeroMenu].posMenu = 0;
        }

        public void izq()
        {

        }

        public void der()
        {

        }
    }

    class Menu
    {
        public string[] items;
        public string nombreMenu;
        public int posMenu;

        public Menu(int posMenu,string nombreMenu,string[] opciones) {
            this.items = opciones;
            this.nombreMenu = nombreMenu;
            this.posMenu = posMenu;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu;

            string[] menu1 = { "Nuevo Cliente", "Modificar Cliente", "Listar Clientes", "Salir"};
            string[] menu2 = { "Nuevo Producto", "Modificar Producto", "Eliminar Producto", "Listar Producto", "Salir" };
            string[] menu3 = { "Nuevo Pene", "Modificar Pene", "Eliminar Pene", "Listar Penes", "Salir de los Penes" };

            var menus = new Dictionary<string,string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }, { "Pene", menu3 }
            };

            Console.Clear();
            menu = new MenuPrincipal(menus);

            ConsoleKeyInfo tecla; // Variable para almacenar la tecla presionada

            // Bucle principal del programa que se ejecuta hasta que se presiona la tecla Enter
            do
            {
                menu.dibujar(1, 1, 1); // Dibuja el menú en la posición especificada
                menu.dibujar(20, 1, 2);
                menu.dibujar(40, 1, 3);
                tecla = Console.ReadKey(); // Lee la tecla presionada por el usuario

                // Dependiendo de la tecla presionada, se moverá hacia arriba o abajo en el menú
                switch (tecla.Key)
                {
                    case ConsoleKey.UpArrow:
                        menu.arriba();
                        break;
                    case ConsoleKey.DownArrow:
                        menu.abajo();
                        break;
                    case ConsoleKey.LeftArrow:
                        menu.izq();
                        break;
                    case ConsoleKey.RightArrow:
                        menu.der();
                        break;
                }
            } while (tecla.Key != ConsoleKey.Enter); // Sale del bucle cuando Enter

            Console.ReadKey();
        }
    }
}