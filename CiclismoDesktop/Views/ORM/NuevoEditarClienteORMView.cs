using CiclismoDesktopPorCodigo.Modelos;
using CiclismoDesktopPorCodigo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class NuevoEditarClienteORMView : Form
    {
        Ciclismo2Context context = new Ciclismo2Context();

        private Cliente? cliente;

        public NuevoEditarClienteORMView()
        {
            InitializeComponent();
            this.cliente = new Cliente();
        }

        public NuevoEditarClienteORMView(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            cargarDatosAPantalla();
        }

        private void cargarDatosAPantalla()
        {
            txtNombre.Text = cliente?.Nombre;
            txtNombreContacto.Text = cliente?.NombreContacto;
            txtApellidoContacto.Text = cliente?.ApellidoContacto;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cliente.Nombre = txtNombre.Text;
            cliente.NombreContacto = txtNombreContacto.Text;
            cliente.ApellidoContacto = txtApellidoContacto.Text;

            if(cliente.Id == 0)
            {
                context.Clientes.Add(cliente);
            }
            else
            {
                context.Clientes.Update(cliente);
            }
            context.SaveChanges();
            this.Close();
        }
    }
}
