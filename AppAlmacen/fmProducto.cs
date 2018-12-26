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
    public partial class fmProducto : Form
    {
        private CProducto aProduc;
        private CTipoProducto aTipoProducto;
        public fmProducto()
        {
            InitializeComponent();
            aProduc = new CProducto();
            aTipoProducto = new CTipoProducto();
            CargarComboUnidadMedida();
            CargarComboTipoProducto();
            CargarGrid();
        }
        public void LimpiarFormulario()
        {
            tbCod.Clear();
            tbProd.Clear();
            tbMarca.Clear();
            tbUnidMed.Clear();
            tbStock.Clear();
            tbPU.Clear();
            tbCodTipPro.Clear();
            tbCod.Enabled = true;
            aProduc.Nuevo = true;
        }
        
        private void buGuardar_Click(object sender, EventArgs e)
        {
            if (aProduc.Nuevo)
                Insertar();
            else
                Actualizar();
            
        }
        public void CargarGrid()
        {
            dgvProduc.DataSource = aProduc.Listado().Tables[0];
        }
        public void Insertar()
        {// validar que los datos obligatorios esten completos
            if (tbCod.Text.Trim() != "" && tbProd.Text.Trim() != ""
                && tbMarca.Text != "" && cbUnidadMedida.Text != "" && tbStock.Text != "" && tbPU.Text != "")
            {
                aProduc.Insertar(tbCod.Text, tbProd.Text, tbMarca.Text, tbUnidMed.Text, tbPU.Text, tbStock.Text, cbCodTipoPro.SelectedValue.ToString());
                tbCod.Enabled = false;
                tbUnidMed.Text = cbUnidadMedida.Text;
                tbCodTipPro.Text = cbCodTipoPro.SelectedValue.ToString();
                MessageBox.Show("Registro guardado exitosamente");
                CargarGrid();
            }
            else
            {
                MessageBox.Show("Ingrese los datos completo");
            }
        }
        public void Actualizar()
        {
            if (tbCod.Text.Trim() != "" && tbProd.Text.Trim() != ""
                && tbMarca.Text != "" && cbUnidadMedida.Text != "" && tbStock.Text != "" )
            {
                //ACTUALIZAR REGISTRO
                aProduc.Actualizar(tbCod.Text, tbProd.Text, tbMarca.Text, cbUnidadMedida.Text, tbPU.Text, tbStock.Text, cbCodTipoPro.SelectedValue.ToString());
                MessageBox.Show("Los datos se actualizaron exitosamente");
                CargarGrid();
            }
            else
            {
                MessageBox.Show("Ingrese los datos completos");
            }
        }
        public void CargarRegistro()
        {
            //llena la informacion de de un registro especifico en el formulario
            if (tbCod.Text.Trim() != "")
            {
                aProduc.Registro(tbCod.Text.Trim());
                tbCod.Text = aProduc.ValorAtributo("CodProducto").ToString();
                tbProd.Text = aProduc.ValorAtributo("Producto").ToString();
                tbMarca.Text = aProduc.ValorAtributo("Marca").ToString();
                tbUnidMed.Text = aProduc.ValorAtributo("UnidadMedida").ToString();
                tbPU.Text = aProduc.ValorAtributo("PU").ToString();
                tbStock.Text = aProduc.ValorAtributo("Stock").ToString();
                tbCodTipPro.Text = aProduc.ValorAtributo("CodTipoProducto").ToString();
                tbCod.Enabled = false;
                aProduc.Nuevo = false;
            }
        }
        private void buNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void buNuevo_Click_1(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
        private void CargarComboTipoProducto()
        {
            cbCodTipoPro.DataSource = aTipoProducto.ListadoOrdenado().Tables[0];
            cbCodTipoPro.DisplayMember = "TipoProducto";
            cbCodTipoPro.ValueMember = "CodTipoProducto";
            cbCodTipoPro.SelectedIndex = -1;
        }
        private void CargarComboUnidadMedida()
        {
            cbUnidadMedida.DataSource = aProduc.ListadoOrdenado().Tables[0];
            cbUnidadMedida.DisplayMember ="UnidadMedida";
            cbCodTipoPro.SelectedIndex = -1;
        }
        private void tbCod_Leave(object sender, EventArgs e)
        {
            if (aProduc.ExisteClave(tbCod.Text.Trim()))
                CargarRegistro();
        }
        private void cbCodTipoPro_DropDown(object sender, EventArgs e)
        {

        }
    }
}