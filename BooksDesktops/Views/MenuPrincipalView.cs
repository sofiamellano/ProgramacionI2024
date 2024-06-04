using BooksDesktops.Views;

namespace BooksDesktops
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void librosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionLibrosView gestionLibrosView = new GestionLibrosView();
            gestionLibrosView.ShowDialog();
        }
    }
}
