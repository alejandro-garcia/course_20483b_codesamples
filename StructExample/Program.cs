using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomina nom; // = new Nomina("Alejandro", 200000);
            nom.Nombre = "alejandro";
            nom.Sueldo = 1000;

            Console.WriteLine(nom.MostrarDatos());

            Nomina nom2 = new Nomina("Alejandro", 200000);
            Console.WriteLine(nom2.MostrarDatos());
            Console.ReadKey();
        }

    }
    struct Nomina
    {
        public string Nombre;
        public int Sueldo;
        public Nomina(string _nombre, int _sueldo)
        {
            Nombre = _nombre;
            Sueldo = _sueldo;
        }
        public string MostrarDatos()
        {
            return string.Format("Nombre: {0}, Sueldo: {1}", this.Nombre, this.Sueldo);
        }
    }
}
