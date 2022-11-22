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
    public partial class frmListarClientes : Form
    {
        OleDbConnection conexionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoBD = new OleDbCommand();

        OleDbConnection conexionTablas = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        //OleDbDataReader leerActividad = comandoBD.ExecuteReader();
        OleDbCommand comandoTablas = new OleDbCommand();

        //OleDbCommand comandoPrueba = new OleDbCommand();
        public frmListarClientes()
        {
            InitializeComponent();
        }

        private void frmListarClientes_Load(object sender, EventArgs e)
        {
            try
            {
                //conexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.accdb");
                conexionBaseDatos.Open();
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.Connection = conexionBaseDatos;
                tSConeccionBd.BackColor = Color.Green;
                tSLEstadoConeccion.Text = "Conectado correctamente" + " " + DateTime.Now;
                conexionBaseDatos.Close();
            }
            catch (Exception mensajito)
            {
                tSConeccionBd.Text = mensajito.Message;
                tSLEstadoConeccion.BackColor = Color.Red;
                //throw;
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {

            string Actividad = "";
            string Barrio = "";
            //borrar lo que tiene para que si toca varias veces el boton no se escriban d nuevo los datos
            dgvListarClientes.Rows.Clear();
            
            //lector para socios
            conexionBaseDatos.Open();
            comandoBD.Connection = conexionBaseDatos;
            comandoBD.CommandText = "Socio";
            OleDbDataReader lectorSocio = comandoBD.ExecuteReader();

            while (lectorSocio.Read())
            {
                //se vacian las variables
                Actividad = "";
                Barrio = "";

                //buscar detalle del barrio
                conexionTablas.Open();
                comandoTablas.Connection = conexionTablas;
                comandoTablas.CommandType = CommandType.TableDirect;
                comandoTablas.CommandText = "Actividad";

                OleDbDataReader leerBarrio = comandoTablas.ExecuteReader();

                while (leerBarrio.Read() && Barrio == "")
                {
                    if (leerBarrio.GetInt32(0) == lectorSocio.GetInt32(3))
                    {
                        Barrio = leerBarrio.GetString(1);
                    }
                }
                conexionTablas.Close();

                //buscar la actividad
                conexionTablas.Open();
                comandoTablas.Connection = conexionTablas;
                comandoTablas.CommandType = CommandType.TableDirect;
                comandoTablas.CommandText = "Barrio";

                OleDbDataReader leerActividad = comandoTablas.ExecuteReader();

                while (leerActividad.Read() && Actividad == "")
                {
                    if (leerActividad.GetInt32(0) == lectorSocio.GetInt32(4))
                    {
                        Actividad = leerActividad.GetString(1);
                    }
                }
                conexionTablas.Close();

                //agregamos todos los datos a la grillas
                dgvListarClientes.Rows.Add(lectorSocio.GetInt32(0), lectorSocio.GetString(1), lectorSocio.GetString(2),
                    Barrio, Actividad, lectorSocio.GetDecimal(5));
            }
            conexionBaseDatos.Close();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
