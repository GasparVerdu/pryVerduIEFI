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
using System.Net;

namespace pryIVerduEFI
{
    public partial class frmEliminarModificarCliente : Form
    {
        OleDbConnection conexionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoBD = new OleDbCommand();

        OleDbConnection conexionTablas = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        //OleDbDataReader leerActividad = comandoBD.ExecuteReader();
        OleDbCommand comandoTablas = new OleDbCommand();

        bool banderaG = false;
        public frmEliminarModificarCliente()
        {
            InitializeComponent();
        }

        private void frmEliminarCliente_Load(object sender, EventArgs e)
        {
            //btnGrabar.Enabled = false;
            txtNombreApellido.Enabled = false;
            txtDireccion.Enabled = false;
            txtSaldo.Enabled = false;
            cboActividad.Enabled = false;
            cboBarrio.Enabled = false;

            try
            {
                //conexionBaseDatos = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.accdb");
                conexionBaseDatos.Open();
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.Connection = conexionBaseDatos;
                tSConeccionBd.BackColor = Color.Green;
                tSLabelEstadoConeccion.Text = "Conectado correctamente" + " " + DateTime.Now;
                conexionBaseDatos.Close();
            }
            catch (Exception mensajito)
            {
                tSConeccionBd.Text = mensajito.Message;
                tSLabelEstadoConeccion.BackColor = Color.Red;
                //throw;
            }
            //conexionBaseDatos.Close();

            //este procedimiento es para leer la tabla actividades y sacar los datos para ponerlos en la combobox
            conexionBaseDatos.Open();
            //comandoBD.Connection = conexionBaseDatos;
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

            
            //txtNombreApellido.Enabled = false;
            //txtDireccion.Enabled = false;
            //txtSaldo.Enabled = false;
            //cboActividad.Enabled = false;
            //cboBarrio.Enabled = false;
        }

        private void grbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            if (mskDocumento.Text != "")
            {
                try
                {
                    conexionBaseDatos.Open();

                    comandoBD.Connection = conexionBaseDatos;
                    comandoBD.CommandType = CommandType.TableDirect;
                    comandoBD.CommandText = "Socio";

                    OleDbDataReader leerAdeDSocio = comandoBD.ExecuteReader();

                    //procedimientos en logica que va a buscar un codigo y compararlo con la otra tabla para obtener cual es el detalle de ese codigo
                    //este mientras seria lo mismo que en logica un not.adedsocio.eof
                    while (leerAdeDSocio.Read())
                    {
                        if (leerAdeDSocio.GetInt32(0) == Convert.ToInt32(mskDocumento.Text))
                        {
                            //habilitamos las cajas de texto ya que el cliente si existe

                            txtNombreApellido.Enabled = true;
                            txtDireccion.Enabled = true;
                            txtSaldo.Enabled = true;
                            cboActividad.Enabled = true;
                            cboBarrio.Enabled = true;

                            bandera = true;

                            txtNombreApellido.Text = leerAdeDSocio.GetString(1);
                            txtDireccion.Text = leerAdeDSocio.GetString(2);
                            txtSaldo.Text = Convert.ToString(leerAdeDSocio.GetDecimal(5));


                            //aca necesito abrir las otras tablas para poder mostrar el detalle del barrio y la actividad
                            //OleDbCommand comandoTablas = new OleDbCommand();
                            conexionTablas.Open();
                            comandoTablas.Connection = conexionTablas;
                            comandoTablas.CommandType = CommandType.TableDirect;
                            comandoTablas.CommandText = "Barrio";

                            OleDbDataReader lectorBarrio = comandoTablas.ExecuteReader();

                            while (lectorBarrio.Read())
                            {
                                if (lectorBarrio.GetInt32(0) == leerAdeDSocio.GetInt32(3))
                                {
                                    cboBarrio.Text = lectorBarrio.GetString(1);
                                }
                            }
                            conexionTablas.Close();

                            conexionTablas.Open();

                            comandoTablas.Connection = conexionTablas;
                            comandoTablas.CommandType = CommandType.TableDirect;
                            comandoTablas.CommandText = "Actividad";

                            OleDbDataReader lectorActividad = comandoTablas.ExecuteReader();

                            while (lectorActividad.Read())
                            {
                                if (lectorActividad.GetInt32(0) == leerAdeDSocio.GetInt32(4))
                                {
                                    cboActividad.Text = lectorActividad.GetString(1);
                                }
                            }

                            conexionTablas.Close();
                        }
                        //else
                        //{
                        //    MessageBox.Show("No se encuentra registrado el cliente");
                        //}
                    }
                    if (bandera == false)
                    {
                        MessageBox.Show("No esta registrado en la base de datos ");
                    }
                    conexionBaseDatos.Close();
                }
                catch (Exception mensajito)
                {
                    MessageBox.Show(mensajito.ToString());
                    //throw;
                }
            }
            else
            {
                MessageBox.Show("Ingrese un documento");
            }

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            int codigoBarrio, codigoActividad;

