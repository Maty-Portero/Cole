using System;
using System.Collections.Generic;

namespace Prueba
{
    public class ProductoElectronico
    {
        public string Nombre;
        public double Precio;
        public string Marca;

        public void MostrarDetalles()
        {
            Console.WriteLine("El " + Nombre + " vale $" + Precio + " y es de " + Marca);
        }
    }

    public class Telefono : ProductoElectronico
    {
        public string SistemaOperativo;

        public Telefono(string nombre, double precio, string marca)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Marca = marca;
        }
    }

    public class Laptop : ProductoElectronico
    {
        public int MemoriaRAM;

        public Laptop(string nombre, double precio, string marca, int memoriaRam)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Marca = marca;
            this.MemoriaRAM = memoriaRam;
        }
    }

    public class Televisor : ProductoElectronico
    {
        public string Resolucion;

        public Televisor(string nombre, double precio, string marca, string resolucion)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Marca = marca;
            this.Resolucion = resolucion;
        }
    }

    internal class Program
    {
        static List<ProductoElectronico> products = new List<ProductoElectronico>();
                
        static void Main(string[] args)
        {
            bool buscarProd = false;
            Console.WriteLine("Buscar un producto: ");
            string linea = Console.ReadLine();;
            Console.WriteLine();
            Console.WriteLine("Agregue un producto: ");
            Console.WriteLine("Nombre: ");
            string nombreNuevo = Console.ReadLine();
            Console.WriteLine("Precio: ");
            double precioNuevo = Double.Parse(Console.ReadLine());
            Console.WriteLine("Marca: ");
            string marcaNuevo = Console.ReadLine();
            Console.WriteLine("Memoria RAM: ");
            int memoryNuevo = Int32.Parse(Console.ReadLine());

            double precioTotal = 0;

            products.Add(new Telefono("iphone15", 4000.05, "Apple"));
            products.Add(new Laptop("hp 5", 5000.05, "hp", 16));
            products.Add(new Televisor("LGTV", 3000.05, "LG", "1920x1080"));
            products.Add(new Laptop(nombreNuevo, precioNuevo, marcaNuevo, memoryNuevo));
            
            foreach (ProductoElectronico p in products)
            {
                if (linea == p.Nombre)
                {
                    buscarProd = true;
                    p.MostrarDetalles();                    
                    if (buscarProd == true)
                    {
                        products.Remove(p);
                        Console.WriteLine("Se removio " + p.Nombre);
                        break;
                    }
                }
            }
            foreach (ProductoElectronico p in products)
            {
                precioTotal += p.Precio;
            }

            if (buscarProd == false)
            {
                Console.WriteLine("No se encontró el producto.");
            }

            Console.WriteLine("el precio total es " + precioTotal);
            Console.ReadKey();
        }
    }
}
