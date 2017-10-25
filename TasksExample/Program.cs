using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TasksExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Proceso principal....");
            //construir una tarea
            Task tarea = new Task(MiTarea);
            tarea.Start();
            // espera paa que se complete la tarea
            for (int i = 0; i < 60; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(100);
            }
            // construir 2 tareas
            Task tarea1 = new Task(MiTarea);
            Task tarea2 = new Task(MiTarea);
            tarea1.Start();
            tarea2.Start();
            Console.WriteLine("Id para la tarea1: " + tarea1.Id);
            Console.WriteLine("Id para la tarea2: " + tarea2.Id);
            // suspender main() hasta que ambas tareas terminen
            tarea1.Wait();
            tarea2.Wait();
            
            #region myregion
            
            Task.WaitAny(tarea1, tarea2);
            Console.WriteLine("Finalizo el proceso principal");
            Console.ReadLine();

            #endregion
        }

        static void MiTarea()
        {
            Console.WriteLine("MiTarea() Nro.:" + Task.CurrentId + " iniciando");

            for (int contador = 0; contador < 10; contador++)
            {
                Thread.Sleep(500);
                Console.WriteLine("En MiTarea(), contador: " + contador);
            }

            Console.WriteLine("MiTarea() Nro.:" + Task.CurrentId + " terminando....");
        }
    }
}
