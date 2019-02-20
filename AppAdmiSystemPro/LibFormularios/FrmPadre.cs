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
    public partial class FrmPadre : Form
    {
        // ATRIBUTOS -----------------------------------------
        protected cEntidad aEntidad;
        // CONSTRUCTOR ---------------------------------------
        public FrmPadre()
        {
            InitializeComponent();
        }

        // METODOS -------------------------------------------
        // Arreglo de strings con los valores que deben ir a la tabla
        public virtual string[] AsignarValoresAtributos()
        {
            return null;
        }

        public void IniciarEntidad(cEntidad pEntidad)
        {   // Indicar con que entidad trabajara el formulario
            aEntidad = pEntidad;
        }

        public virtual void InicializarAtributoClave()
        {
            // Dar valores a los controles relacionados al atributo clave
        }

        public virtual void InicializarAtributosNoClave()
        {
            // Dar valores a los controles relacionados a los atributos no clave
        }

        public virtual void InicializarAtributos()
        {   // Dar valor inicial a todos los atributos de formulario
            InicializarAtributoClave();
            InicializarAtributosNoClave();
        }

        public virtual void MostrarDatos()
        {
            // Visualiza la informacion de un registro en el formulario
        }

        public virtual void ListarRegistros()
        {
            // Lista todos los registros de la tabla relacionada
        }

        public virtual string EsRegistroValido()
        {
            // Verifica que todos los datos esten completos en el formulario
            return "Si";
        }
        public virtual void ProcesarClave()
        {
            // Recuperar atributos, el primer atributo es la clave
            string[] Atributos = AsignarValoresAtributos();
            // Verificar si existe clave primaria
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {   // Registro existente, recuperar atributos y mostrarlos
                MostrarDatos();
                aEntidad.Nuevo = false;
            }
            else
            {   // Registro nuevo, inicializar atributos no clave
                InicializarAtributosNoClave();
            }
        }
        
        public virtual void Guardar()
        {
            // Metodo que guarda o actualiza un registro
            try
            {
                if (EsRegistroValido() == "Si")
                {   // Recuperar atributos, el primer atributo es la clave
                    string[] Atributos = AsignarValoresAtributos();
                    // Verificar si existe clave primaria
                    if (aEntidad.ExisteClavePrimaria(Atributos))
                    {
                        aEntidad.Actualizar(Atributos);
                    }
                    else
                    {
                        aEntidad.Insertar(Atributos);
                    }
                    MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    InicializarAtributos();
                }
                else
                {
                    MessageBox.Show(EsRegistroValido(), "ALERTA");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "ERROR");
            }
        }             
        public virtual void Eliminar()
        {
            // Metodo que elimina un registro   
            string[] Atributos = AsignarValoresAtributos();
            if (aEntidad.ExisteClavePrimaria(Atributos))
            {
                aEntidad.Eliminar(Atributos);
                if (aEntidad.ValorAtributo("CodError") == "0")
                {
                    MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "CONFIRMACION", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    InicializarAtributos();
                    ListarRegistros();
                }
                else
                {
                    MessageBox.Show(aEntidad.ValorAtributo("Mensaje"), "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El codigo ingresado no existe.", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        // EVENTOS --------------------------------------------------------------------------
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            InicializarAtributos();
        }
    }
}
