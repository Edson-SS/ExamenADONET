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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnFrmCrear_Click(object sender, EventArgs e)
        {
            frmCrearProductos frmCrearProductos = new frmCrearProductos();
            frmCrearProductos.Show();
        }

        private void btnFrmBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProductos frmBuscarProductos = new frmBuscarProductos();
            frmBuscarProductos.Show();
        }

        private void btnFrmActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarProductos frmActualizarProductos = new frmActualizarProductos();
            frmActualizarProductos.Show();
        }

        private void btnFrmEliminar_Click(object sender, EventArgs e)
        {
            frmEliminarProductos frmEliminarProductos = new frmEliminarProductos();
            frmEliminarProductos.Show();
        }
    }
}
