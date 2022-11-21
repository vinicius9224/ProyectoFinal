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

namespace ProyectoFinal.Formularios.Alumnos
{
    public partial class FrmListarAlumnos : Form
    {

        DatosAlumnos objeto = new DatosAlumnos();
        public FrmListarAlumnos()
        {
            InitializeComponent();
        }
        private void FrmListarAlumnos_Load_1(object sender, EventArgs e)
        {
            Mostrar();
            Noedi();
        }

        #region Validaciones
        private void Mostrar()
        {
            
            dataGridView1.DataSource = objeto.Mostrar_completo();
        }

        private void Noedi()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.ReadOnly = true;
            }
        }

        #endregion

        #region Botones y Barra de Busqueda
        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objeto.Buscadir(txtBus.Text);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

    }
}
