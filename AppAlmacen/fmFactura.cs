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
    public partial class fmFactura : Form
    {
        private CDocVenta aDocVenta;
        private CCliente aNuevoC;
        private CProducto aProducto;
        private CDetalleVenta aDetalleVenta;
        float SubTotal=0;
        private int GO=0;
        public fmFactura()
        {
            InitializeComponent();
            aDocVenta = new CDocVenta();
            aNuevoC = new CCliente();
            aProducto = new CProducto();
            aDetalleVenta = new CDetalleVenta();
            //GO = aDocVenta.CantidadDocVentas();
            //aTipoProducto = new CTipoProducto();
        }
        //Limpiar cliente
        private void LimpiarCliente()
        {
            tbCodCliente.Clear();
            tbNombre.Clear();
            tbDireccion.Clear();
            tbRuc.Clear();
            tbTelefono.Clear();
            tbCodCliente.Enabled = true;
            aDetalleVenta.Nuevo = true;
            aNuevoC.Nuevo = true;
        }
        private void LimpiarProducto()
        {
            tbCodProducto.Clear();
            tbProducto.Clear();
            tbUnidad.Clear();
            tbStock.Clear();
            tbPU.Clear();
            tbTipoProducto.Clear();
            tbCantidad.Clear();
            tbCodProducto.Enabled = true;
            aProducto.Nuevo = true;
        }
        public void LimpiarFormulario()
        {
            LimpiarCliente();
            //limpiar texboxs
            tbSon.Clear();
            tbSubTotal.Clear();
            tbIGV.Clear();
            tbTotal.Clear();
        }

        private void buSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buGuardar_Click(object sender, EventArgs e)
        {
            if (aDocVenta.Nuevo)
            {
                if (cbTipo.Text.Trim() == "")
                {
                    cbTipo.Focus();
                }
                else
                {
                    Insertar();
                    LimpiarFormulario();

                    dgvDetalleVentas.Rows.Clear();
                }
                //aProducto.Nuevo=false;
                //actualizar
                /*aProducto.Registro(tbCodProducto.Text.Trim());
                aProducto.Actualizar(tbCodProducto.Text,tbProducto.Text,aProducto.ValorAtributo("Marca").ToString(), aProducto.ValorAtributo("UnidadMedida").ToString(),
                   aProducto.ValorAtributo("PU").ToString(), (Int32.Parse(aProducto.ValorAtributo("Stock").ToString())-Int32.Parse(tbCantidad.Text)).ToString(), aProducto.ValorAtributo("CodTipoProducto").ToString());*/

            }
            //else
            // Actualizar();
        }
        public void Insertar()
        {// validar que los datos obligatorios esten completos
            if (tbNroDoc.Text != "" && tbCodCliente.Text != ""
                && cbTipo.Text != "")
            {
                //insertar
                aDocVenta.Insertar(tbNroDoc.Text, tbFecha.Text, cbTipo.Text, tbCodCliente.Text);
               
                // tbNroDoc.Enabled = false;               
                MessageBox.Show("Registro guardado exitosamente");
                // CargarGrid();
            }
            else
            {
                MessageBox.Show("Ingrese los datos completo");

            }
        }


        public void CargarRegistroCliente()
        {
            //llena la informacion de de un registro especifico en el formulario
            if (tbCodCliente.Text.Trim() != "")
            {
                //en este metodo se realiza la recuperacion en el detalle-factura
                aNuevoC.Registro(tbCodCliente.Text.Trim());
                tbCodCliente.Text = aNuevoC.ValorAtributo("CodCliente").ToString();
                tbNombre.Text = aNuevoC.ValorAtributo("Nombre").ToString();
                tbDireccion.Text = aNuevoC.ValorAtributo("Direccion").ToString();
                tbTelefono.Text = aNuevoC.ValorAtributo("Telefono").ToString();
                tbRuc.Text = aNuevoC.ValorAtributo("Ruc").ToString();
                //tbCodTipPro.Text = aProduc.ValorAtributo("CodTipoProducto").ToString();
                tbCodCliente.Enabled = false;
                aNuevoC.Nuevo = false;
            }
        }
        public void CargarRegistroProducto()
        {
            if (tbCodProducto.Text.Trim() != "")
            {
                //en este metodo se realiza la recuperacion en el detalle-factura
                aProducto.Registro(tbCodProducto.Text.Trim());
                tbCodProducto.Text = aProducto.ValorAtributo("CodProducto").ToString();
                tbProducto.Text = aProducto.ValorAtributo("Producto").ToString();
                tbUnidad.Text = aProducto.ValorAtributo("UnidadMedida").ToString();
                tbStock.Text = aProducto.ValorAtributo("Stock").ToString();
                tbTipoProducto.Text = aProducto.ValorAtributo("CodTipoProducto").ToString();
                tbPU.Text = aProducto.ValorAtributo("PU").ToString();
                //tbCodTipPro.Text = aProduc.ValorAtributo("CodTipoProducto").ToString();
                //tbCodCliente.Enabled = false;
                aProducto.Nuevo = false;
            }
        }
        private void EnviarNroDoc()
        {
            fmConsultaFactura cf = new fmConsultaFactura();
            double subTot;
            double Total = 0;
            double igv = 0;
            cf.tbNroDo.Text = tbNroDoc.Text;
            cf.tbCodCliente.Text= aDocVenta.ValorAtributo("CodCliente").ToString();
            cf.tbFecha.Text= aDocVenta.ValorAtributo("Fecha").ToString();
            cf.cbTipo.Text= aDocVenta.ValorAtributo("Tipo").ToString();
            cf.dgvDetalleVenta.DataSource= aDocVenta.RecuperarDetalleVenta(tbNroDoc.Text).Tables[0];

            aNuevoC.Registro(cf.tbCodCliente.Text.Trim());//*****
            cf.tbNombre.Text = aNuevoC.ValorAtributo("Nombre").ToString();
            cf.tbDireccion.Text = aNuevoC.ValorAtributo("Direccion").ToString();
            cf.tbTelefono.Text = aNuevoC.ValorAtributo("Telefono").ToString();
            cf.tbRuc.Text = aNuevoC.ValorAtributo("Ruc").ToString();

            //determinar el subTotal, IGV Y total
            foreach (DataGridViewRow row in cf.dgvDetalleVenta.Rows)
            {
                subTot = Convert.ToDouble(row.Cells[6].Value);
                igv =igv+(subTot*(9/50));
                Total +=subTot;
            }

            cf.tbSuTotal.Text = Total.ToString();
            cf.tbIGV.Text = (Total*9/50).ToString();
            Total += (Total * 9 / 50);
            cf.tbTotaL.Text = Total.ToString();
            //tbSon.Text = "$ " + toText(float.Parse(tbTotal.Text)) + " SOLES";
            cf.tbSon.Text = "$ "+ toText(Total).ToString()+" SOLES";
            cf.Show();
        }
        private void CargarRegistroDocVenta()
        {
            if (tbNroDoc.Text.Trim() != "")
            {
                aDocVenta.Registro(tbNroDoc.Text.Trim());
                tbNroDoc.Text = aDocVenta.ValorAtributo("NroDocVenta").ToString();
                tbCodCliente.Text = aDocVenta.ValorAtributo("CodCliente").ToString();
                tbFecha.Text = aDocVenta.ValorAtributo("Fecha").ToString();
                cbTipo.Text = aDocVenta.ValorAtributo("Tipo").ToString();

                //Recuperar datos del cliente
                CargarRegistroCliente();
                //recuperar detalle venta
                dgvDetalleVentas.DataSource = aDocVenta.RecuperarDetalleVenta(tbNroDoc.Text).Tables[0];

            }
        }
        private void tbCodCliente_Leave(object sender, EventArgs e)
        {
            if (aNuevoC.ExisteClave(tbCodCliente.Text.Trim()))
                CargarRegistroCliente();
        }
        private void tbCodProducto_Leave(object sender, EventArgs e)
        {
            if (aProducto.ExisteClave(tbCodProducto.Text.Trim()))
                CargarRegistroProducto();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buConsultarCliente_Click(object sender, EventArgs e)
        {
            fmConsultaCliente c = new fmConsultaCliente();
            c.Show();
        }

        private void buConsultarProductos_Click(object sender, EventArgs e)
        {
            fmConsultaProductos p = new fmConsultaProductos();
            p.Show();
        }
        //en este método se guarda en un cuadro los detalles de un producto vendido
        private void buAgregar_Click(object sender, EventArgs e)
        {
            //Verificar que el codigo del producto existe
            if (tbCodProducto.Text == "")
            {
                MessageBox.Show("Error. Digite código de producto...");
            }
            else
            {
                //Agregar producto
                AgregarProducto();
                /*aProducto.Registro(tbCodProducto.Text.Trim());
                aProducto.Actualizar(tbCodProducto.Text, tbProducto.Text, aProducto.ValorAtributo("Marca").ToString(), aProducto.ValorAtributo("UnidadMedida").ToString(),
                   aProducto.ValorAtributo("PU").ToString(), (Int32.Parse(aProducto.ValorAtributo("Stock").ToString()) - Int32.Parse(tbCantidad.Text)).ToString(), aProducto.ValorAtributo("CodTipoProducto").ToString());
*/
            }
        }
        //metodo de agrgar producto
        private void AgregarProducto()
        {
            //Buscar los datos del productos en SQL
            if (aProducto.ExisteClave(tbCodProducto.Text.Trim()))
            {
                if (tbCodProducto.Text.Trim() != "")
                {
                    int c;
                    aProducto.Registro(tbCodProducto.Text.Trim());
                    //Verificar que la cantidad de stock sea mayor a la cantidad que se desea comprar
                    if (tbCantidad.Text.CompareTo("") == 0 || !int.TryParse((tbCantidad.Text as string), out c)|| Int32.Parse(tbCantidad.Text) > Int32.Parse(aProducto.ValorAtributo("Stock").ToString()) ||
                        Int32.Parse(tbCantidad.Text) < 0 )
                    {
                        MessageBox.Show("ERROR: Digite bien la cantidad...");
                        tbCantidad.Clear();
                        tbCantidad.Focus();
                    }
                    else
                    {

                        //Asumiendo que los datos fueron correctamente recuperados, se trata 
                        //guardarlos y recuperarlos en la tabla detalle venta
                        string[] row = {tbCodProducto.Text,tbCantidad.Text, aProducto.ValorAtributo("UnidadMedida").ToString(), aProducto.ValorAtributo("Marca").ToString(),
                        aProducto.ValorAtributo("Producto").ToString(),aProducto.ValorAtributo("PU").ToString(),(float.Parse(aProducto.ValorAtributo("PU").ToString())*float.Parse(tbCantidad.Text)).ToString()};
                        dgvDetalleVentas.Rows.Add(row);
                        //-------////////////////////////
                        /*
                        aDetalleVenta.Insertar(tbNroDoc.Text, aProducto.ValorAtributo("CodProducto").ToString(),tbCantidad.Text,tbPU.Text);
                        aDetalleVenta.Nuevo = false;*/
                        //ACTUALIZAR STOCK
                        aProducto.Actualizar(tbCodProducto.Text, tbProducto.Text, aProducto.ValorAtributo("Marca").ToString(), aProducto.ValorAtributo("UnidadMedida").ToString(),
                        aProducto.ValorAtributo("PU").ToString(), (Int32.Parse(aProducto.ValorAtributo("Stock").ToString()) - Int32.Parse(tbCantidad.Text)).ToString(), aProducto.ValorAtributo("CodTipoProducto").ToString());

                        SubTotal+= float.Parse(aProducto.ValorAtributo("PU").ToString()) * float.Parse(tbCantidad.Text);
                        //mostrar en el texbox el subTotal
                        tbSubTotal.Text = SubTotal.ToString();
                        tbIGV.Text = (SubTotal*9/50).ToString();
                        tbTotal.Text = (SubTotal+(SubTotal * 9 / 50)).ToString();
                        tbSon.Text = "$ " + toText(float.Parse(tbTotal.Text)) + " SOLES";
                        LimpiarProducto();
                        //guardar en la tabla TDetalleVenta(insertar)        

                    }
                }
            }
            //recuperar datos del producto en el dataGridview
            //Verificar que la cantidad de stock sea mayor a la cantidad que se desea comprar

            //if (tbCantidad.Text.CompareTo("")==0 || Int32.Parse(tbCantidad.Text)>Int32.Parse())
        }


        private void tbNroDoc_Leave(object sender, EventArgs e)
        {
           // int c;
            int len = tbNroDoc.Text.Length;
            if (len > 4 || len < 3 || tbNroDoc.Text.CompareTo("") == 0)
            {
                tbNroDoc.Focus();
            }
            else
            {
                if (aDocVenta.ExisteClave(tbNroDoc.Text.Trim()))
                {
                    EnviarNroDoc();
                }
            }
        }

        private void buGo_Click(object sender, EventArgs e)
        {
            tbNroDoc.Text = (GO + 10000).ToString();
        }
        private string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);
            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";
            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";
            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }

            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);

            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }
            //Num2Text = "$ " + Num2Text+" Soles";
            return Num2Text;
        }
    }
}