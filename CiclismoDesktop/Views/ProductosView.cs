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
    public partial class ProductosView : Form
    {
        SqlCommand comand = new SqlCommand();
        public ProductosView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            comand.CommandText = "SELECT * FROM productos";
            SqlDataReader productosReader = comand.ExecuteReader();

            DataTable productosTable = new DataTable();
            productosTable.Load(productosReader);
            dataGridProductos.DataSource = productosTable;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int idProductoDelete = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            string NombreProducto = (string)dataGridProductos.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"ESta seguro que desea borrar este producto: {NombreProducto}?", "Eliminar Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                comand.CommandText = $"Delete from productos where id={idProductoDelete}";
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarProductosView nuevoEditarProductosView = new NuevoEditarProductosView();
            nuevoEditarProductosView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idProductoEdit = (int)dataGridProductos.CurrentRow.Cells[0].Value;
            NuevoEditarProductosView nuevoEditarProductosView = new NuevoEditarProductosView(idProductoEdit);
            nuevoEditarProductosView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
