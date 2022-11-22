namespace pryIVerduEFI
{
    partial class frmListarPorBarrio
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
            this.lblResTotal = new System.Windows.Forms.Label();
            this.lblResPromedios = new System.Windows.Forms.Label();
            this.lblResSaldoMenor = new System.Windows.Forms.Label();
            this.lblResSaldoMayor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblSaldoMenor = new System.Windows.Forms.Label();
            this.lblSaldoMayor = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvListarPorBarrio = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.tSConeccionBd = new System.Windows.Forms.ToolStrip();
            this.tSEstadoConeccion = new System.Windows.Forms.ToolStripLabel();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPorBarrio)).BeginInit();
            this.tSConeccionBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblResTotal
            // 
            this.lblResTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResTotal.Location = new System.Drawing.Point(184, 378);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(100, 26);
            this.lblResTotal.TabIndex = 24;
            // 
            // lblResPromedios
            // 
            this.lblResPromedios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResPromedios.Location = new System.Drawing.Point(184, 336);
            this.lblResPromedios.Name = "lblResPromedios";
            this.lblResPromedios.Size = new System.Drawing.Size(100, 26);
            this.lblResPromedios.TabIndex = 23;
            // 
            // lblResSaldoMenor
            // 
            this.lblResSaldoMenor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResSaldoMenor.Location = new System.Drawing.Point(184, 294);
            this.lblResSaldoMenor.Name = "lblResSaldoMenor";
            this.lblResSaldoMenor.Size = new System.Drawing.Size(100, 26);
            this.lblResSaldoMenor.TabIndex = 22;
            // 
            // lblResSaldoMayor
            // 
            this.lblResSaldoMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResSaldoMayor.Location = new System.Drawing.Point(184, 252);
            this.lblResSaldoMayor.Name = "lblResSaldoMayor";
            this.lblResSaldoMayor.Size = new System.Drawing.Size(100, 26);
            this.lblResSaldoMayor.TabIndex = 21;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(58, 378);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 16);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(58, 336);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(74, 16);
            this.lblPromedio.TabIndex = 19;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblSaldoMenor
            // 
            this.lblSaldoMenor.AutoSize = true;
            this.lblSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMenor.Location = new System.Drawing.Point(58, 294);
            this.lblSaldoMenor.Name = "lblSaldoMenor";
            this.lblSaldoMenor.Size = new System.Drawing.Size(95, 16);
            this.lblSaldoMenor.TabIndex = 18;
            this.lblSaldoMenor.Text = "Saldo menor";
            // 
            // lblSaldoMayor
            // 
            this.lblSaldoMayor.AutoSize = true;
            this.lblSaldoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMayor.Location = new System.Drawing.Point(58, 252);
            this.lblSaldoMayor.Name = "lblSaldoMayor";
            this.lblSaldoMayor.Size = new System.Drawing.Size(95, 16);
            this.lblSaldoMayor.TabIndex = 17;
            this.lblSaldoMayor.Text = "Saldo mayor";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(438, 245);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(112, 23);
            this.btnListar.TabIndex = 16;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // dgvListarPorBarrio
            // 
            this.dgvListarPorBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarPorBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.NombreApellido,
            this.Direccion,
            this.Barrio,
            this.Actividad,
            this.Saldo});
            this.dgvListarPorBarrio.Location = new System.Drawing.Point(37, 59);
            this.dgvListarPorBarrio.Name = "dgvListarPorBarrio";
            this.dgvListarPorBarrio.Size = new System.Drawing.Size(513, 180);
            this.dgvListarPorBarrio.TabIndex = 15;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // NombreApellido
            // 
            this.NombreApellido.HeaderText = "NombreApellido";
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.Width = 175;
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
            // cboBarrio
            // 
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(184, 21);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(150, 21);
            this.cboBarrio.TabIndex = 14;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarrio.Location = new System.Drawing.Point(58, 21);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(54, 18);
            this.lblBarrio.TabIndex = 13;
            this.lblBarrio.Text = "Barrio";
            // 
            // tSConeccionBd
            // 
            this.tSConeccionBd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSConeccionBd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSEstadoConeccion});
            this.tSConeccionBd.Location = new System.Drawing.Point(0, 425);
            this.tSConeccionBd.Name = "tSConeccionBd";
            this.tSConeccionBd.Size = new System.Drawing.Size(561, 25);
            this.tSConeccionBd.TabIndex = 25;
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
            this.btnVolver.Location = new System.Drawing.Point(320, 245);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 23);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmListarPorBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.tSConeccionBd);
            this.Controls.Add(this.lblResTotal);
            this.Controls.Add(this.lblResPromedios);
            this.Controls.Add(this.lblResSaldoMenor);
            this.Controls.Add(this.lblResSaldoMayor);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblSaldoMenor);
            this.Controls.Add(this.lblSaldoMayor);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvListarPorBarrio);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Name = "frmListarPorBarrio";
            this.Text = "frmListarPorBarrio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarPorBarrio)).EndInit();
            this.tSConeccionBd.ResumeLayout(false);
            this.tSConeccionBd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Label lblResPromedios;
        private System.Windows.Forms.Label lblResSaldoMenor;
        private System.Windows.Forms.Label lblResSaldoMayor;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSaldoMenor;
        private System.Windows.Forms.Label lblSaldoMayor;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvListarPorBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ToolStrip tSConeccionBd;
        private System.Windows.Forms.ToolStripLabel tSEstadoConeccion;
        private System.Windows.Forms.Button btnVolver;
    }
}