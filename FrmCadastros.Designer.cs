namespace PaisesEstadosCidades
{
    partial class FrmCadastros
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.lblDatCad = new System.Windows.Forms.Label();
            this.txtDatCad = new System.Windows.Forms.TextBox();
            this.lblDatUltAlt = new System.Windows.Forms.Label();
            this.txtUltAlt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodUsu = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(25, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(51, 16);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Codigo";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(595, 403);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // lblDatCad
            // 
            this.lblDatCad.AutoSize = true;
            this.lblDatCad.Location = new System.Drawing.Point(190, 377);
            this.lblDatCad.Name = "lblDatCad";
            this.lblDatCad.Size = new System.Drawing.Size(53, 16);
            this.lblDatCad.TabIndex = 4;
            this.lblDatCad.Text = "DatCad";
            // 
            // txtDatCad
            // 
            this.txtDatCad.Location = new System.Drawing.Point(193, 396);
            this.txtDatCad.Name = "txtDatCad";
            this.txtDatCad.Size = new System.Drawing.Size(101, 22);
            this.txtDatCad.TabIndex = 5;
            // 
            // lblDatUltAlt
            // 
            this.lblDatUltAlt.AutoSize = true;
            this.lblDatUltAlt.Location = new System.Drawing.Point(327, 377);
            this.lblDatUltAlt.Name = "lblDatUltAlt";
            this.lblDatUltAlt.Size = new System.Drawing.Size(38, 16);
            this.lblDatUltAlt.TabIndex = 6;
            this.lblDatUltAlt.Text = "UltAlt";
            // 
            // txtUltAlt
            // 
            this.txtUltAlt.Location = new System.Drawing.Point(330, 396);
            this.txtUltAlt.Name = "txtUltAlt";
            this.txtUltAlt.Size = new System.Drawing.Size(100, 22);
            this.txtUltAlt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuario";
            // 
            // txtCodUsu
            // 
            this.txtCodUsu.Location = new System.Drawing.Point(454, 404);
            this.txtCodUsu.Name = "txtCodUsu";
            this.txtCodUsu.Size = new System.Drawing.Size(100, 22);
            this.txtCodUsu.TabIndex = 9;
            // 
            // FrmCadastros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCodUsu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUltAlt);
            this.Controls.Add(this.lblDatUltAlt);
            this.Controls.Add(this.txtDatCad);
            this.Controls.Add(this.lblDatCad);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.lblCodigo);
            this.Name = "FrmCadastros";
            this.Text = "Cadastros";
            this.Load += new System.EventHandler(this.FrmCadastros_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.lblCodigo, 0);
            this.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.txtDatCad, 0);
            this.Controls.SetChildIndex(this.lblDatUltAlt, 0);
            this.Controls.SetChildIndex(this.txtUltAlt, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtCodUsu, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        protected System.Windows.Forms.Label lblDatCad;
        private System.Windows.Forms.TextBox txtDatCad;
        private System.Windows.Forms.Label lblDatUltAlt;
        private System.Windows.Forms.TextBox txtUltAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodUsu;
        public System.Windows.Forms.Button BtnSalvar;
    }
}
