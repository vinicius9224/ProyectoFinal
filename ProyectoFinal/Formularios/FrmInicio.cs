using ProyectoFinal.Formularios.Alumnos;
using ProyectoFinal.Formularios.Configuración;
using ProyectoFinal.Formularios.Facturas;
using ProyectoFinal.Formularios.Maestros;
using ProyectoFinal.Formularios.Nominas;
using ProyectoFinal.Formularios.Sesiones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Formularios
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
            PersonalizarDesing();
        }

        #region ConfigFormulario

        private Form FormularioActual = null;
        private void AbrirFormulario(Form NuevoFormulario)
        {
            //Verifica si existe un formulario activo
            if (FormularioActual != null)

            //Configurar vuevo formulario
            FormularioActual.Close();
            FormularioActual = NuevoFormulario;
            NuevoFormulario.TopLevel = false;
            NuevoFormulario.FormBorderStyle = FormBorderStyle.None;
            NuevoFormulario.Dock = DockStyle.Fill;
            pnlControl.Controls.Add(NuevoFormulario);
            pnlControl.Tag = NuevoFormulario;
            NuevoFormulario.BringToFront();
            NuevoFormulario.Show();
        }

        //Configuración de los paneles
        private void PersonalizarDesing()
        {
            //pnlLogo.Visible = false;
            //pnlMenuLateral.Visible = false;
            pnlSubMenuAlumnos.Visible = false;
            pnlSubMenuMaestros.Visible = false;
            pnlSubMenuSesiones.Visible = false;
            pnlSubMenuFacturas.Visible = false;
            pnlSubMenuNominas.Visible = false;
            pnlSubMenuConfig.Visible = false;
        }

        private void HideSubMenu()//Ocultas los paneles despues de hacer click
        {
            if (pnlSubMenuAlumnos.Visible == true)
            {
                pnlSubMenuAlumnos.Visible = false;
            }
            if (pnlSubMenuMaestros.Visible == true)
            {
                pnlSubMenuMaestros.Visible = false;
            }
            if (pnlSubMenuSesiones.Visible == true)
            {
                pnlSubMenuSesiones.Visible = false;
            }
            if (pnlSubMenuFacturas.Visible == true)
            {
                pnlSubMenuFacturas.Visible = false;
            }
            if (pnlSubMenuNominas.Visible == true)
            {
                pnlSubMenuNominas.Visible = false;
            }
            if (pnlSubMenuConfig.Visible == true)
            {
                pnlSubMenuConfig.Visible = false;
            }
        }

        private void ShowSubMenu(Panel Submenu)//Muestra los paneles
        {
            if (Submenu.Visible == false)
            {
                HideSubMenu();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void Tiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString(); ;
        }

        #endregion

        #region Alumnos
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuAlumnos);
        }

        private void btnAgregarAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgregarAlumno());
            //HideSubMenu();
        }

        private void btnModAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmModificarAlumno());
            //HideSubMenu();
        }


        private void btnListarAlumnos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListarAlumnos());
            //HideSubMenu();
        }
        #endregion

        #region Maestros
        private void btnMaestros_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuMaestros);
        }
        private void btnAgregarMaestro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgregarMaestro());
            //HideSubMenu();
        }

        private void btnModificarMaestro_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmModificarMaestro());
            //HideSubMenu();
        } 


        private void btnListarMaestros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmListarMaestros());
            //HideSubMenu();
        }

        #endregion

        #region Sesiones
        private void btnSesiones_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuSesiones);
        }
        private void btnListarSesiones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmModificarSesion());
            //HideSubMenu();
        }

        private void btnRegSesion_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAgregarSesion());
            //HideSubMenu();
        }

        #endregion

        #region Facturas

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuFacturas);
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGenerarFactura());
            //HideSubMenu();
        }
        private void btnHistorialFactura_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHistorialFacturas());
            //HideSubMenu();
        }

        private void btnIngresosTotales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmIngresosTotales());
            //HideSubMenu();
        }

        #endregion

        #region Nominas

        private void btnNominas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuNominas);
        }

        private void btnGenerarNomina_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmGenerarNomina());
            //HideSubMenu();
        }

        private void btnHistorialNominas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmHistorialNominas());
            //HideSubMenu();
        }

        private void btnEgresosTotales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEgresosTotales());
            //HideSubMenu();
        }

        #endregion

        #region Configuración
        private void btnConfig_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnlSubMenuConfig);
        }

        private void btnCambContra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditarUsuario());
            //HideSubMenu();
        }
        #endregion

        #region Salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin login= new FrmLogin();
            login.Show();
        }

        #endregion

        private void picCerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
