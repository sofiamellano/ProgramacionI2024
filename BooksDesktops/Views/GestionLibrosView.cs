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
    }
}
