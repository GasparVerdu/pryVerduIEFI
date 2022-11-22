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

namespace pryIVerduEFI
{
    public partial class frmListarSaldos : Form
    {
        OleDbConnection conexionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoBD = new OleDbCommand();

        OleDbConnection conexionTablas = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        //OleDbDataReader leerActividad = comandoBD.ExecuteReader();
        OleDbCommand comandoTablas = new OleDbCommand();
        public frmListarSaldos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            
            decimal ContadorSaldo = 0;
            int ContadorSocios = 0;

            //borrar lo que tiene para que si toca varias veces el boton no se escriban d nuevo los datos
            dgvListarSaldos.Rows.Clear();

            //lector socios
            conexionBaseDatos.Open();
            comandoBD.Connection = conexionBaseDatos;
            comandoBD.CommandText = "Socio";
            OleDbDataReader lectorSocio = comandoBD.ExecuteReader();

            while (lectorSocio.Read())
            {
                //agregamos todos los datos a la grillas
                dgvListarSaldos.Rows.Add(lectorSocio.GetInt32(0), lectorSocio.GetString(1), lectorSocio.GetDecimal(5));
                ContadorSocios = ContadorSocios + 1;
                ContadorSaldo = ContadorSaldo + lectorSocio.GetDecimal(5);
            }
            conexionBaseDatos.Close();

            lblResTotalSocios.Text = Convert.ToString(ContadorSocios);
            lblResTotalSaldos.Text = Convert.ToString(ContadorSaldo);
            lblResPromedios.Text = Convert.ToString(ContadorSaldo/ContadorSocios);
        }

        private void frmListarSaldos_Load(object sender, EventArgs e)
        {
            try
            {
                //conexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.accdb");
                conexionBaseDatos.Open();
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.Connection = conexionBaseDatos;
                tSConeccionBd.BackColor = Color.Green;
                tSEstadoConeccion.Text = "Conectado correctamente" + " " + DateTime.Now;
                conexionBaseDatos.Close();
            }
            catch (Exception mensajito)
            {
                tSConeccionBd.Text = mensajito.Message;
                tSEstadoConeccion.BackColor = Color.Red;
                //throw;
            }
        }
    }
}
