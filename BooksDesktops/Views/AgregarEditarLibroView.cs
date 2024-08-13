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
        BooksRepo repo = new BooksRepo();
        private Book book;

        //nuevo
        public AgregarEditarLibroView()
        {
            InitializeComponent();
            this.book = new Book();
        }

        //editar
        public AgregarEditarLibroView(Book book)
        {
            this.book = book;
            InitializeComponent();
            CargarLibroAPantalla();
        }

        private void CargarLibroAPantalla()
        {
                txtName.Text = book.nombre;
                txtAutor.Text = book.autor;
                txtEditorial.Text = book.editorial;
                txtGenero.Text = book.genero;
                txtSinopsis.Text = book.sinopsis;
                numericPages.Value = book.paginas;
                pictureBoxPortada.ImageLocation = book.portada_url;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            this.book.nombre = txtName.Text;
            this.book.autor = txtAutor.Text;
            this.book.editorial = txtEditorial.Text;
            this.book.portada_url = pictureBoxPortada.ImageLocation;
            this.book.genero = txtGenero.Text;
            this.book.sinopsis = txtSinopsis.Text;
            this.book.paginas = (int)numericPages.Value;

            if (this.book._id != null)
            {
                await repo.UpdateAsync(this.book);
            }
            else
            {
                await repo.AddAsync(this.book);
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
