using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAlmacen
{
    public partial class fmConsultaFactura : Form
    {
        private CDocVenta aDocVenta;
        private CCliente aNuevoC;
        public fmConsultaFactura()
        {
            InitializeComponent();
            aDocVenta = new CDocVenta();
            aNuevoC = new CCliente();
        }
        public void CargarGrid()
        {
            fmFactura j = new fmFactura();
            //tbNroDo.Text=j.tb
            dgvDetalleVenta.DataSource = aDocVenta.RecuperarDetalleVenta(tbNroDo.Text);
        }
        private void CargarRegistroDocVenta()
        {
            if (tbNroDo.Text.Trim() != "")
            {
                aDocVenta.Registro(tbNroDo.Text.Trim());
                tbNroDo.Text = aDocVenta.ValorAtributo("NroDocVenta").ToString();
                tbCodCliente.Text = aDocVenta.ValorAtributo("CodCliente").ToString();
                tbFecha.Text = aDocVenta.ValorAtributo("Fecha").ToString();
                cbTipo.Text = aDocVenta.ValorAtributo("Tipo").ToString();

                //Recuperar datos del cliente
                CargarRegistroCliente();
                //recuperar detalle venta
                dgvDetalleVenta.DataSource = aDocVenta.RecuperarDetalleVenta(tbNroDo.Text).Tables[0];

            }
        }
        public void CargarRegistroCliente()
        {
            //llena la informacion de de un registro especifico en el formulario
            if (tbCodCliente.Text.Trim() != "")
            {
                //en este metodo se realiza la recuperacion en el detalle-factura
                aNuevoC.Registro(tbCodCliente.Text.Trim());
                tbCodCliente.Text = aNuevoC.ValorAtributo("CodCliente").ToString();
                tbNombre.Text = aNuevoC.ValorAtributo("Nombre").ToString();
                tbDireccion.Text = aNuevoC.ValorAtributo("Direccion").ToString();
                tbTelefono.Text = aNuevoC.ValorAtributo("Telefono").ToString();
                tbRuc.Text = aNuevoC.ValorAtributo("Ruc").ToString();
                //tbCodTipPro.Text = aProduc.ValorAtributo("CodTipoProducto").ToString();
                tbCodCliente.Enabled = false;
                aNuevoC.Nuevo = false;
            }
        }
        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
