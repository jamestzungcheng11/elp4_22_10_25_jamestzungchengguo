namespace PaisesEstadosCidades
{
    partial class FrmConsultasCidades
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
            this.colCidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEstados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodigoCidades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDDD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnPesquisar
            // 
            this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCidades,
            this.colEstados,
            this.colCodigoCidades,
            this.colDDD});
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // colCidades
            // 
            this.colCidades.Text = "Cidades";
            this.colCidades.Width = 200;
            // 
            // colEstados
            // 
            this.colEstados.Text = "Estados";
            // 
            // colCodigoCidades
            // 
            this.colCodigoCidades.Text = "CodigoCidades";
            // 
            // colDDD
            // 
            this.colDDD.Text = "DDD";
            // 
            // FrmConsultasCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConsultasCidades";
            this.Text = "Consultas Cidades";
            this.Load += new System.EventHandler(this.FrmConsultasCidades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colCidades;
        private System.Windows.Forms.ColumnHeader colEstados;
        private System.Windows.Forms.ColumnHeader colCodigoCidades;
        private System.Windows.Forms.ColumnHeader colDDD;
    }
}
