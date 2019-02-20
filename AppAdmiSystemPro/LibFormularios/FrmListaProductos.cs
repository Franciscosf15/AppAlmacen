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
    public partial class FrmListaProductos : FrmPadre
    {
        public FrmListaProductos(string pTipo)
        {
            InitializeComponent();
            IniciarEntidad(new cProducto());
            if(pTipo == "ListaSimple")
            {
                DgvProductos.DataSource = aEntidad.ListaSimple();
            }else
            {
                DgvProductos.DataSource = aEntidad.ListaGeneral();
            }
            BtnEliminar.Visible = false;
            BtnGuardar.Visible = false;
            BtnImprimir.Visible = false;
            BtnNuevo.Visible = false;
            PtbImagen.Visible = false;
            label2.Visible = false;
        }

        // Modulo que recupera el codigo
        public string RecuperarCodigo()
        {
            return DgvProductos.CurrentRow.Cells[0].Value.ToString();
        }

        // Modulo que da el fromato adecuado al formulario
        public void DarFormato()
        {
            this.Width = 380;
            DgvProductos.Location = new Point(12, 34);
            label2.Visible = true;
        }

        // EVENTOS -----------------------------------------------------------------------------
        private void DgvProductos_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
