using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine("Valor de x: {0}", x);
            Console.WriteLine("Valor de x: {0}", x.ToString());
            string Mutable = "Instituto";
            Mutable += " tecnologico";
            Mutable += " Lourtec";
            Console.WriteLine(Mutable);
            StringBuilder noMotuble = new StringBuilder();
            noMotuble.Append("Instituto");
            noMotuble.Append(" Tecnologico");
            noMotuble.Append(" Lourtec");
            Console.WriteLine(RetornaEnteros(10));
            
            MiClase obj = new MiClase("alejandro");
            string Nombre = obj.misDatos();
            Console.WriteLine(obj.misDatos());
            obj.modificarNombre(ref Nombre);
            Console.WriteLine(Nombre);
            Console.ReadLine();
        }

        static int RetornaEnteros(int y)
        {
            return y*45;
        }
    }

    public class MiClase
    {
        string nombre;      

        public MiClase(string _nombre)
        {
            this.nombre = _nombre;
        }
        public string misDatos()
        {
            return nombre;
        }
        public void modificarNombre(ref string _nombre)
        {
            _nombre += " mas datos";
        }
    }
}
