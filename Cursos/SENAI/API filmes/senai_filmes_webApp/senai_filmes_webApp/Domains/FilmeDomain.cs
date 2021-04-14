using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApp.Domains
{
    /// <summary>
    /// Classe que representa a entendidade (tabela) Filmes
    /// </summary>
    public class FilmeDomain
    {
        public int idFilme { get; set; }
        public string titulo { get; set; }
        public int idGenero { get; set; }

    }
}
