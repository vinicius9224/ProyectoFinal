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

namespace ProyectoFinal.Formularios.Configuración
{
    public partial class FrmEditarUsuario : Form
    {
        public FrmEditarUsuario()
        {
            InitializeComponent();
            pnlConfirmar.Hide();
        }
        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {
            lblNomUsuario.Text = FrmLogin.NomUser;
            this.Text = "Nombre de Usuario" + FrmLogin.NomUser;
        }

        #region Botones Cerrar,Cancelar, Guardar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlConfirmar.Hide();
            txtContraNueva.Clear();txtContraActual.Clear();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conect);
            string consulta = "UPDATE [dbo].[Usuario] SET PassWrd='" + txtContraNueva.Text + "' WHERE NomUsuario='" + FrmLogin.NomUser+"'";
            conexion.Open();
            SqlCommand sqlComm= new SqlCommand(consulta,conexion);
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataTable Table = new DataTable();
            sda.Fill(Table);
            sqlComm.ExecuteNonQuery();
            MessageBox.Show("Tú contraseña se modificó correctamente.");
            conexion.Close();
            //Limpia los textbox
            pnlConfirmar.Hide();txtContraNueva.Clear();txtContraActual.Clear();
        }
        #endregion

        #region Validar
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conect);
            string consulta = "SELECT * FROM [dbo].[Usuario] WHERE NomUsuario='" + FrmLogin.NomUser + "' AND PassWrd='" + txtContraActual.Text + "'";
            conexion.Open();
            SqlCommand sqlComm = new SqlCommand(consulta, conexion);
            SqlDataAdapter sda = new SqlDataAdapter(sqlComm);
            DataTable Table = new DataTable();
            sda.Fill(Table);
            sqlComm.ExecuteNonQuery();

            if (Table.Rows.Count > 0)
            {
                pnlConfirmar.Show();
            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta.");
                txtContraActual.Clear();
            }
            conexion.Close();
        }
        #endregion
    }
}
