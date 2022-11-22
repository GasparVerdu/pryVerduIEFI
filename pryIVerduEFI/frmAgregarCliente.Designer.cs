namespace pryIVerduEFI
{
    partial class frmAgregarCliente
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
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblNombreYApellido = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtNombreyApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mskDocumento = new System.Windows.Forms.MaskedTextBox();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboActividad = new System.Windows.Forms.ComboBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.tSConeccionBd = new System.Windows.Forms.ToolStrip();
            this.tSLabelEstadoConeccion = new System.Windows.Forms.ToolStripLabel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.tSConeccionBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(12, 29);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(100, 18);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Documento:";
            // 
            // lblNombreYApellido
            // 
            this.lblNombreYApellido.AutoSize = true;
            this.lblNombreYApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreYApellido.Location = new System.Drawing.Point(12, 87);
            this.lblNombreYApellido.Name = "lblNombreYApellido";
            this.lblNombreYApellido.Size = new System.Drawing.Size(149, 18);
            this.lblNombreYApellido.TabIndex = 1;
            this.lblNombreYApellido.Text = "Nombre y apellido:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(12, 145);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(85, 18);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(12, 203);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(59, 18);
            this.lblBarrio.TabIndex = 3;
            this.lblBarrio.Text = "Barrio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Actividad:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(261, 373);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(13, 319);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(56, 18);
            this.lblSaldo.TabIndex = 6;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtNombreyApellido
            // 
            this.txtNombreyApellido.Location = new System.Drawing.Point(177, 87);
            this.txtNombreyApellido.Name = "txtNombreyApellido";
            this.txtNombreyApellido.Size = new System.Drawing.Size(159, 20);
            this.txtNombreyApellido.TabIndex = 8;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(177, 146);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(159, 20);
            this.txtDireccion.TabIndex = 9;
            // 
            // mskDocumento
            // 
            this.mskDocumento.Location = new System.Drawing.Point(177, 30);
            this.mskDocumento.Mask = "00000000";
            this.mskDocumento.Name = "mskDocumento";
            this.mskDocumento.Size = new System.Drawing.Size(159, 20);
            this.mskDocumento.TabIndex = 10;
            // 
            // cboBarrio
            // 
            this.cboBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(177, 204);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(159, 21);
            this.cboBarrio.TabIndex = 11;
            this.cboBarrio.SelectedIndexChanged += new System.EventHandler(this.cboBarrio_SelectedIndexChanged);
            // 
            // cboActividad
            // 
            this.cboActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboActividad.FormattingEnabled = true;
            this.cboActividad.Location = new System.Drawing.Point(177, 261);
            this.cboActividad.Name = "cboActividad";
            this.cboActividad.Size = new System.Drawing.Size(159, 21);
            this.cboActividad.TabIndex = 12;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(177, 319);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(159, 20);
            this.txtSaldo.TabIndex = 13;
            // 
            // tSConeccionBd
            // 
            this.tSConeccionBd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSConeccionBd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSLabelEstadoConeccion});
            this.tSConeccionBd.Location = new System.Drawing.Point(0, 397);
            this.tSConeccionBd.Name = "tSConeccionBd";
            this.tSConeccionBd.Size = new System.Drawing.Size(360, 25);
            this.tSConeccionBd.TabIndex = 15;
            this.tSConeccionBd.Text = "toolStrip1";
            // 
            // tSLabelEstadoConeccion
            // 
            this.tSLabelEstadoConeccion.Name = "tSLabelEstadoConeccion";
            this.tSLabelEstadoConeccion.Size = new System.Drawing.Size(86, 22);
            this.tSLabelEstadoConeccion.Text = "toolStripLabel1";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(177, 373);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 16;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // frmAgregarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 422);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tSConeccionBd);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.cboActividad);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.mskDocumento);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombreyApellido);
            this.Controls.Add(this.lblSaldo);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombreYApellido);
            this.Controls.Add(this.lblDocumento);
            this.Name = "frmAgregarCliente";
            this.Text = "Agregar cliente";
            this.Load += new System.EventHandler(this.frmAgregarCliente_Load);
            this.tSConeccionBd.ResumeLayout(false);
            this.tSConeccionBd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblNombreYApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtNombreyApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mskDocumento;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.ComboBox cboActividad;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ToolStrip tSConeccionBd;
        private System.Windows.Forms.ToolStripLabel tSLabelEstadoConeccion;
        private System.Windows.Forms.Button btnVolver;
    }
}