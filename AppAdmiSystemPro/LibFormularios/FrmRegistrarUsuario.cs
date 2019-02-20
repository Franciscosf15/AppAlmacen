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
    public partial class FrmRegistrarUsuario : FrmPadre
    {
        int NroNumerosContraseña = 0;

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
            IniciarEntidad(new cUsuario());
            BtnImprimir.Visible = false;
            BtnEliminar.Visible = false;
            TxtIdUsuario.Focus();
            lblCheck.Visible = false;
        }
        // METODOS SOBREESCRITOS DE LA CLASE PADRE -----------------------------------------------------------------
        // Establecer valores que iran en la tabla
        public override string[] AsignarValoresAtributos()
        {
            return new string[] { TxtIdUsuario.Text, TxtNombres.Text, TxtVerificarContraseña.Text, "1", "Si" };
        }
        // Mostrar datos de un registro
        public override void MostrarDatos()
        {

        }
        //Inicializar atributos clave y no clave en blanco
        public override void InicializarAtributoClave()
        {
            TxtIdUsuario.Text = "";
        }
        public override void InicializarAtributosNoClave()
        {
            TxtNombres.Text = "";
            TxtContraseña.Text = "";
            TxtVerificarContraseña.Text = "";
            lblCheck.Visible = false;
        }
        // Listar los registros y mostrarlos en el DataGrid
        public override void ListarRegistros()
        {

        }
        // Verificar los campos obligatorios
        public override string EsRegistroValido()
        {
            if (TxtIdUsuario.Text.Trim() != "" && TxtContraseña.Text.Trim() != "" && TxtNombres.Text.Trim() != "")
            {
                if (ValidarContraseña(TxtContraseña.Text))
                {
                    if (TxtContraseña.Text.Trim() == TxtVerificarContraseña.Text.Trim())
                    {
                        return "Si";
                    }
                    else
                    {
                        TxtVerificarContraseña.Text = "";
                        TxtVerificarContraseña.Focus();
                        return "La contraseña no coincide.";
                    }
                }else
                {
                    return "La contraseña no cumple los requisitos.";
                }                
            }
            else
            {
                if (TxtVerificarContraseña.Text.Trim() == "")
                {
                    return "La contraseña no coincide.";
                }
                else
                {
                    return "Debe llenar todo el formulario.";
                }
            }
        }
        // METODOS PROPIOS
        // Metodo que valida la contraseña
        public bool ValidarContraseña(string pContraseña)
        {
            lblCheck.Visible = true;
            if (pContraseña.Length >= 8 && NroNumerosContraseña >= 1)
            {
                lblCheck.Text = "CORRECTO";
                lblCheck.ForeColor = Color.Green;
                return true;
            }else {
                lblCheck.Text = "INCORRECTO";
                lblCheck.ForeColor = Color.Red;
                return false;
            }
        }

        private void TxtContraseña_TextChanged(object sender, EventArgs e)
        {
            ValidarContraseña(TxtContraseña.Text);
        }

        // EVENTOS
        private void TxtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {   // Bloqueamos todas las teclas execto los numeros y la tecla de borrado
            char Key = e.KeyChar;
            // tecla de borrar: 8
            if (char.IsDigit(Key))
            {
                NroNumerosContraseña++;
            }
        }
    }
}
