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
using System.Reflection;

namespace pryIVerduEFI
{
    public partial class frmConsultarUnCliente : Form
    {
        OleDbConnection conexionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoBD = new OleDbCommand();

        OleDbConnection conexionTablas = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        //OleDbDataReader leerActividad = comandoBD.ExecuteReader();
        OleDbCommand comandoTablas = new OleDbCommand();
        public frmConsultarUnCliente()
        {
            InitializeComponent();
        }

        private void frmConsultarUnCliente_Load(object sender, EventArgs e)
        {
            try
            {
                conexionBaseDatos.Open();
                comandoBD.CommandType = CommandType.TableDirect;
                comandoBD.Connection = conexionBaseDatos;
                tSConeccionBd.BackColor = Color.GreenYellow;
                tSEstadoConeccion.Text = "Conectado correctamente" + DateTime.Now;
                conexionBaseDatos.Close();
            }
            catch (Exception mensasjito)
            {
                tSEstadoConeccion.Text = mensasjito.Message;
                tSConeccionBd.BackColor = Color.Red;

                //throw;
            }
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
