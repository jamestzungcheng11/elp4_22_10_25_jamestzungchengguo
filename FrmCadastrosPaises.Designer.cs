namespace PaisesEstadosCidades
{
    partial class FrmCadastrosPaises
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblSigla = new System.Windows.Forms.Label();
            this.lblDdi = new System.Windows.Forms.Label();
            this.lblMoeda = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDdi = new System.Windows.Forms.TextBox();
            this.txtMoeda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.TabIndex = 4;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigo.Enabled = false;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pais";
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.Location = new System.Drawing.Point(282, 9);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(38, 16);
            this.lblSigla.TabIndex = 11;
            this.lblSigla.Text = "Sigla";
            // 
            // lblDdi
            // 
            this.lblDdi.AutoSize = true;
            this.lblDdi.Location = new System.Drawing.Point(416, 9);
            this.lblDdi.Name = "lblDdi";
            this.lblDdi.Size = new System.Drawing.Size(28, 16);
            this.lblDdi.TabIndex = 12;
            this.lblDdi.Text = "Ddi";
            // 
            // lblMoeda
            // 
            this.lblMoeda.AutoSize = true;
            this.lblMoeda.Location = new System.Drawing.Point(561, 9);
            this.lblMoeda.Name = "lblMoeda";
            this.lblMoeda.Size = new System.Drawing.Size(50, 16);
            this.lblMoeda.TabIndex = 13;
            this.lblMoeda.Text = "Moeda";
            // 
            // txtPais
            // 
            this.txtPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPais.Location = new System.Drawing.Point(155, 27);
            this.txtPais.MaxLength = 55;
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(124, 22);
            this.txtPais.TabIndex = 0;
            // 
            // txtSigla
            // 
            this.txtSigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSigla.Location = new System.Drawing.Point(285, 27);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 22);
            this.txtSigla.TabIndex = 1;
            // 
            // txtDdi
            // 
            this.txtDdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDdi.Location = new System.Drawing.Point(419, 27);
            this.txtDdi.MaxLength = 5;
            this.txtDdi.Name = "txtDdi";
            this.txtDdi.Size = new System.Drawing.Size(100, 22);
            this.txtDdi.TabIndex = 2;
            this.txtDdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMoeda
            // 
            this.txtMoeda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMoeda.Location = new System.Drawing.Point(564, 27);
            this.txtMoeda.MaxLength = 3;
            this.txtMoeda.Name = "txtMoeda";
            this.txtMoeda.Size = new System.Drawing.Size(100, 22);
            this.txtMoeda.TabIndex = 3;
            // 
            // FrmCadastrosPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMoeda);
            this.Controls.Add(this.txtDdi);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtPais);
            this.Controls.Add(this.lblMoeda);
            this.Controls.Add(this.lblDdi);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.label1);
            this.Name = "FrmCadastrosPaises";
            this.Text = "Cadastros de Paises";
            this.Load += new System.EventHandler(this.FrmCadastrosPaises_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblSigla, 0);
            this.Controls.SetChildIndex(this.lblDdi, 0);
            this.Controls.SetChildIndex(this.lblMoeda, 0);
            this.Controls.SetChildIndex(this.txtPais, 0);
            this.Controls.SetChildIndex(this.txtSigla, 0);
            this.Controls.SetChildIndex(this.txtDdi, 0);
            this.Controls.SetChildIndex(this.txtMoeda, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.Label lblDdi;
        private System.Windows.Forms.Label lblMoeda;
        protected System.Windows.Forms.TextBox txtPais;
        protected System.Windows.Forms.TextBox txtSigla;
        protected System.Windows.Forms.TextBox txtDdi;
        protected System.Windows.Forms.TextBox txtMoeda;
    }
}
