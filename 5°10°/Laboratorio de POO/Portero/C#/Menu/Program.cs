using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    class Menu
    {
        string[] items;

        public Menu(string[] opciones)
        {
            items = opciones;
        }

        public void dibujar(int columnas, int fila)
        {
            bool primerItem = true;
            foreach (string item in items)
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
                }
                Console.SetCursorPosition(columnas, fila++);
                Console.Write(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu;
            string[] opciones = { "   Nuevo Cliente      ",
                                  "   Modificar Cliente  ",
                                  "   Eliminar Cliente   ",
                                  "   Listar Cliente     ",
                                  "   Salir              "
                                };

            Console.Clear();
            menu = new Menu(opciones);
            menu.dibujar(40, 10);

            Console.ReadKey();



        }
    }
}
