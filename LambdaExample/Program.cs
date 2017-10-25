using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExample
{
    class Program
    {
        static void Main(string[] args)
        {
            DelegadoTradicional();
            DelegadoAnonimo();
            ExpresionLambda();

            Console.ReadLine();
        }

        static void DelegadoTradicional()
        {
            List<int> lista = new List<int>();
            lista.AddRange(new int[] { 10, 2, 4, 5, 6, 7, 19, 20 });
            Predicate<int> retornar = new Predicate<int>(NumeroPar);
            List<int> numerosPares = lista.FindAll(retornar);
            Console.WriteLine("Aqui estan los numeros pares...");
            foreach (int numeroPar in numerosPares)
            {
                Console.Write("{0}\t", numeroPar.ToString());
            }
            Console.WriteLine();
        }

        static void DelegadoAnonimo()
        {
            List<int> lista = new List<int>();
            lista.AddRange(new int[] { 10, 2, 4, 5, 6, 7, 19, 20 });
           
            List<int> numerosPares = lista.FindAll(delegate (int x){
               return (x%2)== 0;
            });

            Console.WriteLine("Aqui estan los numeros pares...");
            foreach (int numeroPar in numerosPares)
            {
                Console.Write("{0}\t", numeroPar.ToString());
            }
            Console.WriteLine();
        }

        static void ExpresionLambda()
        {
            List<int> lista = new List<int>();
            lista.AddRange(new int[] { 10, 2, 4, 5, 6, 7, 19, 20 });

            List<int> numerosPares = lista.FindAll(x=> x % 2 == 0);
           

            Console.WriteLine("Aqui estan los numeros pares...");
            foreach (int numeroPar in numerosPares)
            {
                Console.Write("{0}\t", numeroPar.ToString());
            }
            Console.WriteLine();
        }

        static bool NumeroPar(int x)
        {
            return (x % 2 == 0);
        }
    }


}
