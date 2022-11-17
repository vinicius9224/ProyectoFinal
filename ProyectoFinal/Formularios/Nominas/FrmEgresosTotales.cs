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

namespace ProyectoFinal.Formularios.Nominas
{
    public partial class FrmEgresosTotales : Form
    {
        DatosNominas objeto=new DatosNominas();
        public FrmEgresosTotales()
        {
            InitializeComponent();
        }
        #region Botones
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}
