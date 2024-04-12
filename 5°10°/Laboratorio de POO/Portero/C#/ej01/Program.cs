using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();    
            for (int i = 0; i < s.Length; i++)
            {
                //Console.WriteLine(s[i]);
                for (int j = i-2; j < s.Length/2; j++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine(s[i]);

            }
            
            Console.ReadKey();
        }
    }
}
