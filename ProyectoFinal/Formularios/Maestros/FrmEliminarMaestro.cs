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

namespace ProyectoFinal.Formularios.Maestros
{
    public partial class FrmEliminarMaestro : Form
    {
        DatosTrabajadores obj = new DatosTrabajadores();
        private string ID = null;


        public FrmEliminarMaestro()
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

        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.Buscador(txtBus.Text);
        }

        private void Mostrar()
        {
            dataGridView1.DataSource = obj.Mostrar_Trabajadores();
        }

        private void FrmEliminarMaestro_Load(object sender, EventArgs e)
        {

            Mostrar();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                ID = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                obj.Eliminar_Trabajadores(ID);
                MessageBox.Show("Eliminado");
                Mostrar();

            }
            else
            {
                MessageBox.Show("Selecciona una Fila");
            }
        }
    }
}
