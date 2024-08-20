using CiclismoDesktopPorCodigo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class ProductosStoredProceduresView : Form
    {
        SqlCommand comand = new SqlCommand();
        public ProductosStoredProceduresView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Clear();
            comand.CommandText = "GetAllProductos";
            SqlDataReader clientesReader = comand.ExecuteReader();

            DataTable productosTable = new DataTable();
            productosTable.Load(clientesReader);
            dataGridClientes.DataSource = productosTable;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProductoDelete = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            string NombreProducto = (string)dataGridClientes.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"ESta seguro que desea borrar este producto: {NombreProducto}?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.CommandText = "DeleteProducto";
                comand.Parameters.AddWithValue("id", idProductoDelete);
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarProductosSPView nuevoEditarProductosSPView = new NuevoEditarProductosSPView();
            nuevoEditarProductosSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idProductoEdit = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            NuevoEditarProductosSPView nuevoEditarProductosSPView = new NuevoEditarProductosSPView(idProductoEdit);
            nuevoEditarProductosSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
