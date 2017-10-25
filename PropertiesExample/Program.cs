using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Edificio edf = new Edificio();
            edf.Nombre = "Prueba";
            edf.Costo = 2000000;
            edf.MostrarDatos();
            Console.ReadLine();
        }
    }

    /// <summary>
    /// Clase de edificio para realizar avaluos
    /// </summary>
    class Edificio
    {
        #region Variable o miembros

        private string nombre;
        private int costo; 
        
        #endregion

        #region Area de Propiedades 

        /// <summary>
        /// Costo de la obra
        /// </summary>
        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        //public int Sueldo { get; set; }


        /// <summary>
        /// Muetra los datos del edificio.
        /// </summary>
        public void MostrarDatos()
        {
            Console.WriteLine("Nombre: {0}, Costo: {1}", this.Nombre, this.Costo);
        }

        #endregion
    }

}
