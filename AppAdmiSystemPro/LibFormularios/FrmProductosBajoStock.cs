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
    public partial class FrmProductosBajoStock : FrmPadre
    {
        public FrmProductosBajoStock()
        {
            InitializeComponent();
            IniciarEntidad(new cProducto());
            BtnEliminar.Visible = false;
            BtnGuardar.Visible = false;
            BtnImprimir.Visible = false;
            BtnNuevo.Visible = false;
            PtbImagen.Visible = false;
            DgvProductos.DataSource = aEntidad.ProductosStockBajo();
        }
    }
}
