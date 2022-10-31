namespace pryIVerduEFI
{
    partial class frmModificarCliente
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
            this.lstDocumento = new System.Windows.Forms.ListBox();
            this.btnMostar = new System.Windows.Forms.Button();
            this.grbDatosCliente = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(22, 28);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 0;
            this.lblDocumento.Text = "Documento";
            // 
            // lstDocumento
            // 
            this.lstDocumento.FormattingEnabled = true;
            this.lstDocumento.Location = new System.Drawing.Point(90, 28);
            this.lstDocumento.Name = "lstDocumento";
            this.lstDocumento.Size = new System.Drawing.Size(169, 17);
            this.lstDocumento.TabIndex = 1;
            // 
            // btnMostar
            // 
            this.btnMostar.Location = new System.Drawing.Point(184, 69);
            this.btnMostar.Name = "btnMostar";
            this.btnMostar.Size = new System.Drawing.Size(75, 23);
            this.btnMostar.TabIndex = 2;
            this.btnMostar.Text = "Mostrar";
            this.btnMostar.UseVisualStyleBackColor = true;
            // 
            // grbDatosCliente
            // 
            this.grbDatosCliente.Location = new System.Drawing.Point(25, 119);
            this.grbDatosCliente.Name = "grbDatosCliente";
            this.grbDatosCliente.Size = new System.Drawing.Size(234, 162);
            this.grbDatosCliente.TabIndex = 3;
            this.grbDatosCliente.TabStop = false;
            this.grbDatosCliente.Text = "Datos del cliente";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(184, 292);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // frmModificarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 327);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.grbDatosCliente);
            this.Controls.Add(this.btnMostar);
            this.Controls.Add(this.lstDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Name = "frmModificarCliente";
            this.Text = "Modificar cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.ListBox lstDocumento;
        private System.Windows.Forms.Button btnMostar;
        private System.Windows.Forms.GroupBox grbDatosCliente;
        private System.Windows.Forms.Button btnModificar;
    }
}