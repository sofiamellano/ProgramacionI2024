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
using static System.Net.Mime.MediaTypeNames;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class NuevoEditarClienteView : Form
    {

        string connectionString = "server=.\\SQLEXPRESS; database=Ciclismo2; user id=sa; password=123; multipleactiveresultsets=true; Encrypt=false";

        SqlCommand comand = new SqlCommand();

        SqlConnection conex;
        private int? idClienteEdit;

        public NuevoEditarClienteView()
        {
            InitializeComponent();
            AbrirConexion();
        }

        public NuevoEditarClienteView(int idClienteEdit)
        {
            InitializeComponent();
            AbrirConexion();
            this.idClienteEdit = idClienteEdit;
            cargarDatosAPantalla();
        }

        private void cargarDatosAPantalla()
        {
            comand.CommandText = $"SELECT * FROM clientes WHERE id={this.idClienteEdit}";
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

        private void AbrirConexion()
        {
            conex = new SqlConnection(this.connectionString);
            conex.Open();
            comand.Connection = conex;
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

            if(idClienteEdit == null)
            {
                comand.CommandText = $"INSERT INTO clientes (nombre, NombreContacto, ApellidoContacto) VALUES ('{nombre}', '{nombreContacto}', '{apellidoContacto}')";
            }
            else
            {
                comand.CommandText = $"UPDATE clientes SET nombre='{nombre}', NombreContacto='{nombreContacto}', ApellidoContacto='{apellidoContacto}' WHERE id={this.idClienteEdit}";
            }
            comand.ExecuteNonQuery();
            this.Close();
            
        }
    }
}
