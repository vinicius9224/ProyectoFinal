using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using ProyectoFinal.Formularios.Nominas;

namespace ProyectoFinal.Formularios
{
    public partial class FrmGenerarNomina : Form
    {
        DatosNominas objeto =new DatosNominas();
        public FrmGenerarNomina()
        {
            InitializeComponent();
            //btnDetaNominas.Hide();
        }

        #region ConfiguraciónFormulario

        private Form FormularioActual = null;
        private void AbrirFormulario(Form NuevoFormulario)
        {
            //Verifica si existe un formulario activo
            if (FormularioActual != null)

            //Configurar vuevo formulario
            FormularioActual.Close();
            FormularioActual = NuevoFormulario;
            NuevoFormulario.TopLevel = false;
            NuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            NuevoFormulario.Dock = DockStyle.Fill;
            pnlContenedor.Controls.Add(NuevoFormulario);
            pnlContenedor.Tag = NuevoFormulario;
            NuevoFormulario.BringToFront();
            NuevoFormulario.Show();
        }
        #endregion

        #region Validaciones
        //metodo para limpiar los textbox (recorre todo los controles , cuando encuentra el control textbox , lo limpia)
        public void Limpiar_Datos()
        {
            foreach (Control ctrl in this.pnlDetaNomina.Controls)
            {
                if (ctrl is DateTimePicker)
                {
                    ctrl.ResetText();
                }
            }
        }
        // metodo para verificar si hay un textbox vacio(recorre todo los controles , si esto pasa la bandera se vuelve falsa)
        private bool Validar() // metodo para verificar si hay un textbox vacio(recorre todo los controles ,con el IsNullOrWhiteSpace nos damos cuenta si es nula o esta vacia , si esto pasa retornamos un false)
        {
            if (dttDesde.Value > dttHasta.Value || dttFechaPago.Value> dttHasta.Value)
            {
                return false;
            }
            return true;
            
        }
        #endregion

        #region Botones Cerra,Guardar, HistorialNominas
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //llamamos al metodo validar y si este es igual a false , significa que esta vacia o nula.
                if (Validar() == false)
                {
                    MessageBox.Show("Las fechas están fuera de rango");
                    Limpiar_Datos();
                }
                else
                {
                    objeto.GenerarNominas(dttFechaPago.Value, dttHasta.Value, dttDesde.Value);
                    MessageBox.Show("Nomina Generada.");
                    //btnDetaNominas.Show();
                    AbrirFormulario(new FrmDetalleNomina());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo generar por: " + ex.Message);
            }
        }

        #endregion
    }
}
