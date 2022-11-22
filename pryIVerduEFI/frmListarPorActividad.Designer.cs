namespace pryIVerduEFI
{
    partial class frmListarPorActividad
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
            this.lblActividad = new System.Windows.Forms.Label();
            this.cboActividades = new System.Windows.Forms.ComboBox();
            this.dgvListarActividad = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblSaldoMayor = new System.Windows.Forms.Label();
            this.lblSaldoMenor = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResPromedios = new System.Windows.Forms.Label();
            this.lblResSaldoMenor = new System.Windows.Forms.Label();
            this.lblResSaldoMayor = new System.Windows.Forms.Label();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.tSConeccionBd = new System.Windows.Forms.ToolStrip();
            this.tSEstadoConeccion = new System.Windows.Forms.ToolStripLabel();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarActividad)).BeginInit();
            this.tSConeccionBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActividad.Location = new System.Drawing.Point(33, 25);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(75, 18);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad";
            // 
            // cboActividades
            // 
            this.cboActividades.FormattingEnabled = true;
            this.cboActividades.Location = new System.Drawing.Point(159, 25);
            this.cboActividades.Name = "cboActividades";
            this.cboActividades.Size = new System.Drawing.Size(150, 21);
            this.cboActividades.TabIndex = 1;
            // 
            // dgvListarActividad
            // 
            this.dgvListarActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.NombreApellido,
            this.Direccion,
            this.Barrio,
            this.Actividad,
            this.Saldo});
            this.dgvListarActividad.Location = new System.Drawing.Point(12, 63);
            this.dgvListarActividad.Name = "dgvListarActividad";
            this.dgvListarActividad.Size = new System.Drawing.Size(513, 180);
            this.dgvListarActividad.TabIndex = 2;
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
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(413, 249);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(112, 23);
            this.btnListar.TabIndex = 3;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblSaldoMayor
            // 
            this.lblSaldoMayor.AutoSize = true;
            this.lblSaldoMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMayor.Location = new System.Drawing.Point(33, 256);
            this.lblSaldoMayor.Name = "lblSaldoMayor";
            this.lblSaldoMayor.Size = new System.Drawing.Size(95, 16);
            this.lblSaldoMayor.TabIndex = 4;
            this.lblSaldoMayor.Text = "Saldo mayor";
            // 
            // lblSaldoMenor
            // 
            this.lblSaldoMenor.AutoSize = true;
            this.lblSaldoMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoMenor.Location = new System.Drawing.Point(33, 298);
            this.lblSaldoMenor.Name = "lblSaldoMenor";
            this.lblSaldoMenor.Size = new System.Drawing.Size(95, 16);
            this.lblSaldoMenor.TabIndex = 5;
            this.lblSaldoMenor.Text = "Saldo menor";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(33, 340);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(74, 16);
            this.lblPromedio.TabIndex = 6;
            this.lblPromedio.Text = "Promedio";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(33, 382);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(43, 16);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total";
            // 
            // lblResPromedios
            // 
            this.lblResPromedios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResPromedios.Location = new System.Drawing.Point(159, 340);
            this.lblResPromedios.Name = "lblResPromedios";
            this.lblResPromedios.Size = new System.Drawing.Size(100, 26);
            this.lblResPromedios.TabIndex = 11;
            // 
            // lblResSaldoMenor
            // 
            this.lblResSaldoMenor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResSaldoMenor.Location = new System.Drawing.Point(159, 298);
            this.lblResSaldoMenor.Name = "lblResSaldoMenor";
            this.lblResSaldoMenor.Size = new System.Drawing.Size(100, 26);
            this.lblResSaldoMenor.TabIndex = 10;
            // 
            // lblResSaldoMayor
            // 
            this.lblResSaldoMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResSaldoMayor.Location = new System.Drawing.Point(159, 256);
            this.lblResSaldoMayor.Name = "lblResSaldoMayor";
            this.lblResSaldoMayor.Size = new System.Drawing.Size(100, 26);
            this.lblResSaldoMayor.TabIndex = 9;
            // 
            // lblResTotal
            // 
            this.lblResTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResTotal.Location = new System.Drawing.Point(159, 382);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(100, 26);
            this.lblResTotal.TabIndex = 12;
            // 
            // tSConeccionBd
            // 
            this.tSConeccionBd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSConeccionBd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSEstadoConeccion});
            this.tSConeccionBd.Location = new System.Drawing.Point(0, 425);
            this.tSConeccionBd.Name = "tSConeccionBd";
            this.tSConeccionBd.Size = new System.Drawing.Size(560, 25);
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
            this.btnVolver.Location = new System.Drawing.Point(295, 249);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 23);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // frmListarPorActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
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
            this.Controls.Add(this.dgvListarActividad);
            this.Controls.Add(this.cboActividades);
            this.Controls.Add(this.lblActividad);
            this.Name = "frmListarPorActividad";
            this.Text = "frmListarPorActividad";
            this.Load += new System.EventHandler(this.frmListarPorActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarActividad)).EndInit();
            this.tSConeccionBd.ResumeLayout(false);
            this.tSConeccionBd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox cboActividades;
        private System.Windows.Forms.DataGridView dgvListarActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblSaldoMayor;
        private System.Windows.Forms.Label lblSaldoMenor;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblResPromedios;
        private System.Windows.Forms.Label lblResSaldoMenor;
        private System.Windows.Forms.Label lblResSaldoMayor;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.ToolStrip tSConeccionBd;
        private System.Windows.Forms.ToolStripLabel tSEstadoConeccion;
        private System.Windows.Forms.Button btnVolver;
    }
}