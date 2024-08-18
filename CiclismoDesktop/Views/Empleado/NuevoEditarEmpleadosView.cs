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
    public partial class NuevoEditarEmpleadosView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idEmpleadoEdit;

        public NuevoEditarEmpleadosView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarEmpleadosView(int idEmpleadoEdit)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            this.idEmpleadoEdit = idEmpleadoEdit;
            cargarDatosAPantalla();
        }

        private void cargarDatosAPantalla()
        {
            comand.CommandText = $"SELECT * FROM empleados WHERE id={this.idEmpleadoEdit}";
            var empleadosReader = comand.ExecuteReader();
            if (empleadosReader != null)
            {
                if (empleadosReader.Read())
                {
                    txtApellido.Text = (string)empleadosReader["Apellido"];
                    txtNombre.Text = (string)empleadosReader["Nombre"];
                    txtCargo.Text = (string)empleadosReader["Cargo"];
                }
            }
            empleadosReader?.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string cargo = txtCargo.Text;

            if (idEmpleadoEdit == null)
            {
                comand.CommandText = $"INSERT INTO empleados (Apellido, Nombre, Cargo) VALUES ('{apellido}', '{nombre}', '{cargo}')";
            }
            else
            {
                comand.CommandText = $"UPDATE empleados SET Apellido='{apellido}', Nombre='{nombre}', Cargo='{cargo}' WHERE id={this.idEmpleadoEdit}";
            }
            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
