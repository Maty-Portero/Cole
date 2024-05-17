using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal menu;

            string[] menu1 = { " Nuevo                                                 ",
                               " Abrir                                                 ",
                               " Clonar repositorio                                    ",
                               " Ventana de inicio                                     ",
                               " Cerrar                                                ",
                               " Cerrar solución                                       ",
                               " Iniciar sesión de Live Share                          ",
                               " Unirse a sesión de Live Share                         ",
                               " Guardar MenuPrincipal.cs              Ctrl+S          ",
                               " Guardar MenuPrincipal.cs como...                      ",
                               " Guardar todo                          Ctrl+Mayús.+S   ",
                               " Configurar página...                                  ",
                               " Imprimir...                           Ctrl+P          ",
                               " Configuración de la cuenta...                         ",
                               " Archivos recientes                                  > ",
                               " Proyectos y soluciones recientes                    > ",
                               " Salir                                 Alt+F4          "
                             };

            string[] menu2 = { " a                                                 ",
                               " b                                                 ",
                               " c                                                 ",
                               " Ventana de                                        ",
                               " errar                                             ",
                               " Cerrar  olución                                   ",
                               " Iniciar  esión de Live Share                      ",
                               " Unirse a  esión de Live Share                     ",
                               " Guardar Me uPrincipal.cs              Ctrl+S      ",
                               " Guardar Men Principal.cs como...                  ",
                               " Guardar tod                           Ctrl+Mayús. ",
                               " Configurar pá ina...                              ",
                               " Imprimir...      d                    Ctrl+P      ",
                               " Configuración  e la cuenta...                     ",
                               " Archivos recien es                              > ",
                               " Salir           d                     Alt+F4      "
                             };

            var menus = new Dictionary<string, string[]>
            {
                { "Archivo", menu1 }, { "Editar", menu2 }
            };

            Console.Clear();
            menu = new MenuPrincipal(menus);

            ConsoleKeyInfo tecla; // Variable para almacenar la tecla presionada

            // Bucle principal del programa que se ejecuta hasta que se presiona la tecla Enter
            while (true)
            {
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
            }

            Console.ReadKey();

        }
    }
}
