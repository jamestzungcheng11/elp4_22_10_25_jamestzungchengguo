using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmCadastros : PaisesEstadosCidades.Frm
	{
		public FrmCadastros()
		{
			InitializeComponent();
		}
		
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
			Salvar();
			Sair();
        }
		public  virtual void CarregaTxt()
		{

		}
		public virtual void LimpaTxt()
		{

		}
		public  virtual void Bloqueartxt()
		{

		}
		public virtual void DesbloquearTxt()
		{

		}
		public  virtual void Salvar()
		{

		}

        private void FrmCadastros_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
			Sair();
        }
		protected override void Sair()
		{
			Close();

		}
    }
}
