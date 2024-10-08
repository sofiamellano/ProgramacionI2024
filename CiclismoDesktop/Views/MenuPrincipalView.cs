using CiclismoDesktopPorCodigo.Views;
using CiclismoDesktopPorCodigo.Views.LINQ;

namespace CiclismoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesView clientesView = new ClientesView();
            clientesView.ShowDialog();
        }

        private void gestionDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpleadosView empleadosView = new EmpleadosView();
            empleadosView.ShowDialog();
        }

        private void gestionDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosView productosView = new ProductosView();
            productosView.ShowDialog();
        }

        private void gestionDeTipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipoDeProductoView tipoDeProductoView = new TipoDeProductoView();
            tipoDeProductoView.ShowDialog();
        }

        private void gestionDeClientesStoredProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesStoredProceduresView clientesStoreProceduresView = new ClientesStoredProceduresView();
            clientesStoreProceduresView.ShowDialog();
        }

        private void gestionClientesORMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesORMView clientesORMView = new ClientesORMView();
            clientesORMView.ShowDialog();
        }

        private void gestionDeProductosStoredProceduresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductosStoredProceduresView productosStoredProceduresView = new ProductosStoredProceduresView();
            productosStoredProceduresView.ShowDialog();
        }

        private void pruebasConLINQToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebasLINQView pruebasLINQView = new PruebasLINQView();
            pruebasLINQView.ShowDialog();
        }
    }
}
