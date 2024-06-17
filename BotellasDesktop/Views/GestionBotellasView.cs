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

namespace BotellasDesktop.Views
{
    public partial class GestionBotellasView : Form
    {
        BotellasRepo repo = new BotellasRepo();
        public GestionBotellasView()
        {
            InitializeComponent();
            CargarBotellasAGrilla();
        }

        private async void CargarBotellasAGrilla()
        {
            dataGridBotellas.DataSource = await repo.ObtenerBotellasAsync();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarBotellasView agregarEditarBotellasView = new AgregarEditarBotellasView();
            agregarEditarBotellasView.ShowDialog();
            CargarBotellasAGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string? idBotellaSeleccionada = (string)dataGridBotellas.CurrentRow.Cells[0].Value;
            string? nombreBotellaSeleccionada = (string)dataGridBotellas.CurrentRow.Cells[1].Value;

            DialogResult respuesta = MessageBox.Show($"ESta seguro que desea borrar {nombreBotellaSeleccionada}?", "Eliminar Botella0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await repo.RemoveAsync(idBotellaSeleccionada);
                CargarBotellasAGrilla();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            string? idBotellaSeleccionada = (string)dataGridBotellas.CurrentRow.Cells[0].Value;

            AgregarEditarBotellasView agregarEditarBotellasView = new AgregarEditarBotellasView(idBotellaSeleccionada);
            agregarEditarBotellasView.ShowDialog();

            CargarBotellasAGrilla();
        }
    }
}
