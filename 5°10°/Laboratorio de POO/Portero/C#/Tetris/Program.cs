using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tetris;
=======
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
>>>>>>> 769e0afafd6ad7b337a340613b039d5152431ab1

namespace Tetris
{
    public class Pieza
    {
<<<<<<< HEAD
        string tipo = "H";
=======
        string tipo = "";
>>>>>>> 769e0afafd6ad7b337a340613b039d5152431ab1
        List<Bloque> bloques = new List<Bloque>();

        public Pieza(string tipo)
        {
<<<<<<< HEAD
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
=======
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
>>>>>>> 769e0afafd6ad7b337a340613b039d5152431ab1
            }
        }
    }

    public class Bloque
    {
<<<<<<< HEAD
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
=======
        public int x;
        public int y;

>>>>>>> 769e0afafd6ad7b337a340613b039d5152431ab1
        public Bloque(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
<<<<<<< HEAD

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
=======
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
>>>>>>> 769e0afafd6ad7b337a340613b039d5152431ab1
