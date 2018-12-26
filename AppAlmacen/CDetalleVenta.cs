using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppAlmacen
{
    class CDetalleVenta
    {
        private SqlConnection aConexion;
        private SqlDataAdapter aAdapter;
        private DataSet aDatos;
        private bool aNuevo;
        public CDetalleVenta()
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
        public void Insertar(string pNroDocVenta, string pCodProducto, string pCantidad, string pPrecioUnitario)
        {
            string CadenaInsertar = "insert into TDetalleVenta values ('" + pNroDocVenta + "', '" +
                pCodProducto + "', '" + pCantidad + "', '" + pPrecioUnitario + "')";
            SqlCommand oComando = new SqlCommand(CadenaInsertar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();//Ejecucion sin esperar respuesta
            aConexion.Close();
            aNuevo = false;
        }
        public void Actualizar(string pNroDocVenta, string pCodProducto, string pCantidad, string pPrecioUnitario)
        {
            // Formar la cadena de insercion
            string CadenaActualizar = "update TDocVenta set CodProducto='" + pCodProducto + "'," +//update: actualizar
                   "Cantidad='" + pCantidad + "'," +
                   "PrecioUnitario='" + pPrecioUnitario + "'," +
                   "where NroDocVenta='" + pNroDocVenta + "'";
            //Actualizar el registro
            SqlCommand oComando = new SqlCommand(CadenaActualizar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
        public bool ExisteClave(string pCodPro)
        {
            string CadenaConsulta = "select * from TDetalleVenta where NroDocVenta='" + pCodPro + "'";
            //ejecutar la consulta
            //ejecutar consulta
            aAdapter.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();

            aAdapter.Fill(aDatos);
            return (aDatos.Tables[0].Rows.Count > 0);
        }
        public Object ValorAtributo(string pNombreCamp)
        {
            return aDatos.Tables[0].Rows[0][pNombreCamp];
        }
    }
}
