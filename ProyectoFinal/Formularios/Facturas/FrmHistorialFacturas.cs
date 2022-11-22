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

namespace ProyectoFinal.Formularios.Facturas
{
    public partial class FrmHistorialFacturas : Form
    {
        public FrmHistorialFacturas()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }



        private void cmbBxBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosFacturas data = new DatosFacturas();
            dataGridView1.DataSource = data.ListarDatosViewdetalles(cmbBxBuscar.Text);
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.ReadOnly = true;
            }
        }

      

        private void FrmHistorialFacturas_Load(object sender, EventArgs e)
        {
           
        }
    }
}
