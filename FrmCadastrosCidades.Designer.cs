namespace PaisesEstadosCidades
{
    partial class FrmCadastrosCidades
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
            this.lblCidades = new System.Windows.Forms.Label();
            this.txtCidades = new System.Windows.Forms.TextBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.txtEstados = new System.Windows.Forms.TextBox();
            this.lblCodEstados = new System.Windows.Forms.Label();
            this.txtCodEstados = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDdd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            // 
            // btnSair
            // 
            this.btnSair.TabIndex = 6;
            // 
            // lblCidades
            // 
            this.lblCidades.AutoSize = true;
            this.lblCidades.Location = new System.Drawing.Point(156, 9);
            this.lblCidades.Name = "lblCidades";
            this.lblCidades.Size = new System.Drawing.Size(58, 16);
            this.lblCidades.TabIndex = 10;
            this.lblCidades.Text = "Cidades";
            // 
            // txtCidades
            // 
            this.txtCidades.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCidades.Location = new System.Drawing.Point(159, 28);
            this.txtCidades.MaxLength = 50;
            this.txtCidades.Name = "txtCidades";
            this.txtCidades.Size = new System.Drawing.Size(100, 22);
            this.txtCidades.TabIndex = 0;
            this.txtCidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Location = new System.Drawing.Point(297, 9);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(57, 16);
            this.lblEstados.TabIndex = 12;
            this.lblEstados.Text = "Estados";
            // 
            // txtEstados
            // 
            this.txtEstados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEstados.Location = new System.Drawing.Point(300, 28);
            this.txtEstados.MaxLength = 50;
            this.txtEstados.Name = "txtEstados";
            this.txtEstados.Size = new System.Drawing.Size(100, 22);
            this.txtEstados.TabIndex = 1;
            // 
            // lblCodEstados
            // 
            this.lblCodEstados.AutoSize = true;
            this.lblCodEstados.Location = new System.Drawing.Point(431, 9);
            this.lblCodEstados.Name = "lblCodEstados";
            this.lblCodEstados.Size = new System.Drawing.Size(51, 16);
            this.lblCodEstados.TabIndex = 14;
            this.lblCodEstados.Text = "Codigo";
            // 
            // txtCodEstados
            // 
            this.txtCodEstados.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodEstados.Location = new System.Drawing.Point(434, 28);
            this.txtCodEstados.MaxLength = 5;
            this.txtCodEstados.Name = "txtCodEstados";
            this.txtCodEstados.Size = new System.Drawing.Size(100, 22);
            this.txtCodEstados.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(676, 28);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 16;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ddd";
            // 
            // txtDdd
            // 
            this.txtDdd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDdd.Location = new System.Drawing.Point(554, 29);
            this.txtDdd.MaxLength = 4;
            this.txtDdd.Name = "txtDdd";
            this.txtDdd.Size = new System.Drawing.Size(83, 22);
            this.txtDdd.TabIndex = 3;
            // 
            // FrmCadastrosCidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscar);
            this.Controls.Add(this.txtCodEstados);
            this.Controls.Add(this.lblCodEstados);
            this.Controls.Add(this.txtEstados);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.txtCidades);
            this.Controls.Add(this.lblCidades);
            this.Name = "FrmCadastrosCidades";
            this.Text = "Cadastros de Cidades";
            this.Load += new System.EventHandler(this.FrmCadastrosCidades_Load);
            this.Controls.SetChildIndex(this.txtCodigo, 0);
            this.Controls.SetChildIndex(this.btnSair, 0);
            this.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.Controls.SetChildIndex(this.lblDatCad, 0);
            this.Controls.SetChildIndex(this.lblCidades, 0);
            this.Controls.SetChildIndex(this.txtCidades, 0);
            this.Controls.SetChildIndex(this.lblEstados, 0);
            this.Controls.SetChildIndex(this.txtEstados, 0);
            this.Controls.SetChildIndex(this.lblCodEstados, 0);
            this.Controls.SetChildIndex(this.txtCodEstados, 0);
            this.Controls.SetChildIndex(this.BtnBuscar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtDdd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCidades;
        private System.Windows.Forms.TextBox txtCidades;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.TextBox txtEstados;
        private System.Windows.Forms.Label lblCodEstados;
        private System.Windows.Forms.TextBox txtCodEstados;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDdd;
    }
}
