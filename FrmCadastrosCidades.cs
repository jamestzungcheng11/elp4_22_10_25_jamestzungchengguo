using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmCadastrosCidades : PaisesEstadosCidades.FrmCadastros
	{
		FrmConsultasEstados ofrmConsultaEstados;
		FrmConsultasCidades ofrmConsultaCidades;
	

		Cidades ocidades;
        CtrlCidades aCtrlCidades;



		public FrmCadastrosCidades()
		{
			InitializeComponent();
		}



       
        public override void Salvar()
        {
            //if(MessageDlg("Confirma(S/N)=S)

            ocidades.Codigo = Convert.ToInt32(txtCodigo.Text);
            ocidades.Oestados.Codigo = Convert.ToInt32(txtCodEstados.Text);
            ocidades.Cidade = txtCidades.Text;
            ocidades.Oestados.Estado = txtEstados.Text;

            
            ocidades.Ddd = txtDdd.Text;
            MessageBox.Show(aCtrlCidades.Salvar(ocidades));

            //aCtrl.Salvar(ocidades);
            

           









        }
        //public override void Salvar()
        //{
            //if(MessageDlg("Confirma(S/N)="S)



            //opais.Codigo = Convert.ToInt32(txtCodigo.Text);

            //opais.Pais = txtPais.Text;
            //opais.Sigla = txtSigla.Text;
            //opais.Ddi = txtDdi.Text;
            //opais.Moeda = txtMoeda.Text;
            //MessageBox.Show(aCtrlPaises.Salvar(opais));


            //aCtrl.Salvar(opais);

        //}



        public override void CarregaTxt()
        {
            this.txtCodigo.Text=Convert.ToString(ocidades.Codigo);
            this.txtCidades.Text = ocidades.Cidade;
            this.txtDdd.Text = ocidades.Ddd;
            this.txtCodEstados.Text = ocidades.Oestados.Codigo.ToString();
            this.txtEstados.Text = ocidades.Oestados.Estado;


        }

     
        public override void Bloqueartxt()
        {
            this.txtCidades.Enabled = false;
            this.txtEstados.Enabled = false;
            this.txtCodEstados.Enabled = false;
            this.txtDdd.Enabled = false;

           
           
        }
        
        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtCidades.Clear();
            this.txtEstados.Clear();
            this.txtCodEstados.Clear();
            this.txtDdd.Clear();


            
        }

        public override void DesbloquearTxt()
        {
            this.txtCidades.Enabled = true;
            this.txtEstados.Enabled = true;
            this.txtCodEstados.Enabled = true;
            this.txtDdd.Enabled = true;
        }
        public void SetFrmConsultaEstados(Object Obj)
		{
			if(Obj!=null)
			{
			     ofrmConsultaEstados=(FrmConsultasEstados)Obj;
			}
		}

        private void FrmCadastrosCidades_Load(object sender, EventArgs e)
        {
			
        }
        public override void ConhecaObj(object Obj, object Ctrl)
        {
            if (Obj != null)
                ocidades = (Cidades)Obj;
            if (Obj != null)
                aCtrlCidades = (CtrlCidades)Ctrl;
         
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            string btnasair = ofrmConsultaEstados.btnSair.Text;
            ofrmConsultaEstados.btnSair.Text = "selecionar";
            ofrmConsultaEstados.ConhecaObj(ocidades.Oestados, aCtrlCidades);
            ofrmConsultaEstados.ShowDialog();
            this.txtCodEstados.Text = Convert.ToString(ocidades.Oestados.Codigo);
            this.txtEstados.Text = ocidades.Oestados.Estado.ToString();
            ofrmConsultaEstados.btnSair.Text=btnSair.Text;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
