using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceso principal....");
            MiHilo mh1 = new MiHilo("Hilo secundario 1");
            MiHilo mh2 = new MiHilo("Hilo secundario 2");
            //establecer priordades
            mh1.hilo.Priority = ThreadPriority.Lowest;
            mh2.hilo.Priority = ThreadPriority.Highest;
            mh1.hilo.Start();
            mh2.hilo.Start();
            mh1.hilo.Join();
            mh2.hilo.Join();
            Console.WriteLine("Contador de mh1: {0}", mh1.contador.ToString());
            Console.WriteLine("Contador de mh2: {0}", mh2.contador.ToString());
            Console.WriteLine("Fin de la aplicación....");
            Console.ReadLine();
        }
    }
    class MiHilo
    {
        public int contador;
        public Thread hilo;
        static bool parar = false;
        static string hiloActual;
        
        public MiHilo(string _nombrehilo)
        {
            contador = 0;
            hilo = new Thread(new ThreadStart(this.Ejecutar));
            hilo.Name = _nombrehilo;
            hiloActual = _nombrehilo;
        }

        public void Ejecutar()
        {
            Console.WriteLine(hilo.Name + " iniciando...");
            
            do
            {
                contador++;
                if (hiloActual != hilo.Name)
                {
                    hiloActual = hilo.Name;
                    Console.WriteLine("En " + hilo.Name);
                }

            } while (parar == false && contador < 100000000);
            
            parar = true;
            
            Console.WriteLine(hilo.Name + " finalizando.....");
        }
    }
}
