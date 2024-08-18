using CiclismoDesktopPorCodigo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CiclismoDesktopPorCodigo.Views
{
    public partial class NuevoEditarTipoDeProductoView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idTipoProductoEdit;

        public NuevoEditarTipoDeProductoView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarTipoDeProductoView(int idTipoProductoEdit)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            this.idTipoProductoEdit = idTipoProductoEdit;
            cargarDatosAPantalla();
        }

        private void cargarDatosAPantalla()
        {
            comand.CommandText = $"SELECT * FROM tipo_productos WHERE id={this.idTipoProductoEdit}";
            var tipoProductosReader = comand.ExecuteReader();
            if (tipoProductosReader != null)
            {
                if (tipoProductosReader.Read())
                {
                    txtNombreTipoProducto.Text = (string)tipoProductosReader["NombreTipoProducto"];
                    txtDescripcion.Text = (string)tipoProductosReader["Descripcion"];
                }
            }
            tipoProductosReader?.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreTipoProducto = txtNombreTipoProducto.Text;
            string descripcion = txtDescripcion.Text;

            if (idTipoProductoEdit == null)
            {
                comand.CommandText = $"INSERT INTO tipo_productos (NombreTipoProducto, Descripcion) VALUES ('{nombreTipoProducto}', '{descripcion}')";
            }
            else
            {
                comand.CommandText = $"UPDATE tipo_productos SET NombreTipoProducto='{nombreTipoProducto}', Descripcion='{descripcion}' WHERE id={this.idTipoProductoEdit}";
            }
            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
