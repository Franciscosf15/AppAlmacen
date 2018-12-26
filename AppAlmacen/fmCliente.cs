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
    public partial class fmCliente : Form
    {
        private CCliente aCliente;
        public fmCliente()
        {            
            InitializeComponent();
            aCliente = new CCliente();
            CargarGrid();
        }
        public void LimpiarFormulario()
        {
            tbCodClien.Clear();
            tbNombre.Clear();
            tbDireccion.Clear();
            tbTelefono.Clear();
            tbRuc.Clear();
            tbCodClien.Enabled = true;
            aCliente.Nuevo = true;
        }
        public void CargarGrid()
        {
            dgvClientes.DataSource = aCliente.Listado().Tables[0];
        }
        public void Insertar()
        {// validar que los datos obligatorios esten completos
            if (tbCodClien.Text.Trim() != "" && tbNombre.Text.Trim() != "" 
                && tbDireccion.Text != "" && tbTelefono.Text != "" && tbRuc.Text != "")
            {
                aCliente.Insertar(tbCodClien.Text, tbNombre.Text, tbDireccion.Text, tbTelefono.Text, tbRuc.Text);
                tbCodClien.Enabled = false;
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
            if (tbCodClien.Text.Trim() != "" && tbNombre.Text.Trim() != ""
                && tbDireccion.Text != "" && tbTelefono.Text != "" && tbRuc.Text != "")
            {
                //ACTUALIZAR REGISTRO
                aCliente.Actualizar(tbCodClien.Text, tbNombre.Text, tbDireccion.Text, tbTelefono.Text, tbRuc.Text);
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
            if (tbCodClien.Text.Trim() != "")
            {
                aCliente.Registro(tbCodClien.Text.Trim());
                tbCodClien.Text = aCliente.ValorAtributo("CodCliente").ToString();
                tbNombre.Text = aCliente.ValorAtributo("Nombre").ToString();
                tbDireccion.Text = aCliente.ValorAtributo("Direccion").ToString();
                tbTelefono.Text = aCliente.ValorAtributo("Telefono").ToString();
                tbRuc.Text = aCliente.ValorAtributo("Ruc").ToString();
                tbCodClien.Enabled = false;
                aCliente.Nuevo = false;
            }
        }
        private void buNuevo_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void tbCodClien_Leave(object sender, EventArgs e)
        {
            if (aCliente.ExisteClave(tbCodClien.Text.Trim()))
                CargarRegistro();
        }

        private void buGuardar_Click(object sender, EventArgs e)
        {
            if (aCliente.Nuevo)
                Insertar();
            else
                Actualizar();
        }
    }
}
