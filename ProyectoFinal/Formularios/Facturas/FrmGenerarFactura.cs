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


namespace ProyectoFinal.Formularios
{
    public partial class FrmGenerarFactura : Form
    {
        private DataTable dt;

       DatosFacturas obj = new DatosFacturas();
        public FrmGenerarFactura()
        {
            InitializeComponent();
            txtnom.Enabled =false;
            dataGridView1.AllowUserToAddRows = false;
        }

        #region FormualarioConfig
        private void FrmGenerarFactura_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            dt.Columns.Add("#sesiones");
            dt.Columns.Add("costo");
            dt.Columns.Add("total");
            dataGridView1.DataSource = dt;
            txtcod.Text = obj.Facturas();
            Listar_modalidades();
            Listar_Estados();
            Listar_Servicios();
           
        }

        #endregion

        #region Validar
        public void limpiar_Datos()
        {
            foreach (Control ctrl in this.pnlContenedor.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
                else if (ctrl is ComboBox)
                {
                    ctrl.Text = "";
                }
            }
        }
        private bool Validar() // metodo para verificar si hay un textbox vacio(recorre todo los controles ,con el IsNullOrWhiteSpace nos damos cuenta si es nula o esta vacia , si esto pasa retornamos un false)
        {
            foreach (Control c in this.pnlContenedor.Controls)
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

        #region Listar Servicios y Modalidades

        public void Listar_Servicios()
        {
            foreach (Control ctrl in this.pnlContenedor.Controls)

            {
                if (ctrl is ComboBox)
                {
                    DatosFacturas objeto = new DatosFacturas();

                    comser.DataSource = objeto.Serviciosfac();
                    comser.DisplayMember = "nom_Servicio";
                    comser.ValueMember = "Id";
                    objeto.Serviciosfac().Clear();
                    ctrl.Text = "";
                }
            }
        }

        public void Listar_modalidades()
        {
            foreach (Control ctrl in this.pnlContenedor.Controls)
            {
                if (ctrl is ComboBox)
                {
                    DatosFacturas objeto = new DatosFacturas();

                    commod.DataSource = objeto.Modalidadesfac();
                    commod.DisplayMember = "nom_Modalidad";
                    commod.ValueMember = "Id";
                    objeto.Modalidadesfac().Clear();
                    ctrl.Text = "";
                }
            }
        }

        public void Listar_Estados()
        {
            foreach (Control ctrl in this.pnlContenedor.Controls)
            {
                if (ctrl is ComboBox)
                {
                    DatosFacturas objeto = new DatosFacturas();

                    comest.DataSource = objeto.ListarestSesion();
                    comest.DisplayMember = "nom_EstadoSesion";
                    comest.ValueMember = "Id";
                    objeto.ListarestSesion().Clear();
                    ctrl.Text = "";
                }
            }
        }

        public void mostrar()
        {
            DataRow row = dt.NewRow();

           

            if(dataGridView1.RowCount==0)
            {
                row["#sesiones"] = txtcant.Text;
                row["costo"] = txtcost.Text;
                row["total"] = Int32.Parse(txtcant.Text) * double.Parse(txtcost.Text);
                dt.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Error solo se puede facturar una vez");
            }




        }

        #endregion

        #region Botones
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                    obj.datosfact(txtcod.Text, txtcant.Text, txtcost.Text, datTimeSes.Value, txtId.Text, comest.SelectedValue.ToString(), comser.SelectedValue.ToString(), commod.SelectedValue.ToString());

                    MessageBox.Show("Factura Realizada.");
                    limpiar_Datos();
               


               
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo agregar por" + ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {




            mostrar();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Digite el codigo del Alumno");

            }
            else
            {
                var resultado2 = obj.alumnos(Convert.ToInt32(txtId.Text));
                txtnom.Text = resultado2.Item1;

               
            } 
        }
        #endregion

        private void comser_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comest_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void commod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtcant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtcost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
                return;
            }
        }

        private void txtcod_TextChanged(object sender, EventArgs e)
        {
            string conect = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(conect);

            string codigo = txtcod.Text;

            string consulta1 = "select costo_Factura from Facturas where cod_Factura = '" + codigo + "'";
            SqlCommand sqlcomm = new SqlCommand(consulta1, conexion);
            conexion.Open();

            sqlcomm.Parameters.AddWithValue("cod_Factura", codigo);

            using (SqlDataReader dr = sqlcomm.ExecuteReader())
            {
                if (dr.Read())
                {
                    MessageBox.Show("ya hay una factura con ese codigo");
                    limpiar_Datos();
                    return;
                }
            }
            conexion.Close();
        }

        private void pnlContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
