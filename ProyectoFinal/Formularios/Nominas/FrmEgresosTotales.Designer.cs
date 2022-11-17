namespace ProyectoFinal.Formularios.Nominas
{
    partial class FrmEgresosTotales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEgresosTotales));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.picBoxFondo = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.lblRegSes);
            this.pnlContenedor.Controls.Add(this.btnCerrar);
            this.pnlContenedor.Controls.Add(this.dataGridView1);
            this.pnlContenedor.Controls.Add(this.picBoxFondo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(894, 934);
            this.pnlContenedor.TabIndex = 0;
            // 
            // picBoxFondo
            // 
            this.picBoxFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxFondo.Image = global::ProyectoFinal.Properties.Resources.Fondo2;
            this.picBoxFondo.Location = new System.Drawing.Point(0, 0);
            this.picBoxFondo.Name = "picBoxFondo";
            this.picBoxFondo.Size = new System.Drawing.Size(894, 934);
            this.picBoxFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFondo.TabIndex = 0;
            this.picBoxFondo.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(821, 686);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(358, 862);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 217;
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
            this.lblRegSes.Location = new System.Drawing.Point(312, 77);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(244, 25);
            this.lblRegSes.TabIndex = 218;
            this.lblRegSes.Text = "Egresos Totales";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FrmEgresosTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 934);
            this.Controls.Add(this.pnlContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 973);
            this.MinimumSize = new System.Drawing.Size(910, 973);
            this.Name = "FrmEgresosTotales";
            this.Text = "Egresos Totales";
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox picBoxFondo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblRegSes;
    }
}