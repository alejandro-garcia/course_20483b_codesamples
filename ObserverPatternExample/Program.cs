using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            MedidorSensores medidor = new MedidorSensores(10,10,10);
            ObserverDisplay display = new ObserverDisplay(medidor);

            Console.WriteLine("ajustando nivel de aceite");
            medidor.NivelAceite = 80;
            Console.WriteLine("ajustando nivel de agua");
            medidor.NivelAgua = 100;
            Console.WriteLine("ajustando presion neumticos");
            medidor.NivelPresionNeumaticos = 32;

            Console.ReadLine();
        }
    }

    interface ISujeto
    {
        void RegistrarObserver(IObservador obj);
        void EliminarObserver(IObservador obj);
        void NotificarObservadores();
    }
    interface IObservador
    {
        void Actualizar(object o);
    }

    /// <summary>
    /// Subjeto concreto, implementa la intefaz ISujeto para poder registrar observadores
    /// que puedan ser notificados de los cambios en el estado del objeto.
    /// patron: observador
    /// </summary>
    class MedidorSensores: ISujeto
    {
        #region Miembros

        private List<IObservador> observadores = new List<IObservador>();
        
        private int nivelAceite;
        private int nivelAgua;
        private int nivelPresionNeumaticos;

        #endregion

        #region Propiedades

        public int NivelAceite
        {
            get { return nivelAceite; }
            set {
                if (this.nivelAceite != value)
                {
                    nivelAceite = value;
                    NotificarObservadores();
                }
            }
        }

        public int NivelAgua
        {
            get { return nivelAgua; }
            set
            {
                if (this.nivelAgua != value)
                {
                    nivelAgua = value;
                    NotificarObservadores();
                }
            }
        }

        public int NivelPresionNeumaticos
        {
            get { return nivelPresionNeumaticos; }
            set
            {
                if (this.nivelPresionNeumaticos != value)
                {
                    nivelPresionNeumaticos = value;
                    NotificarObservadores();
                }
            }
        }

        #endregion

        #region Constructores

        public MedidorSensores(int _nivelAgua, int _nivelAceite, int _presionNeumaticos)
        {
            this.nivelAceite = _nivelAceite;
            this.nivelAgua = _nivelAgua;
            this.nivelPresionNeumaticos = _presionNeumaticos;
        }

        #endregion

        #region Metodos Interfaz ISujeto

        public void RegistrarObserver(IObservador obj)
        {
            if (!observadores.Contains(obj))
                observadores.Add(obj);
        }

        public void EliminarObserver(IObservador obj)
        {
            if (observadores.Contains(obj))
                observadores.Remove(obj);
        }

        public void NotificarObservadores()
        {
            Dictionary<string, int> valores = new Dictionary<string, int>();
            valores.Add("nivelAceite", this.NivelAceite);
            valores.Add("nivelAgua", this.NivelAgua);
            valores.Add("presionNeumaticos", this.NivelPresionNeumaticos);

            foreach (IObservador observer in observadores)
            {
                observer.Actualizar(valores);
            }
        } 
        
        #endregion
    }

    /// <summary>
    /// Observador concreto, este se subscribe a los cambios que se hagan 
    /// en el objeto MedidorSensores y cuando es notificado de un cambio 
    /// los imprime en consola.
    /// </summary>
    class ObserverDisplay: IObservador
    {
        private ISujeto subject;

        public ObserverDisplay(ISujeto sujeto)
        {
            this.subject = sujeto;
            this.subject.RegistrarObserver(this);

        }
        public void Actualizar(object o)
        {

            Dictionary<string,int> valores = (Dictionary<string,int>)o;

            //valores.Add("nivelAceite", this.NivelAceite);
            //valores.Add("nivelAgua", this.NivelAgua);
            //valores.Add("presionNeumaticos", this.NivelPresionNeumaticos);

            Console.WriteLine("Valores: Agua:{0}, Aceite: {1}, Presion Neumaticos: {2}", valores["nivelAgua"], valores["nivelAceite"], valores["presionNeumaticos"] );
        }
    }
}
