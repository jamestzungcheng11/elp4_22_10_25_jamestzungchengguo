using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmCadastrosEstados : PaisesEstadosCidades.FrmCadastros
	{
		FrmConsultaPaises ofrmConsultaPaises;
		Estados oEstado;
		FrmCadastrosEstados ofrmCadastroEstados;
        CtrlEstados aCtrlEstados;



		public FrmCadastrosEstados()
		{
			InitializeComponent();
		}
       
        public override void Salvar()
        {
            //if(MessageDlg("Confirma(S/N)="S)
            oEstado.Codigo = Convert.ToInt32(txtCodigo.Text);
            oEstado.Opais.Codigo = Convert.ToInt32(txtCodPais.Text);

            

            oEstado.Estado = txtEstado.Text;
            oEstado.Uf=txtUF.Text;
            oEstado.Opais.Pais = txtPais.Text;
            

            
        }

        
        public override void CarregaTxt()
        {
            this.txtCodigo.Text=Convert.ToString(oEstado.Codigo);
            this.txtPais.Text = oEstado.Opais.Pais;
            this.txtEstado.Text = oEstado.Estado;
            this.txtCodPais.Text = oEstado.Opais.Codigo.ToString();
            this.txtUF.Text = oEstado.Uf;
            
        }
       
        public override void Bloqueartxt()
        {
            this.txtPais.Enabled=false;
            this.txtCodPais.Enabled = false;
            this.txtUF.Enabled=false;
            this.txtEstado.Enabled=false;
           

        }
        public override void DesbloquearTxt()
        {

            this.txtPais.Enabled = true;
            this.txtCodPais.Enabled = true;
            this.txtUF.Enabled = true;
            this.txtEstado.Enabled = true;

        }

        public override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtEstado.Clear();
            this.txtUF.Clear();
            this.txtCodPais.Clear();
            this.txtPais.Clear();
        }

        public void SetFrmConsultaPaises(Object Obj)
		{
			if(Obj!=null)
			{
				ofrmConsultaPaises = (FrmConsultaPaises)Obj;
			}

		}
        public override void ConhecaObj(object Obj, object Ctrl)
        {
			oEstado = (Estados)Obj;

            aCtrlEstados = (CtrlEstados)Ctrl;

        }
        private void FrmCadastrosEstados_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
			string btnSair = ofrmConsultaPaises.btnSair.Text;
			ofrmConsultaPaises.btnSair.Text = "selecionar";

			ofrmConsultaPaises.ConhecaObj(oEstado.Opais, aCtrlEstados);
			ofrmConsultaPaises.ShowDialog();
			this.txtCodPais.Text=Convert.ToString(oEstado.Opais.Codigo);
			this.txtPais.Text=oEstado.Opais.Pais.ToString();
			ofrmConsultaPaises.btnSair.Text = btnSair;

        }
    }
}
