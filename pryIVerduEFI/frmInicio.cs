using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIVerduEFI
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarCliente frmAgregarCliente = new frmAgregarCliente();
            frmAgregarCliente.ShowDialog();
        }

        private void modificarOEliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEliminarModificarCliente frmEliminarModificarCliente = new frmEliminarModificarCliente();
            frmEliminarModificarCliente.ShowDialog();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarUnCliente frmConsultarUnCliente = new frmConsultarUnCliente();
            frmConsultarUnCliente.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListarClientes frmListarClientes = new frmListarClientes();
            frmListarClientes.ShowDialog();
        }

        private void listarSaldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarSaldos frmListarSaldos = new frmListarSaldos();
            frmListarSaldos.ShowDialog();
        }

        private void listarPorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPorActividad frmListarPorActividad = new frmListarPorActividad();
            frmListarPorActividad.ShowDialog();
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarPorBarrio frmListarPorBarrio = new frmListarPorBarrio();
            frmListarPorBarrio.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
