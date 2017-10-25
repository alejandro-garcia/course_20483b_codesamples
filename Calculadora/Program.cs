using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcula calc = new Calcula();
            Console.WriteLine("suma 10 + 20 == {0}", calc.Sumar(10, 20));
            Console.WriteLine("restar 10 - 20 == {0}", calc.Restar(10, 20));
            Console.WriteLine("multiplicar 10 * 20 == {0}", calc.Multiplicar(10, 20));
            Console.WriteLine("dividir 20 / 10 == {0}", calc.Dividr(20, 10));

            Console.ReadLine();
        }
    }

    interface ICalcula
    {
        int Sumar(int x, int y);
        int Restar(int x, int y);
        int Multiplicar(int x, int y);
        int Dividr(int x, int y);
    }

    class Calcula : ICalcula
    {
        public int Sumar(int x, int y)
        {
            return x + y;
        }

        public int Restar(int x, int y)
        {
            return x - y;
        }

        public int Multiplicar(int x, int y)
        {
            return x * y;
        }

        public int Dividr(int x, int y)
        {
            return x / y;
        }
    }

    abstract class Calculo
    { 
       
    }

}
