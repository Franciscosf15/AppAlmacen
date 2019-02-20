using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTablas
{
    public class cDetalleBoleta : cEntidad
    {
        // ATRIBUTOS --------------------------------------------------
        // Todos heredados
        // CONSTRUCTORES ----------------------------------------------
        public cDetalleBoleta() : base("TDetalleBoleta", 1)
        {
        }
        // Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            string[] Aux = new string[] { "NroBoleta", "CodProducto", "Cantidad", "Precio" };
            return Aux;
        }
    }
}
