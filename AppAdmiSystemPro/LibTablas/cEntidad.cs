using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregamos
using System.Data;
using System.Data.SqlClient;

namespace LibTablas
{
    public abstract class cEntidad
    {
        // ATRIBUTOS --------------------------------------------------
        private cConexion aConexion;
        private string aNombreTabla;
        private int aNroClavesPrimarias;
        string[] aNombres = null; // Nombres de los campos de la tabla
        string[] aValores = null; // Valores de los campos de la tabla
        private bool aNuevo;
        // CONSTRUCTORES ----------------------------------------------
        public cEntidad(string pNombreTabla, int pNroClavesPrimarias)
        {
            aNuevo = true;
            aNombreTabla = pNombreTabla;
            aNroClavesPrimarias = pNroClavesPrimarias;
            aConexion = new cConexion();
            aNombres = NombresAtributos();
            aValores = null;
        }
        // PROPIEDADES-------------------------------------------------
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }

        // METODOS DE SOPORTE DE LA BD --------------------------------
        public abstract string[] NombresAtributos();

        // METODOS PARA EL MANTENIMIENTO DE LA TABLA
        // Insercion de nuevos registros
        public virtual void Insertar(params string[] pAtributos) // PARAMS: Numero de parametros variable
        {   // Permite insertar informacion de un registro en la tabla
            // Recuperar los valores de los atributos
            aValores = pAtributos;
            // Formar cadena de insercion
            string CadenaInsertar = "exec spu" + aNombreTabla + "_Insertar '";
            for (int k = 0; k < aValores.Length; k++)
            {   // Incluir los valores en la consulta
                CadenaInsertar += aValores[k];
                if (k == aValores.Length - 1)
                {   // Concatenamos el ultimo atributo
                    CadenaInsertar += "'";
                }
                else
                {   // Dejar la consulta lista para el siguiente atributo
                    CadenaInsertar += "', '";
                }
            }
            aConexion.EjecutarSelect(CadenaInsertar);
            // Verificar resultado de insercion
            if (ValorAtributo("CodError") == "0")
            {
                aNuevo = false;
            }
        }
        // Actualizacion de registros
        public void Actualizar(params string[] pAtributos)
        {   // Permite actualizar la informacion de un registro de la tabla
            // Recuperar los valores de los atributos de la tabla.
            aValores = pAtributos;
            // Formar cadena de actualizacion
            string CadenaActualizar = "exec spu" + aNombreTabla + "_Actualizar '";
            for (int k = 0; k < aValores.Length; k++)
            {   // Incluir los valores en la consulta
                CadenaActualizar += aValores[k];
                if (k == aValores.Length - 1)
                {   // Concatenamos el ultimo atributo
                    CadenaActualizar += "'";
                }
                else
                {   // Dejar la consulta lista para el siguiente atributo
                    CadenaActualizar += "', '";
                }
            }
            aConexion.EjecutarSelect(CadenaActualizar);
        }
        // Eliminacion de un registro
        public void Eliminar(params string[] Atributos)
        {   // Permite eliminar un registro
            // Recuperar los valores de los atributos de la tabla.
            aValores = Atributos;
            // Formar cadena de eliminacion
            string CadenaEliminar = "exec spu" + aNombreTabla + "_Eliminar '";
            for (int i = 0; i < aNroClavesPrimarias; i++)
            {
                CadenaEliminar += aValores[i];
                if (i == aNroClavesPrimarias - 1)
                {   // Cuando se concatena el ultimo atributo
                    CadenaEliminar += "'";
                }
                else
                {   // Dejar la consulta lista para el siguiente atributo
                    CadenaEliminar += "', '";
                }
            }
            // Ejecutar la consulta para eliminar el registro
            aConexion.EjecutarSelect(CadenaEliminar);
        }

        public bool ExisteClavePrimaria(params string[] Atributos)
        {   // Verifica si un registro especifico existe
            // Recuperar los valores de los atributos de la tabla.
            aValores = Atributos;
            // Formar la consulta
            string CadenaConsulta = "exec spu" + aNombreTabla + "_Registro '";
            for (int i = 0; i < aNroClavesPrimarias; i++)
            {
                CadenaConsulta += aValores[i];
                if (i == aNroClavesPrimarias - 1)
                {   // Cuando se concatena el ultimo atributo
                    CadenaConsulta += "'";
                }
                else
                {   // Dejar la consulta lista para el siguiente atributo
                    CadenaConsulta += "', '";
                }
            }
            // Ejecutar la consulta
            aConexion.EjecutarSelect(CadenaConsulta);
            // Si existen registros en la tabla 0 del dataset, la clave primaria existe
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }

        public DataTable Registro(params string[] Atributos)
        {   // Recupera la informacion de un registro
            // Recuperar los valores de los atributos de la tabla.
            aValores = Atributos;
            // Formar la consulta
            string CadenaConsulta = "exec spu" + aNombreTabla + "_Registro '";
            for (int i = 0; i < aNroClavesPrimarias; i++)
            {
                CadenaConsulta += aValores[i];
                if (i == aNroClavesPrimarias - 1)
                {   // Cuando se concatena el ultimo atributo
                    CadenaConsulta += "'";
                }
                else
                {   // Dejar la consulta lista para el siguiente atributo
                    CadenaConsulta += "', '";
                }
            }
            // Ejecutar la consulta y devolver el resultado
            aConexion.EjecutarSelect(CadenaConsulta);
            return aConexion.Datos.Tables[0];
        }

        public string ValorAtributo(string pNombreCampo)
        {   // Recupera el valor del atributo del dataset
            return aConexion.Datos.Tables[0].Rows[0][pNombreCampo].ToString();
        }

        public bool ConsultarUsuario(string pUsuario, string pContraseña)
        {   // Retorna una tabla con la lista completa de libros
            string Consulta = "exec spu" + aNombreTabla + "_Consulta '" + pUsuario + "', '" + pContraseña + "'";
            aConexion.EjecutarSelect(Consulta);
            return (aConexion.Datos.Tables[0].Rows.Count > 0);
        }

        public DataTable ListaGeneral()
        {   // Retorna una tabla con la lista completa de libros
            string Consulta = "exec spu" + aNombreTabla + "_ListadoGeneral";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable ListaSimple()
        {   // Retorna una tabla con la lista completa de libros
            string Consulta = "exec spu" + aNombreTabla + "_ListaSimple";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable ProductosMasVendidos()
        {   // Retorna una tabla con la lista completa de libros
            string Consulta = "exec spu" + aNombreTabla + "_ProductosMasVendidos";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable ProductosStockBajo()
        {   // Retorna una tabla con la lista completa de libros
            string Consulta = "exec spu" + aNombreTabla + "_ProductosStockBajo";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable UltimaBoleta()
        {
            // Retorna una tabla con la lista completa de libros
            string Consulta = "exec spu" + aNombreTabla + "_UltimaBoleta";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }

        public DataTable GananciasPorDia(string pFecha)
        {
            // Retorna una tabla con la lista completa de libros
            string Consulta = "exec spu" + aNombreTabla + "_GananciasPorDia '" + pFecha + "'";
            aConexion.EjecutarSelect(Consulta);
            return aConexion.Datos.Tables[0];
        }
    }
}
