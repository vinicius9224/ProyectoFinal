using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace ProyectoFinal.Formularios.Alumnos
{
    public partial class FrmModificarAlumno : Form
    {
        private bool Editacion = false;
        private string idAlumno = null;

        DatosAlumnos objeto = new DatosAlumnos();

        public FrmModificarAlumno()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void FrmModificarAlumno_Load_1(object sender, EventArgs e)
        {
            Listar_Estado();
            Listar_Municipios();
            Mostrar();
            Listar_Departamentos();
            Noedi();
        }

        private void Mostrar()
        {
           dataGridView1.DataSource = objeto.Mostrar_completo();
        }

        #region Validaciones

        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.pnlAgregarAlumno.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                }
            }

            foreach (Control ctrl in this.pnlResp.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                }
            }
        }
        private bool Validar() // metodo para verificar si hay un textbox vacio(recorre todo los controles ,con el IsNullOrWhiteSpace nos damos cuenta si es nula o esta vacia , si esto pasa retornamos un false)
        {
            foreach (Control c in this.pnlAgregarAlumno.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        return false;
                    }
                }
            }

            foreach (Control c in this.pnlResp.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void Noedi()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.ReadOnly = true;
            }
        }

        #endregion

        #region Método Listar Departamentos y Municipios

        public void Listar_Estado()
        {
            foreach (Control ctrl in this.pnlAgregarAlumno.Controls)
            {
                if (ctrl is ComboBox)
                {
                    DatosAlumnos objeto = new DatosAlumnos();
                    comboBoxEstadoAlum.DataSource = objeto.Mostrar_estado();
                    comboBoxEstadoAlum.DisplayMember = "nom_EstadoAlumno";
                    comboBoxEstadoAlum.ValueMember = "Id";
                    objeto.Mostrar_estado().Clear();
                    ctrl.Text = "";
                }
            }
        }
        public void Listar_Departamentos()
        {
            foreach (Control ctrl in this.pnlAgregarAlumno.Controls)
            {
                if (ctrl is ComboBox)
                {

                    DatosAlumnos objeto = new DatosAlumnos();
                    comboBoxDep.DataSource = objeto.Mostrar_Depar();
                    comboBoxDep.DisplayMember = "nom_Departamento";
                    comboBoxDep.ValueMember = "Id";
                    objeto.Mostrar_Depar().Clear();
                    ctrl.Text = "";
                }
            }
        }

        public void Listar_Municipios()
        {
            foreach (Control ctrl in this.pnlAgregarAlumno.Controls)
            {
                if (ctrl is ComboBox)
                {
                    DatosAlumnos objeto = new DatosAlumnos();
                    int a = Convert.ToInt32(comboBoxMuni.SelectedValue);
                    comboBoxMuni.DataSource = objeto.Mostrar_Muni();
                    comboBoxMuni.DisplayMember = "nom_Municipio";
                    comboBoxMuni.ValueMember = "Id";
                    objeto.Combox(a).Clear();
                    ctrl.Text = "";
                }
            }
        }

        #endregion

        #region Botones de Cerrar, Editar y Guardar

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                txtcod.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                txtnom.Text = dataGridView1.CurrentRow.Cells["nombres"].Value.ToString();
                txtape.Text = dataGridView1.CurrentRow.Cells["Apellidos"].Value.ToString();
                datTimeSes.Text= dataGridView1.CurrentRow.Cells["Fecha"].Value.ToString();
                txtresp.Text = dataGridView1.CurrentRow.Cells["Responsable"].Value.ToString();
                txttelRes.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                txtcol.Text = dataGridView1.CurrentRow.Cells["Colegio"].Value.ToString();
                txtgra.Text = dataGridView1.CurrentRow.Cells["Grado"].Value.ToString();
                txtdom.Text = dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();
                txteva.Text = dataGridView1.CurrentRow.Cells["Evaluacion"].Value.ToString();
                comboBoxDep.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
                comboBoxMuni.Text = dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString();
                idAlumno = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                comboBoxEstadoAlum.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                txtcod.Enabled = false;

                Editacion = true;
            }
            else
            {
                MessageBox.Show("Selecciona una Fila");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editacion == true)
            {
                if (Validar() == false)
                {
                    MessageBox.Show("No pueden quedar espacios en blanco.");
                }
                else
                {
                    try
                    {
                        //Agregar el comboBoxEstadoAlum con los parametros en CapaDatos,CapaNegocio en agregar y editar. Ademas de cambiarle los proced.Almc. 
                        objeto.Editar_Alumnos(txtcod.Text, txtnom.Text, txtape.Text, datTimeSes.Value, txtresp.Text, txttelRes.Text, txtcol.Text, txtgra.Text, txtdom.Text, txteva.Text, int.Parse(comboBoxDep.SelectedValue.ToString()), int.Parse(comboBoxMuni.SelectedValue.ToString()), idAlumno, int.Parse(comboBoxEstadoAlum.SelectedValue.ToString()));
                        MessageBox.Show("Actualizado");
                        dataGridView1.DataSource = objeto.Mostrar_completo();
                        limpiar_Datos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("no se puedo agregar por" + ex.Message);
                    }
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void txtcod_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void txtnom_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                MessageBox.Show("Solo letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }

        }

        private void txtape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                MessageBox.Show("Solo letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtresp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {

                MessageBox.Show("Solo letras", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txttelRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void comboBoxDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxMuni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxEstadoAlum_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

