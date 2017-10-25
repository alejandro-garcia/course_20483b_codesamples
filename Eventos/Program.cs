using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    delegate void Controlador();

    class Program
    {
        static void Main(string[] args)
        {
            MiClick miClick = new MiClick();
            miClick.Click += miClick_Click;
            miClick.Click += OtroClick;
            miClick.OnClick();
            Console.ReadLine();
        }

        static void miClick_Click()
        {
            Console.WriteLine("Hice click...");
        }

        static void OtroClick()
        {
            Console.WriteLine("Hice doble click...");
        }
    }

    class MiClick
    {
        public event Controlador Click;
        public void OnClick()
        {
            if (Click != null) Click();
        }
    }
}
