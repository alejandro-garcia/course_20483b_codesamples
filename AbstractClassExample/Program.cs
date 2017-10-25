using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Forma forma = new DerivadaForma();
            forma.Alto = 25;
            forma.Ancho = 50;
            forma.Nombre = "pepe";
            Console.WriteLine("Area: {0}", forma.Area());
            forma.MostrarDatos();
            forma.VerDatos();           
            Console.ReadLine(); 
        }
    }
    abstract class Forma
    {
        #region Miembros
        
        double ancho;
        double alto;
        string nombre; 
        
        #endregion

        #region Propiedades

        public double Ancho
        {
            get { return ancho; }
            set { ancho = value < 0 ? -value : value; }
        }

        public double Alto
        {
            get { return alto; }
            set { alto = value < 0 ? -value : value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        } 

        #endregion

        #region Constructores

        public Forma()
        {
            Ancho = Alto = 0.0;
            Nombre = string.Empty;
        }

        public Forma(double _ancho, double _alto, string _nombre)
        {
            this.Ancho = _ancho;
            this.Alto = _alto;
            this.Nombre = _nombre;
        }

        public abstract double Area();
        public virtual void VerDatos()
        {
            Console.WriteLine("Sobre escribir");
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Ancho: {0}, Alto: {1}, Nombre: {2}", Ancho.ToString(), Alto.ToString(), Nombre.ToString());
        }

        #endregion

    }

    class DerivadaForma : Forma
    {
        string Estilo; 

        public override double Area()
        {
            return 9.9;
        }

        public override void VerDatos()
        {
            base.VerDatos();
            Console.WriteLine("Ejecutado metodo sobre-escrito");
        }
         
    }
}
