using EjercicioDePrueba.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace EjercicioDePrueba.Repositories
{
    public class BooksRepo
    {
        string urlApi = "https://ingenieria-bd23.restdb.io/rest/libros";
        HttpClient client = new HttpClient();

        public BooksRepo()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "64f8c70c68885409dc0bfe7f");
        }

        public async Task<ObservableCollection<Book?>> ObtenerLibrosAsync()
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Book>>(response);

        }

        public async Task<Book?> AddAsync(string nombre, string autor, string editorial, string portada_url, string sinopsis, int paginas, string genero)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Book book = new Book()
            {
                nombre = nombre,
                autor = autor,
                editorial = editorial,
                portada_url = portada_url,
                sinopsis = sinopsis,
                paginas = paginas,
                genero = genero
            };



            //enviamos por POST el objeto que creamos a la URL de la API
            var bookjson = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, bookjson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Book>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Book?> UpdateAsync(string nombre, string autor, string editorial, string portada_url, string sinopsis, int paginas, string genero, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Book book = new Book()
            {
                nombre = nombre,
                autor = autor,
                editorial = editorial,
                portada_url = portada_url,
                sinopsis = sinopsis,
                paginas = paginas,
                genero = genero
            };

            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                JsonConvert.SerializeObject(book),
                Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Book>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Book> GetById(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Book>(response);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
