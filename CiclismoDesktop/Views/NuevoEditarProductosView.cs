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
    public partial class NuevoEditarProductosView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idProductoEdit;

        public NuevoEditarProductosView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
        }

        public NuevoEditarProductosView(int idProductoEdit)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            this.idProductoEdit = idProductoEdit;
            cargarDatosAPantalla();
        }

        private void cargarDatosAPantalla()
        {
            if (idProductoEdit.HasValue)
            { 
                comand.CommandText = $"SELECT * FROM productos WHERE id={this.idProductoEdit}";
                comand.Parameters.AddWithValue("@IdProducto", idProductoEdit);

                using (var productosReader = comand.ExecuteReader())
                { 
                    if (productosReader != null)
                    {
                        if (productosReader.Read())
                        {
                            txtNombreProducto.Text = GetStringOrNull(productosReader, "NombreProducto");
                            txtColor.Text = GetStringOrNull(productosReader, "Color");
                            numericUpDownTalla.Value = productosReader["Talla"] != DBNull.Value ? Convert.ToInt32(productosReader["Talla"]) : 0;
                            txtM_F.Text = GetStringOrNull(productosReader, "M_F");
                            if (productosReader["Precio"] != DBNull.Value)
                                numericUpDownPrecio.Value = Convert.ToDecimal(productosReader["Precio"]);
                            txtClaseProducto.Text = GetStringOrNull(productosReader, "ClaseProducto");
                        }
                    }
                }
            }
        }
        private string GetStringOrNull(SqlDataReader reader, string columnName)
        {
            int columnIndex = reader.GetOrdinal(columnName);
            return reader.IsDBNull(columnIndex) ? string.Empty : reader.GetString(columnIndex);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            string color = txtColor.Text;
            int talla = (int)numericUpDownTalla.Value;
            string m_f = txtM_F.Text;
            decimal precio = numericUpDownPrecio.Value;
            string claseProducto = txtClaseProducto.Text;

            try
            {
                comand.Parameters.Clear();

                if (!idProductoEdit.HasValue)
                {
                    comand.CommandText = $"INSERT INTO productos    (nombreProducto, color, talla, m_f, precio, claseProducto) VALUES ('{nombreProducto}',  '{color}', '{talla}', '{m_f}', '{precio}', '{claseProducto}')";
                }
                else
                {
                    comand.CommandText = $"UPDATE productos SET nombreProducto='{nombreProducto}', color='{color}', talla='{talla}', m_f='{m_f}', precio='{precio}', claseProducto='{claseProducto}' WHERE id={this.idProductoEdit}";
                    comand.Parameters.AddWithValue("@IdProducto", idProductoEdit);
                }

                comand.ExecuteNonQuery();
                this.Close();
            }

            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
