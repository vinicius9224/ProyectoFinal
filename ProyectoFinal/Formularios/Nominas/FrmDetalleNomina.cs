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
using CapaNegocio;

namespace ProyectoFinal.Formularios.Nominas
{
    public partial class FrmDetalleNomina : Form
    {
        DatosNominas objeto = new DatosNominas();
        public FrmDetalleNomina()
        {
            InitializeComponent();
            txtApeTrabajador.Enabled = false;
            txtNomTrabajador.Enabled = false;
            txtCargoTrab.Enabled = false;
            txtTotalHoras.Enabled = false;
            txtSalarioNeto.Enabled = false;
        }
        #region Validaciones 
        public void Limpiar_Datos()
        {
            foreach (Control ctrl in this.pnlDetaNomina.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
            
        }
        // metodo para verificar si hay un textbox vacio(recorre todo los controles , si esto pasa la bandera se vuelve falsa)
        private bool Validar() // metodo para verificar si hay un textbox vacio(recorre todo los controles ,con el IsNullOrWhiteSpace nos damos cuenta si es nula o esta vacia , si esto pasa retornamos un false)
        {
            foreach (Control c in this.pnlDetaNomina.Controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrWhiteSpace(((TextBox)c).Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        #endregion

        #region Botones Guardar, Buscar, Calcular
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                //llamamos al metodo validar y si este es igual a false , significa que esta vacia o nula.
                if (Validar() == false)
                {
                    MessageBox.Show("No pueden quedar espacios en blanco.");
                }
                else
                {
                    objeto.DetaNomina(txtViatico.Text,txtPagoXHora.Text,txtTotalHoras.Text,txtNominaId.Text,txtSesionId.Text);
                    MessageBox.Show("Nomina Generada.");
                    Limpiar_Datos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo generar por" + ex);
            }
            Limpiar_Datos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conect);
            string consulta1 = " SELECT T.cod_Trabajador, T.nom_Trabajador, T.ape_Trabajador, P.nom_Profesion "
                + " FROM [dbo].[Trabajadores] AS T "
                + " INNER JOIN Profesiones AS P ON T.Id=P.Id "
                + " WHERE T.Id=@Id ";
            

            conexion.Open(); 
            SqlCommand sqlcomm = new SqlCommand(consulta1,conexion);
            
            sqlcomm.Parameters.AddWithValue("@Id", txtCodTrabajador.Text);
            SqlDataReader reader1 = sqlcomm.ExecuteReader();
            
            
            if (reader1.Read())
            {
                txtNomTrabajador.Text = reader1["nom_Trabajador"].ToString();
                txtApeTrabajador.Text = reader1["ape_Trabajador"].ToString();
                txtCargoTrab.Text = reader1["nom_Profesion"].ToString();
                
            }
            else
            {
                MessageBox.Show("Empleado no existente.");
            }
            conexion.Close();

            string conect2 = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion2 = new SqlConnection(conect2);
            string consulta2 = " select SUM(S.cantHoras_Sesion)  AS [TotalHoras] "
                + " from DetalleNominas D "
                + " INNER JOIN Sesiones S ON D.Id=S.Id "
                + " INNER JOIN Facturas F ON D.Id=F.Id "
                + " INNER JOIN Trabajadores T ON D.Id=T.Id " 
                + " WHERE @Id=F.Id ";
            conexion.Open();
            SqlCommand sqlcomm1 = new SqlCommand(consulta2, conexion);
            sqlcomm1.Parameters.AddWithValue("@Id", txtCodTrabajador.Text);
            SqlDataReader reader2 = sqlcomm1.ExecuteReader();
            if (reader2.Read())
            {
                txtTotalHoras.Text = reader2["TotalHoras"].ToString();
            }
            
            conexion.Close();
        }
        #endregion

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDetalleNomina_Load(object sender, EventArgs e)
        {

        }

    }
}
