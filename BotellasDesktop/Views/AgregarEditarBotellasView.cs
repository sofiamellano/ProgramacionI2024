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
using System.Xml.Linq;

namespace BotellasDesktop.Views
{
    public partial class AgregarEditarBotellasView : Form
    {
        private string idBotellaSeleccionada;
        BotellasRepo repo = new BotellasRepo();

        public AgregarEditarBotellasView()
        {
            InitializeComponent();
        }

        public AgregarEditarBotellasView(string idBotellaSeleccionada)
        {
            this.idBotellaSeleccionada = idBotellaSeleccionada;
            InitializeComponent();
            CargarBotellaAPantalla();
        }

        private async void CargarBotellaAPantalla()
        { 
            Botella? botellas = await repo.GetById(this.idBotellaSeleccionada);
            if (botellas != null)
            {
                txtTipo.Text = botellas.tipo;
                txtImgUrl.Text = botellas.imgUrl;
                numericUpDown.Value = (decimal)botellas.Lts_ml;
                pictureBoxBotellas.ImageLocation = botellas.imgUrl;
            }
            else
                MessageBox.Show("ERROR! No se encontro la botella");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if(idBotellaSeleccionada != null)
            {
                await repo.UpdateAsync(this.idBotellaSeleccionada, txtTipo.Text,txtImgUrl.Text, (double)numericUpDown.Value);
            } else
            {
                await repo.AgregarAsync(txtTipo.Text, txtImgUrl.Text, (double)numericUpDown.Value);
            }
            this.Close();
        }
    }
}
