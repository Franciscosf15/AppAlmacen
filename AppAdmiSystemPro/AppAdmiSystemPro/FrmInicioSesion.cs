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

namespace AppAdmiSystemPro
{
    public partial class FrmInicioSesion : Form
    {
        cEntidad aUsuario = new cUsuario();
        string aIdUsuario;

        public FrmInicioSesion()
        {
            InitializeComponent();
            TxtUsuario.Focus();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtUsuario.Text.Trim() != "" && TxtContraseña.Text.Trim() != "")
            {
                if (aUsuario.ConsultarUsuario(TxtUsuario.Text, TxtContraseña.Text))
                {
                    if(aUsuario.ValorAtributo("Habilitado").ToString() == "Si")
                    {
                        aIdUsuario = aUsuario.ValorAtributo("IdUsuario").ToString();
                        FrmProgramaPrincipal fPP = new FrmProgramaPrincipal(aIdUsuario);
                        fPP.ShowDialog();
                        TxtUsuario.Text = "";
                        TxtContraseña.Text = "";
                        TxtUsuario.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Este usuario esta deshabilitado.\nIngresar otro usuario!", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    }
                    
                }else
                {
                    MessageBox.Show("La contraseña no coincide con el usuario.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("LLenar campos USUARIO y CONTRASEÑA", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
    }
}
