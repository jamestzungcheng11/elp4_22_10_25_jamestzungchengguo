using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    internal class CtrlPaises:Controller<Paises>
    {
        ColecoesPaises acolpais;
        DaoPaises aDaoPaises;


        public CtrlPaises()
        {
            acolpais = new ColecoesPaises();
            aDaoPaises = new DaoPaises();

        }

        public override string  Salvar(object obj)
        {
          
            return aDaoPaises.Salvar(obj);
            
            
              
             

        }

       
    }
}