            codigoBarrio = 0;
            codigoActividad = 0;

            //if (banderaG == false)
            //{
                conexionTablas.Open();
                comandoTablas.Connection = conexionTablas;
                comandoTablas.CommandType = CommandType.TableDirect;
                comandoTablas.CommandText = "Actividad";

                OleDbDataReader leerActividad = comandoTablas.ExecuteReader();

                while (leerActividad.Read() && cboActividad.Text != leerActividad.GetString(1))
                {

                }
                if (cboActividad.Text == leerActividad.GetString(1))
                {
                    codigoActividad = leerActividad.GetInt32(0);
                }
                conexionTablas.Close();

                conexionTablas.Open();
                comandoTablas.Connection = conexionTablas;
                comandoTablas.CommandType = CommandType.TableDirect;
                comandoTablas.CommandText = "Barrio";

                OleDbDataReader leerBarrio = comandoTablas.ExecuteReader();

                while (leerBarrio.Read() && cboBarrio.Text != leerBarrio.GetString(1))
                {

                }
                if (cboBarrio.Text == leerBarrio.GetString(1))
                {
                    codigoBarrio = leerBarrio.GetInt32(0);
                }
                conexionTablas.Close();

                conexionBaseDatos.Open();
                using (System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand("UPDATE Socio SET Nombre_Apellido=@NombreApellido, DIRECCION=@Direccion," + 
                    "Codigo_Barrio=@Barrio, Codigo_Actividad=@Actividad, Saldo=@Saldo WHERE Dni_Socio=@Documento", conexionBaseDatos))
                {
                    cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@NombreApellido", txtNombreApellido.Text));
                    cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Direccion", txtDireccion.Text));
                    cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Barrio", codigoBarrio));
                    cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Actividad", codigoActividad));
                    cmd.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Saldo", Convert.ToDecimal(txtSaldo.Text)));
                }
                conexionBaseDatos.Close();
                MessageBox.Show("Usuario modificado");

                txtNombreApellido.Text = "";
                txtDireccion.Text = "";
                txtSaldo.Text = "";
                mskDocumento.Text = "";
                cboActividad.SelectedIndex = -1;
                cboBarrio.SelectedIndex = -1;
            //}
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
            

            string documento = "";

            if (mskDocumento.Text != "")
            {
                documento = mskDocumento.Text;

                conexionBaseDatos.Open();
                comandoBD.Connection = conexionBaseDatos;

                using (System.Data.OleDb.OleDbCommand comandoBorrar = new System.Data.OleDb.OleDbCommand(
                    "DELETE * FROM Socio WHERE [Dni_Socio]=@Documento", conexionBaseDatos))
                {
                    comandoBorrar.Parameters.Add(new System.Data.OleDb.OleDbParameter("@Documento", documento));
                    comandoBorrar.ExecuteNonQuery();
                }
                conexionBaseDatos.Close();
                MessageBox.Show("Cliente eliminado");
            }
            else
            {
                MessageBox.Show("Ingrese un documento");
            }

            txtNombreApellido.Text = "";
            txtDireccion.Text = "";
            txtSaldo.Text = "";
            mskDocumento.Text = "";
            cboActividad.SelectedIndex = -1;
            cboBarrio.SelectedIndex = -1;

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
