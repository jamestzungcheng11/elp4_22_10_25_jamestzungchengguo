using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    class ColecoesCidades:Colecoes<Cidades>
    {
        public Cidades BuscarPorNome(string nome)
        {
            foreach (var cidade in aLista)
            {
                if(cidade.Cidade.Equals(nome,StringComparison.OrdinalIgnoreCase))
                {
                    return cidade;
                }
            }
            return null;
        }

        public Cidades BuscarPorDdd(string ddd)
        {
            foreach(var cidade in aLista)
            {
                if(cidade.Ddd.Equals(ddd,StringComparison.OrdinalIgnoreCase))
                {
                    return cidade;
                }

            }
            return null;
        }

        public override void Imprimir()
        {
            foreach (var cidade in aLista)
            {
                Console.WriteLine($"Cidade:{cidade.Cidade}");
                Console.WriteLine($"Ddd:{cidade.Ddd}");
                Console.WriteLine($"Estado:{cidade.Oestados.Estado}");
                Console.WriteLine($"Paises: {cidade.Oestados.Opais.Pais}");
                Console.WriteLine($"Codigo: {cidade.Codigo}");
                Console.WriteLine($"Data de Cadastros {cidade.Datcad}");
                Console.WriteLine($"Ultimo altercao {cidade.Ultalt}");
            }
        }



    }
}
