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
    public partial class FrmReporteGanancias : FrmPadre
    {
        string aFecha;

        public FrmReporteGanancias()
        {
            InitializeComponent();
            BtnEliminar.Visible = false;
            BtnImprimir.Visible = false;
            BtnGuardar.Visible = false;
            BtnNuevo.Visible = false;
            IniciarEntidad(new cBoleta());
            DtpFecha.MaxDate = DateTime.Now;
            DtpFecha.Value = DateTime.Now;
            aFecha = DtpFecha.Value.ToString().Substring(0, 10);
            //DtpFecha.Value.ToString().Substring(0,10)
            DgvGanancias.DataSource = aEntidad.GananciasPorDia(aFecha);
            CalcularTotal(DgvGanancias);
        }

        // Calcular el total del Grid
        public void CalcularTotal(DataGridView pGrid)
        {
            try
            {
                if (pGrid.Rows.Count >= 1)
                {
                    double Total = 0;
                    for (int i = 0; i < pGrid.Rows.Count; i++)
                    {
                        Total += double.Parse(pGrid[1, i].Value.ToString());
                    }
                    LblTotal.Text = Total.ToString();
                }
            }
            catch
            {
                Console.WriteLine("ERROR");
            }
        }

        private void DtpFecha_ValueChanged(object sender, EventArgs e)
        {
            aFecha = DtpFecha.Value.ToString().Substring(0, 10);
            DgvGanancias.DataSource = aEntidad.GananciasPorDia(aFecha);
            CalcularTotal(DgvGanancias);
        }
    }
}
