using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTablas
{
    public class cUsuario : cEntidad
    {
        // ATRIBUTOS --------------------------------------------------
        // Todos heredados
        // CONSTRUCTORES ----------------------------------------------
        public cUsuario() : base("TUsuario", 1)
        {
        }
        // Implementacion de metodos abstractos
        public override string[] NombresAtributos()
        {
            string[] Aux = new string[] { "IdUsuario", "Nombres", "Contraseña", "NivelAcceso" };
            return Aux;
        }
    }
}
