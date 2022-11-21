
namespace ProyectoFinal.Formularios.Nominas
{
    partial class FrmDetalleNomina
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.pnlDetaNomina = new System.Windows.Forms.Panel();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.lblDatosPago = new System.Windows.Forms.Label();
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
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.lblViatico = new System.Windows.Forms.Label();
            this.lblTotalHoras = new System.Windows.Forms.Label();
            this.txtViatico = new System.Windows.Forms.TextBox();
            this.txtPagoXHora = new System.Windows.Forms.TextBox();
            this.lblPagoXHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSesionId = new System.Windows.Forms.TextBox();
            this.txtNominaId = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlDetaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblRegSes);
            this.panel1.Controls.Add(this.pnlDetaNomina);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 689);
            this.panel1.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(470, 573);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 44);
            this.btnGuardar.TabIndex = 221;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Gray;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(259, 573);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 220;
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
            this.lblRegSes.Location = new System.Drawing.Point(297, 91);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(304, 25);
            this.lblRegSes.TabIndex = 219;
            this.lblRegSes.Text = "Generar Nóminas del Maestro";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlDetaNomina
            // 
            this.pnlDetaNomina.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDetaNomina.Controls.Add(this.txtNominaId);
            this.pnlDetaNomina.Controls.Add(this.txtSesionId);
            this.pnlDetaNomina.Controls.Add(this.btnCalcular);
            this.pnlDetaNomina.Controls.Add(this.lblSalarioNeto);
            this.pnlDetaNomina.Controls.Add(this.txtSalarioNeto);
            this.pnlDetaNomina.Controls.Add(this.lblDatosPago);
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
            this.pnlDetaNomina.Controls.Add(this.txtTotalHoras);
            this.pnlDetaNomina.Controls.Add(this.lblViatico);
            this.pnlDetaNomina.Controls.Add(this.lblTotalHoras);
            this.pnlDetaNomina.Controls.Add(this.txtViatico);
            this.pnlDetaNomina.Controls.Add(this.txtPagoXHora);
            this.pnlDetaNomina.Controls.Add(this.lblPagoXHora);
            this.pnlDetaNomina.Location = new System.Drawing.Point(99, 146);
            this.pnlDetaNomina.Name = "pnlDetaNomina";
            this.pnlDetaNomina.Size = new System.Drawing.Size(659, 395);
            this.pnlDetaNomina.TabIndex = 218;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.Maroon;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(486, 341);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 26);
            this.btnCalcular.TabIndex = 232;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioNeto.Location = new System.Drawing.Point(483, 275);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(94, 16);
            this.lblSalarioNeto.TabIndex = 231;
            this.lblSalarioNeto.Text = "Salario Neto";
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(486, 306);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.Size = new System.Drawing.Size(129, 20);
            this.txtSalarioNeto.TabIndex = 230;
            // 
            // lblDatosPago
            // 
            this.lblDatosPago.AutoSize = true;
            this.lblDatosPago.BackColor = System.Drawing.Color.Gold;
            this.lblDatosPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosPago.ForeColor = System.Drawing.Color.Black;
            this.lblDatosPago.Location = new System.Drawing.Point(482, 24);
            this.lblDatosPago.Name = "lblDatosPago";
            this.lblDatosPago.Size = new System.Drawing.Size(128, 20);
            this.lblDatosPago.TabIndex = 224;
            this.lblDatosPago.Text = "Datos de Pago";
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
            this.btnBuscar.BackColor = System.Drawing.Color.Brown;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
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
            // txtTotalHoras
            // 
            this.txtTotalHoras.Location = new System.Drawing.Point(485, 240);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHoras.TabIndex = 210;
            // 
            // lblViatico
            // 
            this.lblViatico.AutoSize = true;
            this.lblViatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViatico.Location = new System.Drawing.Point(483, 74);
            this.lblViatico.Name = "lblViatico";
            this.lblViatico.Size = new System.Drawing.Size(55, 16);
            this.lblViatico.TabIndex = 201;
            this.lblViatico.Text = "Viatico";
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.AutoSize = true;
            this.lblTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoras.Location = new System.Drawing.Point(483, 203);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(86, 16);
            this.lblTotalHoras.TabIndex = 209;
            this.lblTotalHoras.Text = "Total horas";
            // 
            // txtViatico
            // 
            this.txtViatico.Location = new System.Drawing.Point(485, 104);
            this.txtViatico.Name = "txtViatico";
            this.txtViatico.Size = new System.Drawing.Size(100, 20);
            this.txtViatico.TabIndex = 202;
            // 
            // txtPagoXHora
            // 
            this.txtPagoXHora.Location = new System.Drawing.Point(485, 166);
            this.txtPagoXHora.Name = "txtPagoXHora";
            this.txtPagoXHora.Size = new System.Drawing.Size(100, 20);
            this.txtPagoXHora.TabIndex = 206;
            // 
            // lblPagoXHora
            // 
            this.lblPagoXHora.AutoSize = true;
            this.lblPagoXHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoXHora.Location = new System.Drawing.Point(483, 137);
            this.lblPagoXHora.Name = "lblPagoXHora";
            this.lblPagoXHora.Size = new System.Drawing.Size(106, 16);
            this.lblPagoXHora.TabIndex = 205;
            this.lblPagoXHora.Text = "Pago por hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.Fondo2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(894, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtSesionId
            // 
            this.txtSesionId.Location = new System.Drawing.Point(273, 240);
            this.txtSesionId.Name = "txtSesionId";
            this.txtSesionId.Size = new System.Drawing.Size(100, 20);
            this.txtSesionId.TabIndex = 233;
            // 
            // txtNominaId
            // 
            this.txtNominaId.Location = new System.Drawing.Point(273, 199);
            this.txtNominaId.Name = "txtNominaId";
            this.txtNominaId.Size = new System.Drawing.Size(100, 20);
            this.txtNominaId.TabIndex = 234;
            // 
            // FrmDetalleNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 689);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDetalleNomina";
            this.Text = "FrmDatosNomina";
            this.Load += new System.EventHandler(this.FrmDetalleNomina_Load);
            this.panel1.ResumeLayout(false);
            this.pnlDetaNomina.ResumeLayout(false);
            this.pnlDetaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRegSes;
        private System.Windows.Forms.Panel pnlDetaNomina;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.Label lblDatosPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCargoTrab;
        private System.Windows.Forms.Label lblProfe;
        private System.Windows.Forms.TextBox txtApeTrabajador;
        private System.Windows.Forms.TextBox txtNomTrabajador;
        private System.Windows.Forms.Label lblApeTrabajador;
        private System.Windows.Forms.Label lblNomTranajador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodTrabajador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Label lblViatico;
        private System.Windows.Forms.Label lblTotalHoras;
        private System.Windows.Forms.TextBox txtViatico;
        private System.Windows.Forms.TextBox txtPagoXHora;
        private System.Windows.Forms.Label lblPagoXHora;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtNominaId;
        private System.Windows.Forms.TextBox txtSesionId;
    }
}