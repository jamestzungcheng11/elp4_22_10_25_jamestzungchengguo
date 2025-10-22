using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisesEstadosCidades
{
     internal class Cidades:Pai
    {
        protected string cidade;
        protected string ddd;
        protected Estados oestados;



       public Cidades()
        {
            cidade = string.Empty;
            ddd= string.Empty;
            oestados= new Estados();
        }

        public Cidades(string cidade, string ddd, Estados oestado,int codigo,DateTime datcad,DateTime ultalt):base(codigo,datcad,ultalt)
        {
            this.cidade = cidade;
            this.ddd = ddd;
            this.oestados = oestado;
        }

        public string Cidade
        {
            get => cidade;
            set => cidade = value;
        }

        public string Ddd
        {
            get => ddd;
            set => ddd = value;
        }
        public Estados Oestados
        {
            get=> oestados;
            set => oestados = value;
        }
    }
}
