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

namespace ExamenADONET
{
    public partial class frmCrearProductos : Form
    {
        public frmCrearProductos()
        {
            InitializeComponent();
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter parameter1 = null;
            SqlParameter parameter2 = null;
            SqlParameter parameter3 = null;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_CrearProductos", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    parameter1 = new SqlParameter("@Nombre", SqlDbType.VarChar, 50);
                    parameter1.Value = txtNombre.Text;

                    parameter2 = new SqlParameter("@Precio", SqlDbType.Int);
                    parameter2.Value = txtPrecio.Text;

                    parameter3 = new SqlParameter("@Stock", SqlDbType.Int);
                    parameter3.Value = txtStock.Text;

                    command.Parameters.Add(parameter1);
                    command.Parameters.Add(parameter2);
                    command.Parameters.Add(parameter3);

                    command.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Registro exitoso");
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
                txtNombre.Text = null;
                txtPrecio.Text = null;
                txtStock.Text = null;
            }
        }
    }
}
