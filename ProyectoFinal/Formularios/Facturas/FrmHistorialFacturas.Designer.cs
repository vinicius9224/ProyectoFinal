namespace ProyectoFinal.Formularios.Facturas
{
    partial class FrmHistorialFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistorialFacturas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbBxBuscar = new System.Windows.Forms.ComboBox();
            this.lblSelectMes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbBxBuscar);
            this.panel1.Controls.Add(this.lblSelectMes);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(58, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 541);
            this.panel1.TabIndex = 0;
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
            this.cmbBxBuscar.Location = new System.Drawing.Point(287, 15);
            this.cmbBxBuscar.Name = "cmbBxBuscar";
            this.cmbBxBuscar.Size = new System.Drawing.Size(151, 21);
            this.cmbBxBuscar.TabIndex = 6;
            this.cmbBxBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBxBuscar_SelectedIndexChanged);
            // 
            // lblSelectMes
            // 
            this.lblSelectMes.AutoSize = true;
            this.lblSelectMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectMes.Location = new System.Drawing.Point(131, 19);
            this.lblSelectMes.Name = "lblSelectMes";
            this.lblSelectMes.Size = new System.Drawing.Size(127, 17);
            this.lblSelectMes.TabIndex = 5;
            this.lblSelectMes.Text = "Seleccionar Mes";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 424);
            this.dataGridView1.TabIndex = 4;
            // 
            // FrmHistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 689);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 728);
            this.MinimumSize = new System.Drawing.Size(910, 726);
            this.Name = "FrmHistorialFacturas";
            this.Text = "Historial Facturas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBxBuscar;
        private System.Windows.Forms.Label lblSelectMes;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}