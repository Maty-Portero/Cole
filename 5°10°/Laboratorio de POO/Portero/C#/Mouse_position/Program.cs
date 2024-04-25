using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Security.Cryptography;

namespace Mouse_position
{
    public class Asterisco
    {
        public int fila = 0;
        public int col = 0;

        public Asterisco(int col, int fila)
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
        static List<Asterisco> asteriscos = new List<Asterisco>();
        

        static void Main(string[] args)
        {
            Asterisco a1 = new Asterisco(10, 1);
            Asterisco a2 = new Asterisco(20, 1);
            Asterisco a3 = new Asterisco(30, 1);

            Random r = new Random();
            columna = r.Next(1, 50);
            Console.CursorVisible = false;

            int cantAsteriscos = 10;
            for (int i= 0; i < cantAsteriscos; i++)
            {
                a1 = new Asterisco(r.Next(1, 40), 1);
                asteriscos.Add(a1);
            }

            while (true)
            {
                h2 = DateTime.Now;
                transcurso = h2 - h1;

                if (transcurso.Milliseconds > 500)
                {
                    foreach (Asterisco asterisco in asteriscos)
                    {
                        Console.SetCursorPosition(asterisco.col, asterisco.fila);
                        Console.WriteLine(" ");
                        asterisco.fila++;
                        Console.SetCursorPosition(asterisco.col, asterisco.fila);
                        Console.WriteLine("*");
                        h1 = h2;
                    }
                }
            }
        }
    }
}