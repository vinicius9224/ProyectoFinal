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
            comDep.DropDownStyle = ComboBoxStyle.DropDownList;
            comEst.DropDownStyle = ComboBoxStyle.DropDownList;
            comMuni.DropDownStyle = ComboBoxStyle.DropDownList;
            comProf.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.pnlDatosMaestro.Controls)
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
            foreach (Control c in this.pnlDatosMaestro.Controls)
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
            foreach (Control ctrl in this.pnlDatosMaestro.Controls)
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
            foreach (Control ctrl in this.pnlDatosMaestro.Controls)
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
            foreach (Control ctrl in this.pnlDatosMaestro.Controls)
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
            foreach (Control ctrl in this.pnlDatosMaestro.Controls)
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


        

        private void FrmAgregarMaestro_Load(object sender, EventArgs e)
        {
            Listar_Estado();
            Listar_Profesiones();
            Listar_Municipios();
            Listar_Departamentos();
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
                    //comEst.Text es donde antes iba el salario

                    if (txtTel.Text.Length == 8)
                    {
                        objeto.Agregar_Maestro(txtcod.Text, txtnom.Text, txtape.Text, txtdom.Text, txtTel.Text, int.Parse(comProf.SelectedValue.ToString()), int.Parse(comDep.SelectedValue.ToString()), int.Parse(comMuni.SelectedValue.ToString()), int.Parse(comEst.SelectedValue.ToString()));
                        MessageBox.Show("Maestro Agregado");
                        limpiar_Datos();
                    }
                    else
                    {
                        MessageBox.Show("llenar telefono completo");
                    }

                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo agregar por" + ex);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comMuni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conect);

            string codigo = txtcod.Text;

            string consulta1 = "select nom_Trabajador from Trabajadores where cod_Trabajador = '" + codigo + "'";
            SqlCommand sqlcomm = new SqlCommand(consulta1, conexion);
            conexion.Open();

            sqlcomm.Parameters.AddWithValue("cod_Trabajador", codigo);

            using (SqlDataReader dr = sqlcomm.ExecuteReader())
            {
                if (dr.Read())
                {
                    MessageBox.Show("Ya Existe un Maestro con ese codigo");
                    limpiar_Datos();
                    return;
                }
            }
            conexion.Close();
        }

        private void comProf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comProf.Text == "Psicologo")
            {
                lblMstr.Text = "PSIC-";
            }
            else
                if (comProf.Text == "Maestro")
            {
                lblMstr.Text = "MSTR-";
            }
        }
    }
}
