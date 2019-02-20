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
    class cConexion
    {
        // ATRIBUTOS -------------------------
        private SqlConnection aConexion;
        private SqlDataAdapter aAdaptador;
        private DataSet aDatos;
        // CONSTRUCTORES ---------------------
        public cConexion()
        {   // Iniciar la conexion
            aDatos = new DataSet();
            aAdaptador = new SqlDataAdapter();
            // Realizar la conexion
            string CadenaConexion = "Data Source=DESKTOP-K8DG8LV; Initial Catalog=BdAbarrotes;Integrated Security=SSPI;";
            Console.WriteLine(CadenaConexion);
            aConexion = new SqlConnection(CadenaConexion);
        }
        // PROPIEDADES -----------------------
        public SqlConnection Conexion
        {
            get { return aConexion; }
        }
        public SqlDataAdapter Adaptador
        {
            get { return aAdaptador; }
        }
        public DataSet Datos
        {
            get { return aDatos; }
        }
        // SERVICIOS -------------------------
        // Metodos para ejecutar comandos SQL SERVER
        // Devuelve el resultado en la tabla 0 del DataSet
        public virtual DataSet EjecutarSelect(string pConsulta)
        {   // Metodo para ejecutar consultas del tipo SELECT
            aAdaptador.SelectCommand = new SqlCommand(pConsulta, aConexion);
            aDatos = new DataSet();
            aAdaptador.Fill(aDatos);
            return aDatos;
        }
        // Metodo para ejecutar instrucciones DML. No retorna resultado
        public virtual void EjecutarComando(string pComando)
        {   // Metodo para ejecutar consultas del tipo INSERT, UPDATE, DELETE
            SqlCommand oComando = new SqlCommand(pComando, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
    }
}
