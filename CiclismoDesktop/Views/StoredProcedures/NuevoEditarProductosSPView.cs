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
    public partial class NuevoEditarProductosSPView : Form
    {
        SqlCommand comand = new SqlCommand();
        private int? idProductoEdit;

        public NuevoEditarProductosSPView()
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            comand.CommandType = CommandType.StoredProcedure;
        }

        public NuevoEditarProductosSPView(int idProductoEdit)
        {
            InitializeComponent();
            comand.Connection = Helper.CrearConexion();
            comand.CommandType = CommandType.StoredProcedure;
            this.idProductoEdit = idProductoEdit;
            cargarDatosAPantalla();
        }

        private void cargarDatosAPantalla()
        {
            comand.Parameters.Clear();
            comand.CommandText = "GetProductoById";
            comand.Parameters.AddWithValue("id", idProductoEdit);
            var productoReader = comand.ExecuteReader();
            if (productoReader != null)
            {
                if (productoReader.Read())
                {
                    txtNombreProducto.Text = (string)productoReader["NombreProducto"];
                    txtColor.Text = (string)productoReader["Color"];
                    txtTalla.Text = (string)productoReader["Talla"];
                    txtM_F.Text = (string)productoReader["M_F"];
                    if (productoReader["Precio"] != DBNull.Value)
                        numericUpDownPrecio.Value = Convert.ToDecimal(productoReader["Precio"]);
                }
            }
            productoReader?.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombreProducto = txtNombreProducto.Text;
            string color = txtColor.Text;
            string talla = txtTalla.Text;
            string m_f = txtM_F.Text;
            decimal precio = numericUpDownPrecio.Value;


            comand.Parameters.Clear();

            if ( idProductoEdit == null)
            {
                comand.CommandText = "AddProducto";
            }
            else
            {
                comand.CommandText = "UpdateProducto";
                comand.Parameters.AddWithValue("id", idProductoEdit);
            }

            comand.Parameters.AddWithValue("nombreProducto", nombreProducto);
            comand.Parameters.AddWithValue("color", color);
            comand.Parameters.AddWithValue("talla", talla);
            comand.Parameters.AddWithValue("m_f", m_f);
            comand.Parameters.AddWithValue("precio", precio);

            comand.ExecuteNonQuery();
            this.Close();
        }
    }
}
