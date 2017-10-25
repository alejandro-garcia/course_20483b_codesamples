using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Region Generica
            Generica<string> palabras = new Generica<string>("Lourtec es una institucion...");
            Console.WriteLine("una clase, un resultado: {0}", palabras.RetornarGenerico());

            Generica<int> numeros = new Generica<int>(100);
            Console.WriteLine("resultado clase int: {0}", numeros.RetornarGenerico().ToString());

            DosGenerica<int, int> varios1 = new DosGenerica<int, int>(100, 50);
            DosGenerica<int, string> varios2 = new DosGenerica<int, string>(100, "Caracas");

            Console.WriteLine("resultado clase dosgenerica<int,int> T: {0}", varios1.RetornarGenerico());
            Console.WriteLine("resultado clase dosgenerica<int,int> V: {0}", varios1.RetornarOtroGenerico());

            Console.WriteLine("resultado clase dosgenerica<int,string> T: {0}", varios2.RetornarGenerico());
            Console.WriteLine("resultado clase dosgenerica<int,string> V: {0}", varios2.RetornarOtroGenerico()); 
            #endregion

            #region region no generica

            NoGenerica noGenerica = new NoGenerica("100");

            try
            {
                //int entero = (int)noGenerica.RetornaNoGenerico(); // boxing -- unboxing
                int entero = Convert.ToInt32(noGenerica.RetornaNoGenerico());
                Console.WriteLine("Retornar No Generico (int): {0}", entero.ToString());
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { 
                //close
            }


            NoGenerica noGenerica2 = new NoGenerica("Caracas");

            try
            {
                string cadena = (string)noGenerica2.RetornaNoGenerico(); // boxing -- unboxing              
                Console.WriteLine("Retornar No Generico (string): {0}", cadena);
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //close
            }

            Console.ReadLine();

            #endregion

            
        }
    }

    #region Region Generica

    class Generica<T>
    {
        T generico;
        public Generica(T _generico)
        {
            generico = _generico;
        }
        public T RetornarGenerico()
        {
            return generico;
        }
    }

    class DosGenerica<T, V>
    {
        T generico;
        V otroGenerico;

        public DosGenerica(T _generico, V _otroGenerico)
        {
            generico = _generico;
            otroGenerico = _otroGenerico;
        }

        public T RetornarGenerico()
        {
            return generico;
        }

        public V RetornarOtroGenerico()
        {
            return otroGenerico;
        }
    }

    #endregion

    #region Region no generica

    class NoGenerica
    {
        object objeto;

        public NoGenerica(object _objeto)
        {
            objeto = _objeto;
        }

        public object RetornaNoGenerico()
        {
            return objeto;
        }
    }

    #endregion
}
