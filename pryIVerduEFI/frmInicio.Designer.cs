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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clieintesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarOEliminarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarSaldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuConeccion = new System.Windows.Forms.ToolStrip();
            this.tSEstadoConeccion = new System.Windows.Forms.ToolStripLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStripMenuConeccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clieintesToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clieintesToolStripMenuItem
            // 
            this.clieintesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem,
            this.modificarOEliminarClienteToolStripMenuItem});
            this.clieintesToolStripMenuItem.Name = "clieintesToolStripMenuItem";
            this.clieintesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clieintesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarClienteToolStripMenuItem
            // 
            this.agregarClienteToolStripMenuItem.Name = "agregarClienteToolStripMenuItem";
            this.agregarClienteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.agregarClienteToolStripMenuItem.Text = "Agregar cliente";
            this.agregarClienteToolStripMenuItem.Click += new System.EventHandler(this.agregarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar un cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarToolStripMenuItem1,
            this.listarSaldosToolStripMenuItem,
            this.listarPorToolStripMenuItem});
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.listarToolStripMenuItem.Text = "Listar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.salirToolStripMenuItem.Text = "Salir ";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // modificarOEliminarClienteToolStripMenuItem
            // 
            this.modificarOEliminarClienteToolStripMenuItem.Name = "modificarOEliminarClienteToolStripMenuItem";
            this.modificarOEliminarClienteToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.modificarOEliminarClienteToolStripMenuItem.Text = "Modificar o eliminar cliente";
            this.modificarOEliminarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarOEliminarClienteToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listarToolStripMenuItem1.Text = "Listar clientes";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // listarSaldosToolStripMenuItem
            // 
            this.listarSaldosToolStripMenuItem.Name = "listarSaldosToolStripMenuItem";
            this.listarSaldosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarSaldosToolStripMenuItem.Text = "Listar saldos";
            this.listarSaldosToolStripMenuItem.Click += new System.EventHandler(this.listarSaldosToolStripMenuItem_Click);
            // 
            // listarPorToolStripMenuItem
            // 
            this.listarPorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actividadToolStripMenuItem,
            this.barrioToolStripMenuItem});
            this.listarPorToolStripMenuItem.Name = "listarPorToolStripMenuItem";
            this.listarPorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarPorToolStripMenuItem.Text = "Listar por..";
            this.listarPorToolStripMenuItem.Click += new System.EventHandler(this.listarPorToolStripMenuItem_Click);
            // 
            // actividadToolStripMenuItem
            // 
            this.actividadToolStripMenuItem.Name = "actividadToolStripMenuItem";
            this.actividadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.actividadToolStripMenuItem.Text = "Actividad";
            this.actividadToolStripMenuItem.Click += new System.EventHandler(this.actividadToolStripMenuItem_Click);
            // 
            // barrioToolStripMenuItem
            // 
            this.barrioToolStripMenuItem.Name = "barrioToolStripMenuItem";
            this.barrioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barrioToolStripMenuItem.Text = "Barrio";
            this.barrioToolStripMenuItem.Click += new System.EventHandler(this.barrioToolStripMenuItem_Click);
            // 
            // toolStripMenuConeccion
            // 
            this.toolStripMenuConeccion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripMenuConeccion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSEstadoConeccion});
            this.toolStripMenuConeccion.Location = new System.Drawing.Point(0, 425);
            this.toolStripMenuConeccion.Name = "toolStripMenuConeccion";
            this.toolStripMenuConeccion.Size = new System.Drawing.Size(500, 25);
            this.toolStripMenuConeccion.TabIndex = 1;
            this.toolStripMenuConeccion.Text = "toolConeccionBD";
            // 
            // tSEstadoConeccion
            // 
            this.tSEstadoConeccion.Name = "tSEstadoConeccion";
            this.tSEstadoConeccion.Size = new System.Drawing.Size(10, 22);
            this.tSEstadoConeccion.Text = ".";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.toolStripMenuConeccion);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmInicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripMenuConeccion.ResumeLayout(false);
            this.toolStripMenuConeccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clieintesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarOEliminarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarSaldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripMenuConeccion;
        private System.Windows.Forms.ToolStripLabel tSEstadoConeccion;
    }
}

