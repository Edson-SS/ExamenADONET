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
    public partial class frmBuscarProductos : Form
    {
        public frmBuscarProductos()
        {
            InitializeComponent();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            SqlCommand command = null;
            SqlParameter parameter1;
            SqlDataAdapter dataAdapter;
            List<Producto> products;
            SqlDataReader reader;

            try
            {
                using (SqlConnection conexion = new SqlConnection(Constantes.cadenaConexion))
                {
                    conexion.Open();
                    
                    command = new SqlCommand("USP_BuscarProductos", conexion);
                    command.CommandType = CommandType.StoredProcedure;

                    parameter1 = new SqlParameter("@Nombre", SqlDbType.VarChar, 50);
                    parameter1.Value = txtNombreProducto.Text;

                    command.Parameters.Add(parameter1);

                    dataAdapter = new SqlDataAdapter(command);

                    products = new List<Producto>();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        products.Add(new Producto
                        {
                            IdProducto = Convert.ToInt32(reader["IdProducto"]),
                            Nombre = Convert.ToString(reader["Nombre"]),
                            Precio = Convert.ToDecimal(reader["Precio"]),
                            Stock = Convert.ToInt32(reader["Stock"]),
                            FechaCreacion = Convert.ToDateTime(reader["FechaCreacion"]),
                            Estatus = Convert.ToBoolean(reader["Estatus"]),
                        }
                       );
                    }

                    dgvProducto.DataSource = products;
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
                products = null;
                reader = null;
                txtNombreProducto.Text = null;
            }
        }
    }
}
