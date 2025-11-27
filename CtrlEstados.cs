using System;
using System.Collections.Generic;

namespace PaisesEstadosCidades
{
    internal class CtrlEstados : Controller<Estados>
    {
        ColecoesEstados acolEstados;
        DaoEstados aDaoEstados;

        public CtrlEstados()
        {
            acolEstados = new ColecoesEstados();
            aDaoEstados = new DaoEstados();
        }

        public override string Salvar(object obj)
        {
            return aDaoEstados.Salvar(obj);
        }

        public override List<Estados> Listar()
        {
            return aDaoEstados.Listar();
        }

        public override string Excluir(object obj)
        {
            return aDaoEstados.Excluir(obj);
        }

        public override object CarregaObj(int chave)
        {
            return aDaoEstados.CarregaObj(chave);
        }

        public override List<T> Pesquisar<T>(string chave)
        {
            return aDaoEstados.Pesquisar<T>(chave);
        }
    }
}
