using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    class CtrlCidades:Controller<Cidades>
    {
        ColecoesCidades aColCidades;
        DaoCidades aDaoCidades;
        
   


        public CtrlCidades()
        {
            aColCidades= new ColecoesCidades();
            aDaoCidades= new DaoCidades();
        }
        



        public override string Salvar(object obj)
        {

            return aDaoCidades.Salvar(obj);





        }


    }
}
