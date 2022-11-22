using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public void mostrar()
        {
            DataRow row = dt.NewRow();

            row["#sesiones"] = txtcant.Text;
            row["costo"] = txtcost.Text;

            
            row["total"] = Int32.Parse(txtcant.Text) * double.Parse(txtcost.Text);
      

            dt.Rows.Add(row);
        }

        #endregion

        #region Botones
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                obj.datosfact(txtcod.Text, txtcant.Text, txtcost.Text, txtfech.Text, txtId.Text, txtest.Text, comser.SelectedValue.ToString(), commod.SelectedValue.ToString());
                MessageBox.Show("Factura Hecha");
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
            var resultado2 = obj.alumnos(Convert.ToInt32(txtId.Text));
            txtnom.Text = resultado2.Item1;
        }
        #endregion
    }
}
