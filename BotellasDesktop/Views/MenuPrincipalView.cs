using BotellasDesktop.Views;

namespace BotellasDesktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void botellasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionBotellasView gestionBotellasView = new GestionBotellasView();
            gestionBotellasView.ShowDialog();
        }
    }
}
