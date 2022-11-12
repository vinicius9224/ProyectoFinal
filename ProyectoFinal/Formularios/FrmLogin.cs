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
            //try
            //{
            //Conexion a la Base de Datos
            //    string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            //    using (SqlConnection conexion = new SqlConnection(conect))
            //    {
            //        conexion.Open();

            //        using (SqlCommand cmd = new SqlCommand(
            //            "SELECT NomUsuario,PassWrd " +
            //            "FROM Usuario " +
            //            "Where NomUsuario='" + txtNomUsuario.Text +
            //            " 'AND PassWrd='" + txtContra.Text + "'", conexion))
            //        {
            //            SqlDataReader validar = cmd.ExecuteReader();

            //            if (validar.Read())
            //            {
            //                //MessageBox.Show("Login exitoso");
            //                //Oculta el formulario de Login y abre el formulario de menu/inicio
            //                this.Hide();
            //                //Guarda el nombre de usuario
            //                NomUser = txtNomUsuario.Text;
            //                txtNomUsuario.Clear(); txtContra.Clear();
            //                FrmInicio ventanaMenu = new FrmInicio();
            //                ventanaMenu.Show();
            //            }
            //            else
            //            {
            //                MessageBox.Show("Datos Incorrectos");
            //                txtNomUsuario.Clear(); txtContra.Clear();
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //} 

            string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conect);
            string consulta = "SELECT * FROM [dbo].[Usuario] WHERE NomUsuario=@NomUsuario AND PassWrd=@PassWrd";
            conexion.Open();
            SqlCommand sqlcomm = new SqlCommand(consulta, conexion);
            sqlcomm.Parameters.AddWithValue("@NomUsuario", txtNomUsuario.Text);
            sqlcomm.Parameters.AddWithValue("@PassWrd", txtContra.Text);
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
                MessageBox.Show("Nombre de Usuario y Contraseña invalida. Intente de nuevo.");
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
    }
}
