using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmConsultasEstados : PaisesEstadosCidades.FrmConsultas
	{
        FrmCadastrosEstados ofrmCadastrosEstados;
        Estados oEstado;
        CtrlEstados aCtrlEstados;


		public FrmConsultasEstados()
		{
			InitializeComponent();
		}

        private void FrmConsultasEstados_Load(object sender, EventArgs e)
        {

        }
      
        protected   override void Incluir()
        {
            ofrmCadastrosEstados.LimpaTxt();
            ofrmCadastrosEstados.ConhecaObj(oEstado, aCtrlEstados);
            ofrmCadastrosEstados.ShowDialog();
            this.CarregaLV();

        }
       
        protected  override void Alterar()
        {
            ofrmCadastrosEstados.ConhecaObj(oEstado, aCtrlEstados);
            ofrmCadastrosEstados.LimpaTxt();
            ofrmCadastrosEstados.CarregaTxt();
            ofrmCadastrosEstados.ShowDialog();
            
        }
     
        //protected override void CarregaLV()
        //{

            //foreach (var oestado in aCtrlEstados.Listar())
            //{
                //ListViewItem item = new ListViewItem(Convert.ToString(oEstado.Codigo));
                //item.SubItems.Add(oEstado.Estado);
                //item.SubItems.Add(oEstado.Uf);

                //item.SubItems.Add(Convert.ToString(oEstado.Opais.Codigo));

                //item.SubItems.Add(oEstado.Opais.Pais);

                //ListV.Items.Add(item);
            //}
                
        //}
        protected override void CarregaLV()
        {
            ListV.Items.Clear(); // sempre limpe antes

            foreach (var oestado in aCtrlEstados.Listar())
            {
                ListViewItem item = new ListViewItem(oestado.Codigo.ToString());
                item.SubItems.Add(oestado.Estado);
                item.SubItems.Add(oestado.Uf);

                item.SubItems.Add(oestado.Opais.Codigo.ToString());
                item.SubItems.Add(oestado.Opais.Pais);

                ListV.Items.Add(item);
            }
        }

        protected override void Sair()
        {
           
        }
        public override void setFrmCadastros(object Obj)
        {
            if(Obj!=null)
            {
                ofrmCadastrosEstados = (FrmCadastrosEstados)Obj;
            }

        }
       
        protected  override void Excluir()
        {
            string aux;
            ofrmCadastrosEstados.ConhecaObj(oEstado, aCtrlEstados);
            ofrmCadastrosEstados.LimpaTxt();
            ofrmCadastrosEstados.CarregaTxt();
            ofrmCadastrosEstados.Bloqueartxt();
            aux = ofrmCadastrosEstados.BtnSalvar.Text;
            ofrmCadastrosEstados.BtnSalvar.Text = "Excluir";
            ofrmCadastrosEstados.BtnSalvar.Text = aux;

            ofrmCadastrosEstados.ShowDialog();
            ofrmCadastrosEstados.DesbloquearTxt();
        }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            //Incluir();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            // Alterar();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Excluir();
        }
        public override void ConhecaObj(object Obj, object Ctrl)
        {
            if(Obj!=null) 
            
                oEstado=(Estados)Obj;
            if (Ctrl != null)
                aCtrlEstados = (CtrlEstados)Ctrl;

           

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
            this.Close();
        }
    }
}
