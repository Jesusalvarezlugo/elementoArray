using elementoArray.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elementoArray.Servicios
{
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void aniadirElemento(VajillaDto[] tabAntigua)
        {
                              
            for(int i = 0; i < tabAntigua.Length; i++)
            {
                if(tabAntigua[i] == null)
                {
                    tabAntigua[i] = crearElemento();
                    break;
                }
            }
            
        }

        private VajillaDto crearElemento()
        {
            VajillaDto vajillaN=new VajillaDto();

            Console.WriteLine("Introduzca el id del elemento: ");
            vajillaN.IdElemento = Int64.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el nombre del elemento: ");
            vajillaN.NombreElemento = Console.ReadLine();
            Console.WriteLine("Introduzca la descripcion del elemento: ");
            vajillaN.DescripcionElemento = Console.ReadLine();
            Console.WriteLine("Introduzca la cantidad del elemento: ");
            vajillaN.CantidadElemento = Int32.Parse(Console.ReadLine());
            
            return vajillaN;
        }
    }
}
