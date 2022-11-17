namespace ProyectoFinal.Formularios.Alumnos
{
    partial class FrmListarAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListarAlumnos));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.lblListarAlumno = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtBus = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.pnlFondoListar = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlContenedor.SuspendLayout();
            this.pnlFondoListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.lblListarAlumno);
            this.pnlContenedor.Controls.Add(this.btnCerrar);
            this.pnlContenedor.Controls.Add(this.txtBus);
            this.pnlContenedor.Controls.Add(this.lblBuscar);
            this.pnlContenedor.Controls.Add(this.pnlFondoListar);
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(894, 934);
            this.pnlContenedor.TabIndex = 0;
            // 
            // lblListarAlumno
            // 
            this.lblListarAlumno.BackColor = System.Drawing.Color.DimGray;
            this.lblListarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarAlumno.ForeColor = System.Drawing.SystemColors.Control;
            this.lblListarAlumno.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblListarAlumno.Location = new System.Drawing.Point(309, 41);
            this.lblListarAlumno.Name = "lblListarAlumno";
            this.lblListarAlumno.Size = new System.Drawing.Size(244, 28);
            this.lblListarAlumno.TabIndex = 19;
            this.lblListarAlumno.Text = "Listar Alumno";
            this.lblListarAlumno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(388, 840);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 34);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // txtBus
            // 
            this.txtBus.Location = new System.Drawing.Point(148, 109);
            this.txtBus.Name = "txtBus";
            this.txtBus.Size = new System.Drawing.Size(641, 20);
            this.txtBus.TabIndex = 4;
            this.txtBus.TextChanged += new System.EventHandler(this.txtBus_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Gray;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(68, 109);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(65, 20);
            this.lblBuscar.TabIndex = 5;
            this.lblBuscar.Text = "Buscar";
            // 
            // pnlFondoListar
            // 
            this.pnlFondoListar.Controls.Add(this.dataGridView1);
            this.pnlFondoListar.Location = new System.Drawing.Point(57, 150);
            this.pnlFondoListar.Name = "pnlFondoListar";
            this.pnlFondoListar.Size = new System.Drawing.Size(773, 674);
            this.pnlFondoListar.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 641);
            this.dataGridView1.TabIndex = 0;
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
            // FrmListarAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 934);
            this.Controls.Add(this.pnlContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 973);
            this.MinimumSize = new System.Drawing.Size(910, 973);
            this.Name = "FrmListarAlumnos";
            this.Text = "Listar Alumnos";
            this.Load += new System.EventHandler(this.FrmListarAlumnos_Load_1);
            this.pnlContenedor.ResumeLayout(false);
            this.pnlContenedor.PerformLayout();
            this.pnlFondoListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Panel pnlFondoListar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtBus;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblListarAlumno;
    }
}