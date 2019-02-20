using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTablas
{
    public class cBoleta : cEntidad
    {
        // ATRIBUTOS --------------------------------------------------
        // Todos heredados
        // CONSTRUCTORES ----------------------------------------------
        public cBoleta() : base("TBoleta", 1)
        {
        }
        // Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            string[] Aux = new string[] { "NroBoleta", "Cliente", "Unidad", "Fecha", "IdAdministrador" };
            return Aux;
        }
    }
}
