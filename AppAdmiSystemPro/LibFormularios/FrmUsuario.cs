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
    public partial class FrmUsuario : FrmPadre
    {
        public FrmUsuario()
        {
            InitializeComponent();
            BtnEliminar.Visible = false;
            BtnGuardar.Visible = false;
            BtnImprimir.Visible = false;
            BtnNuevo.Visible = false;
            IniciarEntidad(new cUsuario());
            DgvUsuarios.DataSource = aEntidad.ListaGeneral();                
        }

        private void BtnDeshabilitar_Click(object sender, EventArgs e)
        {
            string IdUsuario = DgvUsuarios.CurrentRow.Cells[0].Value.ToString();
            string Nombres = DgvUsuarios.CurrentRow.Cells[1].Value.ToString();
            string Contraseña = DgvUsuarios.CurrentRow.Cells[2].Value.ToString();
            string NivelAcceso = DgvUsuarios.CurrentRow.Cells[3].Value.ToString();
            string Habilitado = DgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            if (Habilitado == "Si")
            {
                Habilitado = "No";
            } else
            {
                Habilitado = "Si";
            }
            string[] Atributos = new string[] { IdUsuario, Nombres, Contraseña, NivelAcceso, Habilitado };
            if (MessageBox.Show("¿Seguro que deseas deshabilitar este usuario " + IdUsuario + "?", "SALIR", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
            {
                aEntidad.Actualizar(Atributos);
                DgvUsuarios.DataSource = aEntidad.ListaGeneral();
            }
            if (Habilitado == "Si")
            {
                BtnDeshabilitar.Text = "DESHABILITAR";
            }
            else
            {
                BtnDeshabilitar.Text = "HABILITAR";
            }
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string Habilitado = DgvUsuarios.CurrentRow.Cells[4].Value.ToString();
            if (Habilitado == "Si")
            {
                BtnDeshabilitar.Text = "DESHABILITAR";
            }
            else
            {
                BtnDeshabilitar.Text = "HABILITAR";
            }
        }
    }
}
