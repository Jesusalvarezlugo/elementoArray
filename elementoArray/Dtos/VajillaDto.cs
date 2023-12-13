using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elementoArray.Dtos
{
    internal class VajillaDto
    {
        //atributos

        long idElemento=0;
        string codigoElemento="aaaaa";
        string nombreElemento="aaaaa";
        string descripcionElemento = "aaaaa";
        int cantidadElemento=0;



        //Getters y Setters

        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }

        //Constructores

        public VajillaDto()
        {

        }

        public VajillaDto(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = idElemento+nombreElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }

        


        //Método ToString

        override
        public string ToString()
        {
            string texto="Nombre: "+this.nombreElemento+"\n Cantidad: "+this.cantidadElemento;

            return texto;
        }
        
    }
}
