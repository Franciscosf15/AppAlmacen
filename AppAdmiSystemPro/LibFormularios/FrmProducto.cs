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
    public partial class FrmProducto : FrmPadre
    {
        public FrmProducto()
        {
            InitializeComponent();
            IniciarEntidad(new cProducto());
            BtnEliminar.Visible = false;
            BtnImprimir.Visible = false;
            TxtCodProducto.Focus();
        }
        // METODOS SOBREESCRITOS DE LA CLASE PADRE -----------------------------------------------------------------
        // Establecer valores que iran en la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtCodProducto.Text.Trim().ToUpper(), TxtDescripcion.Text.Trim(), TxtUnidad.Text.Trim(), TxtMarca.Text.Trim(), TxtStock.Text.Trim(), TxtPrecio.Text.Trim() };
        }
        // Mostrar datos de un registro
        public override void MostrarDatos()
        {
            TxtDescripcion.Text = aEntidad.ValorAtributo("Descripcion").ToString();
            TxtMarca.Text = aEntidad.ValorAtributo("Marca").ToString();
            TxtUnidad.Text = aEntidad.ValorAtributo("Unidad").ToString();
            TxtPrecio.Text = aEntidad.ValorAtributo("Precio").ToString();
            TxtStock.Text = aEntidad.ValorAtributo("Stock").ToString();
        }
        //Inicializar atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtCodProducto.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtDescripcion.Text = "";
            TxtMarca.Text = "";
            TxtPrecio.Text = "";
            TxtStock.Text = "";
            TxtUnidad.Text = "";
        }
        // Listar los registros y mostrarlos en el DataGrid
        public override void ListarRegistros()
        {
            
        }
        // Verificar los campos obligatorios
        public override string EsRegistroValido()
        {
            if (TxtCodProducto.Text.Trim() != "" && TxtDescripcion.Text.Trim() != "" && TxtMarca.Text.Trim() != ""  && TxtPrecio.Text.Trim() != "" && TxtStock.Text.Trim() != "" && TxtUnidad.Text.Trim() != "")
            {
                if (TxtCodProducto.Text.Trim().Length >= 6)
                {
                    ValidadTxtPrecio();
                    // Verificar que el precio y stock sean diferentes a 0
                    if (float.Parse(TxtPrecio.Text.Trim()) != 0 && int.Parse(TxtStock.Text.Trim()) != 0)
                    {
                        return "Si";
                    }
                    else
                    {
                        return "El precio y el stock deben ser diferentes a 0.";
                    }
                }else
                {
                    return "El codigo debe tener por lo menos 6 digitos.";
                }                    
            }
            else
            {
                return "Debe llenar todo el formulario.";
            }
        }
        // METODOS PROPIOS ------------------------------------------------------------------------------------------
        // Metodo que valida el TextBox Precio
        private void ValidadTxtPrecio()
        {
            if (TxtPrecio.Text.Trim().Substring(0, 1) == ".")
            {
                TxtPrecio.Text = "0" + TxtPrecio.Text.Trim();
            }
            if (TxtPrecio.Text.Trim().Substring(TxtPrecio.Text.Trim().Length - 1, 1) == ".")
            {
                TxtPrecio.Text = TxtPrecio.Text.Trim() + "0";
            }
        }

        // EVENTOS --------------------------------------------------------------------------------------------------
        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {   // Bloqueamos todas las teclas execto los numeros y la tecla de borrado
            char Key = e.KeyChar;
            // tecla de borrar: 8
            if (!char.IsDigit(Key) && Key != 8)
            {
                e.Handled = true;
            }
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {   // Bloqueamos todas las teclas execto los numeros, la tecla de borrado y el punto
            char Key = e.KeyChar;
            int NroPuntos = 0;
            // Calculamos el numero de puntos ingresados
            for (int i = 0; i < TxtPrecio.Text.Trim().Length; i++)
            {
                if (TxtPrecio.Text.Trim().Substring(i, 1) == ".")
                {
                    NroPuntos++;
                    break;
                }
            }
            if (NroPuntos == 0) // Si aun no ingreso alguno
            {
                if (!char.IsDigit(Key) && Key != 8 && Key != 46 && Key != 127)
                {
                    e.Handled = true;
                }
            }
            else // Si ya ingreso un punto, bloqueamos la tecla
            {
                if (!char.IsDigit(Key) && Key != 8 && Key != 127)
                {
                    e.Handled = true;
                }
            }
        }

        private void TxtCodProducto_Leave(object sender, EventArgs e)
        {
            ProcesarClave();
        }

        private void DgvProductos_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {   // Bloqueamos todas las teclas execto los numeros y la tecla de borrado
            char Key = e.KeyChar;
            // tecla de borrar: 8
            if (char.IsDigit(Key))
            {
                e.Handled = true;
            }
        }
    }
}
