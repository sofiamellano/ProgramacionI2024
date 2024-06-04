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
        public AgregarEditarLibroView()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            BooksRepo repo= new BooksRepo();
            await repo.AddAsync(txtName.Text, txtAutor.Text, txtEditorial.Text, txtPortadaUrl.Text, txtSinopsis.Text, (int)numericPages.Value, txtGenero.Text);
            this.Close();
        }
    }
}
