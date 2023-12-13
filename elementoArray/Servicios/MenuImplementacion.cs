using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elementoArray.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            int opcion;

            Console.WriteLine("################");
            Console.WriteLine("0. Salir");
            Console.WriteLine("1. Añadir elemento");
            Console.WriteLine("################");
            Console.WriteLine("Introduzca una opcion: ");
            opcion=Int32.Parse(Console.ReadLine());

            return opcion;
        }
    }
}
