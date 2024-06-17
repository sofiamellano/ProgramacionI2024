using EjercicioDePrueba.Models;
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
    public partial class AgregarEditarLibroView : Form
    {
        private string idbookselected;
        BooksRepo repo = new BooksRepo();

        public AgregarEditarLibroView()
        {
            InitializeComponent();
        }
        //constructor que recibe el id como cparametro
        public AgregarEditarLibroView(string idbookselected)
        {
            this.idbookselected = idbookselected;
            InitializeComponent();
            CargarLibroAPantalla();
        }

        private async void CargarLibroAPantalla()
        {
            Book? book = await repo.GetById(this.idbookselected);
            if (book != null)
            {
                txtName.Text = book.nombre;
                txtAutor.Text = book.autor;
                txtEditorial.Text = book.editorial;
                txtPortadaUrl.Text = book.portada_url;
                txtGenero.Text = book.genero;
                txtSinopsis.Text = book.sinopsis;
                numericPages.Value = book.paginas;
                pictureBoxPortada.ImageLocation = book.portada_url;
            }
            else
                MessageBox.Show("Error no se encontro el libro!");
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (this.idbookselected != null)
            {
                await repo.UpdateAsync(txtName.Text, txtAutor.Text, txtEditorial.Text, txtPortadaUrl.Text, txtSinopsis.Text, (int)numericPages.Value, txtGenero.Text, this.idbookselected);
            }
            else
            {
                await repo.AddAsync(txtName.Text, txtAutor.Text, txtEditorial.Text, txtPortadaUrl.Text, txtSinopsis.Text, (int)numericPages.Value, txtGenero.Text);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
