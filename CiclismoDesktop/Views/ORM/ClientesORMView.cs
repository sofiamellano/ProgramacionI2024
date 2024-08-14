using CiclismoDesktopPorCodigo.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class ClientesORMView : Form
    {
        Ciclismo2Context context = new Ciclismo2Context();
        BindingSource listClientes = new BindingSource();
        public ClientesORMView()
        {
            InitializeComponent();
            dataGridClientes.DataSource = listClientes;
            CargarGrilla();
        }

        private void CargarGrilla()
        {

            listClientes.DataSource = context.Clientes.ToList();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listClientes.Current;

            DialogResult respuesta = MessageBox.Show($"ESta seguro que desea borrar al cliente: {cliente.Nombre}?", "Eliminar Cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                context.Clientes.Remove(cliente);
                context.SaveChanges();
                CargarGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoEditarClienteORMView nuevoEditarClienteORMView = new NuevoEditarClienteORMView();
            nuevoEditarClienteORMView.ShowDialog();
            CargarGrilla();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var Cliente = (Cliente)listClientes.Current;
            NuevoEditarClienteORMView nuevoEditarClienteORMView = new NuevoEditarClienteORMView(Cliente);
            nuevoEditarClienteORMView.ShowDialog();
            CargarGrilla();
        }
    }
}
