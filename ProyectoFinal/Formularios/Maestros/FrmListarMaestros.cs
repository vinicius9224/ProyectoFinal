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

namespace ProyectoFinal.Formularios.Maestros
{
    public partial class FrmListarMaestros : Form
    {
        DatosTrabajadores objeto = new DatosTrabajadores();
        public FrmListarMaestros()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void Mostrar()
        {
         dataGridView1.DataSource = objeto.Mostrar_Trabajadores();
         
        }


        private void Noedi()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.ReadOnly = true;
            }
        }
        

        private void FrmListarMaestros_Load(object sender, EventArgs e)
        {
            Mostrar();
            Noedi();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBus_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = objeto.Buscador(txtBus.Text);
        }
    }
}
