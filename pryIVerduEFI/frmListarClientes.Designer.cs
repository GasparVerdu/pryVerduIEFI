namespace pryIVerduEFI
{
    partial class frmListarClientes
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
            this.dgvListarClientes = new System.Windows.Forms.DataGridView();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.tSConeccionBd = new System.Windows.Forms.ToolStrip();
            this.tSEstadoConeccion = new System.Windows.Forms.ToolStripLabel();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).BeginInit();
            this.tSConeccionBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListarClientes
            // 
            this.dgvListarClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreApellido,
            this.Direccion,
            this.Barrio,
            this.Actividad,
            this.Saldo});
            this.dgvListarClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvListarClientes.Name = "dgvListarClientes";
            this.dgvListarClientes.Size = new System.Drawing.Size(547, 150);
            this.dgvListarClientes.TabIndex = 0;
            // 
            // NombreApellido
            // 
            this.NombreApellido.HeaderText = "Nombre y apellido";
            this.NombreApellido.Name = "NombreApellido";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Barrio
            // 
            this.Barrio.HeaderText = "Barrio";
            this.Barrio.Name = "Barrio";
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(465, 168);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(94, 32);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // tSConeccionBd
            // 
            this.tSConeccionBd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSConeccionBd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSEstadoConeccion});
            this.tSConeccionBd.Location = new System.Drawing.Point(0, 207);
            this.tSConeccionBd.Name = "tSConeccionBd";
            this.tSConeccionBd.Size = new System.Drawing.Size(573, 25);
            this.tSConeccionBd.TabIndex = 16;
            this.tSConeccionBd.Text = "toolStrip1";
            // 
            // tSEstadoConeccion
            // 
            this.tSEstadoConeccion.Name = "tSEstadoConeccion";
            this.tSEstadoConeccion.Size = new System.Drawing.Size(86, 22);
            this.tSEstadoConeccion.Text = "toolStripLabel1";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(365, 168);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(94, 31);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 232);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tSConeccionBd);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListarClientes);
            this.Name = "frmListarClientes";
            this.Text = "frmListarClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarClientes)).EndInit();
            this.tSConeccionBd.ResumeLayout(false);
            this.tSConeccionBd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListarClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.ToolStrip tSConeccionBd;
        private System.Windows.Forms.ToolStripLabel tSEstadoConeccion;
        private System.Windows.Forms.Button btnVolver;
    }
}