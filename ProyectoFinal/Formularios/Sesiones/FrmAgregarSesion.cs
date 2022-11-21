using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal.Formularios.Sesiones
{
    public partial class FrmAgregarSesion : Form
    {
        DatosSesiones DatSes = new DatosSesiones();

        public FrmAgregarSesion()
        {
            InitializeComponent();
        }

        #region Validaciones
        //metodo para limpiar los textbox (recorre todo los controles , cuando encuentra el control textbox , lo limpia)
        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.panelDatos.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }

            foreach (Control ctrl in this.panelBuscar.Controls)
            {
                if (ctrl is TextBox && ctrl.Text != "Buscar")
                {
                    ctrl.Text = "";
                }
            }
        }

        // metodo para verificar si hay un textbox vacio(recorre todo los controles , si esto pasa la bandera se vuelve falsa)
        private bool Validar() 
        {
            Boolean Errores = true;
            foreach (Control c in this.panelDatos.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        errorProvider1.SetError(c, "Campo obligatorio, no puede estar vacio");
                        Errores = false;
                    }
                }
            }
            return Errores;
        }

        //Llama el metodo de la capanegocio para validar que los datos sean correctos y obtenemos los id
        private Boolean ValidarDatos(ref string idfact, ref string idtrab, string codTrab, string codFactur, DateTime fechSes)
        {
            return (DatSes.ValidarDatos(ref idfact ,ref idtrab, codTrab, codFactur, fechSes));
        }

        //Evento para mostrar los datos seleccionados
        private Boolean ValidarNum()
        {
            try
            {
                int hora = int.Parse(txtCantHrsSes.Text);
                if (hora > 24 || hora <= 0)
                {
                    return false;
                }
            }
            catch (Exception)
            {
                errorProvider1.SetError(txtCantHrsSes, "Este campo solo acepta numeros en un rango de 1 a 24");
                return false;
            }
            return true;
        }
        #endregion

        #region Botones Guardar, Seleccionar, Buscar
        //Evento para guardar los datos ingresados 
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string idfact = null;
            string idtrab = null;

            if (Validar() == true && ValidarDatos(ref idfact, ref idtrab, txtCodTrab.Text, txtCodFactur.Text, datTimeSes.Value) == true && ValidarNum() == true)
            {
                try
                {
                    if (DatSes.AgregarSesiones(txtCodSes.Text.Trim(), datTimeSes.Value, txtCantHrsSes.Text.Trim(), idtrab, idfact).Columns.Count == 0)
                    {
                        MessageBox.Show("Sesión Agregada");
                        limpiar_Datos();
                    }
                    else
                    {
                        MessageBox.Show("Ya existe una sesión con ese código, intente otro");
                        limpiar_Datos();
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha habido un error: " + error.Message);
                    throw;
                }
                
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos, intente de nuevo");
                limpiar_Datos();
            }
        }
        private void btnSeleccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBxBuscar.Text == "Trabajadores" && dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    txtCodTrab.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
                else
               if (cmbBxBuscar.Text == "Facturas" && dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    txtCodFactur.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha habido un error: ", error.Message);
            }

        }

        private void cmbBxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DatSes.ListarDatosView(cmbBxBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (cmbBxBuscar.Text == "Trabajadores" || cmbBxBuscar.Text == "Facturas")
            {
                dataGridView1.DataSource = DatSes.BuscarDato(txtBuscar.Text, cmbBxBuscar.Text.Trim());
            }
        }
        #endregion

        #region Notificaciones de Errores
        //limpiamos los errorprovider una vez los textos cambian
        private void txtCodSes_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCantHrsSes_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCodTrab_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCodFactur_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar_Datos();
        }
        #endregion
    }

}
