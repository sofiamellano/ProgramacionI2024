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

        public async Task<Book?> AddAsync(Book book)
        {
            //enviamos por POST el objeto que creamos a la URL de la API
            var bookjson = new StringContent(JsonConvert.SerializeObject(book), Encoding.UTF8, "application/json");
            var response = await client.PostAsync(urlApi, bookjson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Book>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Book?> UpdateAsync(Book book)
        {
            //enviamos por PUT el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                JsonConvert.SerializeObject(book),
                Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + book._id, librojson);

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
