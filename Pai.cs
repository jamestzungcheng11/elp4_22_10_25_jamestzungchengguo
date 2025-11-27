using System;

namespace PaisesEstadosCidades
{
    internal class Pai
    {
        protected int codigo;
        protected DateTime datcad;
        protected DateTime ultalt;

        public Pai()
        {
            codigo = 0;
            datcad = DateTime.Now;
            ultalt = DateTime.Now;
        }

        public Pai(int codigo, DateTime datcad, DateTime ultalt)
        {
            this.codigo = codigo;
            this.datcad = datcad;
            this.ultalt = ultalt;
        }

        public Pai(int codigo, DateTime datcad)
        {
            this.codigo = codigo;
            this.datcad = datcad;
            this.ultalt = DateTime.Now;
        }

        public int Codigo
        {
            get => codigo;
            set => codigo = value;
        }

        public DateTime Datcad
        {
            get => datcad;
            set => datcad = value;
        }

        public DateTime Ultalt
        {
            get => ultalt;
            set => ultalt = value;
        }
    }
}
