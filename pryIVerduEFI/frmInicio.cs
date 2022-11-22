using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryIVerduEFI
{
    public partial class frmInicio : Form
    {
        OleDbConnection conexionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        public frmInicio()
        {
            InitializeComponent();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            try
            {
                conexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.accdb");
                conexionBaseDatos.Open();
                toolStripMenuConeccion.BackColor = Color.Green;
                tSLabelEstadoConeccion.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                toolStripMenuConeccion.Text = mensajito.Message;
                tSLabelEstadoConeccion.BackColor = Color.Red;
                //throw;
            }
            conexionBaseDatos.Close();
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
