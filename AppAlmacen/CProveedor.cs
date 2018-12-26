using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace AppAlmacen
{
    class CProveedor
    {
        private SqlConnection aConexion;
        private SqlDataAdapter aAdapter;
        private DataSet aDatos;
        private bool aNuevo;

        public CProveedor()
        {
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
        public void Insertar(string pCodPro, string pRazonSocial, string pDireccion, string pRuc, string pNombreContacto, string pTelefono)
        {
            string CadenaInsertar = "insert into TProveedor values ('" + pCodPro + "', '" +
                pRazonSocial + "', '" + pDireccion + "', '" + pRuc + "', '" + pNombreContacto + "', '" + pTelefono + "')";
            SqlCommand oComando = new SqlCommand(CadenaInsertar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();//Ejecucion sin esperar respuesta
            aConexion.Close();
            aNuevo = false;
        }
        public void Actualizar(string pCodPro, string pRazonSocial, string pDireccion, string pRuc, string pNombreContacto, string pTelefono)
        {
            // Formar la cadena de insercion
            string CadenaActualizar = "update TProveedor set RazonSocial='" + pRazonSocial + "'," +//update: actualizar
                   "Direccion='" + pDireccion + "'," +
                   "RUC='" + pRuc + "'," +
                   "NombreContacto='" + pNombreContacto + "'," +
                   "Telefono='" + pTelefono + "' " +
                   "where CodProveedor='" + pCodPro + "'";
            //Actualizar el registro
            SqlCommand oComando = new SqlCommand(CadenaActualizar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
        public void Eliminar(string pCodPro)
        {
            // Formar la cadena de insercion
            string CadenaEliminar = "delete from TProveedor where CodProveedor='" + pCodPro + "',";
            //       "where CodLibro='" + pCodLibro + "'";
            //Actualizar el registro
            SqlCommand oComando = new SqlCommand(CadenaEliminar, aConexion);
            aConexion.Open();
            oComando.ExecuteNonQuery();
            aConexion.Close();
        }
        public bool ExisteClave(string pCodClien)
        {
            string CadenaConsulta = "select * from TProveedor where CodProveedor='" + pCodClien + "'";
            //ejecutar la consulta
            //ejecutar consulta
            aAdapter.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();

            aAdapter.Fill(aDatos);
            return (aDatos.Tables[0].Rows.Count > 0);

        }
        public void Registro(string pCodPro)
        {
            //recupera la informacion de un registro
            string CadenaConsulta = "select * from TProveedor where CodProveedor='" + pCodPro + "'";
            //ejecutar consulta
            aAdapter.SelectCommand = new SqlCommand(CadenaConsulta, aConexion);
            aDatos = new DataSet();
            aAdapter.Fill(aDatos);
        }
        public DataSet Listado()
        {
            string CadenaConsulta = "select * from TProveedor";
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
