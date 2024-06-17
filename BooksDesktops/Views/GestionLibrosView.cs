using EjercicioDePrueba.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BooksDesktops.Views
{
    public partial class GestionLibrosView : Form
    {
        BooksRepo repo = new BooksRepo();
        public GestionLibrosView()
        {
            InitializeComponent();
            CargarLibrosALaGrilla();
        }

        private async void CargarLibrosALaGrilla()
        {
            dataGridLibros.DataSource = await repo.ObtenerLibrosAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView();
            agregarEditarLibroView.ShowDialog();
            CargarLibrosALaGrilla();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //obtener id del libro seleccionado

            string? idbookselected = (string)dataGridLibros.CurrentRow.Cells[0].Value;

            //instanciar ventana editar/agregar libro y pasarle el id al constructor

            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView(idbookselected);

            //(vamos a tener que crear un nuevo constructor en ese formulario que este preparado para recibir el id)
            //llamamos a la ventana con el metodo showmodal que la pone por encima

            agregarEditarLibroView.ShowDialog();

            //recargar la grilla

            CargarLibrosALaGrilla();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            //obtener el id del libro seleccionado y su nombre
            string? idbookselected = (string) dataGridLibros.CurrentRow.Cells[0].Value;
            string? namebookselected = (string) dataGridLibros.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta si estas seguro que deseas borrar
            DialogResult answer = MessageBox.Show($"Esta seguro de borrar el libro: {namebookselected}?", "Eliminar Libro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //crear logica. si el usuario selecciono que quiere borrar, enviamos a borrar el libro utilizando el id y el objeto repo.
            if (answer == DialogResult.Yes)
            {
                await repo.RemoveAsync(idbookselected);
                CargarLibrosALaGrilla();
            }
        }
    }
}
