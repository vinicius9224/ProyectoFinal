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

namespace ProyectoFinal.Formularios
{
    public partial class FrmAgregarAlumno : Form
    {
        DatosAlumnos objeto = new DatosAlumnos();

        public FrmAgregarAlumno()
        {
            InitializeComponent();
        }

        private void FrmAgregarAlumno_Load(object sender, EventArgs e)
        {
            Listar_Municipios();

            Listar_Estado();

            Listar_Departamentos();





        }

        #region Validaciones
        //metodo para limpiar los textbox (recorre todo los controles , cuando encuentra el control textbox , lo limpia)
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
                    int a = Convert.ToInt32(comboBoxDep.SelectedValue);
                    comboBoxMuni.DataSource = objeto.Mostrar_Muni();
                    comboBoxMuni.DisplayMember = "nom_Municipio";
                    comboBoxMuni.ValueMember = "Id";
                    objeto.Combox(a).Clear();
                    ctrl.Text = "";
                }
            }
        }

        
        #endregion

        #region Botones Cerrar, Guardar
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                //llamamos al metodo validar y si este es igual a false , significa que esta vacia o nula.
                if (Validar() == false)
                {
                    MessageBox.Show("No pueden quedar espacios en blanco.");
                }
                else
                {
                    //Agregar el comboBoxEstadoAlum con los parametros en CapaDatos,CapaNegocio en agregar y editar. Ademas de cambiarle los proced.Almc. 
                    objeto.AgregarAlumno(txtcod.Text, txtnom.Text, txtape.Text, txtfech.Text, txtresp.Text, txttelRes.Text, txtcol.Text, txtgra.Text, txtdom.Text, txteva.Text, int.Parse(comboBoxDep.SelectedValue.ToString()), int.Parse(comboBoxMuni.SelectedValue.ToString()), int.Parse(comboBoxEstadoAlum.SelectedValue.ToString()));
                    MessageBox.Show("Alumno Agregado");
                    limpiar_Datos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo agregar por" + ex);
            }
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
