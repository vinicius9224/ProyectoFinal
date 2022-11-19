using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios.Nominas
{
    public partial class FrmDetalleNomina : Form
    {
        public FrmDetalleNomina()
        {
            InitializeComponent();
            txtApeTrabajador.Enabled = false;
            txtNomTrabajador.Enabled = false;
            txtCargoTrab.Enabled = false;
            txtSalario.Enabled = false;
            txtTotalHoras.Enabled = false;
            txtSalarioNeto.Enabled = false;
        }
    }
}
