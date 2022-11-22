using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;
using System.Runtime.Remoting.Messaging;

namespace pryIVerduEFI
{
    public partial class frmAgregarCliente : Form
    {
        OleDbConnection conexionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoBD = new OleDbCommand();
        public frmAgregarCliente()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int codigoActividad = 0;
            int codigoBarrio = 0;
            //codigoActividad = 0;
            //codigoActividad = 0;

            //abrir la tabla de barrio porque tenemos que cargar el codigo en la tabla principal
            //y hay que buscarlo
            conexionBaseDatos.Open();
            comandoBD.Connection = conexionBaseDatos;
            //command type indica que el tipo de comando es d acceso directo a una tabla
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "Barrio";

            OleDbDataReader leerBarrio = comandoBD.ExecuteReader();

            while (leerBarrio.Read())
            {
                if (cboBarrio.Text == leerBarrio.GetString(1))
                {
                    codigoBarrio = leerBarrio.GetInt32(0);
                }
            }
            conexionBaseDatos.Close();

            conexionBaseDatos.Open();
            comandoBD.Connection = conexionBaseDatos;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "Actividad";

            OleDbDataReader leerActividad = comandoBD.ExecuteReader();

            while (leerActividad.Read())
            {
                if (cboActividad.Text == leerActividad.GetString(1))
                {
                    codigoActividad = leerActividad.GetInt32(0);
                }
            }
            conexionBaseDatos.Close();

            //cargar los datos con parametros
            conexionBaseDatos.Open();
            using (System.Data.OleDb.OleDbCommand Agregar = new System.Data.OleDb.OleDbCommand(
                    "INSERT INTO Socio (Dni_Socio, Nombre_Apellido, Direccion, Codigo_Barrio, Codigo_Actividad, Saldo) " +
                    "VALUES (@Documento, @NombreApellido, @Direccion, @Barrio, @Actividad, @Saldo)", conexionBaseDatos))
            {
                Agregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Documento", mskDocumento.Text));
                Agregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@NombreApellido", txtNombreyApellido.Text));
                Agregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Direccion", txtDireccion.Text));
                Agregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Barrio", codigoBarrio));
                Agregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Actividad", codigoActividad));
                Agregar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Saldo", txtSaldo.Text));
                Agregar.ExecuteNonQuery();
                conexionBaseDatos.Close();
            }

            MessageBox.Show("Datos cargados");
            mskDocumento.Text = "";
            txtNombreyApellido.Text = "";
            txtDireccion.Text = "";
            cboBarrio.SelectedIndex = -1;
            cboActividad.SelectedIndex = -1;
            txtSaldo.Text = "";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            try
            {
                //conexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.accdb");
                conexionBaseDatos.Open();
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.Connection = conexionBaseDatos;

                tSConeccionBd.BackColor = Color.Green;
                tSLabelEstadoConeccion.Text = "Conectado correctamente" + " " + DateTime.Now;
            }
            catch (Exception mensajito)
            {
                tSConeccionBd.Text = mensajito.Message;
                tSLabelEstadoConeccion.BackColor = Color.Red;
                //throw;
            }
            conexionBaseDatos.Close();

            //este procedimiento es para leer la tabla actividades y sacar los datos para ponerlos en la combobox
            conexionBaseDatos.Open();
            comandoBD.CommandText = "Actividad";
            OleDbDataReader leerActividad = comandoBD.ExecuteReader();

            
            while (leerActividad.Read())
            {
                cboActividad.Items.Add(leerActividad.GetString(1));
            }
            conexionBaseDatos.Close();

            conexionBaseDatos.Open();
            comandoBD.CommandText = "Barrio";
            OleDbDataReader leerBarrio = comandoBD.ExecuteReader();

            while (leerBarrio.Read())
            {
                cboBarrio.Items.Add(leerBarrio.GetString(1));
            }
            conexionBaseDatos.Close();
        }

        private void cboBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
