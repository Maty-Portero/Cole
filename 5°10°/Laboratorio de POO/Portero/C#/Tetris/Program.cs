using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris;

namespace Tetris
{
    public class Pieza
    {
        string tipo = "H";
        List<Bloque> bloques = new List<Bloque>();

        public Pieza(string tipo)
        {
            if (tipo == "linea")
            {
                new Bloque(1, 1);
                new Bloque(1, 2);
                new Bloque(1, 3);
                new Bloque(1, 4);
            }
        }

        public void derecha()
        {
            foreach (var item in bloques)
            {
                item.X++;
            }
        }
        public void izquierda()
        {
            foreach (var item in bloques)
            {
                item.X--;
            }
        }

        public void bajar()
        {
            foreach (var item in bloques)
            {
                item.Y++;
            }
        }
    }

    public class Bloque
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; } set { x = value; }
        }
        
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Bloque(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

}


internal class Program
{
    List<Pieza> piezas = new List<Pieza>();
    static void Main(string[] args)
    {
        Pieza p = new Pieza("linea");

        while (true)
        {
            //checkear teclado
            p.derecha();
        }
    }
}