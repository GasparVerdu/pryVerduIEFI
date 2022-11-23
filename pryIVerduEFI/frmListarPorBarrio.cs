using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIVerduEFI
{
    public partial class frmListarPorBarrio : Form
    {
        OleDbConnection conexionBaseDatos = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoBD = new OleDbCommand();

        OleDbConnection conexionTablas = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        //OleDbDataReader leerActividad = comandoBD.ExecuteReader();
        OleDbCommand comandoTablas = new OleDbCommand();

        OleDbConnection conexionTablas2 = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = BD_Clientes.accdb");
        OleDbCommand comandoTablas2 = new OleDbCommand();
        public frmListarPorBarrio()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            int Contador = 0;
            decimal sMayor = 0;
            decimal sMenor = 0;
            decimal Total = 0;

            //borrar lo que tiene para que si toca varias veces el boton no se escriban d nuevo los datos
            dgvListarPorBarrio.Rows.Clear();

            //si la cbo es diferente de vacio
            if (cboBarrio.SelectedIndex != -1)
            {
                //lector para socios
                conexionTablas.Open();
                comandoTablas.Connection = conexionTablas;
                comandoTablas.CommandType = CommandType.TableDirect;
                comandoTablas.CommandText = "Barrio";
                OleDbDataReader lectorBarrio = comandoTablas.ExecuteReader();

                while (lectorBarrio.Read())
                {
                    if (lectorBarrio.GetString(1) == cboBarrio.Text)
                    {
                        conexionBaseDatos.Open();
                        comandoBD.Connection = conexionBaseDatos;
                        comandoBD.CommandType = CommandType.TableDirect;
                        comandoBD.CommandText = "Socio";
                        OleDbDataReader lectorSocio = comandoBD.ExecuteReader();
                        while (lectorSocio.Read())
                        {
                            if (lectorSocio.GetInt32(3) == lectorBarrio.GetInt32(0))
                            {
                                if (sMenor == 0)
                                {
                                    sMenor = lectorSocio.GetDecimal(5);
                                }


                                if (sMayor < lectorSocio.GetDecimal(5))
                                {
                                    sMayor = lectorSocio.GetDecimal(5);
                                }
                                if (sMenor > lectorSocio.GetDecimal(5))
                                {
                                    sMenor = lectorSocio.GetDecimal(5);
                                }

                                Contador = Contador + 1;
                                Total = Total + lectorSocio.GetDecimal(5);

                                conexionTablas2.Open();
                                comandoTablas2.Connection = conexionTablas2;
                                comandoTablas2.CommandType = CommandType.TableDirect;
                                comandoTablas2.CommandText = "Actividad";

                                OleDbDataReader lectorActividad = comandoTablas2.ExecuteReader();

                                while (lectorActividad.Read() && lectorActividad.GetInt32(0) != lectorSocio.GetInt32(4))
                                {

                                }
                                dgvListarPorBarrio.Rows.Add(lectorSocio.GetInt32(0), lectorSocio.GetString(1), lectorSocio.GetString(2), lectorBarrio.GetString(1),
                                    lectorActividad.GetString(1), lectorSocio.GetDecimal(5));
                                conexionTablas2.Close();
                            }

                        }
                    }
                }
                conexionBaseDatos.Close();
                conexionTablas.Close();

                lblResSaldoMenor.Text = Convert.ToString(sMenor);
                lblResSaldoMayor.Text = Convert.ToString(sMayor);
                lblResTotal.Text = Convert.ToString(Total);
                lblResPromedios.Text = Convert.ToString(Total / Contador);
            }
            else
            {
                MessageBox.Show("Ingrese una actividad");
            }
        }

        private void frmListarPorBarrio_Load(object sender, EventArgs e)
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

            conexionBaseDatos.Open();
            comandoBD.CommandText = "Barrio";
            OleDbDataReader leerActividad = comandoBD.ExecuteReader();

            while (leerActividad.Read())
            {
                cboBarrio.Items.Add(leerActividad.GetString(1));
            }
            conexionBaseDatos.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnImprimir.Enabled = true;

            
            conexionTablas.Open();
            comandoTablas.Connection = conexionTablas;
            comandoTablas.CommandType = CommandType.TableDirect;
            comandoTablas.CommandText = "Barrio";
            OleDbDataReader lectorBarrio = comandoTablas.ExecuteReader();

            //Se crea un SW para crear el archivo
            StreamWriter swListado = new StreamWriter("./Informe de clientes por barrio.csv", false, Encoding.UTF8); //encoding es para las palabras con acentos 
            swListado.WriteLine("Listado de clientes \n");
            swListado.WriteLine("DNI,Nombre,Direccion,Barrio,Actividad,Saldo");

            //Procedimiento para comprobar la actividad que se selecciono
            while (lectorBarrio.Read() && lectorBarrio.GetString(1) != cboBarrio.Text)
            {
            }

            //Se abre la conexion para buscar los datos requeridos
            conexionBaseDatos.Open();
            comandoBD.Connection = conexionBaseDatos;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "Socio";
            OleDbDataReader lectorSocio = comandoBD.ExecuteReader();
            while (lectorSocio.Read())
            {
                if (lectorSocio.GetInt32(3) == lectorBarrio.GetInt32(0))
                {
                    //Se abre otra conexion para poner el detalle del barrio en el archivo
                    conexionTablas2.Open();
                    comandoTablas2.Connection = conexionTablas2;
                    comandoTablas2.CommandType = CommandType.TableDirect;
                    comandoTablas2.CommandText = "Actividad";
                    OleDbDataReader lectorActividad = comandoTablas2.ExecuteReader();
                    while (lectorActividad.Read() && lectorActividad.GetInt32(0) != lectorSocio.GetInt32(3))
                    {
                    }
                    swListado.Write(lectorSocio.GetInt32(0));
                    swListado.Write(",");
                    swListado.Write(lectorSocio.GetString(1));
                    swListado.Write(",");
                    swListado.Write(lectorSocio.GetString(2));
                    swListado.Write(",");
                    swListado.Write(lectorBarrio.GetString(1));
                    swListado.Write(",");
                    swListado.Write(lectorActividad.GetString(1));
                    swListado.Write(",");
                    swListado.Write(lectorSocio.GetDecimal(5));
                    swListado.Write("\n");
                    conexionTablas2.Close();
                }
            }
            MessageBox.Show("Informe generado con exito!");
            conexionTablas2.Close();
            conexionBaseDatos.Close();
            swListado.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            //se muestra una ventana en dond se elige la impresora que queremos para imprimir 
            prtVentana.ShowDialog();
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            //lo que hace el metodo print es ejecutar lo que hay escrito en prtDocumento_printpage
            prtDocumento.Print();
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs reporte)
        {
            //el procedimineto recibe unos valores, PrintPageEventArg recibe la pagina y se llama e
            //elemento print documento

            //clase font es para el tipo de letra
            Font Letra = new Font("Arial", 11);
            Font Titulo = new Font("Arial", 17);
            int posicion = 200;
            int fila = 0;

            //drawstring imprime una cadna de caracteres, tipo letra, color de la letra y la ubicacion en la hoja (X,Y)
            reporte.Graphics.DrawString("Listado de socios de: " + cboBarrio.Text + "", Titulo, Brushes.Black, 100, 50);

            reporte.Graphics.DrawString("DNI", Letra, Brushes.Black, 100, 150);
            reporte.Graphics.DrawString("Nombre y Apellido", Letra, Brushes.Black, 150, 150);
            reporte.Graphics.DrawString("Direccion", Letra, Brushes.Black, 300, 150);
            reporte.Graphics.DrawString("Barrio", Letra, Brushes.Black, 470, 150);
            reporte.Graphics.DrawString("Actividad", Letra, Brushes.Black, 600, 150);
            reporte.Graphics.DrawString("Saldo", Letra, Brushes.Black, 700, 150);


            while (fila < dgvListarPorBarrio.Rows.Count - 1)
            {
                reporte.Graphics.DrawString(dgvListarPorBarrio.Rows[fila].Cells[0].Value.ToString(), Letra, Brushes.Black, 100, posicion);
                reporte.Graphics.DrawString(dgvListarPorBarrio.Rows[fila].Cells[1].Value.ToString(), Letra, Brushes.Black, 150, posicion);
                reporte.Graphics.DrawString(dgvListarPorBarrio.Rows[fila].Cells[2].Value.ToString(), Letra, Brushes.Black, 300, posicion);
                reporte.Graphics.DrawString(dgvListarPorBarrio.Rows[fila].Cells[3].Value.ToString(), Letra, Brushes.Black, 470, posicion);
                reporte.Graphics.DrawString(dgvListarPorBarrio.Rows[fila].Cells[4].Value.ToString(), Letra, Brushes.Black, 600, posicion);
                reporte.Graphics.DrawString(dgvListarPorBarrio.Rows[fila].Cells[5].Value.ToString(), Letra, Brushes.Black, 700, posicion);
                posicion = posicion + 20;
                fila++;
            }

            posicion = posicion + 15;
            reporte.Graphics.DrawString("Saldo Mayor: " + lblResSaldoMayor.Text + "", Letra, Brushes.Black, 100, posicion);
            reporte.Graphics.DrawString("Saldo Menor: " + lblSaldoMenor.Text + "", Letra, Brushes.Black, 250, posicion);
            reporte.Graphics.DrawString("Promedio: " + lblResPromedios.Text + "", Letra, Brushes.Black, 400, posicion);
            reporte.Graphics.DrawString("Total: " + lblResTotal.Text + "", Letra, Brushes.Black, 550, posicion);
            MessageBox.Show("Lista impresa con exito!");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
