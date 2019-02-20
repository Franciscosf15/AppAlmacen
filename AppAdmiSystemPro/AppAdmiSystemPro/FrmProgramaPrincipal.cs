using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFormularios;
using LibTablas;

namespace AppAdmiSystemPro
{
    public partial class FrmProgramaPrincipal : Form
    {
        cEntidad aUsuario = new cUsuario();
        string aIdUsuario;

        public FrmProgramaPrincipal(string pIdUsuario)
        {
            InitializeComponent();
            aIdUsuario = pIdUsuario;
            string[] Atributos = new string[] { aIdUsuario };
            aUsuario.Registro(Atributos);
            string NivelAcceso = aUsuario.ValorAtributo("NivelAcceso");
            if (NivelAcceso == "1")
            {
                masToolStripMenuItem.Visible = false;
            }else
            {
                masToolStripMenuItem.Visible = true;
            }
        }

        private void registrarProductoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProducto fProducto = new FrmProducto();
            fProducto.ShowDialog();
        }

        private void registrarUsuarioToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmRegistrarUsuario fUsuario = new FrmRegistrarUsuario();
            fUsuario.ShowDialog();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaProductos fListaP = new FrmListaProductos("");
            fListaP.ShowDialog();
        }

        private void registrarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBoleta fBoleta = new FrmBoleta(aIdUsuario);
            fBoleta.ShowDialog();
        }

        private void productosMasVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductosMasVendidos fPMV = new FrmProductosMasVendidos();
            fPMV.ShowDialog();
        }

        private void listarProductosDeStockBajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductosBajoStock fPBS = new FrmProductosBajoStock();
            fPBS.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario fUsuario = new FrmUsuario();
            fUsuario.ShowDialog();
        }

        private void reporteDeGananciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReporteGanancias fRG = new FrmReporteGanancias();
            fRG.ShowDialog();
        }

        /*private void FrmProgramaPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            FrmInicioSesion fIS = new FrmInicioSesion();
            fIS.ShowDialog();
        }*/
    }
}
