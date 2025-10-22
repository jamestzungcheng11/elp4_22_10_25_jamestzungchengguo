using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PaisesEstadosCidades
{
	public partial class FrmCadastrosPaises : PaisesEstadosCidades.FrmCadastros
	{
		Paises opais;
        CtrlPaises aCtrlPaises;


		public FrmCadastrosPaises()
		{
			InitializeComponent();
		}

        private void FrmCadastrosPaises_Load(object sender, EventArgs e)
        {

        }

		public override void ConhecaObj(Object Obj,Object Ctrl)
		{
            if(Obj!=null)
               opais = (Paises)Obj;

            if(Ctrl!=null)
                aCtrlPaises=(CtrlPaises)Ctrl; 

		}
        public  override void Salvar()
        {
            //if(MessageDlg("Confirma(S/N)="S)

           

            opais.Codigo=Convert.ToInt32(txtCodigo.Text);
           
            opais.Pais = txtPais.Text;
            opais.Sigla=txtSigla.Text;
            opais.Ddi=txtDdi.Text;
            opais.Moeda=txtMoeda.Text;
            MessageBox.Show(aCtrlPaises.Salvar(opais));


            //aCtrl.Salvar(opais);

        }
       
        public  override void CarregaTxt()
        {
            this.txtCodigo.Text=Convert.ToString(opais.Codigo);
            this.txtPais.Text=opais.Pais;
            this.txtSigla.Text=opais.Sigla;
            this.txtDdi.Text=opais.Ddi;
            this.txtMoeda.Text = opais.Moeda;
        }
        public  override void LimpaTxt()
        {
            this.txtCodigo.Text = "0";
            this.txtPais.Clear();
            this.txtSigla.Clear();
            this.txtMoeda.Clear();
            this.txtDdi.Clear();

            
        }

        public  override void Bloqueartxt()
        {

            this.txtPais.Enabled = false;
            this.txtMoeda.Enabled = false;
            this.txtDdi.Enabled = false;
            this.txtSigla.Enabled = false;
            
        }
        public  override void DesbloquearTxt()
        {
            
            this.txtPais.Enabled = true;
            this.txtMoeda.Enabled = true;
            this.txtDdi.Enabled = true;
            this.txtSigla.Enabled = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
