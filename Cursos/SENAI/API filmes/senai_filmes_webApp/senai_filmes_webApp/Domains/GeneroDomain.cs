using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApp.Domains
{
    /// <summary>
    /// Classe que representa a entendidade (tabela) Generos
    /// </summary>
    public class GeneroDomain
    {
        public int idGenero { get; set; }
        public string nome { get; set; }
    }
}
