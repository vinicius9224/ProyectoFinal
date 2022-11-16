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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescripNomina = new System.Windows.Forms.TextBox();
            this.lblDescripNomina = new System.Windows.Forms.Label();
            this.txtPagoDesde = new System.Windows.Forms.TextBox();
            this.lblFechaPagoDesde = new System.Windows.Forms.Label();
            this.lblPagoHasta = new System.Windows.Forms.Label();
            this.txtPagoHasta = new System.Windows.Forms.TextBox();
            this.txtViatico = new System.Windows.Forms.TextBox();
            this.lblViatico = new System.Windows.Forms.Label();
            this.txtValorPagado = new System.Windows.Forms.TextBox();
            this.lblValorPagado = new System.Windows.Forms.Label();
            this.txtPagoXHora = new System.Windows.Forms.TextBox();
            this.lblPagoXHora = new System.Windows.Forms.Label();
            this.dttFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.txtTotalHoras = new System.Windows.Forms.TextBox();
            this.lblTotalHoras = new System.Windows.Forms.Label();
            this.pnlDetaNomina = new System.Windows.Forms.Panel();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.alertaError = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnHistorialNominas = new System.Windows.Forms.Button();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlDetaNomina.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHistorialNominas);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.lblRegSes);
            this.panel1.Controls.Add(this.pnlDetaNomina);
            this.panel1.Location = new System.Drawing.Point(72, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 524);
            this.panel1.TabIndex = 1;
            // 
            // txtDescripNomina
            // 
            this.txtDescripNomina.Location = new System.Drawing.Point(10, 53);
            this.txtDescripNomina.Multiline = true;
            this.txtDescripNomina.Name = "txtDescripNomina";
            this.txtDescripNomina.Size = new System.Drawing.Size(180, 62);
            this.txtDescripNomina.TabIndex = 0;
            // 
            // lblDescripNomina
            // 
            this.lblDescripNomina.AutoSize = true;
            this.lblDescripNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripNomina.Location = new System.Drawing.Point(7, 19);
            this.lblDescripNomina.Name = "lblDescripNomina";
            this.lblDescripNomina.Size = new System.Drawing.Size(183, 16);
            this.lblDescripNomina.TabIndex = 196;
            this.lblDescripNomina.Text = "Descripción de la nomina";
            // 
            // txtPagoDesde
            // 
            this.txtPagoDesde.Location = new System.Drawing.Point(10, 183);
            this.txtPagoDesde.Name = "txtPagoDesde";
            this.txtPagoDesde.Size = new System.Drawing.Size(100, 20);
            this.txtPagoDesde.TabIndex = 197;
            // 
            // lblFechaPagoDesde
            // 
            this.lblFechaPagoDesde.AutoSize = true;
            this.lblFechaPagoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPagoDesde.Location = new System.Drawing.Point(7, 149);
            this.lblFechaPagoDesde.Name = "lblFechaPagoDesde";
            this.lblFechaPagoDesde.Size = new System.Drawing.Size(92, 16);
            this.lblFechaPagoDesde.TabIndex = 198;
            this.lblFechaPagoDesde.Text = "Pago desde";
            // 
            // lblPagoHasta
            // 
            this.lblPagoHasta.AutoSize = true;
            this.lblPagoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoHasta.Location = new System.Drawing.Point(145, 149);
            this.lblPagoHasta.Name = "lblPagoHasta";
            this.lblPagoHasta.Size = new System.Drawing.Size(86, 16);
            this.lblPagoHasta.TabIndex = 199;
            this.lblPagoHasta.Text = "Pago hasta";
            // 
            // txtPagoHasta
            // 
            this.txtPagoHasta.Location = new System.Drawing.Point(148, 183);
            this.txtPagoHasta.Name = "txtPagoHasta";
            this.txtPagoHasta.Size = new System.Drawing.Size(100, 20);
            this.txtPagoHasta.TabIndex = 200;
            // 
            // txtViatico
            // 
            this.txtViatico.Location = new System.Drawing.Point(303, 47);
            this.txtViatico.Name = "txtViatico";
            this.txtViatico.Size = new System.Drawing.Size(100, 20);
            this.txtViatico.TabIndex = 202;
            // 
            // lblViatico
            // 
            this.lblViatico.AutoSize = true;
            this.lblViatico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViatico.Location = new System.Drawing.Point(300, 13);
            this.lblViatico.Name = "lblViatico";
            this.lblViatico.Size = new System.Drawing.Size(55, 16);
            this.lblViatico.TabIndex = 201;
            this.lblViatico.Text = "Viatico";
            // 
            // txtValorPagado
            // 
            this.txtValorPagado.Location = new System.Drawing.Point(303, 109);
            this.txtValorPagado.Name = "txtValorPagado";
            this.txtValorPagado.Size = new System.Drawing.Size(100, 20);
            this.txtValorPagado.TabIndex = 204;
            // 
            // lblValorPagado
            // 
            this.lblValorPagado.AutoSize = true;
            this.lblValorPagado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorPagado.Location = new System.Drawing.Point(300, 75);
            this.lblValorPagado.Name = "lblValorPagado";
            this.lblValorPagado.Size = new System.Drawing.Size(102, 16);
            this.lblValorPagado.TabIndex = 203;
            this.lblValorPagado.Text = "Valor pagado";
            // 
            // txtPagoXHora
            // 
            this.txtPagoXHora.Location = new System.Drawing.Point(303, 185);
            this.txtPagoXHora.Name = "txtPagoXHora";
            this.txtPagoXHora.Size = new System.Drawing.Size(100, 20);
            this.txtPagoXHora.TabIndex = 206;
            // 
            // lblPagoXHora
            // 
            this.lblPagoXHora.AutoSize = true;
            this.lblPagoXHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoXHora.Location = new System.Drawing.Point(300, 155);
            this.lblPagoXHora.Name = "lblPagoXHora";
            this.lblPagoXHora.Size = new System.Drawing.Size(106, 16);
            this.lblPagoXHora.TabIndex = 205;
            this.lblPagoXHora.Text = "Pago por hora";
            // 
            // dttFechaPago
            // 
            this.dttFechaPago.Location = new System.Drawing.Point(10, 272);
            this.dttFechaPago.Name = "dttFechaPago";
            this.dttFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dttFechaPago.TabIndex = 207;
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDePago.Location = new System.Drawing.Point(7, 236);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(112, 16);
            this.lblFechaDePago.TabIndex = 208;
            this.lblFechaDePago.Text = "Fecha de pago";
            // 
            // txtTotalHoras
            // 
            this.txtTotalHoras.Location = new System.Drawing.Point(303, 275);
            this.txtTotalHoras.Name = "txtTotalHoras";
            this.txtTotalHoras.Size = new System.Drawing.Size(100, 20);
            this.txtTotalHoras.TabIndex = 210;
            // 
            // lblTotalHoras
            // 
            this.lblTotalHoras.AutoSize = true;
            this.lblTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHoras.Location = new System.Drawing.Point(300, 239);
            this.lblTotalHoras.Name = "lblTotalHoras";
            this.lblTotalHoras.Size = new System.Drawing.Size(86, 16);
            this.lblTotalHoras.TabIndex = 209;
            this.lblTotalHoras.Text = "Total horas";
            // 
            // pnlDetaNomina
            // 
            this.pnlDetaNomina.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDetaNomina.Controls.Add(this.txtTotalHoras);
            this.pnlDetaNomina.Controls.Add(this.lblViatico);
            this.pnlDetaNomina.Controls.Add(this.lblTotalHoras);
            this.pnlDetaNomina.Controls.Add(this.txtViatico);
            this.pnlDetaNomina.Controls.Add(this.lblValorPagado);
            this.pnlDetaNomina.Controls.Add(this.lblFechaDePago);
            this.pnlDetaNomina.Controls.Add(this.txtValorPagado);
            this.pnlDetaNomina.Controls.Add(this.dttFechaPago);
            this.pnlDetaNomina.Controls.Add(this.txtPagoHasta);
            this.pnlDetaNomina.Controls.Add(this.txtPagoXHora);
            this.pnlDetaNomina.Controls.Add(this.lblPagoHasta);
            this.pnlDetaNomina.Controls.Add(this.lblPagoXHora);
            this.pnlDetaNomina.Controls.Add(this.lblFechaPagoDesde);
            this.pnlDetaNomina.Controls.Add(this.txtDescripNomina);
            this.pnlDetaNomina.Controls.Add(this.txtPagoDesde);
            this.pnlDetaNomina.Controls.Add(this.lblDescripNomina);
            this.pnlDetaNomina.Location = new System.Drawing.Point(116, 153);
            this.pnlDetaNomina.Name = "pnlDetaNomina";
            this.pnlDetaNomina.Size = new System.Drawing.Size(415, 315);
            this.pnlDetaNomina.TabIndex = 211;
            // 
            // lblRegSes
            // 
            this.lblRegSes.BackColor = System.Drawing.Color.DimGray;
            this.lblRegSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegSes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegSes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegSes.Location = new System.Drawing.Point(227, 32);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(244, 25);
            this.lblRegSes.TabIndex = 4;
            this.lblRegSes.Text = "Generar Nominas";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(557, 424);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 212;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // alertaError
            // 
            this.alertaError.ContainerControl = this;
            this.alertaError.RightToLeft = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(557, 153);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 44);
            this.btnGuardar.TabIndex = 213;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnHistorialNominas
            // 
            this.btnHistorialNominas.BackColor = System.Drawing.Color.Gold;
            this.btnHistorialNominas.FlatAppearance.BorderSize = 0;
            this.btnHistorialNominas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnHistorialNominas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorialNominas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialNominas.Location = new System.Drawing.Point(557, 294);
            this.btnHistorialNominas.Name = "btnHistorialNominas";
            this.btnHistorialNominas.Size = new System.Drawing.Size(115, 44);
            this.btnHistorialNominas.TabIndex = 214;
            this.btnHistorialNominas.Text = "Historial Nominas";
            this.btnHistorialNominas.UseVisualStyleBackColor = false;
            this.btnHistorialNominas.Click += new System.EventHandler(this.btnHistorialNominas_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlDetaNomina.ResumeLayout(false);
            this.pnlDetaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertaError)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDescripNomina;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDetaNomina;
        private System.Windows.Forms.TextBox txtTotalHoras;
        private System.Windows.Forms.Label lblViatico;
        private System.Windows.Forms.Label lblTotalHoras;
        private System.Windows.Forms.TextBox txtViatico;
        private System.Windows.Forms.Label lblValorPagado;
        private System.Windows.Forms.TextBox txtValorPagado;
        private System.Windows.Forms.TextBox txtPagoXHora;
        private System.Windows.Forms.Label lblPagoXHora;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.DateTimePicker dttFechaPago;
        private System.Windows.Forms.TextBox txtPagoHasta;
        private System.Windows.Forms.Label lblPagoHasta;
        private System.Windows.Forms.Label lblFechaPagoDesde;
        private System.Windows.Forms.TextBox txtPagoDesde;
        private System.Windows.Forms.Label lblDescripNomina;
        private System.Windows.Forms.Label lblRegSes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ErrorProvider alertaError;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnHistorialNominas;
    }
}