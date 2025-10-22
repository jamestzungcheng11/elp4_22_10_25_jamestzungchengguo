namespace PaisesEstadosCidades
{
    partial class FrmConsultas
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
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnPesquisar = new System.Windows.Forms.Button();
            this.ListV = new System.Windows.Forms.ListView();
            this.CLCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(670, 415);
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(276, 415);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(75, 23);
            this.BtnIncluir.TabIndex = 2;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(380, 415);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 3;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(507, 415);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Location = new System.Drawing.Point(174, 27);
            this.BtnPesquisar.Name = "BtnPesquisar";
            this.BtnPesquisar.Size = new System.Drawing.Size(85, 28);
            this.BtnPesquisar.TabIndex = 5;
            this.BtnPesquisar.Text = "Pesquisar";
            this.BtnPesquisar.UseVisualStyleBackColor = true;
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CLCodigo});
            this.ListV.FullRowSelect = true;
            this.ListV.HideSelection = false;
            this.ListV.Location = new System.Drawing.Point(53, 61);
            this.ListV.Name = "ListV";
            this.ListV.Size = new System.Drawing.Size(704, 335);
            this.ListV.TabIndex = 6;
            this.ListV.UseCompatibleStateImageBehavior = false;
            this.ListV.View = System.Windows.Forms.View.Details;
            this.ListV.SelectedIndexChanged += new System.EventHandler(this.ListV_SelectedIndexChanged);
            // 
            // CLCodigo
            // 
            this.CLCodigo.Text = "Codigo";
            // 
            // FrmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListV);
            this.Controls.Add(this.BtnPesquisar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnIncluir);
            this.Name = "FrmConsultas";
            this.Text = "Consultas";
            this.Load += new System.EventHandler(this.FrmConsultas_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.BtnIncluir, 0);
            this.Controls.SetChildIndex(this.BtnAlterar, 0);
            this.Controls.SetChildIndex(this.BtnExcluir, 0);
            this.Controls.SetChildIndex(this.BtnPesquisar, 0);
            this.Controls.SetChildIndex(this.ListV, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Button BtnIncluir;
        protected System.Windows.Forms.Button BtnAlterar;
        protected System.Windows.Forms.Button BtnExcluir;
        protected System.Windows.Forms.Button BtnPesquisar;
        protected System.Windows.Forms.ColumnHeader CLCodigo;
        protected System.Windows.Forms.ListView ListV;
    }
}
