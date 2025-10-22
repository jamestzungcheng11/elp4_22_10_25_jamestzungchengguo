using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    class ColecoesEstados:Colecoes<Estados>
    {
        public Estados BuscarPorUF(string uf)
        {
            foreach (var oestado in aLista)
            {
                if(oestado.Uf.Equals(uf,StringComparison.OrdinalIgnoreCase))
                {
                    return oestado;
                }
            }
            return null;
        }


        public override void Imprimir()
        {
            foreach (var oestado in aLista)
            {
                Console.WriteLine($"Estado{oestado.Estado}");
                Console.WriteLine($"UF{oestado.Uf}");
                Console.WriteLine($"Codigo{oestado.Codigo}");
                Console.WriteLine($"Pais{ oestado.Opais.Pais}");

            }
        }
    }
}
