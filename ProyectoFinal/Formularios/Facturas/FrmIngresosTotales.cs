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
    public partial class FrmIngresosTotales : Form
    {
        public FrmIngresosTotales()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatosFacturas data = new DatosFacturas();
            dataGridView1.DataSource = data.ListarDatosView1(cmbBxBuscar.Text);

        }
    }
}
