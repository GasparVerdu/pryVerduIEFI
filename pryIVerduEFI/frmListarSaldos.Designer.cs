namespace pryIVerduEFI
{
    partial class frmListarSaldos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnListar = new System.Windows.Forms.Button();
            this.lblTotalSaldos = new System.Windows.Forms.Label();
            this.lblTotalSocios = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblResTotalSaldos = new System.Windows.Forms.Label();
            this.lblResTotalSocios = new System.Windows.Forms.Label();
            this.lblResPromedios = new System.Windows.Forms.Label();
            this.tSConeccionBd = new System.Windows.Forms.ToolStrip();
            this.tSEstadoConeccion = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tSConeccionBd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.NombreApellido,
            this.Saldo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Documento
            // 
            this.Documento.Frozen = true;
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // NombreApellido
            // 
            this.NombreApellido.Frozen = true;
            this.NombreApellido.HeaderText = "Nombre y apellido";
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.Width = 175;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(333, 168);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(98, 24);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // lblTotalSaldos
            // 
            this.lblTotalSaldos.AutoSize = true;
            this.lblTotalSaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaldos.Location = new System.Drawing.Point(50, 208);
            this.lblTotalSaldos.Name = "lblTotalSaldos";
            this.lblTotalSaldos.Size = new System.Drawing.Size(114, 13);
            this.lblTotalSaldos.TabIndex = 2;
            this.lblTotalSaldos.Text = "Total de los saldos";
            // 
            // lblTotalSocios
            // 
            this.lblTotalSocios.AutoSize = true;
            this.lblTotalSocios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSocios.Location = new System.Drawing.Point(50, 251);
            this.lblTotalSocios.Name = "lblTotalSocios";
            this.lblTotalSocios.Size = new System.Drawing.Size(114, 13);
            this.lblTotalSocios.TabIndex = 3;
            this.lblTotalSocios.Text = "Total de los socios";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromedio.Location = new System.Drawing.Point(50, 294);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(99, 13);
            this.lblPromedio.TabIndex = 4;
            this.lblPromedio.Text = "Promedio saldos";
            // 
            // lblResTotalSaldos
            // 
            this.lblResTotalSaldos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResTotalSaldos.Location = new System.Drawing.Point(199, 208);
            this.lblResTotalSaldos.Name = "lblResTotalSaldos";
            this.lblResTotalSaldos.Size = new System.Drawing.Size(100, 26);
            this.lblResTotalSaldos.TabIndex = 5;
            // 
            // lblResTotalSocios
            // 
            this.lblResTotalSocios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResTotalSocios.Location = new System.Drawing.Point(199, 251);
            this.lblResTotalSocios.Name = "lblResTotalSocios";
            this.lblResTotalSocios.Size = new System.Drawing.Size(100, 26);
            this.lblResTotalSocios.TabIndex = 6;
            // 
            // lblResPromedios
            // 
            this.lblResPromedios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResPromedios.Location = new System.Drawing.Point(199, 294);
            this.lblResPromedios.Name = "lblResPromedios";
            this.lblResPromedios.Size = new System.Drawing.Size(100, 26);
            this.lblResPromedios.TabIndex = 8;
            // 
            // tSConeccionBd
            // 
            this.tSConeccionBd.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tSConeccionBd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSEstadoConeccion});
            this.tSConeccionBd.Location = new System.Drawing.Point(0, 341);
            this.tSConeccionBd.Name = "tSConeccionBd";
            this.tSConeccionBd.Size = new System.Drawing.Size(446, 25);
            this.tSConeccionBd.TabIndex = 16;
            this.tSConeccionBd.Text = "toolStrip1";
            // 
            // tSEstadoConeccion
            // 
            this.tSEstadoConeccion.Name = "tSEstadoConeccion";
            this.tSEstadoConeccion.Size = new System.Drawing.Size(86, 22);
            this.tSEstadoConeccion.Text = "toolStripLabel1";
            // 
            // frmListarSaldos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 366);
            this.Controls.Add(this.tSConeccionBd);
            this.Controls.Add(this.lblResPromedios);
            this.Controls.Add(this.lblResTotalSocios);
            this.Controls.Add(this.lblResTotalSaldos);
            this.Controls.Add(this.lblPromedio);
            this.Controls.Add(this.lblTotalSocios);
            this.Controls.Add(this.lblTotalSaldos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmListarSaldos";
            this.Text = "Listado de saldos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tSConeccionBd.ResumeLayout(false);
            this.tSConeccionBd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Label lblTotalSaldos;
        private System.Windows.Forms.Label lblTotalSocios;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblResTotalSaldos;
        private System.Windows.Forms.Label lblResTotalSocios;
        private System.Windows.Forms.Label lblResPromedios;
        private System.Windows.Forms.ToolStrip tSConeccionBd;
        private System.Windows.Forms.ToolStripLabel tSEstadoConeccion;
    }
}