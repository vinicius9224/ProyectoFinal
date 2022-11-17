namespace ProyectoFinal.Formularios.Nominas
{
    partial class FrmHistorialNominas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialNominas));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.pnlHistorialNominas = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.lblRegSes);
            this.pnlContenedor.Controls.Add(this.pnlHistorialNominas);
            this.pnlContenedor.Controls.Add(this.btnCerrar);
            this.pnlContenedor.Controls.Add(this.pictureBox1);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(894, 934);
            this.pnlContenedor.TabIndex = 214;
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
            // lblRegSes
            // 
            this.lblRegSes.BackColor = System.Drawing.Color.DimGray;
            this.lblRegSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegSes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegSes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegSes.Location = new System.Drawing.Point(277, 96);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(244, 25);
            this.lblRegSes.TabIndex = 215;
            this.lblRegSes.Text = "Generar Nominas";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlHistorialNominas
            // 
            this.pnlHistorialNominas.BackColor = System.Drawing.SystemColors.Control;
            this.pnlHistorialNominas.Location = new System.Drawing.Point(12, 177);
            this.pnlHistorialNominas.Name = "pnlHistorialNominas";
            this.pnlHistorialNominas.Size = new System.Drawing.Size(870, 559);
            this.pnlHistorialNominas.TabIndex = 217;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(353, 806);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(115, 44);
            this.btnCerrar.TabIndex = 216;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmHistorialNominas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 934);
            this.Controls.Add(this.pnlContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 973);
            this.MinimumSize = new System.Drawing.Size(910, 973);
            this.Name = "FrmHistorialNominas";
            this.Text = "Historial Nominas";
            this.pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.Label lblRegSes;
        private System.Windows.Forms.Panel pnlHistorialNominas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}