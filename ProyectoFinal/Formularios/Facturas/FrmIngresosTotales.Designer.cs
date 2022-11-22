namespace ProyectoFinal.Formularios.Facturas
{
    partial class FrmIngresosTotales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresosTotales));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbBxBuscar = new System.Windows.Forms.ComboBox();
            this.lblRegSes = new System.Windows.Forms.Label();
            this.lblSelectMes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(134, 74);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbBxBuscar
            // 
            this.cmbBxBuscar.FormattingEnabled = true;
            this.cmbBxBuscar.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Agosto",
            "Septiembre",
            "octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbBxBuscar.Location = new System.Drawing.Point(358, 173);
            this.cmbBxBuscar.Name = "cmbBxBuscar";
            this.cmbBxBuscar.Size = new System.Drawing.Size(149, 21);
            this.cmbBxBuscar.TabIndex = 1;
            this.cmbBxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblRegSes
            // 
            this.lblRegSes.BackColor = System.Drawing.Color.DimGray;
            this.lblRegSes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegSes.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRegSes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblRegSes.Location = new System.Drawing.Point(224, 103);
            this.lblRegSes.Name = "lblRegSes";
            this.lblRegSes.Size = new System.Drawing.Size(362, 30);
            this.lblRegSes.TabIndex = 219;
            this.lblRegSes.Text = "Ingresos Totales";
            this.lblRegSes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSelectMes
            // 
            this.lblSelectMes.AutoSize = true;
            this.lblSelectMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMes.Location = new System.Drawing.Point(216, 173);
            this.lblSelectMes.Name = "lblSelectMes";
            this.lblSelectMes.Size = new System.Drawing.Size(127, 17);
            this.lblSelectMes.TabIndex = 220;
            this.lblSelectMes.Text = "Seleccionar Mes";
            // 
            // FrmIngresosTotales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 689);
            this.Controls.Add(this.lblSelectMes);
            this.Controls.Add(this.lblRegSes);
            this.Controls.Add(this.cmbBxBuscar);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 728);
            this.MinimumSize = new System.Drawing.Size(910, 726);
            this.Name = "FrmIngresosTotales";
            this.Text = "Ingresos Totales";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbBxBuscar;
        private System.Windows.Forms.Label lblRegSes;
        private System.Windows.Forms.Label lblSelectMes;
    }
}