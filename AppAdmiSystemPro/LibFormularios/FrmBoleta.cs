using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTablas;

namespace LibFormularios
{
    public partial class FrmBoleta : FrmPadre
    {
        // ATRIBUTOS -----------------------------------------------------------------------------------------------
        private cEntidad aDetalleBoleta = new cDetalleBoleta();
        private cEntidad aProducto = new cProducto();
        string aIdUsuario;

        // CONSTRUCTOR ----------------------------------------------------------------------------------------------
        public FrmBoleta(string pIdUsuario)
        {
            InitializeComponent();
            aIdUsuario = pIdUsuario;
            IniciarEntidad(new cBoleta());
            DtpFecha.Value = DateTime.Now;
            BtnGuardar.Visible = false;
            BtnImprimir.Visible = false;
            BtnEliminar.Visible = false;
            this.DgvAux.DataSource = aProducto.ListaGeneral();
            Siguiente();
        }

        // METODOS SOBREESCRITOS DE LA CLASE PADRE -----------------------------------------------------------------
        // Establecer valores que iran en la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtNroBoleta.Text.Trim(), TxtCliente.Text.Trim(), DtpFecha.Value.ToString().Substring(0, 10), aIdUsuario };
        }
        // Mostrar datos de un registro
        public override void MostrarDatos()
        {   // Recuperamos los datos del documento de venta
            /*string[] Atributos = AsignarValoresAtributos();
            aEntidad.Registro(Atributos);
            string Fecha = aEntidad.ValorAtributo("Fecha");
            DtpFecha.Text = Fecha;
            LblTipo.Visible = true;
            LblTipo.Text = aEntidad.ValorAtributo("Tipo");
            TxtCodCliente.Text = aEntidad.ValorAtributo("CodCliente");
            // Mostrar datos cliente
            MostrarDatosCliente();
            // Recuperamos los datos del detalle de venta al grid
            DgvMuestra.DataSource = aDetalleVenta.Registro(new string[] { TxtNroDocVenta.Text, "Aux" });
            DgvMuestra.Visible = true;
            CalcularTotal(DgvMuestra);
            // Bloqueamos algunos campos
            TxtCantidad.Enabled = false;
            BtnAgregar.Enabled = false;
            BtnCodCliente.Enabled = false;
            //BtnCodProducto.Enabled = false;
            BtnGrabar.Enabled = false;
            DgvMuestra.Enabled = false;
            BtnNuevo.Focus();*/
        }
        //Inicializar atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {   // Ir al siguiente documento de venta
            Siguiente();
        }
        public override void InicializarAtributosNoClave()
        {
            // Limpiamos datos del producto y del cliente
            TxtCliente.Text = "";
            FormatearDatosProducto();
            // Limpiamos el grid
            for (int i = DgvVenta.RowCount - 1; i >= 0; i--)
            {
                DgvVenta.Rows.RemoveAt(i);
            }
            // Limpiamos los demas campos
            LblTotalEnLetras.Text = "";
            LblTotal.Text = "";
            // Actualizamos la fecha
            DtpFecha.Value = DateTime.Now;
        }
        // Listar los registros y mostrarlos en el DataGrid
        public override void ListarRegistros()
        {

        }
        // Verificar los campos obligatorios
        public override string EsRegistroValido()
        {
            if (TxtCliente.Text.Trim() != "" && TxtNroBoleta.Text.Trim() != "")
            {
                return "Si";
            }
            else
            {
                return "Llenar los campos obligatorios:\n1. Nombre del cliente\n2. Numero del documento de venta";
            }
        }

        // METODOS PROPIOS -----------------------------------------------------------------------------------------
        // Modulo que aumenta ceros a la izquierda
        public string AumetarCeros(int pNumero)
        {
            int Aux = pNumero.ToString().Length;
            string Cadena = pNumero.ToString();
            for (int i = 0; i < 5 - Aux; i++)
            {
                Cadena = "0" + Cadena;
            }
            return Cadena;
        }
        // Modulo que nos da el numero de boleta
        public void Siguiente()
        {
            try
            {
                string Boleta = aEntidad.UltimaBoleta().Rows[0][0].ToString();
                int Aux = int.Parse(Boleta.Substring(2, 5)) + 1;
                TxtNroBoleta.Text = "B-" + AumetarCeros(Aux);
            }
            catch
            {
                TxtNroBoleta.Text = "B-00001";
            }
        }
        // Modulo que formatea los textbox del producto
        public void FormatearDatosProducto()
        {
            TxtCodProducto.Text = "";
            TxtUnidadMedida.Text = "";
            TxtMarca.Text = "";
            TxtDescripcion.Text = "";
            TxtStock.Text = "";
            TxtPrecio.Text = "";
            TxtCantidad.Text = "1";
        }
        // Modulo que escribe un numero
        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            return Num2Text;
        }
        // Calcular el total del Grid
        public void CalcularTotal(DataGridView pGrid)
        {
            try
            {
                if (pGrid.Rows.Count >= 1)
                {
                    double Total = 0;
                    for (int i = 0; i < pGrid.Rows.Count; i++)
                    {
                        Total += double.Parse(pGrid[6, i].Value.ToString());
                    }
                    LblTotal.Text = Total.ToString();
                    LblTotalEnLetras.Text = toText(Total);
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }
        // Modulo que busca un codigo en el grid
        public int BuscarCodigo(string pCodigo, DataGridView pGrid)
        {
            int Pos = -1;
            if (pGrid.Rows.Count >= 1)
            {
                for (int i = 0; i < pGrid.Rows.Count; i++)
                {
                    if (pCodigo == pGrid[0, i].Value.ToString())
                    {
                        Pos = i;
                        break;
                    }
                }
            }
            return Pos;
        }
        // Metodo que llena los campos del producto
        private void MostrarDatosProducto()
        {
            string[] Atributos = new string[] { TxtCodProducto.Text };
            if (aProducto.ExisteClavePrimaria(Atributos))
            {   // Registro existente, recuperar atributos y mostrarlos
                int Posicion = BuscarCodigo(TxtCodProducto.Text.Trim().ToUpper(), DgvAux);
                TxtDescripcion.Text = aProducto.ValorAtributo("Descripcion").ToString();
                TxtMarca.Text = aProducto.ValorAtributo("Marca").ToString();
                TxtUnidadMedida.Text = aProducto.ValorAtributo("Unidad").ToString();
                TxtPrecio.Text = aProducto.ValorAtributo("Precio").ToString();
                try
                {
                    TxtStock.Text = DgvAux["Stock", Posicion].Value.ToString();
                }
                catch { }
            }
            else
            {
                if (!(TxtCodProducto.Text.Trim() == ""))
                {
                    MessageBox.Show("El producto no existe.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            TxtCantidad.Select();
        }
        // Modulo que actualiza el stock dependiendo de la cantidad
        public void ActualizarStock(string Cantidad, int Posicion)
        {
            DgvAux["Stock", Posicion].Value = int.Parse(DgvAux["Stock", Posicion].Value.ToString()) - int.Parse(Cantidad);
        }
        // Modulo que borra una fila del frid
        private void BorrarFila(DataGridViewCellEventArgs e)
        {   // Determinar las coordenadas de la celda que cambio
            int fila = e.RowIndex;
            int columna = e.ColumnIndex;
            Console.WriteLine(columna);
            try
            {
                if (columna == 7) // Columna de botones de borrado
                {
                    string CodProducto = DgvVenta["colCodigo", fila].Value.ToString();
                    int Posicion = BuscarCodigo(CodProducto, DgvAux);
                    int Cant = int.Parse(DgvVenta["colCantidad", fila].Value.ToString()) * -1;
                    if (CodProducto == TxtCodProducto.Text)
                    {
                        TxtStock.Text = (int.Parse(TxtStock.Text) - Cant).ToString();
                    }
                    Console.WriteLine(Cant);
                    DgvVenta.Rows.RemoveAt(fila);
                    ActualizarStock(Cant.ToString(), Posicion);
                    CalcularTotal(DgvVenta);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Imposible eliminar fila sin informacion.", "ERROR");
            }
        }
        // Metodo que agrega un producto al Grid
        private void Agregar()
        {   // Validar que los campos obligatorios estan llenos
            if (TxtCodProducto.Text.Trim() != "" && TxtCantidad.Text.Trim() != "")
            {
                int Posicion = BuscarCodigo(TxtCodProducto.Text.Trim().ToUpper(), DgvAux);
                double Cant = double.Parse(TxtCantidad.Text);
                if (Cant <= double.Parse(TxtStock.Text))
                {   // Si la cantidad cubre el stock maximo
                    int Pos = BuscarCodigo(TxtCodProducto.Text.Trim(), DgvVenta);
                    if (Pos == -1)
                    {   // Si el codigo ingresado no esta en el grid, agrega una fila
                        double Precio = double.Parse(TxtPrecio.Text);
                        double SubTotal = Cant * Precio;
                        string[] Fila = { TxtCodProducto.Text, TxtCantidad.Text, TxtUnidadMedida.Text, TxtMarca.Text, TxtDescripcion.Text, TxtPrecio.Text, SubTotal.ToString() };
                        // Nueva fila en el grid
                        DgvVenta.Rows.Add(Fila);
                    }
                    else
                    {   // Si esta, solo aumenta la cantidad y por tanto el subtotal
                        DgvVenta["colCantidad", Pos].Value = (int.Parse(DgvVenta["colCantidad", Pos].Value.ToString()) + int.Parse(TxtCantidad.Text));
                        Cant = int.Parse(DgvVenta["colCantidad", Pos].Value.ToString());
                        double SubTotal = Cant * double.Parse(TxtPrecio.Text);
                        DgvVenta["colSubTotal", Pos].Value = SubTotal.ToString();
                    }
                    TxtCodProducto.Focus();
                    CalcularTotal(DgvVenta);
                    ActualizarStock(TxtCantidad.Text, Posicion);
                    FormatearDatosProducto();
                }
                else // Si se pasa 
                {
                    MessageBox.Show("El stock de este producto no puede cubrir la cantidad digitada!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TxtCantidad.Text = TxtStock.Text;
                    TxtCantidad.Select();
                }
            }
            else
            {   // Mensaje
                MessageBox.Show("Llenar los campos obligatorios:\n1. Codigo del Producto\n2. Cantidad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Modulo que recupera los datos del producto
        private void RecuperarCodigoProducto()
        {
            FrmListaProductos fProductos = new FrmListaProductos("ListaSimple");
            fProductos.DarFormato();
            if (fProductos.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                TxtCodProducto.Text = fProductos.RecuperarCodigo();
            }
            MostrarDatosProducto();
        }
        // Modulo que actualiza el Stock de los productos en la base de datos
        public void ActualizarBD()
        {
            for (int i = 0; i < DgvAux.RowCount; i++)
            {   // Actualizamos cada producto en el grid
                aProducto.Actualizar(DgvAux[0, i].Value.ToString(), DgvAux[1, i].Value.ToString(), DgvAux[2, i].Value.ToString(), DgvAux[3, i].Value.ToString(), DgvAux[4, i].Value.ToString(), DgvAux[5, i].Value.ToString());
            }
        }
        // Modulo que inserta detalles de la venta
        public void InsertarDetalleVenta()
        {
            //('F001-001','P001','3','13.00')
            for (int i = 0; i < DgvVenta.RowCount; i++)
            {
                aDetalleBoleta.Insertar(TxtNroBoleta.Text, DgvVenta["colCodigo", i].Value.ToString(), DgvVenta["colCantidad", i].Value.ToString(), DgvVenta["colPrecio", i].Value.ToString());
            }
        }
        // Modulo que guarda los datos introducidos en el documento de venta
        public void Grabar()
        {   // Validar que los campos obligatorios esten llenos
            if (EsRegistroValido() == "Si")
            {   // Vefiricar que hayan productos ingresados
                if (DgvVenta.RowCount > 0)
                {   // Actualizamos stock en la BD
                    ActualizarBD();
                    // Insertamos el documento de venta en la BD
                    string[] Atributos = AsignarValoresAtributos();
                    aEntidad.Insertar(Atributos);
                    // Insertamos los detalles del documento de venta
                    InsertarDetalleVenta();
                    // Formateamos
                    InicializarAtributos();
                    // Mensaje de confirmacion
                    MessageBox.Show("SE GUARDO CORRECTAMENTE.");
                }
                else
                {
                    MessageBox.Show("Agregar al menos un producto!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {   // Mensaje
                MessageBox.Show(EsRegistroValido(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // EVENTOS -------------------------------------------------------------------------------------

        private void BtnCodProducto_Click(object sender, EventArgs e)
        {
            RecuperarCodigoProducto();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void DgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BorrarFila(e);
        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {   // Bloqueamos todas las teclas execto los numeros y la tecla de borrado
            char Key = e.KeyChar;
            // tecla de borrar: 8
            if (!char.IsDigit(Key) && Key != 8)
            {
                e.Handled = true;
            }
        }

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            Grabar();
        }
    }
}
