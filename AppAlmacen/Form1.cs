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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buNuevo_Click(object sender, EventArgs e)
        {

        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmCliente c = new fmCliente();
            c.Show();
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmProducto p = new fmProducto();
            p.Show();
        }

        private void documentoVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmFactura f = new fmFactura();
            f.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmConsultaCliente c = new fmConsultaCliente();
            c.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmConsultaProductos p = new fmConsultaProductos();
            p.Show();
        }

        private void tipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmTipoProducto t = new fmTipoProducto();
            t.Show();
        }
    }
}
