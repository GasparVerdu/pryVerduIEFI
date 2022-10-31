namespace pryIVerduEFI
{
    partial class frmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MstripInicio = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUnClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosGimnasioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUnClienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUnClienteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MstripInicio.SuspendLayout();
            this.SuspendLayout();
            // 
            // MstripInicio
            // 
            this.MstripInicio.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.MstripInicio.Location = new System.Drawing.Point(0, 0);
            this.MstripInicio.Name = "MstripInicio";
            this.MstripInicio.Size = new System.Drawing.Size(500, 24);
            this.MstripInicio.TabIndex = 0;
            this.MstripInicio.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosGimnasioToolStripMenuItem,
            this.consultarUnClienteToolStripMenuItem1,
            this.consultarUnClienteToolStripMenuItem2,
            this.consultaPorBarrioToolStripMenuItem,
            this.consultaPorClienteToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aToolStripMenuItem.Text = "Consultar";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.aToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem,
            this.consultarUnClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar cliente";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.buscarClienteToolStripMenuItem.Text = "Borrar un cliente";
            // 
            // consultarUnClienteToolStripMenuItem
            // 
            this.consultarUnClienteToolStripMenuItem.Name = "consultarUnClienteToolStripMenuItem";
            this.consultarUnClienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarUnClienteToolStripMenuItem.Text = "Modificar";
            // 
            // datosGimnasioToolStripMenuItem
            // 
            this.datosGimnasioToolStripMenuItem.Name = "datosGimnasioToolStripMenuItem";
            this.datosGimnasioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.datosGimnasioToolStripMenuItem.Text = "Datos gimnasio";
            // 
            // consultarUnClienteToolStripMenuItem1
            // 
            this.consultarUnClienteToolStripMenuItem1.Name = "consultarUnClienteToolStripMenuItem1";
            this.consultarUnClienteToolStripMenuItem1.Size = new System.Drawing.Size(207, 22);
            this.consultarUnClienteToolStripMenuItem1.Text = "Consulta por actividad";
            // 
            // consultarUnClienteToolStripMenuItem2
            // 
            this.consultarUnClienteToolStripMenuItem2.Name = "consultarUnClienteToolStripMenuItem2";
            this.consultarUnClienteToolStripMenuItem2.Size = new System.Drawing.Size(207, 22);
            this.consultarUnClienteToolStripMenuItem2.Text = "Consulta total de clientes";
            // 
            // consultaPorBarrioToolStripMenuItem
            // 
            this.consultaPorBarrioToolStripMenuItem.Name = "consultaPorBarrioToolStripMenuItem";
            this.consultaPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.consultaPorBarrioToolStripMenuItem.Text = "Consulta por barrio";
            // 
            // consultaPorClienteToolStripMenuItem
            // 
            this.consultaPorClienteToolStripMenuItem.Name = "consultaPorClienteToolStripMenuItem";
            this.consultaPorClienteToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.consultaPorClienteToolStripMenuItem.Text = "Consulta por cliente";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.MstripInicio);
            this.MainMenuStrip = this.MstripInicio;
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.MstripInicio.ResumeLayout(false);
            this.MstripInicio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MstripInicio;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUnClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosGimnasioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUnClienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarUnClienteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem consultaPorBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorClienteToolStripMenuItem;
    }
}

