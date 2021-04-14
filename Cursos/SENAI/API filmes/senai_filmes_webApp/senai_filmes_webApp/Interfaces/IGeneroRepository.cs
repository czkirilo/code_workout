using senai_filmes_webApp.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai_filmes_webApp.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório GeneroRepository
    /// </summary>
    public interface IGeneroRepository // se colocar apenas interface IGeneroRepository ele fica private como default
    {
         // TipoRetorno NomeMetodo(TipoParametro NomeParamentro); //pode não ter parametro

        List<GeneroDomain>
    }
}
