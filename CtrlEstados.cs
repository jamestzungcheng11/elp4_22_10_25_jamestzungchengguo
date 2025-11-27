using System;
using System.Collections.Generic;

namespace PaisesEstadosCidades
{
    internal class CtrlEstados : Controller<Estados>
    {
<<<<<<< HEAD
        ColecoesEstados acolEstados;
        DaoEstados aDaoEstados;
=======
        ColecoesEstados aColEstados;
        DaoEstados aDaoestados;
>>>>>>> 83455dc513d6e565479f5a81d64ad804a003bedd

        public CtrlEstados()
        {
            acolEstados = new ColecoesEstados();
            aDaoEstados = new DaoEstados();
        }

        public override string Salvar(object obj)
        {
<<<<<<< HEAD
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
=======
            return aDaoestados.Salvar(obj);
        }
>>>>>>> 83455dc513d6e565479f5a81d64ad804a003bedd
    }
}
