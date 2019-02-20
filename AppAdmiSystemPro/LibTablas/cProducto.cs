using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTablas
{
    public class cProducto : cEntidad
    {
        // ATRIBUTOS --------------------------------------------------
        // Todos heredados
        // CONSTRUCTORES ----------------------------------------------
        public cProducto() : base("TProducto", 1)
        {
        }
        // Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            string[] Aux = new string[] { "CodProducto", "Descripcion", "Marca", "Stock", "Precio" };
            return Aux;
        }
    }
}
