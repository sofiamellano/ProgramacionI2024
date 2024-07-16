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
    public partial class EmpleadosView : Form
    {
        SqlCommand comand = new SqlCommand();
        public EmpleadosView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            CargarDatosAGrilla();
        }

        private void CargarDatosAGrilla()
        {
            comand.CommandText = "SELECT * FROM empleados";
            SqlDataReader empleadosReader = comand.ExecuteReader();

            DataTable empleadosTable = new DataTable();
            empleadosTable.Load(empleadosReader);
            dataGridEmpleados.DataSource = empleadosTable;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEmpleadoDelete = (int)dataGridEmpleados.CurrentRow.Cells[0].Value;
            string NombreEmpleado = (string)dataGridEmpleados.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"ESta seguro que desea borrar al empleado: {NombreEmpleado}?", "Eliminar Empleado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                comand.CommandText = $"Delete from empleados where id={idEmpleadoDelete}";
                comand.ExecuteNonQuery();
                CargarDatosAGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarEmpleadosView nuevoEditarEmpleadosView = new NuevoEditarEmpleadosView();
            nuevoEditarEmpleadosView.ShowDialog();
            CargarDatosAGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int idEmpleadoEdit = (int)dataGridEmpleados.CurrentRow.Cells[0].Value;
            NuevoEditarEmpleadosView nuevoEditarEmpleadosView = new NuevoEditarEmpleadosView(idEmpleadoEdit);
            nuevoEditarEmpleadosView .ShowDialog();
            CargarDatosAGrilla();
        }
    }
}
