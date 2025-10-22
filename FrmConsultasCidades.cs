using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmConsultasCidades : PaisesEstadosCidades.FrmConsultas
	{
        
        FrmCadastrosCidades ofrmCadastrosCidades;
        CtrlCidades aCtrlCidades;
        Cidades ocidade;

		public FrmConsultasCidades()
		{
			InitializeComponent();
		}
        protected override void Incluir()
        {
            ofrmCadastrosCidades.LimpaTxt();
            ofrmCadastrosCidades.ConhecaObj(ocidade, aCtrlCidades);
            ofrmCadastrosCidades.ShowDialog();
            this.CarregaLV();
        }
      
        protected override void Alterar()
        {
            ofrmCadastrosCidades.ConhecaObj(ocidade, aCtrlCidades);
            ofrmCadastrosCidades.LimpaTxt();
            ofrmCadastrosCidades.CarregaTxt();
            ofrmCadastrosCidades.ShowDialog();
            
        }
       
        protected override void CarregaLV()
        {
            //foreach (var opais in CtrlPaises.TodosPaises)
            ListViewItem item = new ListViewItem(Convert.ToString(ocidade.Codigo));
            item.SubItems.Add(ocidade.Cidade);
            item.SubItems.Add(ocidade.Oestados.Estado);
            item.SubItems.Add(Convert.ToString(ocidade.Oestados.Codigo));
            item.SubItems.Add(ocidade.Ddd);

            ListV.Items.Add(item);
        }
        public override void setFrmCadastros(Object Obj)
        {
            if(Obj !=null)
            {
                ofrmCadastrosCidades=(FrmCadastrosCidades)Obj;
            }
        }
       
        protected override void Excluir()
        {
            string aux;
            ofrmCadastrosCidades.ConhecaObj(ocidade, aCtrlCidades);
            ofrmCadastrosCidades.LimpaTxt();
            ofrmCadastrosCidades.CarregaTxt();
            ofrmCadastrosCidades.Bloqueartxt();
            aux = ofrmCadastrosCidades.BtnSalvar.Text;
            ofrmCadastrosCidades.BtnSalvar.Text = "Excluir";
            ofrmCadastrosCidades.BtnSalvar.Text = aux;
            ofrmCadastrosCidades.ShowDialog();
            ofrmCadastrosCidades.DesbloquearTxt();
        }
     
        protected override void Pesquisar()
        {
            ofrmCadastrosCidades.ConhecaObj(ocidade, aCtrlCidades);
            ofrmCadastrosCidades.ShowDialog();
        }
       
        protected override void Sair()
        {
            this.Close();
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar();
        }
        public override void ConhecaObj(object Obj, object Ctrl)
        {
            if (Obj != null)
                ocidade = (Cidades)Obj;

            if (Ctrl != null)
                aCtrlCidades = (CtrlCidades)Ctrl;

      

        }

        private void FrmConsultasCidades_Load(object sender, EventArgs e)
        {

        }
        

    }
}
