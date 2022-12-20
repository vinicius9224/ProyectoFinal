namespace ProyectoFinal.Formularios
{
    partial class FrmAgregarMaestro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarMaestro));
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlDatosMaestro = new System.Windows.Forms.Panel();
            this.lblAgreMaestros = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.comEst = new System.Windows.Forms.ComboBox();
            this.comProf = new System.Windows.Forms.ComboBox();
            this.comMuni = new System.Windows.Forms.ComboBox();
            this.comDep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.txtape = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtdom = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.lblMstr = new System.Windows.Forms.Label();
            this.pnlFondo.SuspendLayout();
            this.pnlDatosMaestro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.Controls.Add(this.pnlDatosMaestro);
            this.pnlFondo.Controls.Add(this.picFondo);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(894, 689);
            this.pnlFondo.TabIndex = 0;
            // 
            // pnlDatosMaestro
            // 
            this.pnlDatosMaestro.BackColor = System.Drawing.Color.LightGray;
            this.pnlDatosMaestro.Controls.Add(this.lblMstr);
            this.pnlDatosMaestro.Controls.Add(this.lblAgreMaestros);
            this.pnlDatosMaestro.Controls.Add(this.btnCerrar);
            this.pnlDatosMaestro.Controls.Add(this.BtnAgregar);
            this.pnlDatosMaestro.Controls.Add(this.comEst);
            this.pnlDatosMaestro.Controls.Add(this.comProf);
            this.pnlDatosMaestro.Controls.Add(this.comMuni);
            this.pnlDatosMaestro.Controls.Add(this.comDep);
            this.pnlDatosMaestro.Controls.Add(this.label1);
            this.pnlDatosMaestro.Controls.Add(this.txtnom);
            this.pnlDatosMaestro.Controls.Add(this.txtape);
            this.pnlDatosMaestro.Controls.Add(this.txtTel);
            this.pnlDatosMaestro.Controls.Add(this.txtdom);
            this.pnlDatosMaestro.Controls.Add(this.txtcod);
            this.pnlDatosMaestro.Controls.Add(this.label10);
            this.pnlDatosMaestro.Controls.Add(this.label9);
            this.pnlDatosMaestro.Controls.Add(this.label8);
            this.pnlDatosMaestro.Controls.Add(this.label7);
            this.pnlDatosMaestro.Controls.Add(this.label5);
            this.pnlDatosMaestro.Controls.Add(this.label4);
            this.pnlDatosMaestro.Controls.Add(this.label3);
            this.pnlDatosMaestro.Controls.Add(this.label2);
            this.pnlDatosMaestro.Location = new System.Drawing.Point(58, 74);
            this.pnlDatosMaestro.Name = "pnlDatosMaestro";
            this.pnlDatosMaestro.Size = new System.Drawing.Size(738, 476);
            this.pnlDatosMaestro.TabIndex = 1;
            // 
            // lblAgreMaestros
            // 
            this.lblAgreMaestros.BackColor = System.Drawing.Color.DimGray;
            this.lblAgreMaestros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgreMaestros.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAgreMaestros.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAgreMaestros.Location = new System.Drawing.Point(217, 0);
            this.lblAgreMaestros.Name = "lblAgreMaestros";
            this.lblAgreMaestros.Size = new System.Drawing.Size(304, 25);
            this.lblAgreMaestros.TabIndex = 220;
            this.lblAgreMaestros.Text = "Agregar Maestros";
            this.lblAgreMaestros.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(191, 411);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 39);
            this.btnCerrar.TabIndex = 42;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregar.Location = new System.Drawing.Point(343, 411);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(83, 39);
            this.BtnAgregar.TabIndex = 41;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // comEst
            // 
            this.comEst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comEst.FormattingEnabled = true;
            this.comEst.Location = new System.Drawing.Point(343, 347);
            this.comEst.Name = "comEst";
            this.comEst.Size = new System.Drawing.Size(121, 23);
            this.comEst.TabIndex = 40;
            this.comEst.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comEst_KeyPress);
            // 
            // comProf
            // 
            this.comProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comProf.FormattingEnabled = true;
            this.comProf.Location = new System.Drawing.Point(343, 272);
            this.comProf.Name = "comProf";
            this.comProf.Size = new System.Drawing.Size(121, 23);
            this.comProf.TabIndex = 39;
            this.comProf.SelectedIndexChanged += new System.EventHandler(this.comProf_SelectedIndexChanged);
            this.comProf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comProf_KeyPress);
            // 
            // comMuni
            // 
            this.comMuni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comMuni.FormattingEnabled = true;
            this.comMuni.Location = new System.Drawing.Point(343, 191);
            this.comMuni.Name = "comMuni";
            this.comMuni.Size = new System.Drawing.Size(121, 23);
            this.comMuni.TabIndex = 38;
            this.comMuni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comMuni_KeyPress);
            // 
            // comDep
            // 
            this.comDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comDep.FormattingEnabled = true;
            this.comDep.Location = new System.Drawing.Point(343, 105);
            this.comDep.Name = "comDep";
            this.comDep.Size = new System.Drawing.Size(121, 23);
            this.comDep.TabIndex = 37;
            this.comDep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comDep_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Código";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(128, 193);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(146, 21);
            this.txtnom.TabIndex = 35;
            this.txtnom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnom_KeyPress);
            // 
            // txtape
            // 
            this.txtape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtape.Location = new System.Drawing.Point(128, 272);
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(146, 21);
            this.txtape.TabIndex = 34;
            this.txtape.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtape_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(128, 349);
            this.txtTel.MaxLength = 8;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(146, 21);
            this.txtTel.TabIndex = 33;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtdom
            // 
            this.txtdom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdom.Location = new System.Drawing.Point(538, 191);
            this.txtdom.Multiline = true;
            this.txtdom.Name = "txtdom";
            this.txtdom.Size = new System.Drawing.Size(155, 105);
            this.txtdom.TabIndex = 32;
            // 
            // txtcod
            // 
            this.txtcod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.Location = new System.Drawing.Point(149, 107);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(125, 21);
            this.txtcod.TabIndex = 31;
            this.txtcod.TextChanged += new System.EventHandler(this.txtcod_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(362, 163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 30;
            this.label10.Text = "Municipio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(177, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 29;
            this.label9.Text = "Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(555, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 16);
            this.label8.TabIndex = 28;
            this.label8.Text = "Domicilio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Teléfono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(344, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Profesión";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(376, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nombre";
            // 
            // picFondo
            // 
            this.picFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFondo.Image = global::ProyectoFinal.Properties.Resources.Fondo2;
            this.picFondo.Location = new System.Drawing.Point(0, 0);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(894, 689);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // lblMstr
            // 
            this.lblMstr.AutoSize = true;
            this.lblMstr.Location = new System.Drawing.Point(107, 111);
            this.lblMstr.Name = "lblMstr";
            this.lblMstr.Size = new System.Drawing.Size(0, 13);
            this.lblMstr.TabIndex = 221;
            // 
            // FrmAgregarMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 689);
            this.Controls.Add(this.pnlFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 728);
            this.MinimumSize = new System.Drawing.Size(910, 726);
            this.Name = "FrmAgregarMaestro";
            this.Text = "Agregar Maestro";
            this.Load += new System.EventHandler(this.FrmAgregarMaestro_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlDatosMaestro.ResumeLayout(false);
            this.pnlDatosMaestro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.Panel pnlDatosMaestro;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Label lblAgreMaestros;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ComboBox comEst;
        private System.Windows.Forms.ComboBox comProf;
        private System.Windows.Forms.ComboBox comMuni;
        private System.Windows.Forms.ComboBox comDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtdom;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMstr;
    }
}