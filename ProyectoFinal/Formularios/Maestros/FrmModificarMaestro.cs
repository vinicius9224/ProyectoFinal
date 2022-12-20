using CapaNegocio;
using System;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios.Maestros
{
    public partial class FrmModificarMaestro : Form
    {
        private bool Editacion = false;
        private string idAlumno = null;

        DatosTrabajadores objeto = new DatosTrabajadores();
        public FrmModificarMaestro()
        {
            InitializeComponent();
            comDep.DropDownStyle = ComboBoxStyle.DropDownList;
            comEst.DropDownStyle = ComboBoxStyle.DropDownList;
            comMuni.DropDownStyle = ComboBoxStyle.DropDownList;
            comProf.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmModificarMaestro_Load(object sender, EventArgs e)
        {
            Mostrar();
            Listar_Estado();
            Listar_Profesiones();
            Listar_Municipios();
            Listar_Departamentos();

        }
        private void Mostrar()
        {
           dataGridView1.DataSource = objeto.Mostrar_Trabajadores();
        }

        #region Validaciones

        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.pnlModMaestro.Controls)
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
            foreach (Control c in this.pnlModMaestro.Controls)
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

        #region Listar Municipios, Departamentos, Estados, Profesines
        public void Listar_Departamentos()
        {
            foreach (Control ctrl in this.pnlModMaestro.Controls)
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
            foreach (Control ctrl in this.pnlModMaestro.Controls)
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
            foreach (Control ctrl in this.pnlModMaestro.Controls)
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
            foreach (Control ctrl in this.pnlModMaestro.Controls)
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

        #endregion

        #region Botones

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                        //comEst.Text es donde antes iba el salario


                        if (txtTel.Text.Length == 8)
                        {
                            objeto.Editar_Maestro(txtcod.Text, txtnom.Text, txtape.Text, txtdom.Text, txtTel.Text, int.Parse(comProf.SelectedValue.ToString()), int.Parse(comDep.SelectedValue.ToString()), int.Parse(comMuni.SelectedValue.ToString()), int.Parse(comEst.SelectedValue.ToString()), idAlumno);
                            MessageBox.Show("Actualizado");
                            dataGridView1.DataSource = objeto.Mostrar_Trabajadores();
                            limpiar_Datos();

                        }
                        else
                        {
                           MessageBox.Show("llenar telefono completo");
                        }

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puedo agregar por" + ex.Message);
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                txtcod.Text = dataGridView1.CurrentRow.Cells["codigo"].Value.ToString();
                txtnom.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtape.Text = dataGridView1.CurrentRow.Cells["Apellido"].Value.ToString();
                txtdom.Text = dataGridView1.CurrentRow.Cells["Domicilio"].Value.ToString();
                txtTel.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                comProf.Text = dataGridView1.CurrentRow.Cells["Profesion"].Value.ToString();
                comDep.Text = dataGridView1.CurrentRow.Cells["Departamento"].Value.ToString();
                comMuni.Text = dataGridView1.CurrentRow.Cells["Municipio"].Value.ToString();
                comEst.Text = dataGridView1.CurrentRow.Cells["Estado"].Value.ToString();
                idAlumno = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                txtcod.Enabled = false;
                Editacion = true;
            }
            else
            {
                MessageBox.Show("Selecciona una Fila");
            }
        }
        #endregion

        private void comProf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comMuni_KeyPress(object sender, KeyPressEventArgs e)
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
    }

}
