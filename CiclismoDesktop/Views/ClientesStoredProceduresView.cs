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
    public partial class ClientesStoredProceduresView : Form
    {
        SqlCommand comand = new SqlCommand();

        public ClientesStoredProceduresView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            // comando a ejecutar y ejecutado, resultado queda en sqlDatareader
            comand.CommandType = CommandType.StoredProcedure;
            comand.Parameters.Clear();
            comand.CommandText = "GetAllClientes";
            SqlDataReader clientesReader = comand.ExecuteReader();

            // datos cargados en Datatable para mostar en grilla
            DataTable clientesTable = new DataTable();
            clientesTable.Load(clientesReader);
            dataGridClientes.DataSource = clientesTable;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idClienteDelete = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            string NombreCliente = (string)dataGridClientes.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"ESta seguro que desea borrar al cliente: {NombreCliente}?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                comand.CommandType = CommandType.StoredProcedure;
                comand.CommandText = "DeleteCliente";
                comand.Parameters.AddWithValue("id", idClienteDelete);
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteSPView nuevoEditarClienteSPView = new NuevoEditarClienteSPView();
            nuevoEditarClienteSPView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idClienteEdit = (int)dataGridClientes.CurrentRow.Cells[0].Value;
            NuevoEditarClienteSPView nuevoEditarClienteSPView = new NuevoEditarClienteSPView(idClienteEdit);
            nuevoEditarClienteSPView.ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
