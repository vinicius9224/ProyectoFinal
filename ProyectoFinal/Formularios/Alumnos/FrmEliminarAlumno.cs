using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios.Alumnos
{
    public partial class FrmEliminarAlumno : Form
    {
        DatosAlumnos objeto = new DatosAlumnos();

        private string ID = null;

        public FrmEliminarAlumno()
        {
            InitializeComponent();
        }

        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objeto.Buscadir(txtBus.Text);
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = objeto.Mostrar_completo();
        }
        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.pnlFondo.Controls)
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

        private void FrmEliminarAlumno_Load_1(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                ID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                objeto.Eliminar_Alumnos(ID);
                MessageBox.Show("Eliminado");
                Mostrar();

            }
            else
            {
                MessageBox.Show("Selecciona una Fila");
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
