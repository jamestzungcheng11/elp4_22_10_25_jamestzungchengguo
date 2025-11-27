using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmConsultaPaises : PaisesEstadosCidades.FrmConsultas
	{
        FrmCadastrosPaises ofrmCadastroPaises;
        Paises opais;
      
        CtrlPaises aCtrlPaises;


        public FrmConsultaPaises()
		{
			InitializeComponent();
		}

        private void FrmConsultaPaises_Load(object sender, EventArgs e)
        {

        }

        protected  override void Incluir()
        {
            
            ofrmCadastroPaises.LimpaTxt();
            ofrmCadastroPaises.ConhecaObj(opais, aCtrlPaises);
            
            ofrmCadastroPaises.ShowDialog();
            this.CarregaLV();

        }
        protected  override void Alterar()
        {
            ofrmCadastroPaises.ConhecaObj(opais, aCtrlPaises);
            ofrmCadastroPaises.LimpaTxt();
            ofrmCadastroPaises.CarregaTxt();
           
            
      
            ofrmCadastroPaises.ShowDialog();
        }
       

        protected override void CarregaLV()
        {
            foreach(var opais in aCtrlPaises.Listar())
            {
                ListViewItem item = new ListViewItem(Convert.ToString(opais.Codigo));
                item.SubItems.Add(opais.Pais);
                item.SubItems.Add(opais.Sigla);
                item.SubItems.Add(opais.Ddi);
                item.SubItems.Add(opais.Moeda);
                ListV.Items.Add(item);


            }


        }
       
        protected  override void Excluir()
        {
            string aux;
            ofrmCadastroPaises.ConhecaObj(opais, aCtrlPaises);

            
            ofrmCadastroPaises.LimpaTxt();
            ofrmCadastroPaises.CarregaTxt();
            ofrmCadastroPaises.Bloqueartxt();
            aux = ofrmCadastroPaises.BtnSalvar.Text;
            ofrmCadastroPaises.BtnSalvar.Text = "Excluir";
            ofrmCadastroPaises.BtnSalvar.Text = aux;


            ofrmCadastroPaises.ShowDialog();
            ofrmCadastroPaises.DesbloquearTxt();
            ListV.Items.Clear();
            this.CarregaLV();
        }

        protected override void Pesquisar()
        {
            ofrmCadastroPaises.ConhecaObj(opais, aCtrlPaises);
            ofrmCadastroPaises.ShowDialog();
        }
        public override void setFrmCadastros(object Obj)
        {
            if(Obj!=null)
            {
                ofrmCadastroPaises = (FrmCadastrosPaises)Obj;
            }
        }
        public override void ConhecaObj(Object Obj,Object Ctrl)
        {
           if(Obj!=null)
              opais=(Paises)Obj;

           if(Ctrl!=null)
             aCtrlPaises=(CtrlPaises)Ctrl;

        }

        private void ListV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
