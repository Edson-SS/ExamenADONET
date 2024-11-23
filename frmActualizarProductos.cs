using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenADONET
{
    public partial class frmActualizarProductos : Form
    {
        SqlCommand command = null;
        SqlParameter parameter1;
        SqlParameter parameter2;
        SqlParameter parameter3;
        SqlParameter parameter4;
        SqlDataAdapter dataAdapter;
        SqlDataReader reader;

        public frmActualizarProductos()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_BuscarProductosPorID", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    parameter1 = new SqlParameter("@IdProducto", SqlDbType.VarChar, 50);
                    parameter1.Value = txtIDProducto.Text;

                    command.Parameters.Add(parameter1);

                    dataAdapter = new SqlDataAdapter(command);

                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        txtNombre.Text = Convert.ToString(reader["Nombre"]);
                        txtPrecio.Text = Convert.ToInt64(reader["Precio"]).ToString();
                        txtStock.Text = Convert.ToString(reader["Stock"]);
                        //products.Estatus = Convert.ToBoolean(reader["Estatus"]);

                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                command = null;
                parameter1 = null;
                dataAdapter = null;
                reader = null;
            }
        }

        private void btnActualizarProducto_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_ActualizarProducto", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    parameter1 = new SqlParameter("@IdProducto", SqlDbType.VarChar, 50);
                    parameter1.Value = txtIDProducto.Text;

                    parameter2 = new SqlParameter("@Nombre", SqlDbType.VarChar, 50);
                    parameter2.Value = txtNombre.Text;

                    parameter3 = new SqlParameter("@Precio", SqlDbType.VarChar, 50);
                    parameter3.Value = txtPrecio.Text;

                    parameter4 = new SqlParameter("@Stock", SqlDbType.VarChar, 50);
                    parameter4.Value = txtStock.Text;

                    command.Parameters.Add(parameter1);
                    command.Parameters.Add(parameter2);
                    command.Parameters.Add(parameter3);
                    command.Parameters.Add(parameter4);

                    command.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Actualizacion exitosa");

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                command = null;
                parameter1 = null;
                parameter2 = null;
                parameter3 = null;
                parameter4 = null;
                dataAdapter = null;
            }
        }
    }
}
