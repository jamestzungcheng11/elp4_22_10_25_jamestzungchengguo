namespace PaisesEstadosCidades
{
    partial class FrmConsultasEstados
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
            this.colEstados = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodPaises = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPaises = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colEstados,
            this.colUF,
            this.colCodPaises,
            this.colPaises});
            // 
            // btnSair
            // 
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // colEstados
            // 
            this.colEstados.Text = "Estados";
            this.colEstados.Width = 200;
            // 
            // colUF
            // 
            this.colUF.Text = "UF";
            // 
            // colCodPaises
            // 
            this.colCodPaises.Text = "CodPaises";
            // 
            // colPaises
            // 
            this.colPaises.Text = "Paises";
            // 
            // FrmConsultasEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConsultasEstados";
            this.Text = " Consultas Estados";
            this.Load += new System.EventHandler(this.FrmConsultasEstados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colEstados;
        private System.Windows.Forms.ColumnHeader colUF;
        private System.Windows.Forms.ColumnHeader colCodPaises;
        private System.Windows.Forms.ColumnHeader colPaises;
    }
}
