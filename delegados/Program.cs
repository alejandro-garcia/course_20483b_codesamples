using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    delegate string modPalabra(string miPalabra);
    delegate void modPalabra1(ref string miPalabra);

    class Program
    {
        static void reemplazaEspacios1(ref string a)
        {
            Console.WriteLine("Reemplazar espacios por guiones...");
            a = a.Replace(" ", "-");
        }

        static void removerGuiones1(ref string a)
        {
            a = a.Replace("-", "*");
        }

        static void revertirPalabra(ref string a)
        {
            string t = string.Empty;

            int i, j;

            for (i = a.Length - 1; i >= 0; i--)
            {
                t += a[i];
            }

            a = t;        
        }


        static void Main(string[] args)
        {
            string testWords = "esto es una prueba de delegado";
            modPalabra1 mp1 = reemplazaEspacios1;           
            mp1 += removerGuiones1;
            mp1(ref testWords);
            Console.WriteLine("Resultado 2da parte: {0}", testWords);
            Console.ReadLine();
            mp1 -= reemplazaEspacios1;
            mp1 += revertirPalabra;
            mp1(ref testWords);
            Console.WriteLine("Resultado 2da parte2: {0}", testWords);
            Console.ReadLine();                    
        }
    }
}
