namespace ProyectoFinal.Formularios.Configuración
{
    partial class FrmEditarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditarUsuario));
            this.pnlContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlConfirmar = new System.Windows.Forms.Panel();
            this.lblContra = new System.Windows.Forms.Label();
            this.txtContraNueva = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCambiarContra = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.picFondo = new System.Windows.Forms.PictureBox();
            this.picFondoLogin = new System.Windows.Forms.PictureBox();
            this.pnlConifgFondo = new System.Windows.Forms.Panel();
            this.pnlContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlConfirmar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoLogin)).BeginInit();
            this.pnlConifgFondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Controls.Add(this.panel1);
            this.pnlContenedor.Controls.Add(this.picFondo);
            this.pnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(894, 689);
            this.pnlContenedor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pnlConifgFondo);
            this.panel1.Controls.Add(this.picFondoLogin);
            this.panel1.Location = new System.Drawing.Point(199, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 522);
            this.panel1.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(138, 386);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(83, 35);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.Moccasin;
            this.btnVerificar.FlatAppearance.BorderSize = 0;
            this.btnVerificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(255, 168);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(100, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txtContraActual
            // 
            this.txtContraActual.BackColor = System.Drawing.Color.White;
            this.txtContraActual.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraActual.ForeColor = System.Drawing.Color.Black;
            this.txtContraActual.Location = new System.Drawing.Point(36, 171);
            this.txtContraActual.Multiline = true;
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.PasswordChar = '*';
            this.txtContraActual.Size = new System.Drawing.Size(200, 20);
            this.txtContraActual.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 197;
            this.label2.Text = "Nombre de Usuario";
            // 
            // pnlConfirmar
            // 
            this.pnlConfirmar.BackColor = System.Drawing.Color.DarkGray;
            this.pnlConfirmar.Controls.Add(this.lblContra);
            this.pnlConfirmar.Controls.Add(this.txtContraNueva);
            this.pnlConfirmar.Controls.Add(this.btnConfirmar);
            this.pnlConfirmar.Controls.Add(this.btnCancelar);
            this.pnlConfirmar.Location = new System.Drawing.Point(31, 216);
            this.pnlConfirmar.Name = "pnlConfirmar";
            this.pnlConfirmar.Size = new System.Drawing.Size(322, 154);
            this.pnlConfirmar.TabIndex = 2;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.BackColor = System.Drawing.Color.White;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.ForeColor = System.Drawing.Color.Black;
            this.lblContra.Location = new System.Drawing.Point(59, 20);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(203, 17);
            this.lblContra.TabIndex = 2;
            this.lblContra.Text = "Digite la nueva contraseña";
            // 
            // txtContraNueva
            // 
            this.txtContraNueva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraNueva.Location = new System.Drawing.Point(48, 49);
            this.txtContraNueva.Multiline = true;
            this.txtContraNueva.Name = "txtContraNueva";
            this.txtContraNueva.PasswordChar = '*';
            this.txtContraNueva.Size = new System.Drawing.Size(218, 19);
            this.txtContraNueva.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.Location = new System.Drawing.Point(174, 93);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(92, 32);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(48, 93);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 32);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 195;
            this.label1.Text = "Digite la contraseña actual";
            // 
            // lblCambiarContra
            // 
            this.lblCambiarContra.BackColor = System.Drawing.Color.Transparent;
            this.lblCambiarContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarContra.ForeColor = System.Drawing.Color.Black;
            this.lblCambiarContra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCambiarContra.Location = new System.Drawing.Point(31, 9);
            this.lblCambiarContra.Name = "lblCambiarContra";
            this.lblCambiarContra.Size = new System.Drawing.Size(322, 32);
            this.lblCambiarContra.TabIndex = 192;
            this.lblCambiarContra.Text = "Cambiar Contraseña";
            this.lblCambiarContra.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.BackColor = System.Drawing.Color.White;
            this.lblNomUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomUsuario.Location = new System.Drawing.Point(144, 92);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(0, 16);
            this.lblNomUsuario.TabIndex = 0;
            // 
            // picFondo
            // 
            this.picFondo.BackColor = System.Drawing.Color.White;
            this.picFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFondo.Location = new System.Drawing.Point(0, 0);
            this.picFondo.Name = "picFondo";
            this.picFondo.Size = new System.Drawing.Size(894, 689);
            this.picFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFondo.TabIndex = 0;
            this.picFondo.TabStop = false;
            // 
            // picFondoLogin
            // 
            this.picFondoLogin.Image = ((System.Drawing.Image)(resources.GetObject("picFondoLogin.Image")));
            this.picFondoLogin.Location = new System.Drawing.Point(3, 4);
            this.picFondoLogin.Name = "picFondoLogin";
            this.picFondoLogin.Size = new System.Drawing.Size(460, 489);
            this.picFondoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFondoLogin.TabIndex = 198;
            this.picFondoLogin.TabStop = false;
            // 
            // pnlConifgFondo
            // 
            this.pnlConifgFondo.BackColor = System.Drawing.Color.LightGray;
            this.pnlConifgFondo.Controls.Add(this.btnCerrar);
            this.pnlConifgFondo.Controls.Add(this.lblNomUsuario);
            this.pnlConifgFondo.Controls.Add(this.btnVerificar);
            this.pnlConifgFondo.Controls.Add(this.lblCambiarContra);
            this.pnlConifgFondo.Controls.Add(this.txtContraActual);
            this.pnlConifgFondo.Controls.Add(this.label1);
            this.pnlConifgFondo.Controls.Add(this.label2);
            this.pnlConifgFondo.Controls.Add(this.pnlConfirmar);
            this.pnlConifgFondo.Location = new System.Drawing.Point(38, 19);
            this.pnlConifgFondo.Name = "pnlConifgFondo";
            this.pnlConifgFondo.Size = new System.Drawing.Size(393, 455);
            this.pnlConifgFondo.TabIndex = 199;
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 689);
            this.Controls.Add(this.pnlContenedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(910, 728);
            this.MinimumSize = new System.Drawing.Size(910, 728);
            this.Name = "FrmEditarUsuario";
            this.Text = "FrmEditarUsuario";
            this.Load += new System.EventHandler(this.FrmEditarUsuario_Load);
            this.pnlContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlConfirmar.ResumeLayout(false);
            this.pnlConfirmar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFondoLogin)).EndInit();
            this.pnlConifgFondo.ResumeLayout(false);
            this.pnlConifgFondo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedor;
        private System.Windows.Forms.PictureBox picFondo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtContraNueva;
        private System.Windows.Forms.Label lblCambiarContra;
        private System.Windows.Forms.Panel pnlConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.PictureBox picFondoLogin;
        private System.Windows.Forms.Panel pnlConifgFondo;
    }
}