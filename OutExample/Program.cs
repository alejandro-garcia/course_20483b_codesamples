using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string palabra;
            AsignarValor(out palabra, out x);
            Console.WriteLine("{0} {1}", palabra, x);
            Console.ReadLine();
        }
        static void AsignarValor(out string valor, out int y)
        {
            valor = "casa";
            y = 90;
        }
    }
}
