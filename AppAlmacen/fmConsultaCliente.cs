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
    public partial class fmConsultaCliente : Form
    {
        private CCliente aCliente;
        public fmConsultaCliente()
        {
            InitializeComponent();
            aCliente = new CCliente();
            CargarGrid();
        }
        public void CargarGrid()
        {
            dgvClientes.DataSource = aCliente.Listado().Tables[0];
        }
        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
