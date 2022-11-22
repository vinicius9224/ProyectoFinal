namespace ProyectoFinal.Formularios.Sesiones
{
    partial class FrmAgregarSesion
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
            System.Windows.Forms.Panel panel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarSesion));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbBxBuscar = new System.Windows.Forms.ComboBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.txtCodFactur = new System.Windows.Forms.TextBox();
            this.txtCodTrab = new System.Windows.Forms.TextBox();
            this.txtCantHrsSes = new System.Windows.Forms.TextBox();
            this.datTimeSes = new System.Windows.Forms.DateTimePicker();
            this.txtCodSes = new System.Windows.Forms.TextBox();
            this.lblFechSes = new System.Windows.Forms.Label();
            this.lblCodFactur = new System.Windows.Forms.Label();
            this.lblCodTrab = new System.Windows.Forms.Label();
            this.lblCantHorsSes = new System.Windows.Forms.Label();
            this.lblCodSes = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor.SuspendLayout();
            this.panelBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Gray;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.CausesValidation = false;
            panel1.Enabled = false;
            panel1.Location = new System.Drawing.Point(341, 67);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(10, 510);
            panel1.TabIndex = 10;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(panel1);
            this.panelContenedor.Controls.Add(this.btnCancelar);
            this.panelContenedor.Controls.Add(this.btnGuardar);
            this.panelContenedor.Controls.Add(this.lblRegSes);
            this.panelContenedor.Controls.Add(this.panelBuscar);
            this.panelContenedor.Controls.Add(this.panelDatos);
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(894, 689);
            this.panelContenedor.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(254, 607);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 44);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(446, 607);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(115, 44);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblRegSes
            // 
            this.lblRegSes.BackColor = System.Drawing.Color.DimGray;
            this.lblRegSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegSes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegSes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegSes.Location = new System.Drawing.Point(340, 26);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(244, 25);
            this.lblRegSes.TabIndex = 3;
            this.lblRegSes.Text = "Registrar Sesiones";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelBuscar
            // 
            this.panelBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.panelBuscar.Controls.Add(this.lblBuscar);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Controls.Add(this.btnSeleccion);
            this.panelBuscar.Controls.Add(this.dataGridView1);
            this.panelBuscar.Controls.Add(this.cmbBxBuscar);
            this.panelBuscar.Location = new System.Drawing.Point(351, 67);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(534, 510);
            this.panelBuscar.TabIndex = 2;
            // 
            // lblBuscar
            // 
            this.lblBuscar.BackColor = System.Drawing.Color.Gray;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblBuscar.Location = new System.Drawing.Point(15, 8);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(76, 23);
            this.lblBuscar.TabIndex = 6;
            this.lblBuscar.Text = "Buscar";
            this.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(97, 10);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(296, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSeleccion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSeleccion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSeleccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.Location = new System.Drawing.Point(200, 479);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(109, 24);
            this.btnSeleccion.TabIndex = 4;
            this.btnSeleccion.Text = "Seleccionar";
            this.btnSeleccion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(501, 423);
            this.dataGridView1.TabIndex = 3;
            // 
            // cmbBxBuscar
            // 
            this.cmbBxBuscar.BackColor = System.Drawing.Color.Silver;
            this.cmbBxBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmbBxBuscar.ForeColor = System.Drawing.Color.Black;
            this.cmbBxBuscar.FormattingEnabled = true;
            this.cmbBxBuscar.Items.AddRange(new object[] {
            "Trabajadores",
            "Facturas"});
            this.cmbBxBuscar.Location = new System.Drawing.Point(399, 10);
            this.cmbBxBuscar.Name = "cmbBxBuscar";
            this.cmbBxBuscar.Size = new System.Drawing.Size(105, 21);
            this.cmbBxBuscar.TabIndex = 0;
            this.cmbBxBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBxBuscar_SelectedIndexChanged);
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.SystemColors.Control;
            this.panelDatos.Controls.Add(this.txtCodFactur);
            this.panelDatos.Controls.Add(this.txtCodTrab);
            this.panelDatos.Controls.Add(this.txtCantHrsSes);
            this.panelDatos.Controls.Add(this.datTimeSes);
            this.panelDatos.Controls.Add(this.txtCodSes);
            this.panelDatos.Controls.Add(this.lblFechSes);
            this.panelDatos.Controls.Add(this.lblCodFactur);
            this.panelDatos.Controls.Add(this.lblCodTrab);
            this.panelDatos.Controls.Add(this.lblCantHorsSes);
            this.panelDatos.Controls.Add(this.lblCodSes);
            this.panelDatos.Location = new System.Drawing.Point(39, 67);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(302, 510);
            this.panelDatos.TabIndex = 1;
            // 
            // txtCodFactur
            // 
            this.txtCodFactur.Location = new System.Drawing.Point(69, 342);
            this.txtCodFactur.Name = "txtCodFactur";
            this.txtCodFactur.Size = new System.Drawing.Size(140, 20);
            this.txtCodFactur.TabIndex = 9;
            this.txtCodFactur.TextChanged += new System.EventHandler(this.txtCodFactur_TextChanged);
            // 
            // txtCodTrab
            // 
            this.txtCodTrab.Location = new System.Drawing.Point(70, 225);
            this.txtCodTrab.Name = "txtCodTrab";
            this.txtCodTrab.Size = new System.Drawing.Size(140, 20);
            this.txtCodTrab.TabIndex = 8;
            this.txtCodTrab.TextChanged += new System.EventHandler(this.txtCodTrab_TextChanged);
            // 
            // txtCantHrsSes
            // 
            this.txtCantHrsSes.Location = new System.Drawing.Point(70, 136);
            this.txtCantHrsSes.Name = "txtCantHrsSes";
            this.txtCantHrsSes.Size = new System.Drawing.Size(140, 20);
            this.txtCantHrsSes.TabIndex = 7;
            this.txtCantHrsSes.TextChanged += new System.EventHandler(this.txtCantHrsSes_TextChanged);
            this.txtCantHrsSes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantHrsSes_KeyPress);
            // 
            // datTimeSes
            // 
            this.datTimeSes.CustomFormat = "yyyy--MM-dd";
            this.datTimeSes.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datTimeSes.Location = new System.Drawing.Point(45, 462);
            this.datTimeSes.MaxDate = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.datTimeSes.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.datTimeSes.Name = "datTimeSes";
            this.datTimeSes.Size = new System.Drawing.Size(165, 20);
            this.datTimeSes.TabIndex = 6;
            this.datTimeSes.Value = new System.DateTime(2022, 11, 6, 0, 0, 0, 0);
            // 
            // txtCodSes
            // 
            this.txtCodSes.Location = new System.Drawing.Point(70, 48);
            this.txtCodSes.Name = "txtCodSes";
            this.txtCodSes.Size = new System.Drawing.Size(140, 20);
            this.txtCodSes.TabIndex = 5;
            this.txtCodSes.TextChanged += new System.EventHandler(this.txtCodSes_TextChanged);
            // 
            // lblFechSes
            // 
            this.lblFechSes.BackColor = System.Drawing.Color.Silver;
            this.lblFechSes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFechSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechSes.ForeColor = System.Drawing.Color.Black;
            this.lblFechSes.Location = new System.Drawing.Point(45, 392);
            this.lblFechSes.Name = "lblFechSes";
            this.lblFechSes.Size = new System.Drawing.Size(165, 41);
            this.lblFechSes.TabIndex = 4;
            this.lblFechSes.Text = "Fecha de la sesión";
            this.lblFechSes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCodFactur
            // 
            this.lblCodFactur.BackColor = System.Drawing.Color.Silver;
            this.lblCodFactur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodFactur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodFactur.ForeColor = System.Drawing.Color.Black;
            this.lblCodFactur.Location = new System.Drawing.Point(26, 270);
            this.lblCodFactur.Name = "lblCodFactur";
            this.lblCodFactur.Size = new System.Drawing.Size(242, 39);
            this.lblCodFactur.TabIndex = 3;
            this.lblCodFactur.Text = "Código de la factura al que pertenece esta sesión";
            this.lblCodFactur.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodTrab
            // 
            this.lblCodTrab.BackColor = System.Drawing.Color.Silver;
            this.lblCodTrab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodTrab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTrab.ForeColor = System.Drawing.Color.Black;
            this.lblCodTrab.Location = new System.Drawing.Point(26, 181);
            this.lblCodTrab.Name = "lblCodTrab";
            this.lblCodTrab.Size = new System.Drawing.Size(242, 20);
            this.lblCodTrab.TabIndex = 2;
            this.lblCodTrab.Text = "Código del trabajador";
            this.lblCodTrab.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCantHorsSes
            // 
            this.lblCantHorsSes.BackColor = System.Drawing.Color.Silver;
            this.lblCantHorsSes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantHorsSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantHorsSes.ForeColor = System.Drawing.Color.Black;
            this.lblCantHorsSes.Location = new System.Drawing.Point(26, 88);
            this.lblCantHorsSes.Name = "lblCantHorsSes";
            this.lblCantHorsSes.Size = new System.Drawing.Size(242, 23);
            this.lblCantHorsSes.TabIndex = 1;
            this.lblCantHorsSes.Text = "Cantidad de horas de la sesión";
            this.lblCantHorsSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCodSes
            // 
            this.lblCodSes.BackColor = System.Drawing.Color.Silver;
            this.lblCodSes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodSes.ForeColor = System.Drawing.Color.Black;
            this.lblCodSes.Location = new System.Drawing.Point(26, 10);
            this.lblCodSes.Name = "lblCodSes";
            this.lblCodSes.Size = new System.Drawing.Size(242, 23);
            this.lblCodSes.TabIndex = 0;
            this.lblCodSes.Text = "Código de la sesión";
            this.lblCodSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 100;
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmAgregarSesion
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(894, 689);
            this.Controls.Add(this.panelContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 728);
            this.MinimumSize = new System.Drawing.Size(910, 728);
            this.Name = "FrmAgregarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Sesión";
            this.panelContenedor.ResumeLayout(false);
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegSes;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.TextBox txtCodFactur;
        private System.Windows.Forms.TextBox txtCodTrab;
        private System.Windows.Forms.TextBox txtCantHrsSes;
        private System.Windows.Forms.DateTimePicker datTimeSes;
        private System.Windows.Forms.TextBox txtCodSes;
        private System.Windows.Forms.Label lblFechSes;
        private System.Windows.Forms.Label lblCodFactur;
        private System.Windows.Forms.Label lblCodTrab;
        private System.Windows.Forms.Label lblCantHorsSes;
        private System.Windows.Forms.Label lblCodSes;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cmbBxBuscar;
    }
}