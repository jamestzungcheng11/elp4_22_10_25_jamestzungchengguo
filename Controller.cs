using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    internal class Controller<T>
    {



        public Controller()
        {

        }
            

        public virtual string Excluir(Object obj)
        {
            return null;

        }
        public virtual string  Salvar(object obj)
        {
            return null;
            
        }

        public virtual List<T> Listar()
        {
            return null;


        }
        public virtual Object CarregaObj(int chave)
        {
            return null;
        }

        public virtual List<T>Pesquisar<T>(string chave)
        {
            return null;


        }



    }
}
