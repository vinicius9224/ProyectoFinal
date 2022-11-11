using ProyectoFinal.Formularios;
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

namespace ProyectoFinal
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        public void Login()
        {
            try
            {
                //Conexion a la Base de Datos
                string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(conect))
                {
                    conexion.Open();

                    using (SqlCommand cmd = new SqlCommand(
                        "SELECT NomUsuario,PassWrd " +
                        "FROM Usuario " +
                        "Where NomUsuario='" + txtNomUsuario.Text +
                        " 'AND PassWrd='" + txtContra.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.Read())
                        {
                            //MessageBox.Show("Login exitoso");
                            //Oculta el formulario de Login y abre el formulario de menu/inicio
                            this.Hide();
                            txtNomUsuario.Clear(); txtContra.Clear();
                            FrmInicio ventanaMenu = new FrmInicio();
                            ventanaMenu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Datos Incorrectos");
                            txtNomUsuario.Clear(); txtContra.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
