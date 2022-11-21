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
        //Variable que guarda el nombre del Usuario
        public static string NomUser = "";

        public void Login()
        {
            string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conect);
            string consulta = "SELECT * FROM [dbo].[Usuario] WHERE NomUsuario=@NomUsuario AND PassWrd=@PassWrd";
            conexion.Open();
            SqlCommand sqlcomm = new SqlCommand(consulta, conexion);
            sqlcomm.Parameters.AddWithValue("@NomUsuario", txtNomUsuario.Text.Trim());
            sqlcomm.Parameters.AddWithValue("@PassWrd", txtContra.Text.Trim());
            SqlDataAdapter sda = new SqlDataAdapter(sqlcomm);
            DataTable Tabla = new DataTable();
            sda.Fill(Tabla);
            sqlcomm.ExecuteNonQuery();

            if (Tabla.Rows.Count > 0)
            {
                //MessageBox.Show("Login exitoso");
                //Oculta el formulario de Login y abre el formulario de menu/inicio
                this.Hide();
                //Guarda el nombre de usuario
                NomUser = txtNomUsuario.Text;
                txtNomUsuario.Clear(); txtContra.Clear();
                FrmInicio ventanaMenu = new FrmInicio();
                ventanaMenu.Show();
            }
            else
            {
                MessageBox.Show("Nombre de Usuario y Contraseña incorrecta. Intente de nuevo.");
                txtNomUsuario.Clear(); txtContra.Clear();
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir del programa", "Cerrar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

    }
}
