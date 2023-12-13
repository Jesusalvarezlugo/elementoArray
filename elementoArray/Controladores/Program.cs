using elementoArray.Dtos;
using elementoArray.Servicios;
using System.Security.Cryptography.X509Certificates;

namespace elementoArray.Controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            VajillaDto[] tablaVajilla=new VajillaDto[5];
            MenuInterfaz mi = new MenuImplementacion();
            OperativaInterfaz oi = new OperativaImplementacion();
            int opcionS;
            bool cerrarMenu = false;

            while (!cerrarMenu)
            {
                opcionS = mi.mostrarMenuYSeleccion();

                switch (opcionS)
                {
                    case 0:
                        Console.WriteLine("Se cerrara el menu");
                        cerrarMenu = true;
                        break;


                    case 1:
                        Console.WriteLine("Se añadira un elemento nuevo");

                        oi.aniadirElemento(tablaVajilla);

                        for(int i = 0; i < tablaVajilla.Length; i++)
                        {

                            Console.WriteLine(tablaVajilla[i].ToString());
                            if (tablaVajilla == null)
                            {
                                tablaVajilla[i] = VajillaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento);
                            }
                        }
                        break;

                    
                }
            }
        }
    }
}
