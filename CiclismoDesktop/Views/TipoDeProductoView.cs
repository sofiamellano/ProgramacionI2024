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
    public partial class TipoDeProductoView : Form
    {
        SqlCommand comand = new SqlCommand();
        public TipoDeProductoView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            comand.CommandText = "SELECT * FROM tipo_productos";
            SqlDataReader tipoProductosReader = comand.ExecuteReader();

            DataTable tipoProductosTable = new DataTable();
            tipoProductosTable.Load(tipoProductosReader);
            dataGridViewTipoDeProducto.DataSource = tipoProductosTable;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idTipoProductoDelete = (int)dataGridViewTipoDeProducto.CurrentRow.Cells[0].Value;
            string NombreTipoProducto = (string)dataGridViewTipoDeProducto.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"ESta seguro que desea borrar este tipo de producto: {NombreTipoProducto}?", "Eliminar Tipo de Producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                comand.CommandText = $"Delete from tipo_productos where id={idTipoProductoDelete}";
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarTipoDeProductoView nuevoEditarTipoDeProductoView = new NuevoEditarTipoDeProductoView();
            nuevoEditarTipoDeProductoView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idTipoProductoEdit = (int)dataGridViewTipoDeProducto.CurrentRow.Cells[0].Value;
            NuevoEditarTipoDeProductoView nuevoEditarTipoDeProductoView = new NuevoEditarTipoDeProductoView(idTipoProductoEdit);
            nuevoEditarTipoDeProductoView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
