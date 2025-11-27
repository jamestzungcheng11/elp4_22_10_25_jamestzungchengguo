using System;
using System.Collections.Generic;

namespace PaisesEstadosCidades
{
    class CtrlCidades : Controller<Cidades>
    {
        ColecoesCidades aColCidades;
        DaoCidades aDaoCidades;

        public CtrlCidades()
        {
            aColCidades = new ColecoesCidades();
            aDaoCidades = new DaoCidades();
        }

        public override string Salvar(object obj)
        {
            return aDaoCidades.Salvar(obj);
        }

        public override List<Cidades> Listar()
        {
            return aDaoCidades.Listar();
        }

        public override string Excluir(object obj)
        {
            return aDaoCidades.Excluir(obj);
        }

        public override object CarregaObj(int chave)
        {
            return aDaoCidades.CarregaObj(chave);
        }

        public override List<T> Pesquisar<T>(string chave)
        {
            return aDaoCidades.Pesquisar<T>(chave);
        }
    }
}
