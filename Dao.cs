using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
    internal class Dao
    {
        protected SqlConnection cnn;
        public Dao()
        {
            cnn = Banco.Abrir();

        }


        public virtual string  Excluir(object obj)
        {
            return null;
        }

        public virtual string  Salvar(object obj)
        {
            return null;

        }
        public virtual List<T> Listar<T>()
        {
            return null;
        }

        public virtual Object CarregaObj(int chave)
        {
            return null;
        }
        public virtual List<T> Pesquisar<T>(string chave)
        {
            return null;
        }




    }
}