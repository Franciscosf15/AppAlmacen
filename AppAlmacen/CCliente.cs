using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppAlmacen
{
    class CCliente
    {
        private SqlConnection aConexion;
        private SqlDataAdapter aAdapter;
        private DataSet aDatos;
        private bool aNuevo;
        //Constructores
        public CCliente()
        {
            //Inicializar los atributos
            aNuevo = true;
            aDatos = new DataSet();
            aAdapter = new SqlDataAdapter();
            //realizar la conexion
            string CadenaConexion = "Data Source=DESKTOP-UQE736V; Initial Catalog=BDAlmacen;Integrated Security=SSPI;";
            aConexion = new SqlConnection(CadenaConexion);
        }
        public bool Nuevo
        {
            get { return aNuevo; }
            set { aNuevo = value; }
        }
        //----------------------------------------------------------------------------------------
        //                        Metodos de Mantenimiento
        //----------------------------------------------------------------------------------------
        public void Insertar(string pCodigo, string pNombre, string pDireccion, string pTelefono, string pRuc)
        {
            string CadenaInsertar = "insert into TCliente values ('" + pCodigo + "', '" +
                pNombre + "', '" + pDireccion + "', '" + pTelefono + "', '" + pRuc + "')";
            SqlCommand oComando = new SqlCommand(CadenaInsertar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();//Ejecucion sin esperar respuesta
            aConexion.Close();
            aNuevo = false;
        }
        public void Actualizar(string pCodClien, string pNombre, string pDireccion, string pTelefono, string pRuc)
        {
            // Formar la cadena de insercion
            string CadenaActualizar = "update TCliente set Nombre='" + pNombre + "'," +//update: actualizar
                   "Direccion='" + pDireccion + "'," +
                   "Telefono='" + pTelefono + "'," +
                   "Ruc='" + pRuc + "' " +
                   "where CodCliente='" + pCodClien + "'";
            //Actualizar el registro
            SqlCommand oComando = new SqlCommand(CadenaActualizar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
        public void Eliminar(string pCodClien)
        {
            // Formar la cadena de insercion
            string CadenaEliminar = "delete from TCliente where CodCliente='" + pCodClien + "',";
            //       "where CodLibro='" + pCodLibro + "'";
            //Actualizar el registro
            SqlCommand oComando = new SqlCommand(CadenaEliminar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
        public bool ExisteClave(string pCodClien)
        {
            string CadenaConsulta = "select * from TCliente where CodCliente='" + pCodClien + "'";
            //ejecutar la consulta
            //ejecutar consulta
            aAdapter.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();

            aAdapter.Fill(aDatos);
            return (aDatos.Tables[0].Rows.Count > 0);

        }
        public void Registro(string pCodClien)
        {
            //recupera la informacion de un registro
            string CadenaConsulta = "select * from TCliente where CodCliente='" + pCodClien + "'";
            //ejecutar consulta
            aAdapter.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();
            aAdapter.Fill(aDatos);
        }
        public DataSet Listado()
        {
            string CadenaConsulta = "select * from TCliente";
            aAdapter.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();
            aAdapter.Fill(aDatos);
            return aDatos;
        }
        public Object ValorAtributo(string pNombreCamp)
        {
            return aDatos.Tables[0].Rows[0][pNombreCamp];
        }
    }
}