using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    class CtrlEstados : Controller<Estados>
    {
        ColecoesEstados aColEstados;
        DaoEstados aDaoestados;
        ColecoesPaises acolpais;
  
   

        public CtrlEstados()
        {
            aColEstados = new ColecoesEstados();
            aDaoestados = new DaoEstados();
        }



        public override string Salvar(object obj)
        {

            return aDaoestados.Salvar(obj);





        }


    }
}
