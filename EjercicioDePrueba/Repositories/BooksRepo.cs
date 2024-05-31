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

        public async Task<ObservableCollection<Book>> ObtenerLibrosAsync()
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Book>>(response);

        }
    }
}
