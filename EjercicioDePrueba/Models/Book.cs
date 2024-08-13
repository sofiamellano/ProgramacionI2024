using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioDePrueba.Models
{
    public class Book
    {

            public string _id { get; set; }
            public string nombre { get; set; } = string.Empty;
            public int paginas { get; set; } = 0;
            public string autor { get; set; } = string.Empty;
            public string editorial { get; set; } = string.Empty;
            public string portada_url { get; set; } = string.Empty;
            public string sinopsis { get; set; } = string.Empty;
            public string genero { get; set; } = string.Empty;

    }
}
