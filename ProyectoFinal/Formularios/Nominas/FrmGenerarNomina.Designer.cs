namespace ProyectoFinal.Formularios
{
    partial class FrmGenerarNomina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarNomina));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHistorialNominas = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.pnlDetaNomina = new System.Windows.Forms.Panel();
            this.lblDatosPago = new System.Windows.Forms.Label();
            this.lblDatosNomina = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCargoTrab = new System.Windows.Forms.TextBox();
            this.lblProfe = new System.Windows.Forms.Label();
            this.txtApeTrabajador = new System.Windows.Forms.TextBox();
            this.txtNomTrabajador = new System.Windows.Forms.TextBox();
            this.lblApeTrabajador = new System.Windows.Forms.Label();
            this.lblNomTranajador = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodTrabajador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGastosMensuales = new System.Windows.Forms.TextBox();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.lblGastosMensuales = new System.Windows.Forms.Label();
            this.lblViatico = new System.Windows.Forms.Label();
            this.lblTotalHoras = new System.Windows.Forms.Label();
            this.txtViatico = new System.Windows.Forms.TextBox();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.dttFechaPago = new System.Windows.Forms.DateTimePicker();
            this.txtPagoHasta = new System.Windows.Forms.TextBox();
            this.txtPagoXHora = new System.Windows.Forms.TextBox();
            this.lblPagoHasta = new System.Windows.Forms.Label();
            this.lblPagoXHora = new System.Windows.Forms.Label();
            this.lblFechaPagoDesde = new System.Windows.Forms.Label();
            this.txtPagoDesde = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.alertaError = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSueldoBruto = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblGastosFijos = new System.Windows.Forms.Label();
            this.lblFechaGastoMensuales = new System.Windows.Forms.Label();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblFechaGastoMensual = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlDetaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertaError)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(894, 934);
            this.pnlContenedor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistorialNominas);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblRegSes);
            this.panel1.Controls.Add(this.pnlDetaNomina);
            this.panel1.Location = new System.Drawing.Point(35, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(826, 606);
            this.panel1.TabIndex = 1;
            // 
            // btnHistorialNominas
            // 
            this.btnHistorialNominas.BackColor = System.Drawing.Color.RosyBrown;
            this.btnHistorialNominas.FlatAppearance.BorderSize = 0;
            this.btnHistorialNominas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHistorialNominas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialNominas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialNominas.Location = new System.Drawing.Point(335, 533);
            this.btnHistorialNominas.Name = "btnHistorialNominas";
            this.btnHistorialNominas.Size = new System.Drawing.Size(115, 44);
            this.btnHistorialNominas.TabIndex = 214;
            this.btnHistorialNominas.Text = "Historial Nominas";
            this.btnHistorialNominas.UseVisualStyleBackColor = false;
            this.btnHistorialNominas.Click += new System.EventHandler(this.btnHistorialNominas_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(561, 533);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 44);
            this.btnGuardar.TabIndex = 213;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(90, 533);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 212;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblRegSes
            // 
            this.lblRegSes.BackColor = System.Drawing.Color.DimGray;
            this.lblRegSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegSes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegSes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegSes.Location = new System.Drawing.Point(284, 0);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(244, 25);
            this.lblRegSes.TabIndex = 4;
            this.lblRegSes.Text = "Generar Nominas";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDetaNomina
            // 
            this.pnlDetaNomina.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDetaNomina.Controls.Add(this.lblFechaGastoMensual);
            this.pnlDetaNomina.Controls.Add(this.btnCalcular);
            this.pnlDetaNomina.Controls.Add(this.lblSalarioNeto);
            this.pnlDetaNomina.Controls.Add(this.txtSalarioNeto);
            this.pnlDetaNomina.Controls.Add(this.lblFechaGastoMensuales);
            this.pnlDetaNomina.Controls.Add(this.lblGastosFijos);
            this.pnlDetaNomina.Controls.Add(this.txtSueldoBruto);
            this.pnlDetaNomina.Controls.Add(this.lblSalarioBruto);
            this.pnlDetaNomina.Controls.Add(this.lblDatosPago);
            this.pnlDetaNomina.Controls.Add(this.lblDatosNomina);
            this.pnlDetaNomina.Controls.Add(this.label2);
            this.pnlDetaNomina.Controls.Add(this.txtCargoTrab);
            this.pnlDetaNomina.Controls.Add(this.lblProfe);
            this.pnlDetaNomina.Controls.Add(this.txtApeTrabajador);
            this.pnlDetaNomina.Controls.Add(this.txtNomTrabajador);
            this.pnlDetaNomina.Controls.Add(this.lblApeTrabajador);
            this.pnlDetaNomina.Controls.Add(this.lblNomTranajador);
            this.pnlDetaNomina.Controls.Add(this.btnBuscar);
            this.pnlDetaNomina.Controls.Add(this.txtCodTrabajador);
            this.pnlDetaNomina.Controls.Add(this.label1);
            this.pnlDetaNomina.Controls.Add(this.txtGastosMensuales);
            this.pnlDetaNomina.Controls.Add(this.txtTotalHoras);
            this.pnlDetaNomina.Controls.Add(this.lblGastosMensuales);
            this.pnlDetaNomina.Controls.Add(this.lblViatico);
            this.pnlDetaNomina.Controls.Add(this.lblTotalHoras);
            this.pnlDetaNomina.Controls.Add(this.txtViatico);
            this.pnlDetaNomina.Controls.Add(this.lblFechaDePago);
            this.pnlDetaNomina.Controls.Add(this.dttFechaPago);
            this.pnlDetaNomina.Controls.Add(this.txtPagoHasta);
            this.pnlDetaNomina.Controls.Add(this.txtPagoXHora);
            this.pnlDetaNomina.Controls.Add(this.lblPagoHasta);
            this.pnlDetaNomina.Controls.Add(this.lblPagoXHora);
            this.pnlDetaNomina.Controls.Add(this.lblFechaPagoDesde);
            this.pnlDetaNomina.Controls.Add(this.txtPagoDesde);
            this.pnlDetaNomina.Location = new System.Drawing.Point(20, 39);
            this.pnlDetaNomina.Name = "pnlDetaNomina";
            this.pnlDetaNomina.Size = new System.Drawing.Size(779, 445);
            this.pnlDetaNomina.TabIndex = 211;
            // 
            // lblDatosPago
            // 
            this.lblDatosPago.AutoSize = true;
            this.lblDatosPago.BackColor = System.Drawing.Color.Gold;
            this.lblDatosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPago.ForeColor = System.Drawing.Color.Black;
            this.lblDatosPago.Location = new System.Drawing.Point(312, 24);
            this.lblDatosPago.Name = "lblDatosPago";
            this.lblDatosPago.Size = new System.Drawing.Size(128, 20);
            this.lblDatosPago.TabIndex = 224;
            this.lblDatosPago.Text = "Datos de Pago";
            // 
            // lblDatosNomina
            // 
            this.lblDatosNomina.AutoSize = true;
            this.lblDatosNomina.BackColor = System.Drawing.Color.Gold;
            this.lblDatosNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosNomina.ForeColor = System.Drawing.Color.Black;
            this.lblDatosNomina.Location = new System.Drawing.Point(538, 24);
            this.lblDatosNomina.Name = "lblDatosNomina";
            this.lblDatosNomina.Size = new System.Drawing.Size(147, 20);
            this.lblDatosNomina.TabIndex = 223;
            this.lblDatosNomina.Text = "Datos de Nomina";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(30, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 222;
            this.label2.Text = "Datos del Maestro";
            // 
            // txtCargoTrab
            // 
            this.txtCargoTrab.Location = new System.Drawing.Point(25, 306);
            this.txtCargoTrab.Name = "txtCargoTrab";
            this.txtCargoTrab.Size = new System.Drawing.Size(161, 20);
            this.txtCargoTrab.TabIndex = 221;
            // 
            // lblProfe
            // 
            this.lblProfe.AutoSize = true;
            this.lblProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfe.Location = new System.Drawing.Point(28, 275);
            this.lblProfe.Name = "lblProfe";
            this.lblProfe.Size = new System.Drawing.Size(73, 16);
            this.lblProfe.TabIndex = 220;
            this.lblProfe.Text = "Profesión";
            // 
            // txtApeTrabajador
            // 
            this.txtApeTrabajador.Location = new System.Drawing.Point(24, 240);
            this.txtApeTrabajador.Name = "txtApeTrabajador";
            this.txtApeTrabajador.Size = new System.Drawing.Size(162, 20);
            this.txtApeTrabajador.TabIndex = 219;
            // 
            // txtNomTrabajador
            // 
            this.txtNomTrabajador.Location = new System.Drawing.Point(24, 166);
            this.txtNomTrabajador.Name = "txtNomTrabajador";
            this.txtNomTrabajador.Size = new System.Drawing.Size(162, 20);
            this.txtNomTrabajador.TabIndex = 218;
            // 
            // lblApeTrabajador
            // 
            this.lblApeTrabajador.AutoSize = true;
            this.lblApeTrabajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApeTrabajador.Location = new System.Drawing.Point(22, 203);
            this.lblApeTrabajador.Name = "lblApeTrabajador";
            this.lblApeTrabajador.Size = new System.Drawing.Size(87, 16);
            this.lblApeTrabajador.TabIndex = 217;
            this.lblApeTrabajador.Text = "Apellido (s)";
            // 
            // lblNomTranajador
            // 
            this.lblNomTranajador.AutoSize = true;
            this.lblNomTranajador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomTranajador.Location = new System.Drawing.Point(21, 137);
            this.lblNomTranajador.Name = "lblNomTranajador";
            this.lblNomTranajador.Size = new System.Drawing.Size(84, 16);
            this.lblNomTranajador.TabIndex = 216;
            this.lblNomTranajador.Text = "Nombre (s)";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(192, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(67, 26);
            this.btnBuscar.TabIndex = 215;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodTrabajador
            // 
            this.txtCodTrabajador.Location = new System.Drawing.Point(24, 108);
            this.txtCodTrabajador.Name = "txtCodTrabajador";
            this.txtCodTrabajador.Size = new System.Drawing.Size(162, 20);
            this.txtCodTrabajador.TabIndex = 214;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 16);
            this.label1.TabIndex = 213;
            this.label1.Text = "Código del Maestro";
            // 
            // txtGastosMensuales
            // 
            this.txtGastosMensuales.Location = new System.Drawing.Point(542, 326);
            this.txtGastosMensuales.Name = "txtGastosMensuales";
            this.txtGastosMensuales.Size = new System.Drawing.Size(129, 20);
            this.txtGastosMensuales.TabIndex = 212;
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.Location = new System.Drawing.Point(315, 240);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHoras.TabIndex = 210;
            // 
            // lblGastosMensuales
            // 
            this.lblGastosMensuales.AutoSize = true;
            this.lblGastosMensuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosMensuales.Location = new System.Drawing.Point(539, 292);
            this.lblGastosMensuales.Name = "lblGastosMensuales";
            this.lblGastosMensuales.Size = new System.Drawing.Size(135, 16);
            this.lblGastosMensuales.TabIndex = 211;
            this.lblGastosMensuales.Text = "Gastos Mensuales";
            // 
            // lblViatico
            // 
            this.lblViatico.AutoSize = true;
            this.lblViatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViatico.Location = new System.Drawing.Point(313, 74);
            this.lblViatico.Name = "lblViatico";
            this.lblViatico.Size = new System.Drawing.Size(55, 16);
            this.lblViatico.TabIndex = 201;
            this.lblViatico.Text = "Viatico";
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.AutoSize = true;
            this.lblTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoras.Location = new System.Drawing.Point(313, 203);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(86, 16);
            this.lblTotalHoras.TabIndex = 209;
            this.lblTotalHoras.Text = "Total horas";
            // 
            // txtViatico
            // 
            this.txtViatico.Location = new System.Drawing.Point(315, 104);
            this.txtViatico.Name = "txtViatico";
            this.txtViatico.Size = new System.Drawing.Size(100, 20);
            this.txtViatico.TabIndex = 202;
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDePago.Location = new System.Drawing.Point(505, 153);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(112, 16);
            this.lblFechaDePago.TabIndex = 208;
            this.lblFechaDePago.Text = "Fecha de pago";
            // 
            // dttFechaPago
            // 
            this.dttFechaPago.Location = new System.Drawing.Point(508, 189);
            this.dttFechaPago.Name = "dttFechaPago";
            this.dttFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dttFechaPago.TabIndex = 207;
            // 
            // txtPagoHasta
            // 
            this.txtPagoHasta.Location = new System.Drawing.Point(650, 108);
            this.txtPagoHasta.Name = "txtPagoHasta";
            this.txtPagoHasta.Size = new System.Drawing.Size(100, 20);
            this.txtPagoHasta.TabIndex = 200;
            // 
            // txtPagoXHora
            // 
            this.txtPagoXHora.Location = new System.Drawing.Point(315, 166);
            this.txtPagoXHora.Name = "txtPagoXHora";
            this.txtPagoXHora.Size = new System.Drawing.Size(100, 20);
            this.txtPagoXHora.TabIndex = 206;
            // 
            // lblPagoHasta
            // 
            this.lblPagoHasta.AutoSize = true;
            this.lblPagoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoHasta.Location = new System.Drawing.Point(647, 74);
            this.lblPagoHasta.Name = "lblPagoHasta";
            this.lblPagoHasta.Size = new System.Drawing.Size(86, 16);
            this.lblPagoHasta.TabIndex = 199;
            this.lblPagoHasta.Text = "Pago hasta";
            // 
            // lblPagoXHora
            // 
            this.lblPagoXHora.AutoSize = true;
            this.lblPagoXHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoXHora.Location = new System.Drawing.Point(313, 137);
            this.lblPagoXHora.Name = "lblPagoXHora";
            this.lblPagoXHora.Size = new System.Drawing.Size(106, 16);
            this.lblPagoXHora.TabIndex = 205;
            this.lblPagoXHora.Text = "Pago por hora";
            // 
            // lblFechaPagoDesde
            // 
            this.lblFechaPagoDesde.AutoSize = true;
            this.lblFechaPagoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPagoDesde.Location = new System.Drawing.Point(509, 74);
            this.lblFechaPagoDesde.Name = "lblFechaPagoDesde";
            this.lblFechaPagoDesde.Size = new System.Drawing.Size(92, 16);
            this.lblFechaPagoDesde.TabIndex = 198;
            this.lblFechaPagoDesde.Text = "Pago desde";
            // 
            // txtPagoDesde
            // 
            this.txtPagoDesde.Location = new System.Drawing.Point(512, 108);
            this.txtPagoDesde.Name = "txtPagoDesde";
            this.txtPagoDesde.Size = new System.Drawing.Size(100, 20);
            this.txtPagoDesde.TabIndex = 197;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.Fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 934);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // alertaError
            // 
            this.alertaError.ContainerControl = this;
            this.alertaError.RightToLeft = true;
            // 
            // txtSueldoBruto
            // 
            this.txtSueldoBruto.Location = new System.Drawing.Point(25, 385);
            this.txtSueldoBruto.Name = "txtSueldoBruto";
            this.txtSueldoBruto.Size = new System.Drawing.Size(161, 20);
            this.txtSueldoBruto.TabIndex = 226;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(21, 351);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioBruto.TabIndex = 225;
            this.lblSalarioBruto.Text = "Salario Bruto";
            // 
            // lblGastosFijos
            // 
            this.lblGastosFijos.AutoSize = true;
            this.lblGastosFijos.BackColor = System.Drawing.Color.Gold;
            this.lblGastosFijos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosFijos.ForeColor = System.Drawing.Color.Black;
            this.lblGastosFijos.Location = new System.Drawing.Point(540, 247);
            this.lblGastosFijos.Name = "lblGastosFijos";
            this.lblGastosFijos.Size = new System.Drawing.Size(110, 20);
            this.lblGastosFijos.TabIndex = 227;
            this.lblGastosFijos.Text = "Gastos Fijos";
            // 
            // lblFechaGastoMensuales
            // 
            this.lblFechaGastoMensuales.AutoSize = true;
            this.lblFechaGastoMensuales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGastoMensuales.Location = new System.Drawing.Point(540, 358);
            this.lblFechaGastoMensuales.Name = "lblFechaGastoMensuales";
            this.lblFechaGastoMensuales.Size = new System.Drawing.Size(36, 16);
            this.lblFechaGastoMensuales.TabIndex = 229;
            this.lblFechaGastoMensuales.Text = "Mes";
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(316, 306);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(129, 20);
            this.txtSalarioNeto.TabIndex = 230;
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioNeto.Location = new System.Drawing.Point(313, 275);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(94, 16);
            this.lblSalarioNeto.TabIndex = 231;
            this.lblSalarioNeto.Text = "Salario Neto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(316, 341);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 26);
            this.btnCalcular.TabIndex = 232;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblFechaGastoMensual
            // 
            this.lblFechaGastoMensual.AutoSize = true;
            this.lblFechaGastoMensual.BackColor = System.Drawing.Color.White;
            this.lblFechaGastoMensual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaGastoMensual.ForeColor = System.Drawing.Color.Black;
            this.lblFechaGastoMensual.Location = new System.Drawing.Point(536, 385);
            this.lblFechaGastoMensual.Name = "lblFechaGastoMensual";
            this.lblFechaGastoMensual.Size = new System.Drawing.Size(115, 13);
            this.lblFechaGastoMensual.TabIndex = 215;
            this.lblFechaGastoMensual.Text = "lblFechaGastoMensual";
            // 
            // FrmGenerarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 934);
            this.Controls.Add(this.pnlContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 973);
            this.MinimumSize = new System.Drawing.Size(910, 973);
            this.Name = "FrmGenerarNomina";
            this.Text = "Generar Nomina";
            this.pnlContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlDetaNomina.ResumeLayout(false);
            this.pnlDetaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertaError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDetaNomina;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Label lblViatico;
        private System.Windows.Forms.Label lblTotalHoras;
        private System.Windows.Forms.TextBox txtViatico;
        private System.Windows.Forms.TextBox txtPagoXHora;
        private System.Windows.Forms.Label lblPagoXHora;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.DateTimePicker dttFechaPago;
        private System.Windows.Forms.TextBox txtPagoHasta;
        private System.Windows.Forms.Label lblPagoHasta;
        private System.Windows.Forms.Label lblFechaPagoDesde;
        private System.Windows.Forms.TextBox txtPagoDesde;
        private System.Windows.Forms.Label lblRegSes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider alertaError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnHistorialNominas;
        private System.Windows.Forms.TextBox txtGastosMensuales;
        private System.Windows.Forms.Label lblGastosMensuales;
        private System.Windows.Forms.TextBox txtCargoTrab;
        private System.Windows.Forms.Label lblProfe;
        private System.Windows.Forms.TextBox txtApeTrabajador;
        private System.Windows.Forms.TextBox txtNomTrabajador;
        private System.Windows.Forms.Label lblApeTrabajador;
        private System.Windows.Forms.Label lblNomTranajador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodTrabajador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDatosPago;
        private System.Windows.Forms.Label lblDatosNomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSueldoBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblGastosFijos;
        private System.Windows.Forms.Label lblFechaGastoMensuales;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.Label lblFechaGastoMensual;
    }
}