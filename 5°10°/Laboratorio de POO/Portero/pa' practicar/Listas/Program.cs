using System;
using System.Collections.Generic;
using System.Globalization;


namespace Listas
{
    internal class Program
    {
        //declaro de variables
        static Persona personaTop;
        static Persona personaTop2;
        static List<Persona> personas = new List<Persona>();
        static int n = 3, promedi = 0;

        //metodo de buscar el mayor
        static Persona Mayor()
        {
            personaTop = personas[0];
            
            //for para recorrer a la lista de personas
            for (int i = 1; i < personas.Count; i++)
            {
                //pregunto si la edad de personas en la posicion i es mayor a la edad de personaTop 
                if (personas[i].Edad() > personaTop.Edad())
                {
                    personaTop = personas[i]; //personas en la posicion i se asigna a personaTop
                }
            }
            return personaTop; //devuelve personTop
        }

        //metodo de buscar el menor
        static void Menor()
        {
            List<Persona> auxiliar = new List<Persona>(personas);
            personaTop = auxiliar[0];

            //for para recorrer a la lista de personas "auxiliar"
            for (int i = 1; i < auxiliar.Count; i++)
            {
                //pregunto si la edad de auxiliar en la posicion i es menor a la edad de personaTop
                if (auxiliar[i].Edad() < personaTop.Edad())
                {
                    personaTop = auxiliar[i]; //auxiliar en la posicion i se asigna a personaTop
                }
            }
            auxiliar.Remove(personaTop); //borra personaTop de auxiliar

            personaTop2 = auxiliar[0]; //asigna auxiliar en la posicion 0 y se lo asigna a personaTop2

            //for para recorrer a la lista de personas "auxiliar"
            for (int i = 1; i < auxiliar.Count; i++)
            {
                //pregunto si la edad de auxiliar en la posicion i es menor a la edad de personaTop2
                if (auxiliar[i].Edad() < personaTop2.Edad())
                {
                    personaTop2 = auxiliar[i]; //auxiliar en la posicion i se asigna a personaTop2
                }
            }
        }

        //metodo para buscar el promedio de edad
        static int Promedio()
        {
            //declaro las variables
            int prom = 0;

            //for para recorrer y ver cuantas personas hay
            for (int i = 0; i < personas.Count; i++)
            {
                personaTop = personas[i]; //personas en la posicion i se le asigna a personaTop
                prom += personaTop.Edad(); //la edad de personaTop se le suma e iguala a prom
            }
            int promedi = prom / personas.Count; //hace que prom se divide por la cantidad de personas que hay
            return promedi; //devuelve promedi
        }

        public static void Main(string[] args)
        {
            //declaro de variables
            string inputNombre = "";
            string inputFecha = "";

            //for para recorrer el ingreso de las personas
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingresar nombre: "); //pide un nombre
                inputNombre = Console.ReadLine(); //el usuario ingresa su nombre
                Console.WriteLine("Ingresar fecha de nacimiento: "); //pide una fecha de nacimiento
                inputFecha = Console.ReadLine(); //el usuario ingresa su fecha de nacimiento
                personaTop = new Persona(inputNombre, inputFecha); //se hace un new de persona con los parametros inputNombre y inputFecha
                personas.Add(personaTop); //y lo añade a la lista

                Console.WriteLine("el nombre es " + personaTop.nombre + " y su edad es " + personaTop.Edad()); //imprime los resultados
                Console.WriteLine("                     "); //espacio para que quede mas guapeton
            }

            personaTop = Mayor(); //llamo al metodo Mayor
            Console.WriteLine("El mayor es: " + personaTop.nombre); //lo imprime
            Menor(); //llamo al metodo Menor
            Console.WriteLine("Los menores son: " + personaTop.nombre + " y " + personaTop2.nombre); //lo imprime
            promedi = Promedio(); //llama al metodo Promedio
            Console.WriteLine("El promedio es " + promedi); //lo imprime

            Console.ReadKey();
        }
    }
}