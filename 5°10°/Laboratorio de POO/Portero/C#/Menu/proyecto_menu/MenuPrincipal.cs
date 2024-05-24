using menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    public class MenuPrincipal
    {
        List<Menu> menu = new List<Menu>();
        Dictionary<string, Action> acciones = new Dictionary<string, Action>();

        public MenuPrincipal(Dictionary<string, string[]> menus)
        {
            int pos = 1;
            foreach (var subMenu in menus)
            {
                menu.Add(new Menu(pos++, subMenu.Key, subMenu.Value));
                foreach (var opcion in subMenu.Value)
                {
                    if (!acciones.ContainsKey(opcion))
                    {
                        acciones[opcion] = () =>
                        {
                            Console.Clear();
                            Console.WriteLine($"Acción por defecto para {opcion}");
                            Console.WriteLine("Presione cualquier tecla para continuar...");
                            Console.ReadKey();
                        };
                    }
                }
            }
        }

        public void Dibujar(int columna, int fila, int subMenu, int seleccionarItem)
        {
            Console.Clear();
            Console.SetCursorPosition(columna, fila++);
            Console.WriteLine(menu[subMenu - 1].NombreMenu);
            int indice = 0;
            foreach (string item in menu[subMenu - 1].Items)
            {
                Console.SetCursorPosition(columna, fila++);
                if (indice == seleccionarItem)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                Console.WriteLine(item);
                indice++;
            }
            Console.ResetColor();
        }

        public int ContadorMenu()
        {
            return menu.Count;
        }

        public int ContadorItemMenu(int subMenu)
        {
            return menu[subMenu - 1].Items.Length;
        }

        public string ObtenerNombreMenu(int subMenu)
        {
            return menu[subMenu - 1].NombreMenu;
        }

        public string ObtenerOpcion(int subMenu, int seleccionarItem)
        {
            return menu[subMenu - 1].Items[seleccionarItem];
        }

        public void EjecutarAccion(string opcion)
        {
            if (acciones.ContainsKey(opcion))
            {
                acciones[opcion].Invoke();
            }
        }

        public void AsignarAccion(string opcion, Action accion)
        {
            if (acciones.ContainsKey(opcion))
            {
                acciones[opcion] = accion;
            }
        }
    }
}
