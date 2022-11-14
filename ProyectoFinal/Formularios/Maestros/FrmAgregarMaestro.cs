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
    public partial class FrmAgregarMaestro : Form
    {
        DatosTrabajadores objeto = new DatosTrabajadores();
     

        public FrmAgregarMaestro()
        {
            InitializeComponent();
        }
        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.Controls)
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
            foreach (Control c in this.Controls)
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
        public void Listar_Departamentos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                   
                    DatosAlumnos objeto = new DatosAlumnos();
                    comDep.DataSource = objeto.Mostrar_Depar();
                    comDep.DisplayMember = "nom_Departamento";
                    comDep.ValueMember = "Id";
                    objeto.Mostrar_Depar().Clear();
                    ctrl.Text = "";
                }
            }
        }

        public void Listar_Municipios()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    DatosAlumnos objeto = new DatosAlumnos();
                    comMuni.DataSource = objeto.Mostrar_Muni();
                    comMuni.DisplayMember = "nom_Municipio";
                    comMuni.ValueMember = "Id";
                    objeto.Mostrar_Muni().Clear();
                    ctrl.Text = "";
                }
            }
        }

        public void Listar_Profesiones()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    DatosTrabajadores objeto = new DatosTrabajadores();
                    comProf.DataSource = objeto.Mostrar_Profesiones();
                    comProf.DisplayMember = "nom_Profesion";
                    comProf.ValueMember = "Id";
                    objeto.Mostrar_Profesiones().Clear();
                    ctrl.Text = "";
                }
            }
        }

        public void Listar_Estado()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
                {
                    DatosTrabajadores objeto = new DatosTrabajadores();
                    comEst.DataSource = objeto.Mostrar_EstadosMaestro();
                    comEst.DisplayMember = "nom_EstadoTrabajador";
                    comEst.ValueMember = "Id";
                    objeto.Mostrar_EstadosMaestro().Clear();
                    ctrl.Text = "";
                }
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
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
                    objeto.Agregar_Maestro(txtcod.Text, txtnom.Text, txtape.Text, txtdom.Text, txtsal.Text, txtTel.Text, int.Parse(comProf.SelectedValue.ToString()), int.Parse(comDep.SelectedValue.ToString()), int.Parse(comMuni.SelectedValue.ToString()), int.Parse(comEst.SelectedValue.ToString()));
                    MessageBox.Show("Maestro Agregado");
                    limpiar_Datos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se puedo agregar por" + ex);
            }
        }

        public void ver()
        {
            Listar_Profesiones();
            Listar_Municipios();
           
        }

        private void FrmAgregarMaestro_Load(object sender, EventArgs e)
        {
            Listar_Estado();
            Listar_Departamentos();
            ver();
         
        
        }

        private void txtsal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >=32 && e.KeyChar<=47 || (e.KeyChar>=58 && e.KeyChar <= 255)))
            {
                MessageBox.Show("Solo se Pueden Ingresar Numeros","", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;

            }

        }
    }
}
