using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class Pieza
    {
        string tipo = "";
        List<Bloque> bloques = new List<Bloque>();

        public Pieza(string tipo)
        {
            this.tipo = tipo;
            if (tipo == "linea")
            {
                bloques.Add(new Bloque(5, 1));
                bloques.Add(new Bloque(5, 2));
                bloques.Add(new Bloque(5, 3));
                bloques.Add(new Bloque(5, 4));
            }
        }

        public void der()
        {
            foreach (var item in bloques)
            {
                item.x++;
            }
        }

        public void izq()
        {
            foreach (var item in bloques)
            {
                item.x--;
            }
        }

        /*public void bajar()
        {
            foreach (var item in bloques)
            {
                item.y++;
            }
        }*/

        public void dibujar()
        {
            foreach (var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.x, bloque.y);
                Console.Write("#");
            }
        }

        public void limpiar()
        {
            foreach (var bloque in bloques)
            {
                Console.SetCursorPosition(bloque.x, bloque.y);
                Console.Write(" ");
            }
        }
    }

    public class Bloque
    {
        public int x;
        public int y;

        public Bloque(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
        //List<Pieza> piezas = new List<Pieza>();
        static void Main(string[] args)
        {
            Pieza p = new Pieza("linea");

            while (true)
            {
                //checkear teclado
                p.limpiar();

                //teclad

                p.dibujar();

            }
        }
    }
}
