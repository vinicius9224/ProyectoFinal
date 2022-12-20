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

namespace ProyectoFinal.Formularios.Sesiones
{
    public partial class FrmModificarSesion : Form
    {
        DatosSesiones DatSes = new DatosSesiones();

        public FrmModificarSesion()
        {
            InitializeComponent();
            cmbxAño.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbxMes.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FrmModificarSesion_Load(object sender, EventArgs e)
        {
           
        }

        private void cmbxMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxAño.Text!="" && cmbxMes.Text!="")
            {
                int mes = 0;
                SelecMes(ref mes);
                dataGridView1.DataSource = DatSes.ListSesiones(mes, cmbxAño.Text.Trim());
                lblTotal.Text = LlenarTotal().ToString();
            }

            
        }

        private void SelecMes(ref int mes)
        {
            switch (cmbxMes.Text.Trim())
            {
                case "Enero":
                    mes = 1;
                    break;

                case "Febrero":
                    mes = 2;
                    break;

                case "Marzo":
                    mes = 3;
                    break;

                case "Abril":
                    mes = 4;
                    break;

                case "Mayo":
                    mes = 5;
                    break;

                case "Junio":
                    mes = 6;
                    break;

                case "Julio":
                    mes = 7;
                    break;

                case "Agosto":
                    mes = 8;
                    break;

                case "Septiembre":
                    mes = 9;
                    break;

                case "Octubre":
                    mes = 10;
                    break;

                case "Noviembre":
                    mes = 11;
                    break;

                case "Diciembre":
                    mes = 12;
                    break;

                case "Todos":
                    mes = 13;
                    break;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int LlenarTotal()
        {
            int cont = 0;
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                cont++;
            }
            return cont;
        }

        private void cmbxAño_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxAño.Text != "" && cmbxMes.Text != "")
            {
                int mes = 0;
                SelecMes(ref mes);
                dataGridView1.DataSource = DatSes.ListSesiones(mes, cmbxAño.Text.Trim());
                lblTotal.Text = LlenarTotal().ToString();
            }
            
        }
    }
}
