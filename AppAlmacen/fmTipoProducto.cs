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
    public partial class fmTipoProducto : Form
    {
        private CTipoProducto aTipoProducto;
        public fmTipoProducto()
        {
            InitializeComponent();
            aTipoProducto = new CTipoProducto();
            CargarGrid();
        }
        public void LimpiarFormulario()
        {
            tbCod.Clear();
            tbNombre.Clear();
            tbCod.Enabled = true;
            aTipoProducto.Nuevo = true;
        }
        private void buGuardar_Click(object sender, EventArgs e)
        {
            if (aTipoProducto.Nuevo)
                Insertar();
            else
                Actualizar();
        }
        public void CargarGrid()
        {
            dgvTipoProducto.DataSource = aTipoProducto.Listado().Tables[0];
        }
        public void Insertar()
        {// validar que los datos obligatorios esten completos
            if (tbCod.Text.Trim() != "" && tbNombre.Text.Trim() != "")
            {
                aTipoProducto.Insertar(tbCod.Text, tbNombre.Text);
                tbCod.Enabled = false;               
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
            if (tbCod.Text.Trim() != "" && tbNombre.Text.Trim() != "")
            {
                //ACTUALIZAR REGISTRO
                aTipoProducto.Actualizar(tbCod.Text, tbNombre.Text);
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
                aTipoProducto.Registro(tbCod.Text.Trim());
                tbCod.Text = aTipoProducto.ValorAtributo("CodTipoProducto").ToString();
                tbNombre.Text = aTipoProducto.ValorAtributo("TipoProducto").ToString();
 
                tbCod.Enabled = false;
                aTipoProducto.Nuevo = false;
            }
        }

        private void tbCod_Leave(object sender, EventArgs e)
        {
            if (aTipoProducto.ExisteClave(tbCod.Text.Trim()))
                CargarRegistro();
        }

        private void buNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}
