using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            foreach (Control ctrl in this.pnlContenedor.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            foreach (Control ctrl in this.pnlDetaNomina.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
        }
        // metodo para verificar si hay un textbox vacio(recorre todo los controles , si esto pasa la bandera se vuelve falsa)
        private bool Validar()
        {
            Boolean Errores = true;
            foreach (Control c in this.pnlContenedor.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        alertaError.SetError(c, "Campo obligatorio, no puede estar vacio");
                        Errores = false;
                    }
                }
            }
            return Errores;
        }
        #endregion

        #region Botones Cerra,Guardar, HistorialNominas
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //if (Validar() == true)
            //{
            //    try
            //    {
            //        if (objeto.GenerarNominas(txtPagoDesde.Text,txtPagoHasta.Text,txtDescripNomina.Text,txtPagoXHora.Text,txtTotalHoras.Text,txtValorPagado.Text,txtViatico.Text))
            //        {
            //            MessageBox.Show("Nomina Generada");
            //            Limpiar_Datos();
            //        }
            //    }
            //    catch (Exception error)
            //    {
            //        MessageBox.Show("Ha habido un error: " + error.Message);
            //        throw;
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Los datos ingresados son incorrectos, intente de nuevo");
            //    Limpiar_Datos();
            //}
        }

        private void btnHistorialNominas_Click(object sender, EventArgs e)
        {
            Limpiar_Datos();
            AbrirFormulario(new FrmHistorialNominas());
        }
        #endregion

    }
}
