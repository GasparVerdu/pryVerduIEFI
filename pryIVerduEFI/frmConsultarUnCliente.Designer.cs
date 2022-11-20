namespace pryIVerduEFI
{
    partial class frmConsultarUnCliente
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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblDocumentoCliente = new System.Windows.Forms.Label();
            this.tSConeccionBd = new System.Windows.Forms.ToolStrip();
            this.tSEstadoConeccion = new System.Windows.Forms.ToolStripLabel();
            this.grbDatos.SuspendLayout();
            this.tSConeccionBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(280, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.cboActividad);
            this.grbDatos.Controls.Add(this.cboBarrio);
            this.grbDatos.Controls.Add(this.txtSaldo);
            this.grbDatos.Controls.Add(this.txtDireccion);
            this.grbDatos.Controls.Add(this.txtNombreApellido);
            this.grbDatos.Controls.Add(this.lblSaldo);
            this.grbDatos.Controls.Add(this.lblActividad);
            this.grbDatos.Controls.Add(this.lblBarrio);
            this.grbDatos.Controls.Add(this.lblDireccion);
            this.grbDatos.Controls.Add(this.lblNombreYApellido);
            this.grbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(24, 71);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(310, 316);
            this.grbDatos.TabIndex = 9;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos del cliente";
            // 
            // cboActividad
            // 
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(158, 205);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(132, 26);
            this.cboActividad.TabIndex = 9;
            // 
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(158, 154);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(132, 26);
            this.cboBarrio.TabIndex = 8;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(158, 262);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(132, 24);
            this.txtSaldo.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(158, 100);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(132, 24);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(158, 44);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(132, 24);
            this.txtNombreApellido.TabIndex = 5;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(6, 262);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 18);
            this.lblSaldo.TabIndex = 4;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(6, 208);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(80, 18);
            this.lblActividad.TabIndex = 3;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(6, 154);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(59, 18);
            this.lblBarrio.TabIndex = 2;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 100);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 18);
            this.lblDireccion.TabIndex = 1;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Location = new System.Drawing.Point(6, 46);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(149, 18);
            this.lblNombreYApellido.TabIndex = 0;
            this.lblNombreYApellido.Text = "Nombre y apellido:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(156, 22);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 20);
            this.txtDocumento.TabIndex = 8;
            // 
            // lblDocumentoCliente
            // 
            this.lblDocumentoCliente.AutoSize = true;
            this.lblDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumentoCliente.Location = new System.Drawing.Point(21, 22);
            this.lblDocumentoCliente.Name = "lblDocumentoCliente";
            this.lblDocumentoCliente.Size = new System.Drawing.Size(85, 16);
            this.lblDocumentoCliente.TabIndex = 7;
            this.lblDocumentoCliente.Text = "Documento";
            // 
            // tSConeccionBd
            // 
            this.tSConeccionBd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSConeccionBd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSEstadoConeccion});
            this.tSConeccionBd.Location = new System.Drawing.Point(0, 389);
            this.tSConeccionBd.Name = "tSConeccionBd";
            this.tSConeccionBd.Size = new System.Drawing.Size(356, 25);
            this.tSConeccionBd.TabIndex = 14;
            this.tSConeccionBd.Text = "toolStrip1";
            // 
            // tSEstadoConeccion
            // 
            this.tSEstadoConeccion.Name = "tSEstadoConeccion";
            this.tSEstadoConeccion.Size = new System.Drawing.Size(86, 22);
            this.tSEstadoConeccion.Text = "toolStripLabel1";
            // 
            // frmConsultarUnCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 414);
            this.Controls.Add(this.tSConeccionBd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.grbDatos);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumentoCliente);
            this.Name = "frmConsultarUnCliente";
            this.Text = "Consultar un cliente";
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.tSConeccionBd.ResumeLayout(false);
            this.tSConeccionBd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblDocumentoCliente;
        private System.Windows.Forms.ToolStrip tSConeccionBd;
        private System.Windows.Forms.ToolStripLabel tSEstadoConeccion;
    }
}