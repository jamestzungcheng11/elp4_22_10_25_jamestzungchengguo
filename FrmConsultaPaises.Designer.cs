namespace PaisesEstadosCidades
{
    partial class FrmConsultaPaises
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
            this.codPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodSiglas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDDI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoedas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // ListV
            // 
            this.ListV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.codPais,
            this.CodSiglas,
            this.colDDI,
            this.colMoedas});
            this.ListV.SelectedIndexChanged += new System.EventHandler(this.ListV_SelectedIndexChanged);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(698, 415);
            // 
            // codPais
            // 
            this.codPais.Text = "Pais";
            this.codPais.Width = 200;
            // 
            // CodSiglas
            // 
            this.CodSiglas.Text = "Siglas";
            // 
            // colDDI
            // 
            this.colDDI.Text = "DDI";
            this.colDDI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colMoedas
            // 
            this.colMoedas.Text = "Moedas";
            // 
            // FrmConsultaPaises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "FrmConsultaPaises";
            this.Text = "Consultas Paises";
            this.Load += new System.EventHandler(this.FrmConsultaPaises_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader codPais;
        private System.Windows.Forms.ColumnHeader CodSiglas;
        private System.Windows.Forms.ColumnHeader colDDI;
        private System.Windows.Forms.ColumnHeader colMoedas;
    }
}
