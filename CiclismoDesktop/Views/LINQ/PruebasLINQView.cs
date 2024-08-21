using CiclismoDesktopPorCodigo.DataContext;
using CiclismoDesktopPorCodigo.Modelos;
using CiclismoDesktopPorCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CiclismoDesktopPorCodigo.Views.LINQ
{
    public partial class PruebasLINQView : Form
    {
        #region Definimos un array de JSON
        JArray jsonArrayPeliculas = JArray.Parse("[\r\n  { \"title\": \"El laberinto del fauno\", \"director\": \"Guillermo del Toro\", \"year\": 2006, \"genre\": \"Fantasía\" },\r\n  { \"title\": \"Amores perros\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2000, \"genre\": \"Drama\" },\r\n  { \"title\": \"Mar adentro\", \"director\": \"Alejandro Amenábar\", \"year\": 2004, \"genre\": \"Drama\" },\r\n  { \"title\": \"Todo sobre mi madre\", \"director\": \"Pedro Almodóvar\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"El secreto de sus ojos\", \"director\": \"Juan José Campanella\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"Roma\", \"director\": \"Alfonso Cuarón\", \"year\": 2018, \"genre\": \"Drama\" },\r\n  { \"title\": \"Y tu mamá también\", \"director\": \"Alfonso Cuarón\", \"year\": 2001, \"genre\": \"Drama\" },\r\n  { \"title\": \"La lengua de las mariposas\", \"director\": \"José Luis Cuerda\", \"year\": 1999, \"genre\": \"Drama\" },\r\n  { \"title\": \"Biutiful\", \"director\": \"Alejandro González Iñárritu\", \"year\": 2010, \"genre\": \"Drama\" },\r\n  { \"title\": \"La vida secreta de las palabras\", \"director\": \"Isabel Coixet\", \"year\": 2005, \"genre\": \"Drama\" },\r\n  { \"title\": \"Relatos salvajes\", \"director\": \"Damián Szifron\", \"year\": 2014, \"genre\": \"Comedia negra\" },\r\n  { \"title\": \"Hable con ella\", \"director\": \"Pedro Almodóvar\", \"year\": 2002, \"genre\": \"Drama\" },\r\n  { \"title\": \"El orfanato\", \"director\": \"J.A. Bayona\", \"year\": 2007, \"genre\": \"Terror\" },\r\n  { \"title\": \"Volver\", \"director\": \"Pedro Almodóvar\", \"year\": 2006, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"Abre los ojos\", \"director\": \"Alejandro Amenábar\", \"year\": 1997, \"genre\": \"Ciencia ficción\" },\r\n  { \"title\": \"Celda 211\", \"director\": \"Daniel Monzón\", \"year\": 2009, \"genre\": \"Thriller\" },\r\n  { \"title\": \"El hijo de la novia\", \"director\": \"Juan José Campanella\", \"year\": 2001, \"genre\": \"Comedia dramática\" },\r\n  { \"title\": \"El espinazo del diablo\", \"director\": \"Guillermo del Toro\", \"year\": 2001, \"genre\": \"Terror\" },\r\n  { \"title\": \"La piel que habito\", \"director\": \"Pedro Almodóvar\", \"year\": 2011, \"genre\": \"Thriller\" },\r\n  { \"title\": \"La historia oficial\", \"director\": \"Luis Puenzo\", \"year\": 1985, \"genre\": \"Drama\" }\r\n]\r\n");
        #endregion  

        public PruebasLINQView()
        {
            InitializeComponent();
        }

        private void btnPruebaArray_Click(object sender, EventArgs e)
        {
            //creamos un array de números
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //con LINQ filtramos los números pares y creamos un nuevo array
            var NumerosPares = (from num in numbers
                                where num % 2 == 0
                                select new { Numero = num }).ToList();

            // lo asignamos a la grilla
            dataGridResultados.DataSource = NumerosPares.ToList();
        }

        private void btnPruebaSQL_Click(object sender, EventArgs e)
        {
            using (var context = new Ciclismo2Context())
            {
                var query = from Cliente in context.Clientes
                            select Cliente;

                dataGridResultados.DataSource = query.ToList();
            }
        }

        private void btnPruebaXML_Click(object sender, EventArgs e)
        {
            XDocument doc = XDocument.Load("C:\\Users\\Usuario\\Documents\\Segundo2024\\Programacion_I\\ProgramacionI\\CiclismoDesktop\\XML\\LibrosXML.xml");
            var titles = from book in doc.Descendants("book")
                         select new
                         {
                             Titulo = book.Element("title")?.Value,
                             Autor = book.Element("author")?.Value,
                             Genero = book.Element("genre")?.Value,
                             Año = book.Element("year")?.Value,
                         };

            dataGridResultados.DataSource = titles.ToList();

        }

        private void btnPruebaJSON_Click(object sender, EventArgs e)
        {
            var peliculas = from pelicula in jsonArrayPeliculas
                            select new
                            {
                                Titulo = pelicula["title"],
                                Director = pelicula["director"],
                                Año = pelicula["year"],
                                Genero = pelicula["genre"]
                            };
            dataGridResultados.DataSource = peliculas.ToList();

        }

        private void btnPruebaSelect_Click(object sender, EventArgs e)
        {
            var peliculas = jsonArrayPeliculas.Select(pelicula => new
            {
                Titulo = pelicula["title"],
                Director = pelicula["director"],
                Año = pelicula["year"],
                Genero = pelicula["genre"]
            });

            dataGridResultados.DataSource = peliculas.ToList();


        }

        private void btnSelectMany_Click(object sender, EventArgs e)
        {
            object[] objects = { 1, "San Justo", true, new string[] { "Hola", "Mundo" }, 5.5f, "Crespo", 7, 8, 9, 10, new string[] { "Santa Fe", "Argentina" } };

            var textosEnArray = objects.OfType<string[]>().SelectMany(t => t).Select(t => new { Texto = t }).ToList();


            dataGridResultados.DataSource = textosEnArray;
        }

        private void btnPruebaWhere_Click(object sender, EventArgs e)
        {

            var pelis = jsonArrayPeliculas.ToObject<List<Peliculas>>();
            //var peliculas = pelis.Where(peli => peli.year > 2000);
            //var peliculas = pelis.Where(peli => peli.genre == "Drama");
            //var peliculas = pelis.Where(peli => peli.year.Equals(1985));
            var peliculas = pelis.Where(peli => peli.title.Contains("Roma"));
            dataGridResultados.DataSource = peliculas.ToList();
        }

        private void btnPruebaWhereAvanzado_Click(object sender, EventArgs e)
        {
            var pelis = jsonArrayPeliculas.ToObject<List<Peliculas>>();

            dataGridResultados.DataSource = pelis.Where(
                peli => peli.title.Contains(txtFiltro.Text) ||
                peli.director.Contains(txtFiltro.Text) ||
                peli.genre.Contains(txtFiltro.Text)).ToList();
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            using (var context = new Ciclismo2Context())
            {
                var clientes = context.Clientes.OrderBy(c => c.Nombre).ToList();

                dataGridResultados.DataSource = clientes.ToList();
            }
        }


        private void btnPruebaOrderByAvanzado_Click(object sender, EventArgs e)
        {
            using (var context = new Ciclismo2Context())
            {
                var clientes = context.Clientes.OrderBy(c => c.Pais).ThenBy(c => c.Nombre).ToList();

                dataGridResultados.DataSource = clientes.ToList();
            }
        }

        private void btnPruebaOffType_Click(object sender, EventArgs e)
        {
            ////creamos un array de objects
            //object[] objects = { 1, "San Justo", true, new string[] { "Hola", "Mundo"}, 5.5f, "Crespo", 7, 8, 9, 10 };

            //var textosEnArray = objects.OfType<string /*strin []*/>().Select(t => new { Texto = t }).ToList();

            //// lo asignamos a la grilla
            //dataGridResultados.DataSource = textosEnArray;
        }

        private void btnPruebaOrderByDecending_Click(object sender, EventArgs e)
        {
            using (var context = new ArgentinaContext())
            {
                //Extension Method (metodos de extension)
                //var provincias = context.Provincias.OrderByDescending(p => p.Nombre);

                //Query Expression
                var provincias = from provincia in context.Provincias
                                 orderby provincia.Nombre descending
                                 select provincia;

                dataGridResultados.DataSource = provincias.ToList();
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            using (var context = new ArgentinaContext())
            {
                var dptosAgupadosXProvincias = context.Departamentos.Include(d => d.Provincias).GroupBy(d => d.ProvinciasId).Select(d => new
                {
                    Provincia = d.First().Provincias.Nombre,
                    Departamentos = d.Count()
                });

                dataGridResultados.DataSource = dptosAgupadosXProvincias.ToList();
            }
        }

        private void btnGroupBy2_Click(object sender, EventArgs e)
        {
            using (var context = new ArgentinaContext())
            {
                var localidadesPorDepartamento = context.Localidades
                    .Where(l => l.Departamentos.Provincias.Nombre == "Santa Fe")
                    .Include(l => l.Departamentos)
                    .ThenInclude(l => l.Provincias)
                    .GroupBy(l => l.DepartamentosId)
                    .Select (l => new
                    {
                        Departamento = l.First().Departamentos.Nombre,
                        Localidades = l.Count()
                    });

                dataGridResultados.DataSource = localidadesPorDepartamento.ToList();
            }
        }
    }
}
