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
    public class BotellasRepo
    {
        string urlApi = "https://cocacola-0733.restdb.io/rest/botellas";
        HttpClient client = new HttpClient();

        public BotellasRepo()
        {
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "6538195049f7411e08b42cbd");
        }

        public async Task<ObservableCollection<Botella>> ObtenerBotellasAsync()
        {

            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Botella>>(response);

        }

        //public async Task<Book?> AddAsync(string nombre, string autor, string editorial, string portada_url, string sinopsis, int paginas, string genero)
        public async Task<Botella?> AgregarAsync(string tipo, string imgUrl, double Lts_ml)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Botella botella = new Botella()
            {
                tipo = tipo,
                imgUrl = imgUrl,
                Lts_ml = Lts_ml
            };

            //enviamos por POST el objeto que creamos a la URL de la API
            var botellajson = new StringContent(
                JsonConvert.SerializeObject(botella),
                Encoding.UTF8, "application/json");

            var response = await client.PostAsync(urlApi, botellajson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Botella>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Botella?> UpdateAsync(string id, string tipo, string imgUrl, double Lts_ml)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Botella botella = new Botella()
            {
                tipo = tipo,
                imgUrl = imgUrl,
                Lts_ml = Lts_ml
            };

            //enviamos por POST el objeto que creamos a la URL de la API
            var botellajson = new StringContent(
                JsonConvert.SerializeObject(botella),
                Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, botellajson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Botella>(await response.Content.ReadAsStringAsync());
        }

        public async Task<Botella> GetById(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Botella>(response);
        }

        public async Task<bool> RemoveAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
    }
}
