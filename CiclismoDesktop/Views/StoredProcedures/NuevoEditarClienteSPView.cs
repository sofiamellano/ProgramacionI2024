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
    public partial class NuevoEditarClienteSPView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idClienteEdit;

        public NuevoEditarClienteSPView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            comand.CommandType = CommandType.StoredProcedure;
        }

        public NuevoEditarClienteSPView(int idClienteEdit)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            comand.CommandType = CommandType.StoredProcedure;
            this.idClienteEdit = idClienteEdit;
            cargarDatosAPantalla();
        }

        private void cargarDatosAPantalla()
        {            
            comand.Parameters.Clear();
            comand.CommandText = "GetClienteById";
            comand.Parameters.AddWithValue("id", idClienteEdit);
            var clienteReader = comand.ExecuteReader();
            if (clienteReader != null)
            {
                if (clienteReader.Read())
                {
                    txtNombre.Text = (string)clienteReader["Nombre"];
                    txtNombreContacto.Text = (string)clienteReader["NombreContacto"];
                    txtApellidoContacto.Text = (string)clienteReader["ApellidoContacto"];
                }
            }
            clienteReader?.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string nombreContacto = txtNombreContacto.Text;
            string apellidoContacto = txtApellidoContacto.Text;

            
            comand.Parameters.Clear();

            if (idClienteEdit == null)
            {
                comand.CommandText = "AddCliente";
            }
            else
            {
                comand.CommandText = "UpdateCliente";
                comand.Parameters.AddWithValue("id", idClienteEdit);
            }

            comand.Parameters.AddWithValue("nombre", nombre);
            comand.Parameters.AddWithValue("nombreContacto", nombreContacto);
            comand.Parameters.AddWithValue("apellidoContacto", apellidoContacto);

            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
