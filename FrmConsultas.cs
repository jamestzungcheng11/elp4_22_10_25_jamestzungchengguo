using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmConsultas : PaisesEstadosCidades.Frm
	{
		public FrmConsultas()
		{
			InitializeComponent();
		}

        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }
        protected  virtual void Incluir()
        {

        }
        protected  virtual void Alterar()
        {

        }

        protected virtual void CarregaLV()
        {

        }
        protected  virtual void Excluir()
        {

        }
        protected  virtual void Pesquisar()
        {

        }

        public virtual void setFrmCadastros(Object Obj)
        {

        }

        public override void ConhecaObj(Object Obj,Object Ctrl)
        {

        }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            Incluir();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
