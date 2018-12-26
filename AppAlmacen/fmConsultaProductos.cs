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
    public partial class fmConsultaProductos : Form
    {
        private CProducto aProducto;
        public fmConsultaProductos()
        {
            InitializeComponent();
            aProducto = new CProducto();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgvProductos.DataSource = aProducto.Listado().Tables[0];
        }
        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}