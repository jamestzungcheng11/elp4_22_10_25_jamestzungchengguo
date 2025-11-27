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

       public override List<Paises> Listar()
        {
            return aDaoPaises.Listar();
        }

        public override string Excluir(object obj)
        {
            return aDaoPaises.Excluir(obj);
        }
        public override object CarregaObj(int chave)
        {
            return aDaoPaises.CarregaObj(chave);
        }
        public override List<Paises> Pesquisar<Paises>(string chave)
        {
            return aDaoPaises.Pesquisar<Paises>(chave);
        }





    }
}
