using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    class ColecoesPaises:Colecoes<Paises>
    {
        public Paises BuscarPorSiglas(string sigla)
        {
            foreach (var opais in aLista)
            {
                if(opais.Sigla.Equals(sigla,StringComparison.OrdinalIgnoreCase ))
                {
                    return opais;

                }
            }
            return null;
        }

        public override void Imprimir()
        {
            foreach(var opais in aLista)
            {
                Console.WriteLine($"Pais: {opais.Pais}");
                Console.WriteLine($"Sigla {opais.Sigla}");
                Console.WriteLine($"DDI {opais.Ddi}");
                Console.WriteLine($"Moeda {opais.Moeda}");
            }

        }
    }
     
}
