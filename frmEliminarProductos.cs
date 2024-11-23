using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenADONET
{
    public partial class frmEliminarProductos : Form
    {
        public frmEliminarProductos()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter parameter1;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();

                    command = new SqlCommand("USP_EliminarProductoPorEstatus", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    parameter1 = new SqlParameter("@IdProducto", SqlDbType.Int);
                    parameter1.Value = txtIDProducto.Text;

                    command.Parameters.Add(parameter1);

                    command.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Se elimino el ID "+txtIDProducto.Text);

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
                txtIDProducto.Text = null;
            }
        }
    }
}
