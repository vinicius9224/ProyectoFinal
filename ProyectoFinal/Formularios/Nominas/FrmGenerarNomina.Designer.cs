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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarNomina));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pnlFondoBtn = new System.Windows.Forms.Panel();
            this.pnlDetaNomina = new System.Windows.Forms.Panel();
            this.lblDatosNomina = new System.Windows.Forms.Label();
            this.lblFechaDePago = new System.Windows.Forms.Label();
            this.dttFechaPago = new System.Windows.Forms.DateTimePicker();
            this.lblPagoHasta = new System.Windows.Forms.Label();
            this.lblFechaPagoDesde = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dttHasta = new System.Windows.Forms.DateTimePicker();
            this.dttDesde = new System.Windows.Forms.DateTimePicker();
            this.pnlContenedor.SuspendLayout();
            this.pnlFondoBtn.SuspendLayout();
            this.pnlDetaNomina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.pnlFondoBtn);
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(894, 689);
            this.pnlContenedor.TabIndex = 0;
            // 
            // pnlFondoBtn
            // 
            this.pnlFondoBtn.Controls.Add(this.pnlDetaNomina);
            this.pnlFondoBtn.Controls.Add(this.btnGuardar);
            this.pnlFondoBtn.Controls.Add(this.btnCerrar);
            this.pnlFondoBtn.Controls.Add(this.lblRegSes);
            this.pnlFondoBtn.Location = new System.Drawing.Point(193, 113);
            this.pnlFondoBtn.Name = "pnlFondoBtn";
            this.pnlFondoBtn.Size = new System.Drawing.Size(528, 372);
            this.pnlFondoBtn.TabIndex = 1;
            // 
            // pnlDetaNomina
            // 
            this.pnlDetaNomina.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlDetaNomina.Controls.Add(this.dttDesde);
            this.pnlDetaNomina.Controls.Add(this.dttHasta);
            this.pnlDetaNomina.Controls.Add(this.lblDatosNomina);
            this.pnlDetaNomina.Controls.Add(this.lblFechaDePago);
            this.pnlDetaNomina.Controls.Add(this.dttFechaPago);
            this.pnlDetaNomina.Controls.Add(this.lblPagoHasta);
            this.pnlDetaNomina.Controls.Add(this.lblFechaPagoDesde);
            this.pnlDetaNomina.Location = new System.Drawing.Point(43, 81);
            this.pnlDetaNomina.Name = "pnlDetaNomina";
            this.pnlDetaNomina.Size = new System.Drawing.Size(439, 202);
            this.pnlDetaNomina.TabIndex = 216;
            // 
            // lblDatosNomina
            // 
            this.lblDatosNomina.AutoSize = true;
            this.lblDatosNomina.BackColor = System.Drawing.Color.Gold;
            this.lblDatosNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosNomina.ForeColor = System.Drawing.Color.Black;
            this.lblDatosNomina.Location = new System.Drawing.Point(142, 9);
            this.lblDatosNomina.Name = "lblDatosNomina";
            this.lblDatosNomina.Size = new System.Drawing.Size(147, 20);
            this.lblDatosNomina.TabIndex = 223;
            this.lblDatosNomina.Text = "Datos de Nómina";
            // 
            // lblFechaDePago
            // 
            this.lblFechaDePago.AutoSize = true;
            this.lblFechaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDePago.Location = new System.Drawing.Point(159, 134);
            this.lblFechaDePago.Name = "lblFechaDePago";
            this.lblFechaDePago.Size = new System.Drawing.Size(112, 16);
            this.lblFechaDePago.TabIndex = 208;
            this.lblFechaDePago.Text = "Fecha de pago";
            // 
            // dttFechaPago
            // 
            this.dttFechaPago.CustomFormat = "yyyy--MM-dd";
            this.dttFechaPago.Location = new System.Drawing.Point(115, 162);
            this.dttFechaPago.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dttFechaPago.Name = "dttFechaPago";
            this.dttFechaPago.Size = new System.Drawing.Size(200, 20);
            this.dttFechaPago.TabIndex = 207;
            this.dttFechaPago.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // lblPagoHasta
            // 
            this.lblPagoHasta.AutoSize = true;
            this.lblPagoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagoHasta.Location = new System.Drawing.Point(310, 62);
            this.lblPagoHasta.Name = "lblPagoHasta";
            this.lblPagoHasta.Size = new System.Drawing.Size(86, 16);
            this.lblPagoHasta.TabIndex = 199;
            this.lblPagoHasta.Text = "Pago hasta";
            // 
            // lblFechaPagoDesde
            // 
            this.lblFechaPagoDesde.AutoSize = true;
            this.lblFechaPagoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaPagoDesde.Location = new System.Drawing.Point(16, 62);
            this.lblFechaPagoDesde.Name = "lblFechaPagoDesde";
            this.lblFechaPagoDesde.Size = new System.Drawing.Size(92, 16);
            this.lblFechaPagoDesde.TabIndex = 198;
            this.lblFechaPagoDesde.Text = "Pago desde";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(367, 308);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 44);
            this.btnGuardar.TabIndex = 213;
            this.btnGuardar.Text = "Generar Nómina";
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
            this.btnCerrar.Location = new System.Drawing.Point(43, 308);
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
            this.lblRegSes.Location = new System.Drawing.Point(154, 0);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(244, 25);
            this.lblRegSes.TabIndex = 4;
            this.lblRegSes.Text = "Generar Nóminas";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // dttHasta
            // 
            this.dttHasta.CustomFormat = "yyyy--MM-dd";
            this.dttHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttHasta.Location = new System.Drawing.Point(313, 81);
            this.dttHasta.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dttHasta.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dttHasta.Name = "dttHasta";
            this.dttHasta.Size = new System.Drawing.Size(91, 20);
            this.dttHasta.TabIndex = 224;
            this.dttHasta.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // dttDesde
            // 
            this.dttDesde.CustomFormat = "yyyy--MM-dd";
            this.dttDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dttDesde.Location = new System.Drawing.Point(19, 81);
            this.dttDesde.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dttDesde.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dttDesde.Name = "dttDesde";
            this.dttDesde.Size = new System.Drawing.Size(91, 20);
            this.dttDesde.TabIndex = 225;
            this.dttDesde.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // FrmGenerarNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 689);
            this.Controls.Add(this.pnlContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 728);
            this.MinimumSize = new System.Drawing.Size(910, 728);
            this.Name = "FrmGenerarNomina";
            this.Text = "Generar Nomina";
            this.pnlContenedor.ResumeLayout(false);
            this.pnlFondoBtn.ResumeLayout(false);
            this.pnlDetaNomina.ResumeLayout(false);
            this.pnlDetaNomina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlFondoBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegSes;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel pnlDetaNomina;
        private System.Windows.Forms.Label lblDatosNomina;
        private System.Windows.Forms.Label lblFechaDePago;
        private System.Windows.Forms.DateTimePicker dttFechaPago;
        private System.Windows.Forms.Label lblPagoHasta;
        private System.Windows.Forms.Label lblFechaPagoDesde;
        private System.Windows.Forms.DateTimePicker dttDesde;
        private System.Windows.Forms.DateTimePicker dttHasta;
    }
}