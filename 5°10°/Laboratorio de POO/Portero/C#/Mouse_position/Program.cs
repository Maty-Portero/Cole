using System;
using System.Collections.Generic;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Security.Cryptography;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;


namespace Mouse_position
{
    public class Copo
    {
        public int col = 0;
        public int fila = 0;

        public Copo(int col, int fila)
        {
            this.col = col;
            this.fila = fila;
        }
    }


    internal class Program
    {
        static TimeSpan transcurso;
        static DateTime h1 = DateTime.Now;
        static DateTime h2 = DateTime.Now;
        static int fila = 0;
        static int columna = 0;
        static List<Copo> copos = new List<Copo>();

        static public bool bajar(Copo c)
        {
            bool estado = false;
            if (c.fila < 30)
                estado = true;
            foreach (Copo co in copos)
            {   
                if(c.col == co.col && c.fila+1 == co.fila)
                {
                    estado = false;
                }
            }

            return estado;
        }

        static void Main(string[] args)
        {
            Copo a1;
            Random r = new Random();
            columna = r.Next(1, 50);
            Console.CursorVisible = false;

            a1 = new Copo(r.Next(1, 40), 1);
            copos.Add(a1);

            while (true)
            {
                h2 = DateTime.Now;
                transcurso = h2 - h1;


                if (transcurso.Milliseconds > 100)
                {
                    a1 = new Copo(r.Next(1, 40), 1);
                    copos.Add(a1);

                    foreach (Copo copo in copos)
                    {
                        if (bajar(copo)==true)
                        {
                            Console.SetCursorPosition(copo.col, copo.fila);
                            Console.Write(" ");
                            copo.fila++;
                            Console.SetCursorPosition(copo.col, copo.fila);
                            Console.Write("*");
                        }
                    }
                    h1 = h2;
                }
            }
        }
    }
}